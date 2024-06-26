﻿using System;
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

namespace HurPsyExp
{
    /// <summary>
    /// Interaction logic for StartupDialog.xaml
    /// </summary>
    public partial class StartupDialog : Window
    {
        public StartupDialog()
        {
            InitializeComponent();
        }

        private void DesignExperiment(object sender, RoutedEventArgs e)
        {
            ExpDesign.DesignWindow windsgn = new ExpDesign.DesignWindow();
            windsgn.Show();
            this.Close();
        }

        private void RunExperiment(object sender, RoutedEventArgs e)
        {
            ExpRun.RunWindow winrun = new ExpRun.RunWindow();
            winrun.Show();
            this.Close();
        }
    }
}
