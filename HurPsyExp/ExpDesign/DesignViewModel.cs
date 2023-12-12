using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Media.Imaging;
using HurPsyLib;
using HurPsyExpStrings;
using CommunityToolkit.Mvvm.Input;

namespace HurPsyExp.ExpDesign
{  
    public partial class DesignViewModel
    {
        private Experiment _experiment;

        public ObservableCollection<StimulusViewModel> StimulusVMs { get; set; }

        public ObservableCollection<LocatorViewModel> LocatorVMs { get; set; }

        public DesignViewModel()
        {
            _experiment = new Experiment();
            StimulusVMs = new ObservableCollection<StimulusViewModel>();
            LocatorVMs = new ObservableCollection<LocatorViewModel>();
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
                    // Load the actual stimulus objects from files named in the experiment definition
                    foreach (Stimulus stim in _experiment.StimulusList)
                    {
                        if (stim is ImageStimulus)
                        { LoadImageStimulus((ImageStimulus)stim); }
                        StimulusVMs.Add(new StimulusViewModel(stim));
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
                    foreach (Stimulus stim in _experiment.StimulusList)
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

                    StimulusViewModel stimvm = new StimulusViewModel(imgstim);
                    // TODO: Add an event handler that will respond to IdChanged event of stimvm
                    StimulusVMs.Add(stimvm);
                }
            }
        }

        private void LoadImageStimulus(ImageStimulus imgstim)
        {
            BitmapImage stimImage = new BitmapImage(new Uri(imgstim.FileName, UriKind.Absolute));
            imgstim.StimulusObject = stimImage;
            imgstim.ImageSize.Width = stimImage.Width;
            imgstim.ImageSize.Height = stimImage.Height;
        }

        [RelayCommand]
        public void AddPointLocator()
        {
            PointLocator ploc = new PointLocator();
            _experiment.AddLocator(ploc);

            LocatorViewModel locvm = new LocatorViewModel(ploc);
            // TODO: Add an event handler that will respond to IdChanged event of locvm
            LocatorVMs.Add(locvm);
        }

        [RelayCommand]
        public void AddBlock()
        {
            _experiment.AddNewBlock();
        }   
    }
}
