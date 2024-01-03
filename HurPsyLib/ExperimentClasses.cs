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
        }

        public StimulusLocatorPair AddStimulusLocatorPair(StimulusLocatorPair? newpair = null)
        {
            if (newpair == null)
            { newpair = new StimulusLocatorPair(); }
            StimulusLocators.Add(newpair);
            return newpair;
        }

        public void AddStimulusLocatorPairs(StimulusLocatorPair[] newpairs)
        {
            for(int i=0; i<newpairs.Length; i++)
            {
                StimulusLocators.Add(newpairs[i]);
            }
        }

        public void ChangeStimulusId(string oldId, string newId)
        {
            foreach (StimulusLocatorPair pair in StimulusLocators)
            {
                if (pair.StimulusId == oldId)
                { pair.StimulusId = newId; }
            }
        }

        public void ChangeLocatorId(string oldId, string newId)
        {
            foreach (StimulusLocatorPair pair in StimulusLocators)
            {
                if (pair.LocatorId == oldId)
                { pair.LocatorId = newId; }
            }
        }
    }

    [DataContract]
    public class  Trial
    {
        [DataMember]
        public List<Step> Steps { get; set; }

        [DataMember]
        public bool CanShuffle { get; set; }

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

        public void ChangeStimulusId(string oldId, string newId)
        {
            foreach (Step stp in Steps)
            {
                stp.ChangeStimulusId(oldId, newId);
            }
        }

        public void ChangeLocatorId(string oldId, string newId)
        {
            foreach (Step stp in Steps)
            {
                stp.ChangeLocatorId(oldId, newId);
            }
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
            Name = HurPsyCommon.GetObjectGuid(this);
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