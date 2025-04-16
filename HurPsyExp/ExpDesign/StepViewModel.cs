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

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This class is a specialized version of `IdObjectViewModel` that represents a trial step.
    /// </summary>
    public partial class StepViewModel : IdObjectViewModel
    {
        /// <summary>
        /// This is the basis of the property bound to the `ToggleButton` **btnAddPair** with a popu that helkps add a pair of Ids.
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

        [RelayCommand]
        private void AddPair(DependencyPair dpobj)
        {
            if (dpobj.Object1 is string locId && dpobj.Object2 is string stimid)
            {
                if (!string.IsNullOrEmpty(locId) && !string.IsNullOrEmpty(stimid))
                {
                    ExpPair pr = new ExpPair(locId, stimid);
                    ((ExpStep) ItemObject).StepPairs.Add(pr);
                    PairVMs.Add(pr);
                }
            }

            AddingMode = false;
        }

        [RelayCommand]
        private void CancelAddPair()
        {
            AddingMode = false;
        }
    }
}
