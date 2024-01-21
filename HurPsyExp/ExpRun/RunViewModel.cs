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
using static System.Net.WebRequestMethods;

namespace HurPsyExp.ExpRun
{
    public partial class RunViewModel : ObservableObject
    {
        private Experiment _experiment;

        public RunWindow RunWnd { get; set; }
        public TimeSpan StepTime { get; set; }

        private int blockNo;
        private int trialNo;
        private int stepNo;

        public ObservableCollection<StimulusViewModel> StimulusVMs { get; set; }

        public RunViewModel(RunWindow rwnd)
        {
            _experiment = new Experiment();
            StimulusVMs = new ObservableCollection<StimulusViewModel>();
            RunWnd = rwnd;
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

        public void LoadCurrentStep()
        {
            Step stp = GetCurrentStep();

            List<Stimulus> stimuli = GetStepStimuli(stp);
            List<Locator> locators = GetStepLocators(stp);

            StimulusVMs.Clear();

            // ATTENTION! In case location-less stimuli
            // such as audio stimuli are implemented,
            // there should be some extra control statements.
            for (int i = 0, n = stimuli.Count; i < n; i++)
            {
                Stimulus stim = stimuli[i];
                StimulusViewModel stimvm = new StimulusViewModel();

                if (stim is IVisualStimulus)
                {
                    Locator loc = locators[i];
                    Point pnt = UtilityClass.GetDIULocation((IVisualStimulus)stim, loc);

                    stimvm.StimulusObject = stim.StimulusObject;
                    stimvm.StimulusLocation = pnt;
                    stimvm.StimulusSize = UtilityClass.GetDIUSize((IVisualStimulus)stim);
                }

                StimulusVMs.Add(stimvm);
                StepTime = stp.StepTime.Span;
                RunWnd.DisplayCurrentStep();
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

        private Block GetCurrentBlock()
        {
            return _experiment.Blocks[blockNo];
        }

        private Trial GetCurrentTrial()
        {
            return GetCurrentBlock().Trials[trialNo];
        }

        private Step GetCurrentStep()
        {
            return GetCurrentTrial().Steps[stepNo];
        }

        public bool NextStep()
        {
            if (stepNo < GetCurrentTrial().Steps.Count - 1)
            { stepNo++; return true; }
            else if (trialNo < GetCurrentBlock().Trials.Count - 1)
            { trialNo++; stepNo = 0; return true; }
            else if (blockNo < _experiment.Blocks.Count - 1)
            { blockNo++; trialNo = 0; stepNo = 0; return true; }
            else return false;
        }

    }
}
