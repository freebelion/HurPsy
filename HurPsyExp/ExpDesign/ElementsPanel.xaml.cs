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

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// Interaction logic for ElementsPanel.xaml
    /// </summary>
    public partial class ElementsPanel : UserControl
    {
        public ElementsPanel()
        {
            InitializeComponent();
        }

        private void StimulusId_Updated(object sender, DataTransferEventArgs e)
        {
            // TODO: The event signals that the Id string has changed for a Stimulus object.
            // Get the Stimulus' reference from the sender's DataContext
            // and have the viewmodel replace the old Id values
            // in trial steps where this Stimulus was used.
        }

        private void LocatorId_Updated(object sender, DataTransferEventArgs e)
        {
            // TODO: The event signals that the Id string has changed for a Locator object.
            // Get the Stimulus' reference from the sender's DataContext
            // and have the viewmodel replace the old Id values
            // in trial steps where this Locator was used.
        }

        private void ImageStimulusButton_Click(object sender, RoutedEventArgs e)
        {
            DesignViewModel designVM = (DesignViewModel) this.DataContext;
            designVM.SelectImageStimulus();
            StimulusList.Items.Refresh();
        }

        private void PointLocatorButton_Click(object sender, RoutedEventArgs e)
        {
            DesignViewModel designVM = (DesignViewModel)this.DataContext;
            designVM.AddPointLocator();
            LocatorList.Items.Refresh();
        }
    }
}
