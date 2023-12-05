using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HurPsyLib;
using CommunityToolkit.Mvvm.Input;
using HurPsyDesignStrings;
using System.IO;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace HurPsyDesign
{
    public partial class ExperimentViewModel
    {
        private Experiment _experiment;

        public ObservableCollection<Stimulus> StimulusObjects { get; set; }

        public ExperimentViewModel()
        {
            _experiment = new Experiment();
            StimulusObjects = new ObservableCollection<Stimulus>();
        }

        [RelayCommand]
        private void NewExperiment() => _experiment = new Experiment();

        [RelayCommand]
        private void LoadExperiment()
        {
            string[]? selectedFiles = UtilityClass.OpenFiles(StringResources.ExperimentFileFilter, false);

            if (selectedFiles != null && selectedFiles.Length == 1)
            {
                string expFileName = selectedFiles[0];

                string? expDirectoryPath = Path.GetDirectoryName(expFileName);
                if (expDirectoryPath != null)
                {
                    // Load the experiment definition from the selected file
                    _experiment = Experiment.LoadFromXml(expFileName);
                    // Load the actual stimulus objects from files named in the experiment definition
                    StimulusObjects.Clear();
                    foreach (KeyValuePair<string, Stimulus> dictItem in _experiment.StimulusDict)
                    {
                        Stimulus stim = dictItem.Value;

                        if (stim is ImageStimulus)
                        { LoadImageStimulus((ImageStimulus)stim); }
                    }

                    // Change the working directory for the application
                    // so that stimulus filenames will work without full paths.
                    Directory.SetCurrentDirectory(expDirectoryPath);
                }
            }
        }

        [RelayCommand]
        private void SaveExperiment()
        {
            string? expFileName = UtilityClass.FileSaveName(StringResources.ExperimentFileFilter);
            if (expFileName != null)
            {
                string? expDirectoryPath = Path.GetDirectoryName(expFileName);
                if(expDirectoryPath != null)
                {                   
                    // save the experiment definition
                    _experiment.SaveToXml(expFileName);
                    // Copy the files containing the stimuli to the same target directory
                    // so that stimulus filename will not need to contain the whole path.
                    foreach (Stimulus stim in StimulusObjects)
                    {
                        string stimFileName = Path.GetFileName(stim.FileName);
                        File.Copy(stim.FileName, Path.Combine(expDirectoryPath, stimFileName), overwrite:true);
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
        private void LoadImageFile()
        {
            string[]? selectedFiles = UtilityClass.OpenFiles(StringResources.ImageFileFilter, true);
            
            if(selectedFiles != null && selectedFiles.Length > 0)
            {
                foreach (string strFile in selectedFiles)
                {
                    string? basename = Path.GetFileNameWithoutExtension(strFile);
                    ImageStimulus imgstim = new ImageStimulus();
                    if(basename != null) { imgstim.Id = basename; }
                    imgstim.FileName = strFile;
                    _experiment.AddStimulus(imgstim.Id, imgstim);

                    LoadImageStimulus(imgstim);
                }
            }
        }

        private void LoadImageStimulus(ImageStimulus imgstim)
        {
            BitmapImage stimImage = new BitmapImage(new Uri(imgstim.FileName, UriKind.Absolute));
            imgstim.StimulusObject = stimImage;
            imgstim.ImageSize.Width = stimImage.Width;
            imgstim.ImageSize.Height = stimImage.Height;
            StimulusObjects.Add(imgstim);
        }

        [RelayCommand]
        private void AddPointLocator()
        {

        }
    }
}
