using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HurPsyLib
{
    [DataContract]
    [KnownType(typeof(PointLocator))]
    public abstract class Locator
    {
        [DataMember]
        public string Id { get; set; }

        public Locator() { Id = HurPsyCommon.GetObjectGuid(this); }

        public abstract HurPsyPoint GetLocation();
    }
}
