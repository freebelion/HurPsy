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
    [KnownType(typeof(HtmlStimulus))]
    [KnownType(typeof(ImageStimulus))]
    public abstract class Stimulus
    {
        [DataMember] // Id will serve as a uniquely identifying string for each instance
        public string Id { get; set; }
        [DataMember] // This is the full path of the file containing the actual Stimulus object
        public string FileName { get; set; }

        public Stimulus()
        {
            Id = HurPsyCommon.GetObjectGuid(this);
            FileName = string.Empty;
        }
    }
}
