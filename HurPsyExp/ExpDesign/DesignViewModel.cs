using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Media.Imaging;
using HurPsyLib;
using HurPsyExpStrings;
using CommunityToolkit.Mvvm.Input;
using System.Security.Cryptography;

namespace HurPsyExp.ExpDesign
{  
    public partial class DesignViewModel
    {
        private Experiment _experiment;

        public ObservableCollection<StimulusViewModel> StimulusVMs { get; set; }

        public ObservableCollection<LocatorViewModel> LocatorVMs { get; set; }

        public ObservableCollection<BlockViewModel> BlockVMs { get; set; }

        public DesignViewModel()
        {
            _experiment = new Experiment();
            StimulusVMs = new ObservableCollection<StimulusViewModel>();
            LocatorVMs = new ObservableCollection<LocatorViewModel>();
            BlockVMs = new ObservableCollection<BlockViewModel>();
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
            string[]? selectedFiles = UtilityClass.OpenFiles(StringResources.FileFilter_Experiment, false);

            if (selectedFiles != null && selectedFiles.Length == 1)
            {
                string expFileName = selectedFiles[0];

                string? expDirectoryPath = Path.GetDirectoryName(expFileName);
                if (expDirectoryPath != null)
                {
                    ClearVMs() ;
                    // Load the experiment definition from the selected file
                    _experiment = Experiment.LoadFromXml(expFileName);
                    // Load the actual Stimulus objects from files named in the experiment definition
                    foreach (Stimulus stim in _experiment.StimulusDict.Values)
                    {
                        if (stim is ImageStimulus)
                        { LoadImageStimulus((ImageStimulus)stim); }
                        AddStimulusVM(stim);
                    }
                    // Load the Locator objects and associate them with LocatorViewModel objects
                    foreach (Locator loc in _experiment.LocatorDict.Values)
                    {
                        AddLocatorVM(loc);
                    }

                    //Load experiment blocks and associate them with BlockViewModel objects
                    foreach(Block blck in _experiment.Blocks)
                    {
                        BlockViewModel blockvm = new BlockViewModel(blck);
                        BlockVMs.Add(blockvm);

                        foreach(Trial trl in blck.Trials)
                        {
                            TrialViewModel trvm = new TrialViewModel(trl);
                            blockvm.TrialVMs.Add(trvm);
                        }
                    }

                    // Change the working directory for the application
                    // so that stimulus filenames will work without full paths.
                    Directory.SetCurrentDirectory(expDirectoryPath);
                }
            }
        }

        [RelayCommand]
        public void SaveExperiment()
        {
            string? expFileName = UtilityClass.FileSaveName(StringResources.FileFilter_Experiment);
            if (expFileName != null)
            {
                string? expDirectoryPath = Path.GetDirectoryName(expFileName);
                if (expDirectoryPath != null)
                {
                    // save the experiment definition
                    _experiment.SaveToXml(expFileName);
                    // Copy the files containing the stimuli to the same target directory
                    // so that stimulus filename will not need to contain the whole path.
                    foreach (Stimulus stim in _experiment.StimulusDict.Values)
                    {
                        string stimFileName = Path.GetFileName(stim.FileName);
                        File.Copy(stim.FileName, Path.Combine(expDirectoryPath, stimFileName), overwrite: true);
                        // Strip out the original directory path (if any) from the stimulus filename
                        stim.FileName = stimFileName;
                    }
                    // Change the working directory for the application
                    // so that stimulus filenames will work without full paths.
                    Directory.SetCurrentDirectory(expDirectoryPath);
                }
            }
        }

        [RelayCommand]
        public void SelectImages()
        {
            string[]? selectedFiles = UtilityClass.OpenFiles(StringResources.FileFilter_Image, true);

            if (selectedFiles != null && selectedFiles.Length > 0)
            {
                foreach (string strFile in selectedFiles)
                {
                    string? basename = Path.GetFileNameWithoutExtension(strFile);
                    ImageStimulus imgstim = new ImageStimulus();
                    if (basename != null) { imgstim.Id = basename; }
                    imgstim.FileName = strFile;
                
                    _experiment.AddStimulus(imgstim);

                    LoadImageStimulus(imgstim);
                    AddStimulusVM(imgstim);
                }
            }
        }

        private void AddStimulusVM(Stimulus stim)
        {
            StimulusViewModel stimvm = new StimulusViewModel(stim);
            // TODO: Add an event handler that will respond to IdChanged event of stimvm
            stimvm.IdChanged += Stimvm_IdChanged;
            StimulusVMs.Add(stimvm);
            // Add the Id to the list of Ids shared by BlockViewModel objects,
            // so that they can be displayed in AddTrialView
            BlockViewModel.AddStimulusId(stim.Id);
        }

