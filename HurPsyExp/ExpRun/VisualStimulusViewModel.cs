using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HurPsyLib;

namespace HurPsyExp.ExpRun
{
    /// <summary>
    /// This viewmodel helps displays a visual stimulus on `RunWindow`
    /// </summary>
    public class VisualStimulusViewModel
    {
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
    }
}
