using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLibStrings
{
    public static class StringFinder
    {
        public static string GetString(string strName)
        {
            string? str = StringResources.ResourceManager.GetString(strName);

            if (str != null) { return str; }
            else
            {
                throw new ApplicationException("String resource not found");
            }
        }
    }
}
