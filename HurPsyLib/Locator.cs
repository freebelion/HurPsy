using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This abstract class serves as the blueprint for all subclasses which will help position `Stimulus` objects.
    /// </summary>
    [KnownType( typeof(PointLocator))]
    [DataContract]
    public abstract class Locator : IdObject
    {
        /// <summary>
        /// At this time, this default constructor doesn't need to do anything; the base class handles the temporary unique Id
        /// </summary>
        public Locator()
        {

        }

        /// <summary>
        /// Derived classes will have to override this abstract function to produce a location for the given `VisualStimulus` object.
        /// </summary>
        /// <param name="vistim">The visual stimulus to be placed</param>
        /// <returns>A location produced according to the method of the derived class</returns>
        public abstract HurPsyPoint GetLocation(VisualStimulus? vistim = null);
    }
}
