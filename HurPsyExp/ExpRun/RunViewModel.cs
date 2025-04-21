using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;
using CommunityToolkit.Mvvm.ComponentModel;
using HurPsyLib;

namespace HurPsyExp.ExpRun
{
    /// <summary>
    /// This viewmodel class will handle running an experiment
    /// </summary>
    public partial class RunViewModel : ObservableObject
    {
        /// <summary>
        /// A reference to the `RunWindow` object
        /// </summary>
        private RunWindow runwin;

        /// <summary>
        /// A reference to the `Experiment` object representing the experiment being run
        /// </summary>
        private Experiment _experiment;

        // Index values for current experiment objects
        private int currentBlockIndex;
        private int currentTrialIndex;
        private int currentStepIndex;

        // References to current experiment objects
        private ExpBlock currentBlock;
        private ExpTrial currentTrial;
        private ExpStep currentStep;

        private double scaleFactor;

        /// <summary>
        /// The collection of visual stimulus objects that will be presented together on the same step
        /// </summary>
        public ObservableCollection<VisualStimulusViewModel> VisualStimuli {  get; set; }

        /// <summary>
        /// A dictionary collection of actual stimulus objects keyed with their Id strings.
        /// </summary>
        private Dictionary<string, object> VisualStimulusObjects { get; set; }

        /// <summary>
        /// The default constructor starts with a reference to the window element and an existing experiment.
        /// If no `Experiment` object is forwarded, the user will be prompted to open a file containing an experiment's definition.
        /// </summary>
        /// <param name="runwnd">The reference to the window element (for updating the display step by step)</param>
        /// <param name="exp">The reference to an existing experiment (if any)</param>
        public RunViewModel(RunWindow runwnd, Experiment? exp = null)
        {// I am ignoring the warnings that references to current experiment objects were not initialized;
         // they are initialized in a method called later.
            VisualStimuli = [];
            VisualStimulusObjects = [];

            runwin = runwnd;
            scaleFactor = ((App)Application.Current).CurrentSettings.ScaleFactor;

            if (exp != null)
            { _experiment = exp; }
            else // Bring up the dialog box to load an experiment definition from a file
            { _experiment = LoadExperiment(); }
        }

        /// <summary>
        /// The method which lets the user choose a file to load the experiment definition
        /// </summary>
        /// <returns></returns>
        /// <exception cref="HurPsyException"></exception>
        private static Experiment LoadExperiment()
        {
            string[]? selectedFiles = Utility.OpenFiles(HurPsyExpStrings.StringResources.Filter_ExperimentFiles, false);

            if (selectedFiles != null && System.IO.File.Exists(selectedFiles[0]))
            {
                string openfilename = selectedFiles[0];
                Experiment? tryexp = Utility.LoadFromXml<Experiment>(openfilename);
                if (tryexp != null)
                {
                    tryexp.FileName = openfilename;
                    return tryexp;
                }
            }
            
            throw(new HurPsyException(HurPsyExpStrings.StringResources.Error_NoExperimentLoaded));
        }

        /// <summary>
        /// The inner method to load visual stimulus objects in memory to make them faster to access
        /// (This method may have to be bound to a user option in the future, if memory requirements will become demanding)
        /// </summary>
        private void LoadVisualStimulusObjects()
        {
            VisualStimulusObjects.Clear();

            List<Stimulus> expStims = _experiment.GetStimulusItems();

            foreach (VisualStimulus vistim in expStims)
            {
                if(vistim is ImageStimulus imgstim)
                {
                    BitmapImage imgobj = Utility.LoadImage(imgstim.FileName);
                    VisualStimulusObjects.Add(imgstim.Id, imgobj);
                }
            }
        }

        /// <summary>
        /// Starting point of the experiment
        /// </summary>
        public void StartExperiment()
        {
            if (_experiment != null)
            {
                LoadVisualStimulusObjects();

                currentBlockIndex = 0;
                currentTrialIndex = 0;
                currentStepIndex = 0;

                // There may have to be just-in-case sanity checks against zero blocks/trials/steps
                currentBlock = _experiment.Blocks[0];
                if (currentBlock.MustShuffleTrials)
                { currentBlock.Trials.Shuffle(); }

                currentTrial = currentBlock.Trials[0];
                currentStep = currentTrial.Steps[0];

                LoadStep();
            }
        }

        /// <summary>
        /// This method loads the visual stimulus objects to be used to display the current trial step.
        /// </summary>
        private void LoadStep()
        {
            VisualStimuli.Clear();

            foreach (ExpPair pr in currentStep.StepPairs)
            {
                Stimulus stim = _experiment.StimulusDict[pr.StimulusId];

                if(stim is not VisualStimulus vistim) continue;

                VisualStimulusViewModel vistimVM = new VisualStimulusViewModel();

                Locator loc = _experiment.LocatorDict[pr.LocatorId];
                HurPsyPoint locpnt = loc.GetLocation(vistim);

                vistimVM.Xpos = (System.Windows.SystemParameters.PrimaryScreenWidth / 2) + Utility.MM2DIU * (locpnt.X - vistim.VisualSize.Width / 2) / scaleFactor;
                vistimVM.Ypos = (System.Windows.SystemParameters.PrimaryScreenHeight / 2) - Utility.MM2DIU * (locpnt.Y + vistim.VisualSize.Height / 2) / scaleFactor;
                vistimVM.VisualWidth = Utility.MM2DIU * vistim.VisualSize.Width / scaleFactor;
                vistimVM.VisualHeight = Utility.MM2DIU * vistim.VisualSize.Height / scaleFactor;
             
                vistimVM.VisualObject = VisualStimulusObjects[vistim.Id];
                VisualStimuli.Add(vistimVM);
            }

            runwin.DisplayStep(TimeSpan.FromSeconds(1));
        }

        /// <summary>
        /// Move on to the next trial step (if any)
        /// </summary>
        public void NextStep()
        {
            if (currentStepIndex < currentTrial.Steps.Count - 1)
            {
                currentStepIndex++;
                currentStep = currentTrial.Steps[currentStepIndex];
                LoadStep();
            }
            else if (currentTrialIndex < currentBlock.Trials.Count - 1)
            {
                currentTrialIndex++;
                currentTrial = currentBlock.Trials[currentTrialIndex];
                currentStepIndex = 0;
                currentStep = currentTrial.Steps[currentStepIndex];
                LoadStep();
            }
            else if (currentBlockIndex < _experiment.Blocks.Count - 1)
            {// Starting a new block may require certain special actions,
             // depending on the needs of actual experiment designers.
                currentBlockIndex++;
                currentBlock = _experiment.Blocks[currentBlockIndex];
                currentTrialIndex = 0;
                currentTrial = currentBlock.Trials[currentTrialIndex];
                currentStepIndex = 0;
                currentStep = currentTrial.Steps[currentStepIndex];
                LoadStep();
            }
            else
            {// Ending of the experiment may also require special actions in the future.
                MessageBox.Show("Experiment has ended");
            }
        }
    }
}
