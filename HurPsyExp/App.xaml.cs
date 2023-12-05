using System.Configuration;
using System.Data;
using System.Windows;

namespace HurPsyExp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// The handler function for the application's Startup event.
        /// At this stage, the application will let the user
        /// to open up a window to design an experiment,
        /// or open up another window to run an experiment.
        /// This is an implementation based on a tutorial found at:
        /// https://wpf-tutorial.com/wpf-application/working-with-app-xaml/
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            StartupDialog dlgStartup = new StartupDialog();
            dlgStartup.ShowDialog();
        }
    }

}
