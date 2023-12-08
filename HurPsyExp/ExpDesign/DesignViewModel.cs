using System.Collections.ObjectModel;
using System.IO;
using System.Windows.Media.Imaging;
using HurPsyLib;
using HurPsyExpStrings;

namespace HurPsyExp.ExpDesign
{  
    public class DesignViewModel
    {
        private Experiment _experiment;

        public List<Stimulus> StimulusList
        {
            get { return _experiment.StimulusList; }
        }

        public List<Locator> LocatorList
        {
            get { return _experiment.LocatorList; }
        }

        public List<Block> Blocks
        {
            get { return _experiment.Blocks; }
        }

        public DesignViewModel()
        {
            _experiment = new Experiment();
        }

        public void NewExperiment() => _experiment = new Experiment();

        public void LoadExperiment()
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
                    foreach (Stimulus stim in _experiment.StimulusList)
                    {
                        if (stim is ImageStimulus)
                        { LoadImageStimulus((ImageStimulus)stim); }
                    }

                    // Change the working directory for the application
                    // so that stimulus filenames will work without full paths.
                    Directory.SetCurrentDirectory(expDirectoryPath);
                }
            }
        }

        public void SaveExperiment()
        {
            string? expFileName = UtilityClass.FileSaveName(StringResources.ExperimentFileFilter);
            if (expFileName != null)
            {
                string? expDirectoryPath = Path.GetDirectoryName(expFileName);
                if (expDirectoryPath != null)
                {
                    // save the experiment definition
                    _experiment.SaveToXml(expFileName);
                    // Copy the files containing the stimuli to the same target directory
                    // so that stimulus filename will not need to contain the whole path.
                    foreach (Stimulus stim in StimulusList)
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

        public void SelectImageStimulus()
        {
            string[]? selectedFiles = UtilityClass.OpenFiles(StringResources.ImageFileFilter, true);

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

        public void AddPointLocator()
        {
            PointLocator ploc = new PointLocator();
            _experiment.AddLocator(ploc);
        }

        public void AddBlock() => _experiment.AddNewBlock();
    
    }
}
