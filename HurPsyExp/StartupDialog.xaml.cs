using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HurPsyExp
{
    /// <summary>
    /// This class definition defines the interaction logic for `StartupDialog.xaml`.
    /// It contains the event handlers which display the design window or the run window, depending on the user's choice.
    /// </summary>
    public partial class StartupDialog : Window
    {
        /// <summary>
        /// The usual default constructor simply calls the component initializer.
        /// </summary>
        public StartupDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// If an experiment is to be designed, a design window is displayed and takes over the rest.
        /// </summary>
        /// <param name="sender">The object firing the event (the radio button for the "Design an Experiment" choice)</param>
        /// <param name="e">Additional event info</param>
        private void DesignExperiment(object sender, RoutedEventArgs e)
        {
            ExpDesign.DesignWindow windsgn = new ExpDesign.DesignWindow();
            windsgn.Show();
            this.Close();
        }

        /// <summary>
        /// If an experiment is to be designed, a run window is displayed and takes over the rest.
        /// </summary>
        /// <param name="sender">The object firing the event (the radio button for the "Run an Experiment" choice)</param>
        /// <param name="e">Additional event info</param>
        private void RunExperiment(object sender, RoutedEventArgs e)
        {
            ExpRun.RunWindow winrun = new ExpRun.RunWindow();
            winrun.Show();
            this.Close();
        }
    }
}
