using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
	/// <summary>
	/// This class represents the complete definition of a computerized psychology experiment.
	/// </summary>
	[DataContract]
	public class Experiment
	{
		/// <summary>
		/// This `Dictionary` collection helps access `Stimulus` objects through their ids.
		/// </summary>
		private Dictionary<string, Stimulus> StimulusDict;

		/// <summary>
		/// This default constructor starts with empty collections and assigns the default values to other properties.
		/// </summary>
		public Experiment()
		{
			StimulusDict = [];
		}
	}
}
