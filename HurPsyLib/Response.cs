using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This abstract class represents a response definition identified by a unique string provided by its base class `IdObject`
    /// </summary>
    public abstract class Response : IdObject
    {
        /// <summary>
        /// Derived classes has to provide a way to check their equality (in terms of content) with another object of this abstract type.
        /// </summary>
        /// <param name="rep"></param>
        /// <returns></returns>
        public abstract bool Equals(Response rep);
    }
}
