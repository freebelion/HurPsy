using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HurPsyExp.ExpDesign;
using HurPsyLib;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;

namespace HurPsyExp.ExpRun
{
    public partial class StimulusViewModel : ObservableObject
    {
        [ObservableProperty]
        private Stimulus innerStimulus;

        [ObservableProperty]
        private Point stimulusLocation;

        [ObservableProperty]
        private Size stimulusSize;

        [ObservableProperty]
        private bool hidden;

        public object? StimulusObject
        {
            get { return InnerStimulus.StimulusObject; }
        }

        public StimulusViewModel(Stimulus stim, Point stimloc)
        {
            InnerStimulus = stim;
            StimulusLocation = stimloc;
            Hidden = true;
        }
    }
}