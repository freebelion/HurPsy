using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using HurPsyLib;

namespace HurPsyExp.ExpRun
{
    /// <summary>
    /// This viewmodel helps displays a visual stimulus on `RunWindow`
    /// </summary>
    public class VisualStimulusViewModel
    {
        private static readonly double scaleFactor = ((App)Application.Current).CurrentSettings.ScaleFactor;

        /// <summary>
        /// X position (in Windows coordinates)
        /// </summary>
        public double Xpos { get; set; }

        /// <summary>
        /// Y position (in Windows coordinates)
        /// </summary>
        public double Ypos { get; set; }

        /// <summary>
        /// Width (in DIU)
        /// </summary>
        public double VisualWidth { get; set; }

        /// <summary>
        /// Height (in DIU)
        /// </summary>
        public double VisualHeight { get; set; }

        /// <summary>
        /// The actual visual object (`Shape` or `Image`) to be displayed
        /// </summary>
        public object? VisualObject { get; set; }

        /// <summary>
        /// This constructor takes care of unit conversions from mm to device pixels and associates the actual visual stimulus object with this viewmodel object.
        /// </summary>
        /// <param name="vistim">`VisualStimulus` object modeled by this object</param>
        /// <param name="locpnt">Location point (in millimeters) calculoated by the `Locator` paired with the `VisualStimulus` object.</param>
        /// <param name="visobj">The actual visual object to be displayed at the location point.</param>
        public VisualStimulusViewModel(VisualStimulus vistim, HurPsyPoint locpnt, object visobj)
        {
            // CAUTION: Locations and sizes are calculated for the primary screen of the system (maybe the use of the primary screen must be enforced)
            Xpos = (System.Windows.SystemParameters.PrimaryScreenWidth / 2) + Utility.MM2DIU * (locpnt.X - vistim.VisualSize.Width / 2) / scaleFactor;
            Ypos = (System.Windows.SystemParameters.PrimaryScreenHeight / 2) - Utility.MM2DIU * (locpnt.Y + vistim.VisualSize.Height / 2) / scaleFactor;

            VisualWidth = Utility.MM2DIU * vistim.VisualSize.Width / scaleFactor;
            VisualHeight = Utility.MM2DIU * vistim.VisualSize.Height / scaleFactor;

            VisualObject = visobj;
        }
    }
}
