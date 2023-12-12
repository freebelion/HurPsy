using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace HurPsyExp.ExpDesign
{
    public class DesignSettings
    {
        public double MinFontSize {  get; private set; }
        public double MaxFontSize { get; private set; }
        public double MinPanelWidth { get; private set; }
        public double MaxPanelWidth { get; private set; }

        public double UIFontSize { get; set; }
        public double MenuFontSize { get; set; }
        public double ElementsPanelWidth { get; set; }
        public double ExperimentPanelWidth { get; set; }

        public double CommandButtonHeight { get; set; }
        public double ImagePreviewHeight { get; set; }

        public DesignSettings()
        {
            MinFontSize = 6;
            MaxFontSize = 60;
            UIFontSize = 20;
            MenuFontSize = 16;

            CommandButtonHeight = 26;
            ImagePreviewHeight = 32;
            
            MinPanelWidth = 100;
            MaxPanelWidth = 500;
            ElementsPanelWidth = 250;
            ExperimentPanelWidth = 250;
        }
    }
}
