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
    [KnownType(typeof(ImageStimulus))]
    public abstract class Stimulus
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string FileName { get; set; }

        public Stimulus()
        {
            Id = HurPsyCommon.GetObjectGuid(this);
            FileName = "";
        }
    }
}
