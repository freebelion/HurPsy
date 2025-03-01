using HurPsyLib;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This class represents a collection of trials which will be formed according to the choices of the experiment designer on `AddingTrialDialog`, 
    /// </summary>
    public class TrialPattern
    {
        /// <summary>
        /// The collection of `Locator` viewmodels that will help construct new steps and trials
        /// </summary>
        static public ObservableCollection<ItemViewModel<Locator>>? LocatorItemVMs { get; set; }

        /// <summary>
        /// The collection of `Stimulus` viewmodels that will help construct new steps and trials
        /// </summary>
        static public ObservableCollection<ItemViewModel<Stimulus>>? StimulusItemVMs { get; set; }

        /// <summary>
        /// This static constructor starts with null collections for itemn viewmodels.
        /// They will later point to the collections maintained by `DesignViewModel`
        /// </summary>
        static TrialPattern()
        {
            LocatorItemVMs = null;
            StimulusItemVMs = null;
        }
    }
}
