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
        #region Data members and properties
        /// <summary>
        /// This `Dictionary` collection helps access `Stimulus` objects through their ids.
        /// </summary>
        [DataMember]
        private Dictionary<string, Stimulus> StimulusDict;
        #endregion

        #region Constructor(s)
        /// <summary>
        /// This default constructor starts with empty collections and assigns the default values to other properties.
        /// </summary>
        public Experiment()
		{
			StimulusDict = [];
		}
        #endregion

        #region Methods and Functions
        /// <summary>
        /// This function checks whether a certain stimulus Id already exists in the dictionary collection
        /// </summary>
        /// <param name="stimId"></param>
        /// <returns></returns>
        public bool StimulusIdExists(string stimId)
        {
            return StimulusDict.ContainsKey(stimId);
        }

        /// <summary>
        /// This function attempts to add the given `Stimulus` object to the dictionary collection and reports on the outcome.
        /// </summary>
        /// <param name="stim">The object to be added</param>
        /// <returns>The success of the operation</returns>
        public bool AddStimulus(Stimulus stim)
        {
            try
            {
                StimulusDict.Add(stim.Id, stim);
                return true;
            }
            catch
            { return false; }
        }
        #endregion
    }
}
