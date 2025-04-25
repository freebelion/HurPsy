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
using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// Interaction logic for DesignWindow.xaml
    /// </summary>
    public partial class DesignWindow : Window
    {
        /// <summary>
        /// The viewmodel object that will handle data exchange with the visual controls
        /// </summary>
        public DesignViewModel DesignVM { get; set; }

        /// <summary>
        /// This default constructor simply initailizes the visual components of the window.
        /// </summary>
        public DesignWindow(Experiment? exp = null)
        {
            DesignVM = new DesignViewModel(exp);
            InitializeComponent();
        }

        /// <summary>
        /// When this window is loaded, the window adopts its `dataContext` and draws the grid which will be used to calculate the scale factor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = DesignVM;

            DrawScaleCanvas();
        }

        /// <summary>
        /// This inner method draws a grid inside the `ScaleCanvas` on the settings panel on the right,
        /// so that a user can calculate the scale correction factor for placing visual stimuli on the screen.
        /// </summary>
        private void DrawScaleCanvas()
        {
            SolidColorBrush lnbr = new SolidColorBrush(Colors.Black);

            for (int i = 0; i < 20; i++)
            {
                Line ln = new Line();
                ln.X1 = 0;      ln.Y1 = 12 * i;
                ln.X2 = 240;    ln.Y2 = 12 * i;
                ln.Stroke = lnbr;
                ln.StrokeThickness = 0.25;
                ScaleCanvas.Children.Add(ln);

                ln = new Line();
                ln.X1 = 12 * i; ln.Y1 = 0;
                ln.X2 = 12 * i; ln.Y2 = 240;
                ln.Stroke = lnbr;
                ln.StrokeThickness = 0.25;
                ScaleCanvas.Children.Add(ln);
            }
        }
    }
}
