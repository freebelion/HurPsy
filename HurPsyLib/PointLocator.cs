using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    [DataContract]
    public class PointLocator : Locator
    {
        [DataMember]
        public HurPsyPoint LocatorPoint { get; set;} 

        public PointLocator()
        {
            LocatorPoint = new HurPsyPoint();
        }

        public PointLocator(double locX, double locY)
        {
            LocatorPoint = new HurPsyPoint(locX, locY);
        }

        public override HurPsyPoint GetLocation()
        {
            return LocatorPoint;
        }
    }
}
