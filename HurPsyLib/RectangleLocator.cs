using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    [DataContract]
    public class RectangleLocator : Locator
    {
        [DataMember]
        public HurPsyPoint RectangleLocation { get; private set; }
        [DataMember]
        public HurPsySize RectangleSize { get; private set; }

        public RectangleLocator()
        {
            RectangleLocation = new HurPsyPoint();
            RectangleSize = new HurPsySize();
        }

        public override HurPsyPoint GetLocation(IVisualStimulus? vistim = null)
        {
            double width = RectangleSize.Width;
            double height = RectangleSize.Height;
            double topleftx = RectangleLocation.X;
            double toplefty = RectangleLocation.Y;
            
            HurPsySize stimSize = new HurPsySize();

            if (vistim != null)
            { stimSize = vistim.VisualSize; }

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
