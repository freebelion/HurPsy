using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HurPsyLib;
using Microsoft.VisualBasic.Logging;

namespace HurPsyWinForms
{
    internal class ExperimentViewModel
    {
        public Experiment TestExperiment { get; set; }
        public TrialView TrialViewControl { get; set; }

        public ExperimentViewModel(Experiment exp)
        {
            TestExperiment = exp;
            TrialViewControl = new TrialView();
            TrialViewControl.TrialEnded += TrialViewControl_TrialEnded;
        }

        public void StartExperiment()
        {
            MessageBox.Show("Click OK to start the experiment");
            DisplayCurrentStep();
        }

        private void TrialViewControl_TrialEnded(object? sender, EventArgs e)
        {
            if(TestExperiment.NextStep())
            {
                DisplayCurrentStep();
            }
            else
            {
                MessageBox.Show("Click OK to end the experiment");
                Application.Exit();
            }
        }

        private void DisplayCurrentStep()
        {
            Experiment.TrialStep currentStep = TestExperiment.CurrentStep;

            TrialViewControl.StimulusCount = currentStep.StimulusCount;
            for(int i=0; i < currentStep.StimulusCount; i++)
            {
                Stimulus stim = TestExperiment.GetStimulus(currentStep.GetStimulusId(i));
                Locator loc = TestExperiment.GetLocator(currentStep.GetLocatorId(i));
                if (stim is ImageStimulus)
                { DisplayImageStimulus(i, stim, loc); }              
            }

            HurPsyTimePeriod? period = currentStep.StepTime;
            if (period != null)
            {
                TrialViewControl.StartTrial(period.Milliseconds);
            }
        }

        private void DisplayImageStimulus(int index, Stimulus stim, Locator loc)
        {
            StimulusView stimView = TrialViewControl.GetStimulusView(index);
            ImageStimulus? imgstim = stim as ImageStimulus;
            if (imgstim != null)
            {
                stimView.SetSize(TrialViewControl, imgstim.ImageSize);
                stimView.SetLocation(TrialViewControl, loc.GetLocation());
                stimView.SetImage(imgstim.FileName);
            }
        }
    }
}
