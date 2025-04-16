using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This class is intended to represent `ExpPair` objects and help `AddPairPopup` to add new Id pairs to `ExpStep` objects
    /// </summary>
    public partial class PairViewModel : ObservableObject
    {
        [ObservableProperty]
        private string? locatorId;

        [ObservableProperty]
        private string? stimulusId;

        public PairViewModel()
        {
            LocatorId = string.Empty;
            StimulusId = string.Empty;  
        }

        public PairViewModel(ExpPair pr)
        {
            LocatorId = pr.LocatorId;
            StimulusId= pr.StimulusId;
        }
    }
}
