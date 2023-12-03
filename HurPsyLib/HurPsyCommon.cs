using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace HurPsyLib
{
    public static class HurPsyCommon
    {
        public static HurPsySize? ViewSize = null;

        public static Random Rnd = new Random((int)DateTime.Now.Ticks);

        public static string GetObjectGuid(object obj)
        { return obj.GetType().Name + "_" + Guid.NewGuid().ToString().Substring(0, 8); }
    }
}
