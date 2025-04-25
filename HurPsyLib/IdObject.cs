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
	[KnownType(typeof(ExpTrial))]
    [KnownType(typeof(ExpBlock))]
    [KnownType(typeof(Locator))]
    [KnownType(typeof(Stimulus))]
	[DataContract]
	public abstract class IdObject
	{
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
            Id = CreateId(GetType());
        }

		/// <summary>
		/// This statis function is an attempt to create -hopefully unique- temporary Id strings for newly created objects.
		/// </summary>
		/// <param name="objty"></param>
		/// <returns></returns>
		public static string CreateId(Type objty)
		{
            return objty.Name + "_" + Guid.NewGuid().ToString().Substring(0, 8);
        }
	}
}
