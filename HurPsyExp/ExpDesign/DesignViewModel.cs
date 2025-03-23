using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This VM class will handle the exchange of data between the experiment definition and the design interface
    /// </summary>
    public partial class DesignViewModel : ObservableObject
    {
        #region Design Properties
        /// <summary>
        /// The current content set by this viewmodel (it will change depending on the menu choices of the user)
        /// </summary>
        [ObservableProperty]
        private object? mainContent;

        #endregion

        #region Experiment Items
        /// <summary>
        /// The `Experiment` object managed by this viewmodel
        /// </summary>
        private Experiment exp;

        /// <summary>
        /// Collection of viewmodels associated with experiment `Stimulus` objects
        /// </summary>
        public ObservableCollection<IdObjectViewModel> StimulusVMs { get; set; }

        /// <summary>
        /// Collection of viewmodels associated with experiment `Locator` objects
        /// </summary>
        public ObservableCollection<IdObjectViewModel> LocatorVMs { get; set; }
        #endregion

        #region Constructor(s)
        /// <summary>
        /// This default constructor starts with a new experiment definition and empty VM collections
        /// </summary>
        public DesignViewModel()
        {
            exp = new Experiment();

            StimulusVMs = [];
            LocatorVMs = [];

            InitializeTest();
        }
        #endregion

        #region Methods
        private void InitializeTest()
        {
            
        }
        #endregion

        #region Commands
        
        #endregion
    }
}
