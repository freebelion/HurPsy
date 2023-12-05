using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyExp
{
    public class AppSettings
    {
        public double MinFontSize {  get; private set; }
        public double MaxFontSize { get; private set; }
        public double MinPanelWidth { get; private set; }
        public double MaxPanelWidth { get; private set; }

        public double UIFontSize { get; set; }
        public double MenuFontSize { get; set; }
        public double ElementsPanelWidth { get; set; }
        public double ExperimentPanelWidth { get; set; }

        public AppSettings()
        {
            MinFontSize = 6;
            MaxFontSize = 60;
            UIFontSize = 20;
            MenuFontSize = 16;

            MinPanelWidth = 100;
            MaxPanelWidth = 500;
            ElementsPanelWidth = 250;
            ExperimentPanelWidth = 250;
        }
    }
}
