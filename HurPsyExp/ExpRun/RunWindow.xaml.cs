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
using System.Windows.Threading;
using HurPsyLib;

namespace HurPsyExp.ExpRun
{
    /// <summary>
    /// Interaction logic for RunWindow.xaml
    /// </summary>
    public partial class RunWindow : Window
    {
        private DispatcherTimer expTimer;
        /// <summary>
        /// The viewmodel which will keep updating this window during the run
        /// </summary>
        public RunViewModel RunVM { get; set; }
        
        /// <summary>
        /// This default constructor simply initailizes the visual components of the window.
        /// </summary>
        public RunWindow(Experiment? exp = null)
        {
            InitializeComponent();

            expTimer = new DispatcherTimer();
            expTimer.Tick += ExpTimer_Tick;

            RunVM = new RunViewModel(this, exp);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = RunVM;

            RunVM.StartExperiment();
        }

        public void DisplayStep(TimeSpan displaytime)
        {
            expTimer.Interval = displaytime;
            VisualDisplay.Visibility = Visibility.Visible;
            expTimer.Start();
        }

        private void ExpTimer_Tick(object? sender, EventArgs e)
        {
            expTimer.Stop();
            VisualDisplay.Visibility = Visibility.Collapsed;
            RunVM.NextStep();
        }

    }
}
