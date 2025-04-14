using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This class is a specialized version of `IdObjectViewModel` that represents a block of trials.
    /// </summary>
    public partial class BlockViewModel : IdObjectViewModel
    {
        /// <summary>
        /// The privately stored index of `CurrentTrial`
        /// </summary>
        [ObservableProperty]
        private int currentTrialIndex;
        /// <summary>
        /// This field will keep track of the index for the current trial being edited
        /// </summary>
        [ObservableProperty]
        private ExpTrial? currentTrial;

        /// <summary>
        /// This parametrized constructor defers to the base class.
        /// </summary>
        /// <param name="blck"></param>
        public BlockViewModel(ExpBlock blck) : base(blck)
        {
            CurrentTrialIndex = 0;
            GetCurrentTrial();
        }

        /// <summary>
        /// A shortcut method to access the inner block of trials
        /// </summary>
        /// <returns></returns>
        private ExpBlock GetBlockItem() => (ExpBlock) ItemObject;

        /// <summary>
        /// A readonly property to access the current Trial being edited
        /// </summary>
        public void GetCurrentTrial()
        {
            if (GetBlockItem().Trials.Count > CurrentTrialIndex)
            { CurrentTrial = GetBlockItem().Trials[CurrentTrialIndex]; }
            else { CurrentTrial = null; }
        }

        [RelayCommand]
        private void PreviousTrial()
        {
            if (GetBlockItem().Trials.Count > 0
                && CurrentTrialIndex > 0)
            {
                CurrentTrialIndex--;
                GetCurrentTrial();
            }
        }

        [RelayCommand]
        private void NextTrial()
        {
            if (GetBlockItem().Trials.Count > 0
                && GetBlockItem().Trials.Count > 1 + CurrentTrialIndex)
            {
                CurrentTrialIndex++;
                GetCurrentTrial();
            }
        }
    }
}
