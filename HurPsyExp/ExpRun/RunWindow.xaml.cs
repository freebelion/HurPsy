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
    /// This class definition describes the interaction logic for `RunWindow.xaml`.
    /// </summary>
    public partial class RunWindow : Window
    {
        /// <summary>
        /// This timer will be used to display timed steps.
        /// </summary>
        private DispatcherTimer stepTimer = new();

        /// <summary>
        /// The viewmodel object will be responsible for advancing through trial steps, trials and blocks.
        /// </summary>
        public RunViewModel RunVM { get; set; }

        /// <summary>
        /// This default constructor will initialize this window's components, create the viewmodel object and specify the event handler for the timer
        /// </summary>
        public RunWindow()
        {
            InitializeComponent();
            RunVM = new RunViewModel(this);
            stepTimer.Tick += StepTimer_Tick;
        }

        /// <summary>
        /// The asssociated viewmodel object will start running the experiment as soon as this window is loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = RunVM;
            if (RunVM.LoadExperiment())
            { RunVM.StartExperiment(); }
            else { this.Close(); }
        }

        /// <summary>
        /// This little function will display the current trial step.
        /// Currently, it assumes every step will be on display for a specific period of time,
        /// but there may be cases a display time is not specified because the current step may need to stay on display until an acceptable response is given.
        /// </summary>
        public void DisplayCurrentStep()
        {
            stepTimer.Interval = RunVM.StepTime;
            StimulusItemsControl.Visibility = Visibility.Visible;
            stepTimer.Start();
        }

        /// <summary>
        /// This method handles the timer's `Tick` event and takes the necessary actions to end the current step.
        /// </summary>
        /// <param name="sender">The object firing the event (which is `stepTimer`)</param>
        /// <param name="e">Additional event info</param>
        private void StepTimer_Tick(object? sender, EventArgs e)
        {
            stepTimer.Stop();
            StepEnded();
        }

        /// <summary>
        /// This method performs the end-of-step operations.
        /// </summary>
        private void StepEnded()
        {
            StimulusItemsControl.Visibility = Visibility.Hidden;
            if (RunVM.NextStep())
            { RunVM.LoadCurrentStep(); }
            else { this.Close(); }
        }

        /// <summary>
        /// This method handles the `Loaded` event of the `WebBrowser control, which will be come onto the screen if a `HtmlStimulus` is to be displayed.
        /// </summary>
        /// <param name="sender">The object firing the event (which the `WebBrowser` control)</param>
        /// <param name="e">Additional event info</param>
        private void WebBrowser_Loaded(object sender, RoutedEventArgs e)
        {
            WebBrowser? wbr = sender as WebBrowser;

            if(wbr != null)
            {
                StimulusViewModel? stimvm = wbr.DataContext as StimulusViewModel;

                if(stimvm != null)
                {// The web browser control will display the contents of the Html file specified by the `HtmlStimulus` object.
                    HtmlStimulus htmstim = (HtmlStimulus) stimvm.InnerStimulus;
                    wbr.Navigate("file:///" + htmstim.FileName);
                }
            }
        }

        /// <summary>
        /// This method handles the `Loaded` event of an `Image` control, which will be come onto the screen if an `ImageStimulus` is to be displayed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Additional event info</param>
        /// <exception cref="HurPsyException">The object firing the event (which the `Image` control)</exception>
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

        /// <summary>
        /// This method will handle the `KeyDown` events if the current step requires a key response.
        /// </summary>
        /// <param name="sender">The object firing the event (which is any key on the keyboard)</param>
        /// <param name="e">Additional event info</param>
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                StepEnded();
            }
        }
    }
}
