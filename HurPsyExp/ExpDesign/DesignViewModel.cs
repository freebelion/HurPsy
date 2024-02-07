using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Media.Imaging;
using HurPsyLib;
using HurPsyExpStrings;
using CommunityToolkit.Mvvm.Input;
using System.Security.Cryptography;
using System.Windows.Controls;

namespace HurPsyExp.ExpDesign
{  
    public partial class DesignViewModel
    {
        private Experiment _experiment;

        public ObservableCollection<StimulusItemViewModel> StimulusVMs { get; set; }

        public ObservableCollection<LocatorItemViewModel> LocatorVMs { get; set; }

        public ObservableCollection<BlockItemViewModel> BlockVMs { get; set; }

        public DesignViewModel()
        {
            _experiment = new Experiment();
            StimulusVMs = new ObservableCollection<StimulusItemViewModel>();
            LocatorVMs = new ObservableCollection<LocatorItemViewModel>();
            BlockVMs = new ObservableCollection<BlockItemViewModel>();
        }

        private void ClearVMs()
        {
            StimulusVMs.Clear();
            LocatorVMs.Clear();
        }

        [RelayCommand]
        public void NewExperiment()
        {
            ClearVMs();
            _experiment = new Experiment();
        }

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

        [RelayCommand]
        public void SaveExperiment()
        {
            Utility.SaveExperiment(_experiment);
        }

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
                    /*
                     * I have decided not to load the actual image into memory,
                     * so I made use of the file size in bytes to guess the size,
                     * assuming a square image, but that was rather stupid.
                    BitmapImage bmp = Utility.LoadImage(strFile);
                    */
                    FileInfo finfo = new FileInfo(strFile);
                    double imgdim = Utility.GetMMValue(Math.Sqrt(finfo.Length));
                    imgstim.VisualSize.Width = imgdim;
                    imgstim.VisualSize.Height = imgdim;
                    
                    _experiment.AddStimulus(imgstim);
                    AddStimulusVM(imgstim);
                }
            }
        }

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

        private void AddStimulusVM(Stimulus stim)
        {
            StimulusItemViewModel stimvm = new StimulusItemViewModel(stim);
            // TODO: Add an event handler that will respond to IdChanged event of stimvm
            stimvm.IdChanged += Stimvm_IdChanged;
            StimulusVMs.Add(stimvm);
            // Add the Id to the list of Ids shared by BlockViewModel objects,
            // so that they can be displayed in AddTrialView
            BlockItemViewModel.AddStimulusId(stim.Id);
        }

        private void Stimvm_IdChanged(object? sender, IdChangeEventArgs e)
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
                        // If the new id is not acceptible, StimulusViewModel object
                        // here reverts to the old id, but this results in
                        // this event handler being called once again.
                        // TODO: Find a way to revert the change without invoking this same method.
                        stimvm.TempId = oldId;
                    }
                }             
            }
        }

        [RelayCommand]
        public void AddPointLocator()
        {
            PointLocator ploc = new PointLocator();
            _experiment.AddLocator(ploc);

            AddLocatorVM(ploc);
        }

        private void AddLocatorVM(Locator loc)
        {
            LocatorItemViewModel locvm = new LocatorItemViewModel(loc);
            // TODO: Add an event handler that will respond to IdChanged event of locvm
            locvm.IdChanged += Locvm_IdChanged;
            LocatorVMs.Add(locvm);
            // Add the Id to the list of Ids shared by BlockViewModel objects,
            // so that they can be displayed in AddTrialView
            BlockItemViewModel.AddLocatorId(loc.Id);
        }

        /// <summary>
        /// This specialized event handler intervenes
        /// when the user attempts to change the TempId
        /// of a LocatorVM object and passes the change
        /// to the underlying Locator object
        /// only after certain conditions are met.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Locvm_IdChanged(object? sender, IdChangeEventArgs e)
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
                        _experiment.RemoveStimulus(stim);
                    }
                    deleteList.Add(stimvm);
                }              
            }

            // Then remove the selected StimulusVm objects
            foreach (StimulusItemViewModel stimvm in deleteList)
            {
                StimulusVMs.Remove(stimvm);
            }
        }

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
                        _experiment.RemoveLocator(loc);
                    }
                    deleteList.Add(locvm);
                }
            }

            // Then remove the selected LocatorVm objects
            foreach (LocatorItemViewModel locvm in deleteList)
            {
                LocatorVMs.Remove(locvm);
            }
        }

        [RelayCommand]
        public void AddBlock()
        {
            Block newblock = _experiment.AddNewBlock();
            BlockItemViewModel blockvm = new BlockItemViewModel(newblock);
            BlockVMs.Add(blockvm);
        }

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

            // Then remove the selected LocatorVm objects
            foreach (BlockItemViewModel blckvm in deleteList)
            {
                BlockVMs.Remove(blckvm);
            }
        }
    }
}
