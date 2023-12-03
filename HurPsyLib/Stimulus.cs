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
        // The following property will not be saved as part of a Stimulus instance;
        // it is only going to be used by the design and display applications
        // to display a representation of the actual stimulus object.
        public object? StimulusObject { get; set; }

        public Stimulus()
        {
            Id = HurPsyCommon.GetObjectGuid(this);
            FileName = string.Empty;
            StimulusObject = null;
        }
    }
}
