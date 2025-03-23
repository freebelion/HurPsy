using System.Configuration;
using System.Data;
using System.IO;
using System.Windows;

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
            AppSettings appSettings = (AppSettings)this.Resources["AppSettings"];
            appSettings.DeSerializeJson();
        }

        /// <summary>
        /// Settings will be serialized in App's `Exit` event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            AppSettings appSettings = (AppSettings)this.Resources["AppSettings"];
            appSettings.SerializeJson();
        }
    }

}
