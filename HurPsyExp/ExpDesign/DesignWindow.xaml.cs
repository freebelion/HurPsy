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

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// Interaction logic for DesignWindow.xaml
    /// </summary>
    public partial class DesignWindow : Window
    {
        public DesignViewModel DesignVM { get; set; }

        public DesignWindow()
        {
            InitializeComponent();
            
            DesignVM = new DesignViewModel();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Although I started with a strict adherence to the MVVM architecture,
            // I decided to go back to code-behind in order to keep the codes simple
            // and make the application leaner.
            this.DataContext = DesignVM;
        }

        private void NewExperimentMenuItem_Click(object sender, RoutedEventArgs e)
        {
            DesignVM.NewExperiment();
        }

        private void LoadExperimentMenuItem_Click(object sender, RoutedEventArgs e)
        {
            DesignVM.LoadExperiment();
        }

        private void SaveExperimentMenuItem_Click(object sender, RoutedEventArgs e)
        {
            DesignVM.SaveExperiment();
        }

    }
}
