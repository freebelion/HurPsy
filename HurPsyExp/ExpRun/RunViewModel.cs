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
            Experiment? exp = Utility.LoadExperiment();

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

            GetCurrentBlock().ShuffleTrials();
            LoadCurrentStep();
        }

        public void LoadCurrentStep()
        {
            Step stp = GetCurrentStep();

            StimulusVMs.Clear();

            // ATTENTION! In case location-less stimuli
            // such as audio stimuli are implemented,
            // there should be some extra control statements.
            for (int i = 0, n = stp.StimulusLocators.Count; i < n; i++)
            {
                Stimulus stim = GetStimulus(stp.StimulusLocators[i].StimulusId);
                
                if (stim is not IVisualStimulus) continue;

                Locator loc = GetLocator(stp.StimulusLocators[i].LocatorId); ;
                Point pnt = Utility.GetDIULocation((IVisualStimulus)stim, loc);
                StimulusViewModel stimvm = new StimulusViewModel(stim, pnt);
                stimvm.StimulusSize = Utility.GetDIUSize((IVisualStimulus)stim);

                StimulusVMs.Add(stimvm);
                StepTime = stp.StepTime.Span;
                RunWnd.DisplayCurrentStep();
            }
        }

        public Stimulus GetStimulus(string stimId)
        { return _experiment.GetStimulus(stimId); }

        public Locator GetLocator(string locId)
        { return _experiment.GetLocator(locId); }

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
            { blockNo++; trialNo = 0; stepNo = 0; GetCurrentBlock().ShuffleTrials(); return true; }
            else return false;
        }

    }
}
