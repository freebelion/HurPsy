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
        // These min/max settings will serve as limit values
        // for the sliders that will let a user change the relevant UI settings.
        public double MinFontSize {  get; private set; }
        public double MaxFontSize { get; private set; }
        public double MinPanelWidth { get; private set; }
        public double MaxPanelWidth { get; private set; }

        public double UIFontSize { get; set; }
        public double SmallFontSize { get; set; }
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
            SmallFontSize = 14;

            CommandButtonHeight = 24;
            ImagePreviewHeight = 24;
            
            MinPanelWidth = 100;
            MaxPanelWidth = 500;
            ElementsPanelWidth = 250;
            ExperimentPanelWidth = 250;
        }
    }
}
