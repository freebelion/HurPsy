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
    [KnownType(typeof(ExpSession))]
    [DataContract]
	public class Experiment
	{
        #region Data members and properties
        /// <summary>
        /// A name which will help a designer to remember this experiment.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Full path of the file where the experiment definition is stored
        /// </summary>
        [DataMember]
        public string FilePath { get; set; }

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
        /// This `Dictionary` collection helps access `Response` objects through their ids.
        /// </summary>
        [DataMember]
        private Dictionary<string, Response> ResponseDict;

        /// <summary>
        /// The experiment's trial blocks
        /// </summary>
        [DataMember]
        public List<ExpBlock> Blocks { get; set; }
        #endregion

        #region Constructor(s)
        /// <summary>
        /// This default constructor starts with empty collections and a temporary name and uses that name as a local file path.
        /// </summary>
        public Experiment()
		{
            // Create a temporary unique name
            Name = IdObject.CreateId(this.GetType());
            // Keep file path empty until the experiment definition is saved in a file
            FilePath = string.Empty;
            StimulusDict = [];
            LocatorDict = [];
            ResponseDict = [];
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
        public void AddStimulus(Stimulus stim)
        {
            while(StimulusIdExists(stim.Id))
            { stim.Id = IdObject.CreateId(stim.GetType()); }
            StimulusDict.Add(stim.Id, stim);
        }

        /// <summary>
        /// This inline function will return a list containing `Stimulus` definitions in the experiment
        /// </summary>
        /// <returns></returns>
        public List<Stimulus> GetStimulusItems() => StimulusDict.Values.ToList();

        /// <summary>
        /// This inline function will help access a `Stimulus` object through its Id
        /// </summary>
        /// <param name="stimId">The Id string</param>
        /// <returns>The `Stimulus` object with that Id</returns>
        public Stimulus GetStimulusItem(string stimId) => StimulusDict[stimId];

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
            // record the old Id
            string oldId = stim.Id;
            // Replace the Id-Stimulus pair in StimulusDict
            StimulusDict.Remove(stim.Id);
            stim.Id = newid;
            AddStimulus(stim);
            // Pass on the id change to the blocks
            foreach(var blck in Blocks)
            { blck.ChangeStimulusId(oldId, newid); }
            return true;
        }

        /// <summary>
        /// This function attempts to add the given `Locator` object to the dictionary collection and reports on the outcome.
        /// </summary>
        /// <param name="loc">The object to be added</param>
        /// <returns>The success of the operation</returns>
        public void AddLocator(Locator loc)
        {
            while (LocatorIdExists(loc.Id))
            { loc.Id = IdObject.CreateId(loc.GetType()); }
            LocatorDict.Add(loc.Id, loc);
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
        /// This inline function will help access a `Locator` object through its Id
        /// </summary>
        /// <param name="locId">The Id string</param>
        /// <returns>The `Locator` object with that Id</returns>
        public Locator GetLocatorItem(string locId) => LocatorDict[locId];

        /// <summary>
        /// This function updates the Id of a `Locator` item, provided that the Id is not a duplicate.
        /// </summary>
        /// <param name="loc">The object whose Id will be changed</param>
        /// <param name="newid">The new Id</param>
        /// <returns></returns>
        public bool LocatorIdChanged(Locator loc, string newid)
        {
            if (LocatorIdExists(newid)) return false;
            // record the old Id
            string oldId = loc.Id;
            // Replace the Id-Locator pair in LocatorDict
            LocatorDict.Remove(loc.Id);
            loc.Id = newid;
            AddLocator(loc);
            // Pass on the id change to the blocks
            foreach (var blck in Blocks)
            { blck.ChangeLocatorId(oldId, newid); }
            return true;
        }

        public void AddResponse(Response rep)
        {
            while (ResponseIdExists(rep.Id))
            { rep.Id = IdObject.CreateId(rep.GetType()); }
            ResponseDict.Add(rep.Id, rep);
        }

        /// <summary>
        /// The inline function to check for duplicate `Response` Ids
        /// </summary>
        /// <param name="newid">Id to check</param>
        /// <returns></returns>
        private bool ResponseIdExists(string newid) => ResponseDict.ContainsKey(newid);

        /// <summary>
        /// This inline function will return a list containing `Locator` definitions in the experiment
        /// </summary>
        /// <returns></returns>
        public List<Response> GetResponseItems() => ResponseDict.Values.ToList();

        /// <summary>
        /// This method will help clone the experiment items onto `Session` objects.
        /// </summary>
        /// <returns></returns>
        public Experiment ShallowCopy()
        {
            return (Experiment)MemberwiseClone();
        }

        #endregion
    }
}
