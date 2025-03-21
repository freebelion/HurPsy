using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This class stores a specific location point and uses its coordinates to produce a location for any visual stimulus
    /// </summary>
    [DataContract]
    public class PointLocator : Locator
    {
        /// <summary>
        /// The location point
        /// </summary>
        public HurPsyPoint LocatorPoint {  get; private set; }

        /// <summary>
        /// This default constructor starts with a location point at the origin (normally, the center of the screen)
        /// </summary>
        public PointLocator()
        {
            LocatorPoint = new HurPsyPoint();
        }

        /// <summary>
        /// This parametreized constructor initializes the location point at the given coordinates
        /// </summary>
        /// <param name="locX">X coordinate</param>
        /// <param name="locY">Y coordinate</param>
        public PointLocator(double locX, double locY)
        {
            LocatorPoint = new HurPsyPoint(locX, locY);
        }

        /// <summary>
        /// When prompted to produce a location, this class simply returns a temporary copy of the location point
        /// </summary>
        /// <param name="vistim">The visual stimulus to be placed</param>
        /// <returns>A temporary copy of the location point</returns>
        public override HurPsyPoint GetLocation(VisualStimulus? vistim = null)
        {
            return LocatorPoint.ShallowCopy();
        }
    }
}
