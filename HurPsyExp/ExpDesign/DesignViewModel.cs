using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Media.Imaging;
using HurPsyLib;
using HurPsyExpStrings;
using CommunityToolkit.Mvvm.Input;
using System.Security.Cryptography;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;

namespace HurPsyExp.ExpDesign
{  
    /// <summary>
    /// This VM class will handle the exchange of data input on the experiment design interface
    /// </summary>
    public partial class DesignViewModel : ObservableObject
    {
        /// <summary>
        /// The reference variable for the object representing the experiment's definition
        /// </summary>
        private Experiment _experiment;
        
        /// <summary>
        /// Observable collection of the viewmodels which will help edit/display stimulus definitions
        /// </summary>
        public ObservableCollection<StimulusItemViewModel> StimulusVMs { get; set; }

        /// <summary>
        /// Observable collection of the viewmodels which will help edit/display locator definitions
        /// </summary>
        public ObservableCollection<LocatorItemViewModel> LocatorVMs { get; set; }

        /// <summary>
        /// Observable collection of the viewmodels which will help edit/display trial blocks
        /// </summary>
        public ObservableCollection<BlockItemViewModel> BlockVMs { get; set; }

        /// <summary>
        /// This default constructor starts with empty lists of the inner viewmodel objects
        /// </summary>
        public DesignViewModel()
        {
            _experiment = new Experiment();
            StimulusVMs = new ObservableCollection<StimulusItemViewModel>();
            LocatorVMs = new ObservableCollection<LocatorItemViewModel>();
            BlockVMs = new ObservableCollection<BlockItemViewModel>();
        }

        /// <summary>
        /// This private method clears all lists of viewmodel objects before loading or starting a new experiment definition.
        /// </summary>
        private void ClearVMs()
        {
            StimulusVMs.Clear();
            LocatorVMs.Clear();
        }

        /// <summary>
        /// The method which will create a new experiment definition when the associated command is executed
        /// </summary>
        [RelayCommand]
        public void NewExperiment()
        {
            ClearVMs();
            _experiment = new Experiment();
        }

        /// <summary>
        /// The method which will load an experiment definition from a file when the associated command is executed
        /// (Choosing the definition file and loading of the experiment is left to `Utility.LoadExperiment()` method because it depends on the runtime environment)
        /// </summary>
        [RelayCommand]
        public void LoadExperiment()
        {
            Experiment? exp = Utility.LoadExperiment();

            if (exp != null)
            {// If an experiment definition was successfully loaded,
                _experiment = exp;


                ClearVMs(); // clear all the viewmodel objects

                // Load the actual Stimulus objects from files named in the experiment definition
                foreach (Stimulus stim in _experiment.GetStimuli())
                {
                    AddStimulusVM(stim);
                }
                // Load the Locator objects and associate them with LocatorViewModel objects
                foreach (Locator loc in _experiment.GetLocators())
                {
                    AddLocatorVM(loc);
                }

                //Load experiment blocks and associate them with BlockViewModel objects
                foreach (Block blck in _experiment.Blocks)
                {
                    BlockItemViewModel blockvm = new BlockItemViewModel(blck);
                    BlockVMs.Add(blockvm);

                    foreach (Trial trl in blck.Trials)
                    {
                        TrialItemViewModel trvm = new TrialItemViewModel(trl);
                        blockvm.TrialVMs.Add(trvm);
                    }
                }
            }
        }

        /// <summary>
        /// The method which will save an experiment definition to a file when the associated command is executed
        /// (Creating the definition file and saving the experiment definition is left to `Utility.SaveExperiment()` method because it depends on the runtime environment)
        /// </summary>
        [RelayCommand]
        public void SaveExperiment()
        {
            Utility.SaveExperiment(_experiment);
        }

        /// <summary>
        /// The method which will load image stimuli from files selected by the user when the associated command is executed.
        /// (Choosing the image files is left to the `Utility.OpenFiles()` method, because it depends on the runtime environment)
        /// </summary>
        [RelayCommand]
        public void SelectImages()
        {
            string[]? selectedFiles = Utility.OpenFiles(StringResources.FileFilter_Image, true);

            if (selectedFiles != null && selectedFiles.Length > 0)
            {
                foreach (string strFile in selectedFiles)
                {
                    string? basename = Path.GetFileNameWithoutExtension(strFile);
                    ImageStimulus imgstim = new ImageStimulus();
                    if (basename != null) { imgstim.Id = basename; }
                    // save the file name
                    imgstim.FileName = strFile;
                    // Load the image from the file (hopefully temporarily)
                    BitmapImage bmp = Utility.LoadImage(strFile);
                    // Get its current size in millimeters (changes may be necessary if the unit preference is different)
                    imgstim.VisualSize.Unit = HurPsyUnit.MM;
                    imgstim.VisualSize.Width = Utility.ConvertFromDIU(bmp.Width, HurPsyUnit.MM);
                    imgstim.VisualSize.Height = Utility.ConvertFromDIU(bmp.Height, HurPsyUnit.MM);
                    // Add the stimulus definition to the experiment definition and create and add an associated viewmodel object
                    _experiment.AddStimulus(imgstim);
                    AddStimulusVM(imgstim);
                }
            }
        }

