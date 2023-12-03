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

        public Experiment()
        {
            StimulusDict = new Dictionary<string, Stimulus>();
            LocatorDict = new Dictionary<string, Locator>();
        }

        public bool AddStimulus(string stimId, Stimulus stim)
        {
            try { StimulusDict.Add(stimId, stim); return true; }
            catch { return false; }
        }

        public bool AddLocator(string locId, Locator loc)
        {
            try { LocatorDict.Add(locId, loc); return true; }
            catch { return false; }
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
