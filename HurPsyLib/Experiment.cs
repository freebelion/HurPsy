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
        public List<Stimulus> StimulusList { get; private set; }

        [DataMember]
        public List<Locator> LocatorList { get; private set; }

        [DataMember]
        public List<Block> Blocks { get; private set; }

        public Experiment()
        {
            StimulusList = new List<Stimulus>();
            LocatorList = new List<Locator>();
            Blocks = new List<Block>();
        }

        public bool AddStimulus(Stimulus stim)
        {
            // Do not accept Stimulus objects with previously used Ids
            bool idExists = StimulusList.Any(s => s.Id == stim.Id);
            if(!idExists) { StimulusList.Add(stim); }
            return !idExists;
        }

        public bool AddLocator(Locator loc)
        {
            // Do not accept Locator objects with previously used Ids
            bool idExists = LocatorList.Any(s => s.Id == loc.Id);
            if (!idExists) { LocatorList.Add(loc); }
            return !idExists;
        }

        public void AddNewBlock()
        {
            Block newblock = new Block();
            Blocks.Add(newblock);
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
