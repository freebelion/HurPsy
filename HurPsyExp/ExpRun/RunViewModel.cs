using CommunityToolkit.Mvvm.ComponentModel;
using HurPsyExp.ExpDesign;
using HurPsyLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HurPsyExp.ExpRun
{
    public partial class RunViewModel : ObservableObject
    {
        private Experiment _experiment;

        private int blockNo;
        private int trialNo;
        private int stepNo;

        public ObservableCollection<StimulusViewModel> StimulusVMs { get; set; }

        public RunViewModel()
        {
            _experiment = new Experiment();
            StimulusVMs = new ObservableCollection<StimulusViewModel>();
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
                List<Stimulus> stimuli = GetStepStimuli(stp);
                List<Locator> locators = GetStepLocators(stp);

                StimulusVMs.Clear();

                // ATTENTION! In case location-less stimuli
                // such as audio stimuli are implemented,
                // there should be some extra control statements.
                for(int i=0, n = stimuli.Count; i < n; i++)
                {
                    Stimulus stim = stimuli[i];
                    if (stim is not IVisualStimulus) continue;
                    Locator loc = locators[i];
                    Point pnt = UtilityClass.GetDIULocation((IVisualStimulus)stim, loc);

                    StimulusViewModel stimvm = new StimulusViewModel();
                    stimvm.StimulusObject = stim.StimulusObject;
                    stimvm.StimulusLocation = pnt;
                    stimvm.StimulusSize = UtilityClass.GetDIUSize((IVisualStimulus)stim);
                    StimulusVMs.Add(stimvm);
                }
            }
        }

        public List<Stimulus> GetStepStimuli(Step stp)
        {
            List<Stimulus> stimuli = new List<Stimulus>();

            foreach(StimulusLocatorPair stimlocpair in stp.StimulusLocators)
            {
                Stimulus? stim = _experiment.GetStimulus(stimlocpair.StimulusId);
                if(stim != null) { stimuli.Add(stim); }
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
