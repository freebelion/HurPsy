using CommunityToolkit.Mvvm.ComponentModel;
using HurPsyExp.ExpDesign;
using HurPsyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyExp.ExpRun
{
    public partial class RunViewModel : ObservableObject
    {
        private Experiment _experiment;

        [ObservableProperty]
        private StepViewModel currentStepVM;

        private int blockNo;
        private int trialNo;
        private int stepNo;

        public RunViewModel()
        {
            _experiment = new Experiment();
            CurrentStepVM = new StepViewModel();
        }

        public void LoadExperiment()
        {
            Experiment? exp = UtilityClass.LoadExperiment();

            if (exp != null)
            {// If an experiment definition was successfully loaded,
                _experiment = exp;
            }
        }

        public void StartExperiment()
        {
            blockNo = 0;
            trialNo = 0;
            stepNo = 0;

            LoadCurrentStep();
        }

        private void LoadCurrentStep()
        {
            Step? stp = GetCurrentStep();

            if (stp != null)
            {
                List<object> stimuli = GetStepStimuli(stp);
                List<Locator> locators = GetStepLocators(stp);
            }
        }

        public List<object> GetStepStimuli(Step stp)
        {
            List<object> stimuli = new List<object>();

            foreach(StimulusLocatorPair stimlocpair in stp.StimulusLocators)
            {
                object? stimobject = _experiment.GetStimulus(stimlocpair.StimulusId).StimulusObject;
                if(stimobject != null) { stimuli.Add(stimobject); }
            }

            return stimuli;
        }

        public List<Locator> GetStepLocators(Step stp)
        {
            List<Locator> locators = new List<Locator>();

            foreach (StimulusLocatorPair stimlocpair in stp.StimulusLocators)
            {
                Locator? loc = _experiment.GetLocator(stimlocpair.LocatorId);
                if (loc != null) { locators.Add(loc); }
            }

            return locators;
        }

        private Step? GetCurrentStep()
        {
            try
            {
                return _experiment.Blocks[blockNo].Trials[trialNo].Steps[stepNo];
            }
            catch(Exception e)
            { return null; }
        }      
    }
}
