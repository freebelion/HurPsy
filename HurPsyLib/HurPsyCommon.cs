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
		/// This static method will throw an exception displaying the named string resource from the **HurPsyLibStrings** assembly.
		/// </summary>
		/// <param name="strid">Name of the string resource</param>
		public static void Throw(string strid)
		{
			string? resstr = HurPsyLibStrings.StringResources.ResourceManager.GetString(strid);
			if (resstr != null)
			{
				throw (new HurPsyException(resstr));
			}
			else
			{
				throw (new HurPsyException(HurPsyLibStrings.StringResources.Error_InvalidStringResource));
			}
		}
	}
}
