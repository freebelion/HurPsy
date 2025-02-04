using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace HurPsyLib
{
    /// <summary>
    /// This static class serves as a container for global objects utilized by all the `HurPsyLib` objects 
    /// </summary>
    public static class HurPsyCommon
    {
        /// <summary>
        /// The pseudo-random number generator shared by HurPsyLib` objects
        /// </summary>
        public static Random Rnd = new Random((int)DateTime.Now.Ticks);

        /// <summary>
        /// This function returns a temporary unique id generated with the type name of any object
        /// </summary>
        /// <param name="obj">The object which needs the temporary unique id</param>
        /// <returns></returns>
        public static string GetObjectGuid(object obj)
        { return obj.GetType().Name + "_" + Guid.NewGuid().ToString().Substring(0, 8); }
    }
}
