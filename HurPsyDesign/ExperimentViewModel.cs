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
            string[]? selectedFiles = Common.OpenFiles(StringResources.ExperimentFileFilter, false);

            if (selectedFiles != null && selectedFiles.Length == 1)
            {
                string xmlFileName = selectedFiles[0];
                _experiment = Experiment.LoadFromXml(xmlFileName);

                StimulusObjects.Clear();
                foreach(KeyValuePair<string, Stimulus> dictItem in _experiment.StimulusDict)
                {
                    Stimulus stim = dictItem.Value;

                    if (stim is ImageStimulus)
                    { LoadImageStimulus((ImageStimulus)stim); }
                }
            }
        }

        [RelayCommand]
        private void SaveExperiment()
        {
            string? saveFileName = Common.FileSaveName(StringResources.ExperimentFileFilter);
            if (saveFileName != null)
            {
                _experiment.SaveToXml(saveFileName);
            }
        }

        [RelayCommand]
        private void LoadImageFile()
        {
            string[]? selectedFiles = Common.OpenFiles(StringResources.ImageFileFilter, true);
            
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
    }
}
