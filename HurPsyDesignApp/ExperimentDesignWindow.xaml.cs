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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HurPsyDesignApp
{
    /// <summary>
    /// Interaction logic for ExperimentDesignWindow.xaml
    /// </summary>
    public partial class ExperimentDesignWindow : Window
    {
        public ExperimentDesignWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void LoadDynamicResourceDictionary(string xamlResourceFileName)
        {
            if (System.IO.File.Exists(xamlResourceFileName))
            {
                ResourceDictionary resdict =
                    (ResourceDictionary)XamlReader.Load(System.Xml.XmlReader.Create(xamlResourceFileName));
                this.Resources.MergedDictionaries.Add(resdict);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            ValueSettings.Default.Save();
        }

        private void GridSplitter_DragCompleted(object sender, System.Windows.Controls.Primitives.DragCompletedEventArgs e)
        {
            ValueSettings.Default.DefinitionsPanelWidth = mainGrid.ColumnDefinitions[0].ActualWidth;
            ValueSettings.Default.BlockDesignPanelWidth = mainGrid.ColumnDefinitions[2].ActualWidth;
        }
    }
}
