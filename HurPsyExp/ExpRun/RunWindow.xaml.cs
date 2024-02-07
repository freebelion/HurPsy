using HurPsyLib;
using System;
using System.Collections.Generic;
using System.IO;
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
            if (RunVM.LoadExperiment())
            { RunVM.StartExperiment(); }
            else { this.Close(); }
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
            StepEnded();
        }

        private void StepEnded()
        {
            StimulusItemsControl.Visibility = Visibility.Hidden;
            if (RunVM.NextStep())
            { RunVM.LoadCurrentStep(); }
            else { this.Close(); }
        }

        private void WebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
            WebBrowser? wbr = sender as WebBrowser;

            if(wbr != null)
            {
                StimulusViewModel? stimvm = wbr.DataContext as StimulusViewModel;

                if(stimvm != null)
                {
                    HtmlStimulus htmstim = (HtmlStimulus) stimvm.InnerStimulus;
                    wbr.Navigate("file:///" + htmstim.FileName);
                }
            }
        }

        private void Image_Loaded(object sender, RoutedEventArgs e)
        {
            Image? imgctrl = sender as Image;

            if(imgctrl != null)
            {
                StimulusViewModel? stimvm = imgctrl.DataContext as StimulusViewModel;

                if (stimvm != null)
                {
                    ImageStimulus imgstim = (ImageStimulus)stimvm.InnerStimulus;
                    if(File.Exists(imgstim.FileName))
                    {
                        imgctrl.Source = Utility.LoadImage(imgstim.FileName);
                    }
                    else
                    {
                        throw new HurPsyException(HurPsyExpStrings.StringResources.Error_StimulusFileNotFound
                                                    + "(Id: " + imgstim.Id + ", Searched Path: " + imgstim.FileName + ")");
                    }
                }
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                StepEnded();
            }
        }
    }
}
