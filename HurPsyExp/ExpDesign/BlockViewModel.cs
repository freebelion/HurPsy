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
        /// This is the basis of the property bound to the `ToggleButton` **btnAddMultipleTrial**.
        /// </summary>
        [ObservableProperty]
        private bool addingMode;

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
            AddingMode = false;
            TrialVMs = [];

            foreach (ExpTrial tr in blck.Trials)
            { AddTrialVM(tr); }

            if (TrialVMs.Count > 0)
            { CurrentTrialIndex = 0; }
        }

        /// <summary>
        /// This private method adds a viewmodel object associated with a `ExpTrial` object
        /// </summary>
        /// <param name="tr"></param>
        private void AddTrialVM(ExpTrial tr)
        {
            TrialViewModel trvm = new TrialViewModel(tr);
            trvm.IdChanged += TrialIdChanged;
            TrialVMs.Add(trvm);
        }

        /// <summary>
        /// This inner method updates the `CurrentTrial` property after `CurrentTrialIndex` has changed.
        /// </summary>
        /// <param name="value"></param>
        partial void OnCurrentTrialIndexChanged(int value)
        {
            if (CurrentTrialIndex >= 0 && TrialVMs.Count > CurrentTrialIndex)
            {
                CurrentTrial = TrialVMs[CurrentTrialIndex];
                CurrentTrial.Selected = true;
            }

            else { CurrentTrial = null; }
        }

        /// <summary>
        /// This command implementation moves to the previous trial as `CurrentTrial`
        /// </summary>

        [RelayCommand]
        private void PreviousTrial()
        {
            if (TrialVMs.Count > 0
                && CurrentTrialIndex > 0)
            {
                CurrentTrialIndex--;
            }
        }

        /// <summary>
        /// This command implementation moves to the next trial as `CurrentTrial`
        /// </summary>
        [RelayCommand]
        private void NextTrial()
        {
            if (TrialVMs.Count > 0
                && TrialVMs.Count > 1 + CurrentTrialIndex)
            {
                CurrentTrialIndex++;
            }
        }

        /// <summary>
        /// This command implementation adds one new single-step trial and moves the `CurrentTrial` to that one.
        /// </summary>
        [RelayCommand]
        private void AddSingleTrial()
        {
            ExpTrial newTrial = new ExpTrial();
            ((ExpBlock)ItemObject).AddTrial(newTrial);
            AddTrialVM(newTrial);
            CurrentTrialIndex = TrialVMs.Count - 1;
        }

        /// <summary>
        /// This command implementation adds multiple trials based on the combination of `Stimulus`-`Locator` pairing choices of the user.
        /// </summary>
        [RelayCommand]
        private void AddMultipleTrial(object param)
        {
            AddingMode = false;
        }

        /// <summary>
        /// This command implementation will cancel adding multiple trials and close the **AddTrialPopup**.
        /// </summary>
        [RelayCommand]
        private void AddMultipleTrialCancel()
        {
            AddingMode = false;
        }

        /// <summary>
        /// This event handler updates the Id of an `ExpTrial` object when its viewmodel reports an Id change.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrialIdChanged(object? sender, IdChangeEventArgs e)
        {
            if (sender is TrialViewModel trvm && !string.IsNullOrEmpty(e.NewId))
            {
                ((ExpTrial)trvm.ItemObject).Id = e.NewId;
            }
        }
    }
}
