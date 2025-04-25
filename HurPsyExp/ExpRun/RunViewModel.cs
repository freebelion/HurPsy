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
        private ExpSession currentSession;

        /// <summary>
        /// The scale factor used to display visuals on correct positions on displays that don't support standard DIU.
        /// </summary>
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
        {
            VisualStimuli = [];
            VisualStimulusObjects = [];

            runwin = runwnd;
            scaleFactor = ((App)Application.Current).CurrentSettings.ScaleFactor;

            if (exp != null)
            { currentSession = new ExpSession(exp); }
            else // Bring up the dialog box to load an experiment definition from a file
            { currentSession = new ExpSession(LoadExperiment()); }
        }

        /// <summary>
        /// The method which lets the user choose a file to load the experiment definition
        /// </summary>
        /// <returns>A reference to the experiment definition loaded from the file</returns>
        /// <exception cref="HurPsyException">The exception thrown when a valid definition could not be loaded</exception>
        private static Experiment LoadExperiment()
        {
            string[]? selectedFiles = Utility.FileOpenDialog(HurPsyExpStrings.StringResources.Filter_ExperimentFiles, false);

            if (selectedFiles != null && System.IO.File.Exists(selectedFiles[0]))
            {
                string openfilename = selectedFiles[0];
                Experiment? tryexp = Utility.LoadFromXml<Experiment>(openfilename);
                if (tryexp != null)
                {
                    tryexp.FilePath = openfilename;
                    return tryexp;
                }
            }
            
            throw(new HurPsyException(HurPsyLibStrings.StringResources.Error_ExperimentNotLoaded));
        }

        /// <summary>
        /// The inner method to load visual stimulus objects in memory to make them faster to access
        /// (This method may have to be bound to a user option in the future, if memory requirements will become demanding)
        /// </summary>
        private void LoadVisualStimulusObjects()
        {
            VisualStimulusObjects.Clear();

            List<Stimulus> expStims = currentSession.GetStimulusItems();

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
            LoadVisualStimulusObjects();
            currentSession.StartSession();
            LoadStep();
        }

        /// <summary>
        /// This method loads the visual stimulus objects to be used to display the current trial step.
        /// </summary>
        private void LoadStep()
        {
            VisualStimuli.Clear();

            foreach (ExpPair pr in currentSession.CurrentStep.StepPairs)
            {
                Stimulus stim = currentSession.StimulusDict[pr.StimulusId];

                if (stim is not VisualStimulus vistim) continue;

                VisualStimulusViewModel vistimVM = new VisualStimulusViewModel();

                Locator loc = currentSession.LocatorDict[pr.LocatorId];
                HurPsyPoint locpnt = loc.GetLocation(vistim);

                vistimVM.Xpos = (System.Windows.SystemParameters.PrimaryScreenWidth / 2) + Utility.MM2DIU * (locpnt.X - vistim.VisualSize.Width / 2) / scaleFactor;
                vistimVM.Ypos = (System.Windows.SystemParameters.PrimaryScreenHeight / 2) - Utility.MM2DIU * (locpnt.Y + vistim.VisualSize.Height / 2) / scaleFactor;
                vistimVM.VisualWidth = Utility.MM2DIU * vistim.VisualSize.Width / scaleFactor;
                vistimVM.VisualHeight = Utility.MM2DIU * vistim.VisualSize.Height / scaleFactor;

                vistimVM.VisualObject = VisualStimulusObjects[vistim.Id];
                VisualStimuli.Add(vistimVM);
            }

            runwin.DisplayStep(currentSession.CurrentStep.StepTime.Span);
        }

        /// <summary>
        /// Move on to the next trial step (if any)
        /// </summary>
        public void NextStep()
        {
            if(currentSession.NextStep())
            { LoadStep(); }
            else
            { MessageBox.Show("Experiment is finished"); }
        }
    }
}
