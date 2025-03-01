using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using HurPsyLib;
using HurPsyExpStrings;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using HurPsy;
using System.Windows.Media.Imaging;
using System.Windows;

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
        public ObservableCollection<ItemViewModel<Stimulus>> StimulusItemVMs { get; set; }

        /// <summary>
        /// Observable collection of the viewmodels which will help edit/display locator definitions
        /// </summary>
        public ObservableCollection<ItemViewModel<Locator>> LocatorItemVMs { get; set; }

        /// <summary>
        /// Observable collection of the viewmodels which will help edit/display locator definitions
        /// </summary>
        public ObservableCollection<BlockItemViewModel> BlockItemVMs { get; set; }

        /// <summary>
        /// This default constructor starts with empty lists of the inner viewmodel objects
        /// </summary>
        public DesignViewModel()
        {
            _experiment = new Experiment();
            
            // Start with empty viewmodels lists and then
            // let the static collections of TrialPattern class point to them.
            StimulusItemVMs = [];
            LocatorItemVMs = [];
            TrialPattern.StimulusItemVMs = StimulusItemVMs;
            TrialPattern.LocatorItemVMs = LocatorItemVMs;

            BlockItemVMs = [];

            // Comment out the following lines when testing is done
            LoadTestExperiment();
        }

        /// <summary>
        /// This internal method loads an experiment from an existing file for testing purposes
        /// </summary>
        private void LoadTestExperiment()
        {
            Experiment? exp = Utility.LoadExperiment("C:\\Users\\freeb\\Documents\\HurPsyTest\\deney1\\deney1.xml");
            if (exp != null) { _experiment = exp; }
            ConstructViewModels();
        }

        /// <summary>
        /// This private method clears all lists of viewmodel objects before loading or starting a new experiment definition.
        /// </summary>
        private void ClearVMs()
        {
            StimulusItemVMs.Clear();
            LocatorItemVMs.Clear();
            BlockItemVMs.Clear();
        }

        /// <summary>
        /// A shortcut function to return the `Stimulus` object with the given id
        /// </summary>
        /// <param name="stimId">The Id of the `Stimulus` object to be accessed</param>
        /// <returns>The `Stimulus` object</returns>
        public Stimulus GetStimulus(string stimId)
        { return _experiment.GetStimulus(stimId); }

        /// <summary>
        /// A shortcut function to return the `Locator` object with the given id
        /// </summary>
        /// <param name="locId">The Id of the `Locator` object to be accessed</param>
        /// <returns>The `Locator` object</returns>
        public Locator GetLocator(string locId)
        { return _experiment.GetLocator(locId); }

        #region Experiment Menu Commands
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

                ConstructViewModels();
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
        #endregion

        #region Add/Delete Item Commands
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
        /// This method which delete the `Stimulus` objects selected on the experiment design interface when the associated command is executed.
        /// </summary>
        [RelayCommand]
        private void DeleteStimulus()
        {
            List<ItemViewModel<Stimulus>> deleteList = [];
            // Delete all the Stimulus objects associated with
            // the selected members of the StimulusVMs list
            foreach (var stimvm in StimulusItemVMs)
            {
                if (stimvm.Selected)
                {
                    Stimulus? stim = stimvm.ItemObject as Stimulus;

                    if (stim != null)
                    {
                        // BlockItemViewModel.DeleteStimulusId(stim.Id);
                        _experiment.RemoveStimulus(stim.Id);
                    }
                    deleteList.Add(stimvm);
                }
            }

            // Then remove the selected StimulusVM objects
            foreach (var stimvm in deleteList)
            {
                StimulusItemVMs.Remove(stimvm);
            }
        }

        /// <summary>
        /// This method which delete the `Locator` objects selected on the experiment design interface when the associated command is executed.
        /// </summary>
        [RelayCommand]
        private void DeleteLocator()
        {
            List<ItemViewModel<Locator>> deleteList = [];
            // Delete all the Locator objects associated with
            // the selected members of the LocatorVMs list
            foreach (var locvm in LocatorItemVMs)
            {
                if (locvm.Selected)
                {
                    Locator? loc = locvm.ItemObject as Locator;
                    if (loc != null)
                    {
                        // BlockItemViewModel.DeleteLocatorId(loc.Id);
                        _experiment.RemoveLocator(loc.Id);
                    }
                    deleteList.Add(locvm);
                }
            }

            // Then remove the selected LocatorVM objects
            foreach (var locvm in deleteList)
            {
                LocatorItemVMs.Remove(locvm);
            }
        }

        /// <summary>
        /// This method will create and add a block of trials to the experiment definition when the associated command is executed.
        /// </summary>
        [RelayCommand]
        public void AddBlock()
        {
            Block newblock = _experiment.AddNewBlock();
            AddBlockVM(newblock);
        }

        /// <summary>
        /// This method will deleted a block of trials selected on the experiment design interface when the associated command is executed.
        /// </summary>
        [RelayCommand]
        public void DeleteBlock()
        {
            List<BlockItemViewModel> deleteList = [];
            // Delete all the Block objects associated with
            // the selected members of the BlockItemVMs list
            foreach (var blckvm in BlockItemVMs)
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
            foreach (var blckvm in deleteList)
            {
                BlockItemVMs.Remove(blckvm);
            }
        }

        #endregion

        /// <summary>
        /// This internal method constructs the viewmodel objects based on the experiment elements.
        /// </summary>
        private void ConstructViewModels()
        {
            ClearVMs(); // clear all the viewmodel objects

            // Create viewmodels based on the `Stimulus` objects loaded from the experiment definition
            List<Stimulus> expstims = _experiment.GetStimuli();
            foreach (Stimulus stim in expstims)
            {
                AddStimulusVM(stim);
            }

            // Create viewmodels based on the `Locator` objects loaded from the experiment definition
            List<Locator> explocs = _experiment.GetLocators();
            foreach (Locator loc in explocs)
            {
                AddLocatorVM(loc);
            }
            
            //Load experiment blocks and associate them with BlockViewModel objects
            foreach (Block blck in _experiment.Blocks)
            {
                AddBlockVM(blck);
            }
        }

        /// <summary>
        /// Create and add a viewmodel object associated with a `Block` object
        /// </summary>
        /// <param name="blck"></param>
        private void AddBlockVM(Block blck)
        {
            BlockItemViewModel blockvm = new(blck);
            blockvm.IdChanged += BlockVM_IdChanged;
            BlockItemVMs.Add(blockvm);
        }

        /// <summary>
        /// Create and add a viewmodel object associated with a `Stimulus` object
        /// </summary>
        /// <param name="stim"></param>
        private void AddStimulusVM(Stimulus stim)
        {
            ItemViewModel<Stimulus> stimvm = new(stim);
            // Add an event handler that will respond to IdChanged event of stimvm
            stimvm.IdChanged += StimVM_IdChanged;
            StimulusItemVMs.Add(stimvm);
        }

        /// <summary>
        /// This method will create and add a viewmodel object associated with a `Locator` object
        /// </summary>
        /// <param name="loc"></param>
        private void AddLocatorVM(Locator loc)
        {
            ItemViewModel<Locator> locvm = new(loc);
            // Add an event handler that will respond to IdChanged event of locvm
            locvm.IdChanged += LocVM_IdChanged;
            LocatorItemVMs.Add(locvm);
        }

        /// <summary>
        /// This method will handle the `IdChanged` events for `StimulusVM` objects
        /// </summary>
        /// <param name="sender">The object reporting the id change</param>
        /// <param name="e">Additional event info</param>
        private void StimVM_IdChanged(object? sender, IdChangeEventArgs e)
        {
            ItemViewModel<Stimulus>? stimvm = sender as ItemViewModel<Stimulus>;
            if (stimvm != null && e.NewId != null)
            {
                Stimulus? stim = stimvm.ItemObject as Stimulus;
                if (stim != null)
                {
                    string oldId = stim.Id;
                    // Ensure that the new Id is not a duplicate of an existing one
                    if (_experiment.StimulusIdExists(e.NewId) == false)
                    {
                        _experiment.ReplaceStimulusId(oldId, e.NewId);
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
        /// This method will handle the `IdChanged` events for `LocatorVM` objects
        /// </summary>
        /// <param name="sender">The object reporting the id change</param>
        /// <param name="e">Additional event info</param>
        private void LocVM_IdChanged(object? sender, IdChangeEventArgs e)
        {
            ItemViewModel<Locator>? locvm = sender as ItemViewModel<Locator>;
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
        /// This method will handle the `IdChanged` events for `BlockItemVM` objects
        /// </summary>
        /// <param name="sender">The object reporting the id change</param>
        /// <param name="e">Additional event info</param>
        private void BlockVM_IdChanged(object? sender, IdChangeEventArgs e)
        {
            ItemViewModel<Block>? blckvm = sender as ItemViewModel<Block>;
            if (blckvm != null && e.NewId != null)
            {// Add the necessary controls, such as checking for a unique Id.
                Block? blck = blckvm.ItemObject as Block;
                if(blck != null) blck.Id = e.NewId;
            }
        }
    }
}
