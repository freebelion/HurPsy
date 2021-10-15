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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HurPsyDesignApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ExperimentDesignWindow : Window
    {
        /// <summary>
        /// A private reference to this application's setings
        /// </summary>
        private Properties.Settings appSettings;

        public ExperimentDesignWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            appSettings = new Properties.Settings();
            appSettings.Reload(); // load the settings beforehand.
        }
    }
}