        /// <summary>
        /// The method which will load and HTML stimulus from a file selected by the user when the associated command is executed.
        /// (Choosing the file is left to the `Utility.OpenFiles()` method, because it depends on the runtime environment)
        /// </summary>
        [RelayCommand]
        public void AddHtmlStimulus()
        {
            string[]? selectedFiles = Utility.OpenFiles(StringResources.FileFilter_Html, false);

            if (selectedFiles != null && selectedFiles.Length == 1)
            {
                string strFile = selectedFiles[0];
                string? basename = Path.GetFileNameWithoutExtension(strFile);
                HtmlStimulus htmstim = new HtmlStimulus();
                if (basename != null) { htmstim.Id = basename; }
                // save the file name; file will later be copied to the same directory with the experiment.
                htmstim.FileName = strFile;
                _experiment.AddStimulus(htmstim);
                AddStimulusVM(htmstim);
            }
        }

        /// <summary>
        /// Create and add a viewmodel object associated with a `Stimulus` object
        /// </summary>
        /// <param name="stim"></param>
        private void AddStimulusVM(Stimulus stim)
        {
            StimulusItemViewModel stimvm = new StimulusItemViewModel(stim);
            // TODO: Add an event handler that will respond to IdChanged event of stimvm
            stimvm.IdChanged += StimVM_IdChanged;
            StimulusVMs.Add(stimvm);
            // Add the Id to the list of Ids shared by BlockViewModel objects,
            // so that they can be displayed in AddTrialView
            BlockItemViewModel.AddStimulusId(stim.Id);
        }

        /// <summary>
        /// This method will handle the `IdChanged` events for `StimulusVM` objects
        /// </summary>
        /// <param name="sender">The object reporting the id change</param>
        /// <param name="e">Additional event info</param>
        private void StimVM_IdChanged(object? sender, IdChangeEventArgs e)
        {
            StimulusItemViewModel? stimvm = sender as StimulusItemViewModel;
            if (stimvm != null && e.NewId != null)
            {
                Stimulus? stim = stimvm.ItemObject as Stimulus;
                if(stim != null)
                {
                    string oldId = stim.Id;
                    // Ensure that the new Id is not a duplicate of an existing one
                    if (_experiment.StimulusIdExists(e.NewId) == false)
                    {
                        _experiment.ReplaceStimulusId(oldId, e.NewId);
                        // stim.Id = e.NewId; already been done in the above call
                        // TODO: Go through stimulus selections and the trial steps
                        // where the old Id was used and change them, too
                        BlockItemViewModel.ReplaceStimulusId(oldId, stim.Id);

                        foreach(BlockItemViewModel blckvm in this.BlockVMs)
                        {
                            blckvm.ChangeStimulusId(oldId, e.NewId);
                        }
                    }
                    else
                    {
                        // If the new id is not acceptable, StimulusViewModel object
                        // here reverts to the old id, but this results in
                        // this event handler being called once again.
                        // TODO: Find a way to revert the change without invoking this same method.
                        stimvm.TempId = oldId;
                    }
                }             
            }
        }

        /// <summary>
        /// This method will create and add a `PointLocator` object to the experiment definition
        /// </summary>
        [RelayCommand]
        public void AddPointLocator()
        {
            PointLocator ploc = new PointLocator();
            _experiment.AddLocator(ploc);

            AddLocatorVM(ploc);
        }

        /// <summary>
        /// This method will create and add a viewmodel object associated with a `Locator` object
        /// </summary>
        /// <param name="loc"></param>
        private void AddLocatorVM(Locator loc)
        {
            LocatorItemViewModel locvm = new LocatorItemViewModel(loc);
            // TODO: Add an event handler that will respond to IdChanged event of locvm
            locvm.IdChanged += LocVM_IdChanged;
            LocatorVMs.Add(locvm);
            // Add the Id to the list of Ids shared by BlockViewModel objects,
            // so that they can be displayed in AddTrialView
            BlockItemViewModel.AddLocatorId(loc.Id);
        }

