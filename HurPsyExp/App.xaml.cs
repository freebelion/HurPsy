using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;
using HurPsyLib;

namespace HurPsyExp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Previously serialized settings will be stored in App's `Startup` event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            CurrentSettings.DeSerializeJson();
        }

        /// <summary>
        /// Settings will be serialized in App's `Exit` event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            CurrentSettings.SerializeJson();
        }

        /// <summary>
        /// An easy accessor for the AppSettings to use in the code
        /// </summary>
        public AppSettings CurrentSettings
        {
            get
            {
                AppSettings? curSettings = this.FindResource("AppSettings") as AppSettings;

                if (curSettings != null) { return curSettings; }
                else { throw new HurPsyException(HurPsyExpStrings.StringResources.Error_CannotAccessSettings); }
            }
        }
    }

}
