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
        private object? stimulusObject;

        [ObservableProperty]
        private Point? stimulusLocation;

        [ObservableProperty]
        private Size stimulusSize;

        [ObservableProperty]
        private bool hidden;

        public StimulusViewModel()
        {
            StimulusObject = null;
            StimulusLocation = null;
            Hidden = true;
        }
    }
}