using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This class is for positioning a visual stimulus in a rectangular area
    /// </summary>
    [DataContract]
    public class RectangleLocator : Locator
    {
        /// <summary>
        /// The anchor point of the positioning rectangle (taken to be the center of the rectangle due to the default origin choice)
        /// Note that extra code might have to be written if more origin choices are implemented in the `HurPsyOrigin` enumeration.
        /// </summary>
        [DataMember]
        public HurPsyPoint RectangleLocation { get; private set; }
        
        /// <summary>
        /// The size of the positioning rectangle
        /// </summary>
        [DataMember]
        public HurPsySize RectangleSize { get; private set; }

        /// <summary>
        /// This default constructor creates a zero-size rectangle at the origin point
        /// </summary>
        public RectangleLocator()
        {
            RectangleLocation = new HurPsyPoint();
            RectangleSize = new HurPsySize();
        }

        /// <summary>
        /// The required implementation of the function inherited from the abstract base class will specify a randomized position within the underlying rectangle
        /// </summary>
        /// <param name="vistim">The visual stimulus which will be positioned by this locator instance</param>
        /// <returns>A randomized location within the underlying rectangle (with the guarantee that the visual stoimulus will not extend beyond that rectangle)</returns>
        public override HurPsyPoint GetLocation(IVisualStimulus? vistim = null)
        {
            double width = RectangleSize.Width;
            double height = RectangleSize.Height;
            double topleftx = RectangleLocation.X;
            double toplefty = RectangleLocation.Y;
            
            HurPsySize stimSize = new HurPsySize();

            if (vistim != null)
            { stimSize = vistim.VisualSize; }

            // The following calculations may have to be modified if the origin choices or anchor points are different for the locator and the runtime screen
            topleftx += stimSize.Width / 2;
            toplefty += stimSize.Height / 2;
            width -= stimSize.Width;
            height -= stimSize.Height;

            double x = topleftx + width * HurPsyCommon.Rnd.NextDouble();
            double y = toplefty + height * HurPsyCommon.Rnd.NextDouble();

            HurPsyPoint loc = new HurPsyPoint(x, y);
            return loc;
        }
    }
}
