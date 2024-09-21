using HurPsyLibStrings;
using System;
using System.Collections.Generic;
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
        /// The Dictionary collection which helps access Stimulus objects through their ids.
        /// </summary>
        [DataMember]
        private Dictionary<string, Stimulus> stimulusDict;

        /// <summary>
        /// The Dictionary collection which helps access Locator objects through their ids.
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
        /// The list of Block objects which represent the trial blocks that make up the experiment.
        /// </summary>
        [DataMember]
        public List<Block> Blocks { get; private set; }
       
        /// <summary>
        /// The default class constructor which starts with an empty filename and empty lists.
        /// </summary>
        public Experiment()
        {
            FileName = string.Empty;
            stimulusDict = new Dictionary<string, Stimulus>();
            locatorDict = new Dictionary<string, Locator>();
            Blocks = new List<Block>();
        }

        /// <summary>
        /// The method which adds a Stimulus object to the Dictionary collection associating Stimulus objects with their ids.
        /// </summary>
        /// <param name="stim">Stimulus object which will be added to the Dictionary collection.</param>
        /// <returns>A boolean flag indicating whether the operation was successful</returns>
        public bool AddStimulus(Stimulus stim)
        {
            // The underlying Dictionary collection will not accept
            // Stimulus objects with previously used Ids
            try
            {
                stimulusDict.Add(stim.Id, stim);
                return false;
            }
            catch { return false; }
        }

        /// <summary>
        /// The boolean function to check whether a Stimulus with the given id already exists in the Dictionary collection. 
        /// </summary>
        /// <param name="stimId">The Stimulus id which will be checked</param>
        /// <returns>A boolean flag indicating the presence of the given id</returns>
        public bool StimulusIdExists(string stimId)
        { return stimulusDict.ContainsKey(stimId); }

        /// <summary>
        /// The method which updates the id of a Stimulus object in the Dictionary collection.
        /// This method must be called when an end-user gives a Stimulus object a new id through an experimental design program.
        /// Otherwise, the Dictionary collection associating Stimulus objects with their ids will be out of date.
        /// </summary>
        /// <param name="oldId">Previous id of the Stimulus object</param>
        /// <param name="newId">New if od the Stimulus object</param>
        public void ReplaceStimulusId(string oldId, string newId)
        {
            // We need to remove the dictionary pair with the old id
            // and create a new one with the new id.
            Stimulus stim = GetStimulus(oldId);
            stimulusDict.Remove(oldId);
            stim.Id = newId;
            stimulusDict.Add(newId, stim);
        }

        /// <summary>
        /// The method which helps access a Stimulus object through its id.
        /// </summary>
        /// <param name="stimId">The id of the Stimulus object which will be accessed.</param>
        /// <returns></returns>
        public Stimulus GetStimulus(string stimId)
        { return stimulusDict[stimId]; }

        /// <summary>
        /// The method which constructs a new generic list of Stimulus objects.
        /// </summary>
        /// <returns>The generic list of Stimulus objects</returns>
        public List<Stimulus> GetStimuli()
        { return stimulusDict.Values.ToList(); }

        /// <summary>
        /// The method which removes the Stimulus object with the given id from the Dictionary collection.
        /// </summary>
        /// <param name="stim">The Stimulus object to be removed</param>
        public void RemoveStimulus(Stimulus stim)
        {
            stimulusDict.Remove(stim.Id);
            // WARNING! This method is so far incomplete;
            // One should also delete the trials referring the removed Stimulus object.
        }

        /// <summary>
        /// The method which adds a Locator object to the Dictionary collection associating Locator objects with their ids.
        /// </summary>
        /// <param name="loc">Locator object which will be added to the Dictionary collection.</param>
        /// <returns>A boolean flag indicating whether the operation was successful</returns>
        public bool AddLocator(Locator loc)
        {
            // The underlying Dictionary collection will not accept
            // Locator objects with previously used Ids
            try
            {
                locatorDict.Add(loc.Id, loc);
                return false;
            }
            catch { return false; }
        }

        public Locator GetLocator(string locId)
        { return locatorDict[locId]; }

        public List<Locator> GetLocators()
        { return locatorDict.Values.ToList(); }

        public void RemoveLocator(Locator loc)
        {
            locatorDict.Remove(loc.Id);
        }

        public bool LocatorIdExists(string locId)
        { return locatorDict.ContainsKey(locId); }

        public void ReplaceLocatorId(string oldId, string newId)
        {
            // We need to remove the dictionary pair with the old id
            // and create a new one with the new id.
            Locator loc = GetLocator(oldId);
            locatorDict.Remove(oldId);
            loc.Id = newId;
            locatorDict.Add(newId, loc);
        }

        public Block AddNewBlock()
        {
            Block newblock = new Block();
            Blocks.Add(newblock);
            return newblock;
        }

        public void RemoveBlock(Block blck)
        {
            Blocks.Remove(blck);
        }

        public void SaveToXml(string fileName)
        {
            DataContractSerializer expser = new DataContractSerializer(this.GetType());
            XmlWriterSettings settings = new XmlWriterSettings { Indent = true };
            FileStream fs = File.Open(fileName, FileMode.Create);
            using (var writer = XmlWriter.Create(fs, settings))
            { expser.WriteObject(writer, this); }
            fs.Close();
        }

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
                    throw new HurPsyException(StringFinder.GetString("Error_ExperimentNotLoaded"));
                }
                else
                { exp = tryexp; }
            }
                
            return exp;
        }
    }
}
