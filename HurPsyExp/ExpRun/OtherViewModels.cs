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
        public Stimulus InnerStimulus { get; set; }

        public Point StimulusLocation { get; set; }

        public Size StimulusSize { get; set; }
     
        [ObservableProperty]
        private bool hidden;

        public StimulusViewModel(Stimulus stim, Point stimloc)
        {
            InnerStimulus = stim;
            StimulusLocation = stimloc;
            Hidden = true;
        }
    }
}