        private void Stimvm_IdChanged(object? sender, IdChangeEventArgs e)
        {
            StimulusViewModel? stimvm = sender as StimulusViewModel;
            if (stimvm != null && e.NewId != null)
            {
                Stimulus? stim = stimvm.ItemObject as Stimulus;
                if(stim != null)
                {
                    string oldId = stim.Id;
                    // Ensure that the new Id is not a duplicate of an existing one
                    if (_experiment.StimulusDict.ContainsKey(e.NewId) == false)
                    {
                        stim.Id = e.NewId;
                        // TODO: Go through stimulus selections and the trial steps
                        // where the old Id was used and change them, too
                        BlockViewModel.ReplaceStimulusId(oldId, stim.Id);

                        foreach(BlockViewModel blckvm in this.BlockVMs)
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

        private void LoadImageStimulus(ImageStimulus imgstim)
        {
            BitmapImage stimImage = new BitmapImage();
            stimImage.BeginInit();
            stimImage.UriSource = new Uri(imgstim.FileName, UriKind.Absolute);
            stimImage.CacheOption = BitmapCacheOption.OnLoad;
            stimImage.EndInit();
            
            imgstim.StimulusObject = stimImage;
            imgstim.ImageSize.Width = stimImage.Width;
            imgstim.ImageSize.Height = stimImage.Height;
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
            LocatorViewModel locvm = new LocatorViewModel(loc);
            // TODO: Add an event handler that will respond to IdChanged event of locvm
            locvm.IdChanged += Locvm_IdChanged;
            LocatorVMs.Add(locvm);
            // Add the Id to the list of Ids shared by BlockViewModel objects,
            // so that they can be displayed in AddTrialView
            BlockViewModel.AddLocatorId(loc.Id);
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
            LocatorViewModel? locvm = sender as LocatorViewModel;
            if (locvm != null && e.NewId != null)
            {
                Locator? loc = locvm.ItemObject as Locator;
                if (loc != null)
                {
                    string oldId = loc.Id;
                    // Ensure that the new Id is not a duplicate of an existing one
                    if (_experiment.LocatorDict.ContainsKey(e.NewId) == false)
                    {
                        loc.Id = e.NewId;
                        // TODO: Go through Locator selections and the trial steps
                        // where the old Id was used and change them, too
                        BlockViewModel.ReplaceLocatorId(oldId, loc.Id);

                        foreach (BlockViewModel blckvm in this.BlockVMs)
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
            List<StimulusViewModel> deleteList = new List<StimulusViewModel>();
            // Delete all the stimulus objects associated with
            // the selected members of the StimulusVms list
            foreach (StimulusViewModel stimvm in StimulusVMs)
            {
                if(stimvm.Selected)
                {
                    Stimulus? stim = stimvm.ItemObject as Stimulus;
                    
                    if (stim != null)
                    {
                        BlockViewModel.DeleteStimulusId(stim.Id);
                        _experiment.RemoveStimulus(stim);
                    }
                    deleteList.Add(stimvm);
                }              
            }

            // Then remove the selected StimulusVm objects
            foreach (StimulusViewModel stimvm in deleteList)
            {
                StimulusVMs.Remove(stimvm);
            }
        }

        [RelayCommand]
        private void DeleteLocator()
        {
            List<LocatorViewModel> deleteList = new List<LocatorViewModel>();
            // Delete all the locator objects associated with
            // the selected members of the LocatorVms list
            foreach (LocatorViewModel locvm in LocatorVMs)
            {
                if (locvm.Selected)
                {
                    Locator? loc = locvm.ItemObject as Locator;
                    if (loc != null)
                    {
                        BlockViewModel.DeleteLocatorId(loc.Id);
                        _experiment.RemoveLocator(loc);
                    }
                    deleteList.Add(locvm);
                }
            }

            // Then remove the selected LocatorVm objects
            foreach (LocatorViewModel locvm in deleteList)
            {
                LocatorVMs.Remove(locvm);
            }
        }

        [RelayCommand]
        public void AddBlock()
        {
            Block newblock = _experiment.AddNewBlock();
            BlockViewModel blockvm = new BlockViewModel(newblock);
            BlockVMs.Add(blockvm);
        }

        [RelayCommand]
        public void DeleteBlock()
        {
            List<BlockViewModel> deleteList = new List<BlockViewModel>();
            // Delete all the locator objects associated with
            // the selected members of the LocatorVms list
            foreach (BlockViewModel blckvm in BlockVMs)
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
            foreach (BlockViewModel blckvm in deleteList)
            {
                BlockVMs.Remove(blckvm);
            }
        }
    }
}