        /// <summary>
        /// This method will handle the `IdChanged` events for `LocatorVM` objects
        /// </summary>
        /// <param name="sender">The object reporting the id change</param>
        /// <param name="e">Additional event info</param>
        private void LocVM_IdChanged(object? sender, IdChangeEventArgs e)
        {
            LocatorItemViewModel? locvm = sender as LocatorItemViewModel;
            if (locvm != null && e.NewId != null)
            {
                Locator? loc = locvm.ItemObject as Locator;
                if (loc != null)
                {
                    string oldId = loc.Id;
                    // Ensure that the new Id is not a duplicate of an existing one
                    if (_experiment.LocatorIdExists(e.NewId) == false)
                    {
                        _experiment.ReplaceLocatorId(oldId, e.NewId);
                        // TODO: Go through Locator selections and the trial steps
                        // where the old Id was used and change them, too
                        BlockItemViewModel.ReplaceLocatorId(oldId, loc.Id);

                        foreach (BlockItemViewModel blckvm in this.BlockVMs)
                        {
                            blckvm.ChangeLocatorId(oldId, e.NewId);
                        }
                    }
                    else
                    {
                        // If the new id is not acceptible, LocatorViewModel object
                        // here reverts to the old id, but this results in
                        // this event handler being called once again.
                        // TODO: Find a way to revert the change without invoking this same method.
                        locvm.TempId = oldId;
                    }
                }
            }
        }

        /// <summary>
        /// This method which delete the `Stimulus` objects selected on the experiment design interface when the associated command is executed.
        /// </summary>
        [RelayCommand]
        private void DeleteStimulus()
        {
            List<StimulusItemViewModel> deleteList = new List<StimulusItemViewModel>();
            // Delete all the stimulus objects associated with
            // the selected members of the StimulusVms list
            foreach (StimulusItemViewModel stimvm in StimulusVMs)
            {
                if(stimvm.Selected)
                {
                    Stimulus? stim = stimvm.ItemObject as Stimulus;
                    
                    if (stim != null)
                    {
                        BlockItemViewModel.DeleteStimulusId(stim.Id);
                        _experiment.RemoveStimulus(stim.Id);
                    }
                    deleteList.Add(stimvm);
                }              
            }

            // Then remove the selected StimulusVM objects
            foreach (StimulusItemViewModel stimvm in deleteList)
            {
                StimulusVMs.Remove(stimvm);
            }
        }

        /// <summary>
        /// This method which delete the `Locator` objects selected on the experiment design interface when the associated command is executed.
        /// </summary>
        [RelayCommand]
        private void DeleteLocator()
        {
            List<LocatorItemViewModel> deleteList = new List<LocatorItemViewModel>();
            // Delete all the locator objects associated with
            // the selected members of the LocatorVms list
            foreach (LocatorItemViewModel locvm in LocatorVMs)
            {
                if (locvm.Selected)
                {
                    Locator? loc = locvm.ItemObject as Locator;
                    if (loc != null)
                    {
                        BlockItemViewModel.DeleteLocatorId(loc.Id);
                        _experiment.RemoveLocator(loc.Id);
                    }
                    deleteList.Add(locvm);
                }
            }

            // Then remove the selected LocatorVM objects
            foreach (LocatorItemViewModel locvm in deleteList)
            {
                LocatorVMs.Remove(locvm);
            }
        }

        /// <summary>
        /// This method will create and add a block of trials to the experiment definition when the associated command is executed.
        /// </summary>
        [RelayCommand]
        public void AddBlock()
        {
            Block newblock = _experiment.AddNewBlock();
            BlockItemViewModel blockvm = new BlockItemViewModel(newblock);
            BlockVMs.Add(blockvm);
        }

        /// <summary>
        /// This method will deleted a block of trials selected on the experiment design interface when the associated command is executed.
        /// </summary>
        [RelayCommand]
        public void DeleteBlock()
        {
            List<BlockItemViewModel> deleteList = new List<BlockItemViewModel>();
            // Delete all the locator objects associated with
            // the selected members of the LocatorVms list
            foreach (BlockItemViewModel blckvm in BlockVMs)
            {
                if (blckvm.Selected)
                {
                    Block? blck = blckvm.ItemObject as Block;
                    if (blck != null)
                    {
                        _experiment.RemoveBlock(blck);
                    }
                    deleteList.Add(blckvm);
                }
            }

            // Then remove the selected BlockVM objects
            foreach (BlockItemViewModel blckvm in deleteList)
            {
                BlockVMs.Remove(blckvm);
            }
        }

        /// <summary>
        /// This method will create and add a `KeyResponse` object to the experiment definition
        /// </summary>
        [RelayCommand]
        public void AddKeyResponse()
        {
            
        }
    }
}
