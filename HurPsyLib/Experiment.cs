﻿using HurPsyLibStrings;
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
    /// The class which represents the complete definition
    /// of a computerized psychology experiment.
    /// </summary>
    [DataContract]
    public class Experiment
    {
        /// <summary>
        /// The property which helps get/set the origin choice for the experiment.
        /// </summary>
        [DataMember]
        public HurPsyOrigin Origin { get; set; }

        [DataMember]
        private Dictionary<string, Stimulus> StimulusDict { get; set; }

        [DataMember]
        private Dictionary<string, Locator> LocatorDict { get; set; }

        /// <summary>
        /// The property which helps get/set the name of the file
        /// where the experiment definition will be saved.
        /// </summary>
        [DataMember]
        public string FileName { get; set; }

        /// <summary>
        /// The list of the Block objects which represent
        /// the trial blocks that make up the experiment.
        /// </summary>
        [DataMember]
        public List<Block> Blocks { get; private set; }
       
        /// <summary>
        /// The default class constructor which starts with
        /// an empty name and empty lists of objects.
        /// </summary>
        public Experiment()
        {
            FileName = string.Empty;
            StimulusDict = new Dictionary<string, Stimulus>();
            LocatorDict = new Dictionary<string, Locator>();
            Blocks = new List<Block>();
        }

        /// <summary>
        /// The method to add a Stimulus object
        /// that represents an experimental stimulus
        /// to the list of objects
        /// that represent the stimuli used in the experiment.
        /// </summary>
        /// <param name="stim"></param>
        /// <returns></returns>
        public bool AddStimulus(Stimulus stim)
        {
            // The underlying Dictionary collection will not accept
            // Stimulus objects with previously used Ids
            try
            {
                StimulusDict.Add(stim.Id, stim);
                return false;
            }
            catch { return false; }
        }

        public bool StimulusIdExists(string stimId)
        { return StimulusDict.ContainsKey(stimId); }

        public void ReplaceStimulusId(string oldId, string newId)
        {
            // We need to remove the dictionary pair with the old id
            // and create a new one with the new id.
            Stimulus stim = GetStimulus(oldId);
            StimulusDict.Remove(oldId);
            stim.Id = newId;
            StimulusDict.Add(newId, stim);
        }

        public Stimulus GetStimulus(string stimId)
        { return StimulusDict[stimId]; }

        public List<Stimulus> GetStimuli()
        { return StimulusDict.Values.ToList(); }

        public void RemoveStimulus(Stimulus stim)
        {
            StimulusDict.Remove(stim.Id);
        }

        public bool AddLocator(Locator loc)
        {
            // The underlying Dictionary collection will not accept
            // Locator objects with previously used Ids
            try
            {
                LocatorDict.Add(loc.Id, loc);
                return false;
            }
            catch { return false; }
        }

        public Locator GetLocator(string locId)
        { return LocatorDict[locId]; }

        public List<Locator> GetLocators()
        { return LocatorDict.Values.ToList(); }

        public void RemoveLocator(Locator loc)
        {
            LocatorDict.Remove(loc.Id);
        }

        public bool LocatorIdExists(string locId)
        { return LocatorDict.ContainsKey(locId); }

        public void ReplaceLocatorId(string oldId, string newId)
        {
            // We need to remove the dictionary pair with the old id
            // and create a new one with the new id.
            Locator loc = GetLocator(oldId);
            LocatorDict.Remove(oldId);
            loc.Id = newId;
            LocatorDict.Add(newId, loc);
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
