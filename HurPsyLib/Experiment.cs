using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
        /// Full path of the file where the experiment definition is stored
        /// </summary>
        [DataMember]
        public string FileName { get; set; } = string.Empty;

        /// <summary>
        /// This `Dictionary` collection helps access `Stimulus` objects through their ids.
        /// </summary>
        [DataMember]
        private Dictionary<string, Stimulus> StimulusDict;

        /// <summary>
        /// This `Dictionary` collection helps access `Locator` objects through their ids.
        /// </summary>
        [DataMember]
        private Dictionary<string, Locator> LocatorDict;

        /// <summary>
        /// The experiment's trial blocks
        /// </summary>
        public List<ExpBlock> Blocks { get; set; }
        #endregion

        #region Constructor(s)
        /// <summary>
        /// This default constructor starts with empty collections and assigns the default values to other properties.
        /// </summary>
        public Experiment()
		{
			StimulusDict = [];
            LocatorDict = [];
            Blocks = [];
		}
        #endregion

        #region Methods and Functions
        /// <summary>
        /// Add a new block
        /// </summary>
        /// <param name="blck">The block to be added</param>
        public void AddBlock(ExpBlock blck) => Blocks.Add(blck);

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

        /// <summary>
        /// This inline function will return a list containing `Stimulus` definitions in the experiment
        /// </summary>
        /// <returns></returns>
        public List<Stimulus> GetStimulusItems() => StimulusDict.Values.ToList();

        /// <summary>
        /// The inline function to check for duplicate stimulus Ids
        /// </summary>
        /// <param name="newid">Id to check</param>
        /// <returns></returns>
        private bool StimulusIdExists(string newid) => StimulusDict.ContainsKey(newid);

        /// <summary>
        /// This function updates the Id of a `Stimulus` item, provided that the Id is not a duplicate.
        /// </summary>
        /// <param name="stim">The object whose Id will be changed</param>
        /// <param name="newid">The new id</param>
        /// <returns></returns>
        public bool StimulusIdChanged(Stimulus stim, string newid)
        {
            if(StimulusIdExists(newid)) return false;
            // First, remove the key-value pair with the old id
            StimulusDict.Remove(stim.Id);
            stim.Id = newid;
            return AddStimulus(stim);
        }

        /// <summary>
        /// This function attempts to add the given `Locator` object to the dictionary collection and reports on the outcome.
        /// </summary>
        /// <param name="loc">The object to be added</param>
        /// <returns>The success of the operation</returns>
        public bool AddLocator(Locator loc)
        {
            try
            {
                LocatorDict.Add(loc.Id, loc);
                return true;
            }
            catch
            { return false; }
        }

        /// <summary>
        /// The inline function to check for duplicate locator Ids
        /// </summary>
        /// <param name="newid">Id to check</param>
        /// <returns></returns>
        public bool LocatorIdExists(string newid) => LocatorDict.ContainsKey(newid);

        /// <summary>
        /// This inline function will return a list containing `Locator` definitions in the experiment
        /// </summary>
        /// <returns></returns>
        public List<Locator> GetLocatorItems() => LocatorDict.Values.ToList();

        /// <summary>
        /// This function updates the Id of a `Locator` item, provided that the Id is not a duplicate.
        /// </summary>
        /// <param name="loc">The object whose Id will be changed</param>
        /// <param name="newid">The new Id</param>
        /// <returns></returns>
        public bool LocatorIdChanged(Locator loc, string newid)
        {
            if (LocatorIdExists(newid)) return false;
            // First, remove the key-value pair with the old id
            LocatorDict.Remove(loc.Id);
            loc.Id = newid;
            return AddLocator(loc);
        }
        #endregion
    }
}
