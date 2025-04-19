using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Controls.Primitives;
using System.Windows.Controls;
using HurPsyLib;
using System.Security.Cryptography.Pkcs;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Security.Cryptography;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This class is a specialized version of `IdObjectViewModel` that represents a trial step.
    /// </summary>
    public partial class StepViewModel : IdObjectViewModel
    {
        /// <summary>
        /// This is the basis of the property bound to the `ToggleButton` **btnAddPair**.
        /// </summary>
        [ObservableProperty]
        private bool addingMode;

        /// <summary>
        /// The observable collection equivalent to the `ExpPair` list in the inner object
        /// </summary>
        public ObservableCollection<ExpPair> PairVMs { get; set; }

        /// <summary>
        /// The parametrized constructor for this specialized viewmodel
        /// </summary>
        /// <param name="st">The inner `ExpStep` object</param>
        public StepViewModel(ExpStep st) : base(st)
        {
            PairVMs = [];

            foreach (ExpPair pr in st.StepPairs)
            {
                PairVMs.Add(pr);
            }
        }

        /// <summary>
        /// This command implementation adds a new `Locator`-`Stimulus` Id pair to the underlying trial step.
        /// </summary>
        /// <param name="pr">The `ParameterPair` object which brings in the Ids to be paired</param>
        [RelayCommand]
        private void AddPair(ExpPair pr)
        {
            if (!string.IsNullOrEmpty(pr.LocatorId) && !string.IsNullOrEmpty(pr.StimulusId))
            {
                ((ExpStep)ItemObject).StepPairs.Add(pr);
                PairVMs.Add(pr);
            }

            AddingMode = false;
        }

        /// <summary>
        /// This command implementation cancels adding a new pair and hides the **AddPairPopup* control.
        /// </summary>
        [RelayCommand]
        private void CancelAddPair()
        {
            AddingMode = false;
        }
    }
}
