using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// The following class will encapsulate the properties and behaviors
    /// which should be globally available to this control and class library.
    /// </summary>
    internal static class Globals
    {
        public static StringSettings HurPsyLibStrings { get; set; }

        static Globals()
        {
            HurPsyLibStrings = new StringSettings();
            HurPsyLibStrings.Reload();
        }

        public static void SaveStringSettings()
        {
            HurPsyLibStrings.Save();
        }
    }
}
