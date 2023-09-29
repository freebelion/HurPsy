using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HurPsyLib;

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
            TrialViewControl.Load += TrialViewControl_Load;
            TrialViewControl.TrialEnded += TrialViewControl_TrialEnded;
        }

        private void TrialViewControl_Load(object? sender, EventArgs e)
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
            }
        }

        private void DisplayCurrentStep()
        {
            Experiment.TrialStep currentStep = TestExperiment.CurrentStep;

            TrialViewControl.StimulusCount = currentStep.StimulusCount;
            for(int i=0; i < currentStep.StimulusCount; i++)
            {

            }

            HurPsyTimePeriod? period = currentStep.StepTime;
            if (period != null)
            {
                TrialViewControl.StartTrial(period.Milliseconds);
            }
        }
    }
}
