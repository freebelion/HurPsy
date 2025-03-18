using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
	/// <summary>
	/// This abstract class serves as the blueprint for all classes which will represent different types of experimental stimuli.
	/// </summary>
	[DataContract]
	public abstract class Stimulus : IdObject
	{
		/// <summary>
		/// `FileName` will contain the full path of the file containing the actual Stimulus object
		/// </summary>
		[DataMember]
		public string FileName { get; set; }

		/// <summary>
		/// This default constructor, after getting the object Id initialized by the base class, starts with an empty string for the filename.
		/// </summary>
		public Stimulus()
		{
			FileName = string.Empty;
		}
	}
}
