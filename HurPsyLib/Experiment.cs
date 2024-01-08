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
    [DataContract]
    public class Experiment
    {
        [DataMember]
        public Dictionary<string, Stimulus> StimulusDict { get; private set; }

        [DataMember]
        public Dictionary<string, Locator> LocatorDict { get; private set; }

        [DataMember]
        public List<Block> Blocks { get; private set; }
       
        public Experiment()
        {
            StimulusDict = new Dictionary<string, Stimulus>();
            LocatorDict = new Dictionary<string, Locator>();
            Blocks = new List<Block>();
        }

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

        public Stimulus GetStimulus(string stimId)
        { return StimulusDict[stimId]; }

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

        public void RemoveLocator(Locator loc)
        {
            LocatorDict.Remove(loc.Id);
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
            DataContractSerializer expser =
                    new DataContractSerializer(typeof(Experiment));
            FileStream fs = new FileStream(fileName, FileMode.Open);
            XmlDictionaryReader reader =
                    XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

            Experiment? tryexp = (Experiment?)expser.ReadObject(reader);
            if (tryexp == null)
            {
                throw new HurPsyException(StringFinder.GetString("Error_ExperimentNotLoaded"));
            }
            else
            { exp = tryexp; }
            return exp;
        }
    }
}
