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

        #endregion

        #region Constructor(s)
        /// <summary>
        /// This default constructor starts with a new experiment definition and empty VM collections
        /// </summary>
        public DesignViewModel()
        {
            exp = new Experiment();

            MainContent = null;
        }
        #endregion

        #region Commands
        /// <summary>
        /// This method switches the current layout
        /// </summary>
        /// <param name="newlayout"></param>
        [RelayCommand]
        private void SwitchLayout(DesignLayout newlayout)
        {
            // Layout choice is stored and (de)seralized in AppSettings resource defined in App.xaml
            AppSettings? currentSettings = App.Current.TryFindResource("AppSettings") as AppSettings;
            if (currentSettings != null)
            {
                currentSettings.CurrentLayout = newlayout;
            }
        }
        #endregion
    }
}
