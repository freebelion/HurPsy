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
        /// <summary>
        /// The viewmodel object that will handle data exchange with the visual controls
        /// </summary>
        public DesignViewModel DesignVM { get; set; }

        /// <summary>
        /// This default constructor simply initailizes the visual components of the window.
        /// </summary>
        public DesignWindow()
        {
            DesignVM = new();
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.DataContext = DesignVM;
        }
    }
}
