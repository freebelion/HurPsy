using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This class represents an association between a `Stimulus` and a `Locator` which specifies a location for the stimulus.
    /// </summary>
    [DataContract]
    public class ExpPair
    {
        /// <summary>
        /// The Id representing the `Stimulus` of the pair
        /// </summary>
        [DataMember]
        public string StimulusId {  get; set; }

        /// <summary>
        /// The Id representing the `Locator` of the pair
        /// </summary>
        [DataMember]
        public string LocatorId { get; set; }

        /// <summary>
        /// This default constructor starts with empty Id strings.
        /// </summary>
        public ExpPair()
        {
            StimulusId = string.Empty;
            LocatorId = string.Empty;
        }

        /// <summary>
        /// This parametrized constructor uses the given Ids for initialization.
        /// </summary>
        /// <param name="stimId"></param>
        /// <param name="locId"></param>
        public ExpPair(string stimId, string locId)
        {
            StimulusId = stimId;
            LocatorId = locId;
        }
    }
}
