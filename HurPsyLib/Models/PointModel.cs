using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    /// <summary>
    /// This class is to represent a location 
    /// on the experiment presentation surface.
    /// </summary>
    public class PointModel
    {
        // Member variables to store the coordinates in millimeters
        private double pointX;
        private double pointY;

        /// <summary>
        /// The property to help access the X coordinate
        /// </summary>
        public double X
        {
            get { return pointX; }
            set { pointX = value; }
        }

        /// <summary>
        /// The property to access the Y coordinate
        /// </summary>
        public double Y
        {
            get { return pointY; }
            set { pointY = value; }
        }
    }
}
