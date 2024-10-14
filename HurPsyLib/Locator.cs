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
    /// The abstract class which serves as the blueprint for all classes which will help position experimental stimuli according to their own rules
    /// </summary>
    [DataContract]
    [KnownType(typeof(RectangleLocator))]
    [KnownType(typeof(PointLocator))]
    public abstract class Locator
    {
        /// <summary>
        /// `Id` will serve as a uniquely identifying string for each instance
        /// </summary>
        [DataMember]
        public string Id { get; set; }

        /// <summary>
        /// This default constructor will assign a temporary unique id to every instance, one based on its type
        /// </summary>
        public Locator() { Id = HurPsyCommon.GetObjectGuid(this); }

        /// <summary>
        /// Derived classes will have to implement this function to specify a location for a visual stimulus
        /// </summary>
        /// <param name="vistim">The visual stimulus which will be positioned according to the outcome</param>
        /// <returns>The position specified for the visual stimulus</returns>
        public abstract HurPsyPoint GetLocation(VisualStimulus? vistim = null);
    }
}
