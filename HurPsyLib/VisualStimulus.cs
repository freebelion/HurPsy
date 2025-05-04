using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
	/// <summary>
	/// This abstract class will be the basis for all classes which will represent visual stimuli.
	/// </summary>
	[KnownType(typeof(ImageStimulus))]
    [DataContract]
    public abstract class VisualStimulus : Stimulus
	{
		/// <summary>
		/// Any object representing a visual stimulus must have a property to get/set the stimulus size
		/// (which has a unit of millimeters, by default)
		/// </summary>
		[DataMember]
		public HurPsySize VisualSize { get; set; }

		/// <summary>
		/// This default constructor starts with an empty (zero) size
		/// </summary>
		public VisualStimulus()
		{
			VisualSize = new HurPsySize();
		}
	}
}