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
        /// The current content set by this viewmodel (it will change depending on the choice clicked on **MainContentMenu** defined in **DesignLayouts.xaml**)
        /// </summary>
        [ObservableProperty]
        private object? displayContent;

        /// <summary>
        /// The label indicating the current display content (it will apear on **MainContentLabel** defined in **DesignLayouts.xaml**)
        /// </summary>
        [ObservableProperty]
        private string displayContentLabel = string.Empty;
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

            // Start with StimulusDefinitions content, until a diferent decision is made.
            ChooseContent(DisplayContentChoice.StimulusDefinitions);

            InitializeTest();
        }
        #endregion

        #region Methods
        private void InitializeTest()
        {
            
        }
        #endregion

        #region Commands
        /// <summary>
        /// This method, when executed as a command, changes the display content according to the user's choice.
        /// </summary>
        /// <param name="newchoice"></param>
        [RelayCommand]
        private void ChooseContent(DisplayContentChoice newchoice)
        {
            switch(newchoice)
            {
                case DisplayContentChoice.StimulusDefinitions:
                    DisplayContent = StimulusVMs;
                    DisplayContentLabel = HurPsyExpStrings.StringResources.Header_StimulusDefinitions;
                    break;
                case DisplayContentChoice.LocatorDefinitions:
                    DisplayContent = LocatorVMs;
                    DisplayContentLabel = HurPsyExpStrings.StringResources.Header_LocatorDefinitions;
                    break;
            }
        }
        #endregion
    }
}
