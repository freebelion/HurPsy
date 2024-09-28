using HurPsyLibStrings;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HurPsyLib
{
    /// <summary>
    /// The class which represents the complete definition of a computerized psychology experiment.
    /// </summary>
    [DataContract]
    public class Experiment
    {
        /// <summary>
        /// The Dictionary collection which helps access `Stimulus` objects through their ids.
        /// </summary>
        [DataMember]
        private Dictionary<string, Stimulus> stimulusDict;

        /// <summary>
        /// The Dictionary collection which helps access `Locator` objects through their ids.
        /// </summary>
        [DataMember]
        private Dictionary<string, Locator> locatorDict;

        /// <summary>
        /// The property which helps get/set the origin choice for the experiment.
        /// </summary>
        [DataMember]
        public HurPsyOrigin Origin { get; set; }
       
        /// <summary>
        /// The property which helps get/set the name of the file where the experiment definition will be saved.
        /// </summary>
        [DataMember]
        public string FileName { get; set; }

        /// <summary>
        /// The list of `Block` objects which represent the trial blocks that make up the experiment.
        /// </summary>
        [DataMember]
        public List<Block> Blocks { get; private set; }
       
        /// <summary>
        /// This default constructor which starts with an empty filename and empty lists.
        /// </summary>
        public Experiment()
        {
            FileName = string.Empty;
            stimulusDict = new Dictionary<string, Stimulus>();
            locatorDict = new Dictionary<string, Locator>();
            Blocks = new List<Block>();
        }

        /// <summary>
        /// The function which adds a `Stimulus` object to `stimulusDict` collection and returns on the result
        /// </summary>
        /// <param name="stim">The `Stimulus` object which will be added</param>
        /// <returns>A boolean flag indicating if the operation was successful</returns>
        public bool AddStimulus(Stimulus stim)
        {
            // The underlying Dictionary collection will not accept
            // Stimulus objects with previously used Ids
            try
            {
                stimulusDict.Add(stim.Id, stim);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// The boolean function which checks if a `Stimulus` id exists in `stimulusDict` collection. 
        /// </summary>
        /// <param name="stimId">The `Stimulus` id which will be checked</param>
        /// <returns>A boolean flag indicating the presence of the given id</returns>
        public bool StimulusIdExists(string stimId)
        { return stimulusDict.ContainsKey(stimId); }

        /// <summary>
        /// The method which updates the id of a `Stimulus` object in `stimulusDict` collection.
        /// This method must be called when an end-user gives a `Stimulus` object a new id through an experiment design program.
        /// Otherwise, `stimulusDict` collection will be out of date.
        /// </summary>
        /// <param name="oldId">Previous id of the `Stimulus` object</param>
        /// <param name="newId">New id of the `Stimulus` object</param>
        public void ReplaceStimulusId(string oldId, string newId)
        {
            // We need to remove the dictionary pair with the old id
            // and create a new one with the new id.
            Stimulus stim = GetStimulus(oldId);
            stimulusDict.Remove(oldId);
            stim.Id = newId;
            stimulusDict.Add(newId, stim);

            // and make sure the id is updated in all the trial steps
            foreach (Block blck in Blocks)
            { blck.ChangeStimulusId(oldId, newId); }
        }

        /// <summary>
        /// The function which returns the `Stimulus` object with the given id
        /// </summary>
        /// <param name="stimId">The id of the `Stimulus` object which will be accessed</param>
        /// <returns>The `Stimulus` object with the given id</returns>
        /// <exception cref="HurPsyException">An exception will be thrown if a `Stimulus` object with the given id cannot be found.</exception>
        public Stimulus GetStimulus(string stimId)
        {
            if (StimulusIdExists(stimId))
            { return stimulusDict[stimId]; }
            else
            { throw new HurPsyException(HurPsyLibStrings.StringResources.Error_InvalidStimulusId + stimId); }
        }

        /// <summary>
        /// The function which returns a new generic list of `Stimulus` objects.
        /// </summary>
        /// <returns>A generic list of all the `Stimulus` objects in the experiment definition</returns>
        public List<Stimulus> GetStimuli()
        { return stimulusDict.Values.ToList(); }

        /// <summary>
        /// The method which removes the `Stimulus` object with the given id from `stimulusDict` collection.
        /// </summary>
        /// <param name="stim">The `Stimulus` object which will be removed</param>
        public void RemoveStimulus(Stimulus stim)
        {
            stimulusDict.Remove(stim.Id);
            // WARNING! This method is so far incomplete;
            // One should also delete the trials referring to the removed Stimulus object
        }

        /// <summary>
        /// The function which adds a `Locator` object to `locatorDict` collection and reports on the result
        /// </summary>
        /// <param name="loc">The `Locator` object which will be added to the collection.</param>
        /// <returns>A boolean flag indicating if the operation was successful</returns>
        public bool AddLocator(Locator loc)
        {
            // The underlying Dictionary collection will not accept
            // Locator objects with previously used Ids
            try
            {
                locatorDict.Add(loc.Id, loc);
                return true;
            }
            catch { return false; }
        }

        /// <summary>
        /// The function which returns the `Locator` object with the given id
        /// </summary>
        /// <param name="locId">The id of the `Locator` object which will be accessed</param>
        /// <returns>The `Locator` object with the given id</returns>
        /// <exception cref="HurPsyException">An exception will be thrown if a `Locator` object with the given id cannot be found.</exception>
        public Locator GetLocator(string locId)
        {
            if (LocatorIdExists(locId))
            { return locatorDict[locId]; }
            else
            { throw new HurPsyException(HurPsyLibStrings.StringResources.Error_InvalidLocatorId + locId); }
        }

        /// <summary>
        /// The function which returns a new generic list of `Locator` objects.
        /// </summary>
        /// <returns>A generic list of all the `Locator` objects in the experiment definition</returns>
        public List<Locator> GetLocators()
        { return locatorDict.Values.ToList(); }

        /// <summary>
        /// The method which removes the `Locator` object with the given id from `locatorDict` collection.
        /// </summary>
        /// <param name="loc">The `Locator` object which will be removed</param>
        public void RemoveLocator(Locator loc)
        {
            locatorDict.Remove(loc.Id);
            // WARNING! This method is so far incomplete;
            // One should also delete the trials referring to the removed Locator object.
        }

        /// <summary>
        /// The boolean function which checks whether a `Locator` id exists in `locatorDict` collection.
        /// </summary>
        /// <param name="locId"></param>
        /// <returns>A boolean flag indicating the presence of the given id</returns>
        public bool LocatorIdExists(string locId)
        { return locatorDict.ContainsKey(locId); }

        /// <summary>
        /// The method which updates the id of a `Locator` object in `locatorDict` collection.
        /// This method must be called when an end-user gives a `Locator` object a new id through an experimental design program.
        /// Otherwise, `locatorDict` collection will be out of date.
        /// </summary>
        /// <param name="oldId">Previous id of the `Locator` object</param>
        /// <param name="newId">New id of the `Locator` object</param>
        public void ReplaceLocatorId(string oldId, string newId)
        {
            // We need to remove the dictionary pair with the old id
            // and create a new one with the new id.
            Locator loc = GetLocator(oldId);
            locatorDict.Remove(oldId);
            loc.Id = newId;
            locatorDict.Add(newId, loc);

            // and make sure the id is updated in all the trial steps
            foreach(Block blck in Blocks)
            { blck.ChangeLocatorId(oldId, newId); }
        }

        /// <summary>
        /// The function which adds a newly created trial block to `Blocks` collection and returns a reference to it
        /// </summary>
        /// <returns>A reference to the newly added `Block` object</returns>
        public Block AddNewBlock()
        {
            Block newblock = new Block();
            Blocks.Add(newblock);
            return newblock;
        }

        /// <summary>
        /// The method which removes a `Block` objects from `Blocks` collection.
        /// </summary>
        /// <param name="blck">The `Block` object which will be removed</param>
        public void RemoveBlock(Block blck)
        {
            Blocks.Remove(blck);
        }

        /// <summary>
        /// The method which saves the experiment definition to an XML file using a `DataContractSerializer`
        /// </summary>
        /// <param name="fileName">The name of the XML file</param>
        public void SaveToXml(string fileName)
        {
            DataContractSerializer expser = new DataContractSerializer(this.GetType());
            XmlWriterSettings settings = new XmlWriterSettings { Indent = true };
            FileStream fs = File.Open(fileName, FileMode.Create);
            using (var writer = XmlWriter.Create(fs, settings))
            { expser.WriteObject(writer, this); }
            fs.Close();
        }

        /// <summary>
        /// The function which loads an experiment definition from an XML file by using a `DataContractSerializer`
        /// </summary>
        /// <param name="fileName">The name of the XML file</param>
        /// <returns>The `Experiment` object which contains the experiment definition loaded from the file</returns>
        /// <exception cref="HurPsyException">An exception will be thrown if a valid definition of an experiment could not be loaded from the file.</exception>
        public static Experiment LoadFromXml(string fileName)
        {
            Experiment exp = new Experiment();
            using (XmlDictionaryReader reader =
                   XmlDictionaryReader.CreateTextReader(new FileStream(fileName, FileMode.Open), new XmlDictionaryReaderQuotas()))
            {
                DataContractSerializer expser =
                    new DataContractSerializer(typeof(Experiment));
                Experiment? tryexp = (Experiment?)expser.ReadObject(reader);
                if (tryexp == null)
                {
                    throw new HurPsyException(HurPsyLibStrings.StringResources.Error_ExperimentNotLoaded);
                }
                else
                { exp = tryexp; }
            }
                
            return exp;
        }
    }
}
