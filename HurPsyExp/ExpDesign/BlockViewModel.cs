using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
        private int currentTrialIndex = -1;
        /// <summary>
        /// This field will keep track of the index for the current trial being edited
        /// </summary>
        [ObservableProperty]
        private TrialViewModel? currentTrial;

        /// <summary>
        /// Observable collection of viewmodels representing the block trials
        /// </summary>
        public ObservableCollection<TrialViewModel> TrialVMs { get; set; }

        /// <summary>
        /// This parametrized constructor defers to the base class.
        /// </summary>
        /// <param name="blck"></param>
        public BlockViewModel(ExpBlock blck) : base(blck)
        {
            TrialVMs = [];

            foreach (ExpTrial tr in blck.Trials)
            { AddTrialVM(tr); }

            if (TrialVMs.Count > 0)
            { CurrentTrialIndex = 0; }
        }

        private void AddTrialVM(ExpTrial tr)
        {
            TrialViewModel trvm = new TrialViewModel(tr);
            trvm.IdChanged += TrialIdChanged;
            TrialVMs.Add(trvm);
        }

        partial void OnCurrentTrialIndexChanged(int value)
        {
            if (CurrentTrialIndex >= 0 && TrialVMs.Count > CurrentTrialIndex)
            {
                CurrentTrial = TrialVMs[CurrentTrialIndex];
                CurrentTrial.Selected = true;
            }

            else { CurrentTrial = null; }
        }

        [RelayCommand]
        private void PreviousTrial()
        {
            if (TrialVMs.Count > 0
                && CurrentTrialIndex > 0)
            {
                CurrentTrialIndex--;
            }
        }

        [RelayCommand]
        private void NextTrial()
        {
            if (TrialVMs.Count > 0
                && TrialVMs.Count > 1 + CurrentTrialIndex)
            {
                CurrentTrialIndex++;
            }
        }

        [RelayCommand]
        private void AddSingleTrial()
        {
            ExpTrial newTrial = new ExpTrial();
            ((ExpBlock)ItemObject).AddTrial(newTrial);
            AddTrialVM(newTrial);
            CurrentTrialIndex = TrialVMs.Count - 1;
        }

        private void TrialIdChanged(object? sender, IdChangeEventArgs e)
        {
            if (sender is TrialViewModel trvm && !string.IsNullOrEmpty(e.NewId))
            {
                ((ExpTrial)trvm.ItemObject).Id = e.NewId;
            }
        }
    }
}
