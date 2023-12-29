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
    public class StimulusLocatorPair
    {
        [DataMember]
        public string StimulusId { get; set; }

        [DataMember]
        public string LocatorId { get; set; }

        public StimulusLocatorPair()
        {
            StimulusId = string.Empty;
            LocatorId = string.Empty;
        }

        public StimulusLocatorPair(string stimId, string locId)
        {
            StimulusId = stimId;
            LocatorId = locId;
        }
    }

    [DataContract]
    public class Step
    {
        [DataMember]
        public List<StimulusLocatorPair> StimulusLocators { get; set; }

        [DataMember]
        public HurPsyTimePeriod StepTime { get; set; }

        public  Step()
        {
            StimulusLocators = new List<StimulusLocatorPair>();
            StepTime = new HurPsyTimePeriod();

            for (int i = 0; i < 3; i++)
            { AddStimulusLocatorPair(); }
            StepTime.Milliseconds = 1000 * HurPsyCommon.Rnd.NextDouble();
        }

        public StimulusLocatorPair AddStimulusLocatorPair(StimulusLocatorPair? newpair = null)
        {
            if (newpair == null)
            { newpair = new StimulusLocatorPair(); }
            StimulusLocators.Add(newpair);
            return newpair;
        }
    }

    [DataContract]
    public class  Trial
    {
        [DataMember]
        public List<Step> Steps { get; set; }

        public Trial()
        {
            Steps = new List<Step>();
        }

        public Step AddStep(Step? newstep = null)
        {
            if (newstep == null) { newstep = new Step(); }
            Steps.Add(newstep);
            return newstep;
        }
    }

    [DataContract]
    public class Block
    {
        private static int blockCount = 0;
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public List<Trial> Trials { get; set; }
        [DataMember]
        public bool ShuffleTrials { get; set; }

        public Block()
        {
            blockCount++;
            Name = "Block_" + blockCount.ToString();
            Trials = new List<Trial>();
            ShuffleTrials = true;
        }

        public Trial AddTrial(Trial? newtrial = null)
        {
            if (newtrial == null) { newtrial = new Trial(); }
            Trials.Add(newtrial);
            return newtrial;
        }
    }
}