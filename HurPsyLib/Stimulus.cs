using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HurPsyLib
{
    /// <summary>
    /// The abstract class which serves as the blueprint for all classes which will represent different types of experimental stimuli
    /// </summary>
    [DataContract]
    [KnownType(typeof(HtmlStimulus))]
    [KnownType(typeof(ImageStimulus))]
    public abstract class Stimulus
    {
        /// <summary>
        /// `Id` will serve as a uniquely identifying string for each instance
        /// </summary>
        [DataMember]
        public string Id { get; set; }

        /// <summary>
        /// `FileName` will contain the full path of the file containing the actual Stimulus object
        /// </summary>
        [DataMember]
        public string FileName { get; set; }

        /// <summary>
        /// Every instance of any class representing an experimental stimulus will start with a temporary unique id and an empty filename
        /// </summary>
        public Stimulus()
        {
            Id = HurPsyCommon.GetObjectGuid(this);
            FileName = string.Empty;
        }
    }
}
