using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HurPsyLib
{
	/// <summary>
	/// This abstract class enables all instances of derived classes to have temporary Ids assigned.
	/// </summary>
	public abstract class IdObject
	{
		/// <summary>
		/// This function returns a temporary unique id generated with the type name of any object derived from this class.
		/// </summary>
		/// <param name="idobj"></param>
		/// <returns></returns>
		public static string GenerateId(IdObject idobj)
		{
			return idobj.GetType().Name + "_" + Guid.NewGuid().ToString().Substring(0, 8);
		}

		/// <summary>
		/// `Id` will serve as a uniquely identifying string for each instance.
		/// </summary>
		[DataMember]
		public string Id { get; set; }

		/// <summary>
		/// This default constructor assigns a temporary unique Id to the object based on its type name.
		/// </summary>
		public IdObject()
		{
			Id = GenerateId(this);
		}
	}
}
