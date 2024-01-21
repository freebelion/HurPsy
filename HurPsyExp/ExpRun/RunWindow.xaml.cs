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

namespace HurPsyExp.ExpRun
{
    /// <summary>
    /// Interaction logic for RunWindow.xaml
    /// </summary>
    public partial class RunWindow : Window
    {
        private DispatcherTimer stepTimer = new();

        public RunViewModel RunVM { get; set; }

        public RunWindow()
        {
            InitializeComponent();
            RunVM = new RunViewModel(this);
            stepTimer.Tick += StepTimer_Tick;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = RunVM;
            RunVM.LoadExperiment();
            RunVM.StartExperiment();
        }

        public void DisplayCurrentStep()
        {
            stepTimer.Interval = RunVM.StepTime;
            StimulusItemsControl.Visibility = Visibility.Visible;
            stepTimer.Start();
        }

        private void StepTimer_Tick(object? sender, EventArgs e)
        {
            stepTimer.Stop();
            StimulusItemsControl.Visibility = Visibility.Hidden;
            if(RunVM.NextStep())
            { RunVM.LoadCurrentStep(); }
            else { this.Close(); }
        }
    }
}
