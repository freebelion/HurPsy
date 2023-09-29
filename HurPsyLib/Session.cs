using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    public class Session
    {
        public class TrialStep
        {
            private double? responseTime;
            public List<StimulusLocationPair> StimulusLocations { get; set; }

            internal TrialStep()
            {
                responseTime = null;
                StimulusLocations = new List<StimulusLocationPair>();
            }

            public double? ResponseTime
            {
                get { return responseTime; }
                set
                {
                    if (value!= null && value < 0)
                    { HurPsyException.Throw("Error_NegativeTimeValue"); }
                    else
                    { responseTime = value; }
                }
            }
        }

        public class Trial
        {
            public List<TrialStep> Steps { get; set; }

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
        }

        public class Block
        {
            public string Name { get; set; }
            public List<Trial> Trials { get; set; }

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
        }

        public DateTime SessionTime { get; set; }
        private List<Block> Blocks { get; set; }

        public Session()
        {
            SessionTime = DateTime.Now;
            Blocks = new List<Block>();
        }

        public Block CreateNewBlock()
        {
            Block newBlock = new Block();
            Blocks.Add(newBlock);
            return newBlock;
        }
    }
}
