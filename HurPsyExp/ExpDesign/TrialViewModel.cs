using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using CommunityToolkit.Mvvm.Input;
using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This class is a specialized version of `IdObjectViewModel` that represents an experiment trial.
    /// </summary>
    public partial class TrialViewModel : IdObjectViewModel
    {
        /// <summary>
        /// The observable collection equivalent to the `ExpStep` list in the inner object
        /// </summary>
        public ObservableCollection<StepViewModel> StepVMs { get; set; }

        /// <summary>
        /// The parametrized constructor for this specialized viewmodel
        /// </summary>
        /// <param name="tr">The inner `ExpTrial` object</param>
        public TrialViewModel(ExpTrial tr) : base(tr)
        {
            StepVMs = [];

            foreach (ExpStep st in tr.Steps)
            { StepVMs.Add(new StepViewModel(st)); }
        }

        [RelayCommand]
        private void AddStep()
        {
            ExpStep st = new ExpStep();
            ((ExpTrial) ItemObject).AddStep(st);
            StepVMs.Add(new StepViewModel(st));
        }
    }
}
