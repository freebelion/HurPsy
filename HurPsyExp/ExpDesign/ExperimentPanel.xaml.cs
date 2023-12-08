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
    /// Interaction logic for ExperimentPanel.xaml
    /// </summary>
    public partial class ExperimentPanel : UserControl
    {
        public ExperimentPanel()
        {
            InitializeComponent();
        }

        private void AddBlock_Click(object sender, RoutedEventArgs e)
        {
            DesignViewModel designVM = (DesignViewModel)this.DataContext;
            designVM.AddBlock();
            lbBlocks.Items.Refresh();
        }
    }
}
