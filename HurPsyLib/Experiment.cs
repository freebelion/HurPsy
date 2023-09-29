using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static HurPsyLib.Experiment;
using static HurPsyLib.Session;

namespace HurPsyLib
{
    [DataContract]
    public class Experiment
    {
        [DataContract]
        public class TrialStep
        {
            [DataMember]
            public HurPsyTimePeriod? StepTime { get; set; } 
            [DataMember]
            private List<StimulusLocatorPair> StimulusLocators { get; set; }

            internal TrialStep()
            {
                StepTime = null;
                StimulusLocators = new List<StimulusLocatorPair>();
            }

            public void AddStimulusLocatorPair(string stimId, string locId)
            {
                StimulusLocators.Add(new StimulusLocatorPair(stimId,locId));
            }

            public int StimulusCount
            { get { return StimulusLocators.Count; } }

            public string GetStimulusId(int index)
            {
                if(index < 0 || index >= StimulusLocators.Count)
                { HurPsyException.Throw("Error_InvalidIndex"); }
                return StimulusLocators[index].StimulusId;
            }

            public string GetLocatorId(int index)
            {
                if (index < 0 || index >= StimulusLocators.Count)
                { HurPsyException.Throw("Error_InvalidIndex"); }
                return StimulusLocators[index].LocatorId;
            }
        }

        [DataContract]
        public class Trial
        {
            [DataMember]
            private List<TrialStep> Steps { get; set; }

            private int stepNo = 0;

            internal Trial()
            {
                Steps = new List<TrialStep>();
            }

            public TrialStep CreateNewStep()
            {
                TrialStep newStep = new TrialStep();
                Steps.Add(newStep);
                return newStep;
            }

            internal TrialStep CurrentStep
            {
                get { return Steps[stepNo]; }
            }


            internal bool NextStep()
            {
                if (stepNo < Steps.Count - 1)
                {
                    stepNo++;
                    return true;
                }
                else
                { return false; }
            }
        }

        [DataContract]
        public class Block
        {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            private List<Trial> Trials { get; set; }

            private int trialNo = 0;
            
            internal Block()
            {
                Name = string.Empty;
                Trials = new List<Trial>();
            }

            public Trial CreateNewTrial()
            {
                Trial newTrial = new Trial();
                Trials.Add(newTrial);
                return newTrial;
            }

            internal Trial CurrentTrial
            {
                get { return Trials[trialNo]; } 
            }

            internal bool NextTrial()
            {
                if (trialNo < Trials.Count - 1)
                {
                    trialNo++;
                    return true;
                }
                else
                { return false; }
            }
        }

        [DataMember]
        public string Name { get; set; }
        [DataMember]
        private List<Block> Blocks { get; set; }
        [DataMember]
        private Dictionary<string, Stimulus> StimulusDict { get; set; }
        [DataMember]
        private Dictionary<string, Locator> LocatorDict { get; set; }

        private int blockNo = 0;
        
        public Experiment()
        {
            Name = string.Empty;
            Blocks = new List<Block>();
            StimulusDict = new Dictionary<string, Stimulus>();
            LocatorDict = new Dictionary<string, Locator>();   
        }

        public Block CurrentBlock
        { get { return Blocks[blockNo]; } } 

        public Trial CurrentTrial
        { get { return CurrentBlock.CurrentTrial; } }

        public TrialStep CurrentStep
        { get { return CurrentTrial.CurrentStep; } }

        public bool NextBlock()
        {
            if(blockNo < Blocks.Count - 1)
            {
                blockNo++;
                return true;
            }
            else
            { return false; }
        }

        public bool NextStep()
        {
            if(CurrentTrial.NextStep())
            { return true; }
            else if(CurrentBlock.NextTrial())
            { return true; }
            else if(NextBlock())
            { return true; }
            else
            { return false; }
        }

        public Block CreateNewBlock()
        {
            Block newBlock = new Block();
            Blocks.Add(newBlock);
            return newBlock;
        }

        public void AddStimulus(Stimulus stim)
        { StimulusDict.Add(stim.Id, stim); }

        public void AddLocator(Locator loc)
        { LocatorDict.Add(loc.Id, loc); }

        public Stimulus GetStimulus(string stimId)
        { return StimulusDict[stimId]; }

        public Locator GetLocator(string locId)
        { return LocatorDict[locId]; }

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
            if(tryexp == null)
            { HurPsyException.Throw("Error_ExperimentNotLoaded"); }
            else
            { exp = tryexp; }
            return exp;
        }
    }
}
