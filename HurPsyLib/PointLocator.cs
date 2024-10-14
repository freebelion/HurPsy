using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This class represents a single-point locator
    /// </summary>
    [DataContract]
    public class PointLocator : Locator
    {
        /// <summary>
        /// The location point
        /// </summary>
        [DataMember]
        public HurPsyPoint LocatorPoint { get; private set;} 

        /// <summary>
        /// This default constructor starts with a point location at the origin (normally at the center of the screen)
        /// </summary>
        public PointLocator()
        {
            LocatorPoint = new HurPsyPoint();
        }

        /// <summary>
        /// This parametrized constructor accepts the coordinates of a point
        /// </summary>
        /// <param name="locX">The horizontal position of the location point</param>
        /// <param name="locY">The vertical position of the location point</param>
        public PointLocator(double locX, double locY)
        {
            LocatorPoint = new HurPsyPoint(locX, locY);
        }

        /// <summary>
        /// The required implementation of the function inherited from the abstracxt base class simply specific the inner location point as the stimulus location
        /// </summary>
        /// <param name="vistim">The visual stimulus which will be positioned by this locator instance</param>
        /// <returns>A tempotrary copy of the inner location point, so that subsequent operations will not modify `LocatorPoint`</returns>
        public override HurPsyPoint GetLocation(VisualStimulus? vistim = null)
        {
            return LocatorPoint.ShallowCopy();
        }
    }
}
