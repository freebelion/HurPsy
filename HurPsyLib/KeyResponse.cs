using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HurPsyLib
{
    /// <summary>
    /// This class represents a keyboard response
    /// </summary>
    [DataContract]
    public class KeyResponse : Response
    {
        /// <summary>
        /// The specific code for any key (which corresponds to Key.None enumeration value for WPF)
        /// A programmer may have to define another value for a different OS.
        /// </summary>
        private const int ANYKEY = 0;

        /// <summary>
        /// An integer code representing the key pressed on the keyboard
        /// (It may be an integer equivalent of an enumerated value provided by the OS;
        ///  if not, a programmer will have to find a define an enumeration representing the keys.)
        /// </summary>
        [DataMember]
        public int KeyCode { get; set; }

        /// <summary>
        /// This default constructor assumes that the key response can be any key.
        /// </summary>
        public KeyResponse()
        {
            KeyCode = ANYKEY;
        }

        /// <summary>
        /// This parametrized constructor starts with the given key code.
        /// </summary>
        /// <param name="kcode"></param>
        public KeyResponse(int kcode) : this()
        {
            KeyCode = kcode;
        }

        /// <summary>
        /// This implementation checks for equality of the key response represented by this object with another.
        /// </summary>
        /// <param name="rep">The other key response object</param>
        /// <returns>The indicator of equality</returns>
        public override bool Equals(Response rep)
        {
            if (rep is KeyResponse krep)
            {
                if (KeyCode == ANYKEY) return true;
                else return (KeyCode == krep.KeyCode);   
            }
            return false;
        }
    }
}
