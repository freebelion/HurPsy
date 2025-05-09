using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This abstract class represents a response definition identified by a unique string provided by its base class `IdObject`
    /// </summary>
    [KnownType(typeof(KeyResponse))]
	[DataContract]
    public abstract class Response : IdObject
    {
        /// <summary>
        /// Derived classes has to provide a way to check their equality (in terms of content) with another instance of the class.
        /// </summary>
        /// <param name="rep"></param>
        /// <returns></returns>
        public abstract bool Equals(Response rep);
    }
}
