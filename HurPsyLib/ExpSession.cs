using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This class represents an experiment session with simple UserId and RunTime info, along with the actual order of blocks, trials and steps.
    /// </summary>
    [DataContract]
    public class ExpSession : Experiment
    {
        #region Data members and properties
        // Simple session info
        [DataMember]
        private Guid userId;
        [DataMember]
        private DateTime sessionStart;
        [DataMember]
        private DateTime sessionEnd;
        
        // Index values for current experiment objects
        private int currentBlockIndex;
        private int currentTrialIndex;
        private int currentStepIndex;

        // References to current experiment objects
        private ExpBlock CurrentBlock
        {
            get { return Blocks[currentBlockIndex]; }
        }

        private ExpTrial CurrentTrial
        {
            get { return CurrentBlock.Trials[currentTrialIndex]; }
        }

        /// <summary>
        /// This `Session` object will keep track of the current step for the `RunViewModel`.
        /// </summary>
        public ExpStep CurrentStep
        {
            get
            { return CurrentTrial.Steps[currentStepIndex]; }
        }
        #endregion

        #region Constructor(s)
        /// <summary>
        /// This parametrized constructor starts with an empty or an existing experiment.
        /// </summary>
        /// <param name="exp"></param>
        public ExpSession(Experiment? exp)
        {
            if(exp != null )
            { InitializeSession(exp); }
        }
        #endregion

        #region Methods
        /// <summary>
        /// This method handles the initial setup: it clones the collections of the source experiment and reorders them as needed.
        /// This may consist of shuffling the unfixed trials; further reordering must be done by the user on the application that runs the session.
        /// </summary>
        private void InitializeSession(Experiment exp)
        {
            // Create a name and file path for the session, using the Experiment properties
            Name = exp.Name + "_Session" + userId.ToString();
            // Copy the dictionary collections from the original experiment definition
            StimulusDict = exp.StimulusDict;
            LocatorDict = exp.LocatorDict;

            foreach (ExpBlock blck in exp.Blocks)
            {
                // Create a temporary clone of the original block's trial list.
                List<ExpTrial> tempTrials = blck.Trials.ToList();
                // Shuffle those temp trials if needed.
                if(blck.MustShuffleTrials)
                { ShuffleTrials(tempTrials); }
                // Session block will be the same as the original block
                ExpBlock sesblck = blck;
                // but will use the shuffled clone list of trials.
                sesblck.Trials = tempTrials;
                // That way, the original block's list of trials will remain in the original order.
                Blocks.Add(sesblck);
            }
        }

        /// <summary>
        /// This method shuffles a collection of `Trials` to be used in experiment runs.
        /// </summary>
        private static void ShuffleTrials(List<ExpTrial> tempTrials)
        {
            Random rnd = new Random(Guid.NewGuid().GetHashCode());
            int repeatShuffle = 5;
            for (int n = 0; n < repeatShuffle; n++)
            {
                for (int i = 0; i < tempTrials.Count; i++)
                {
                    if (tempTrials[i].IsFixed) continue;

                    int j = rnd.Next(tempTrials.Count);
                    if (tempTrials[j].IsFixed) continue;

                    ExpTrial tmptr = tempTrials[i];
                    tempTrials[i] = tempTrials[j];
                    tempTrials[j] = tmptr;
                }
            }
        }
        #endregion

        /// <summary>
        /// Initial arragements for starting an experiment run
        /// </summary>
        public void StartSession()
        {
            sessionStart = DateTime.Now;

            currentBlockIndex = 0;
            currentTrialIndex = 0;
            currentStepIndex = 0;
        }

        /// <summary>
        /// This function progresses through the experiment session.
        /// </summary>
        /// <returns></returns>
        public bool NextStep()
        {
            if(currentStepIndex < CurrentTrial.Steps.Count -1)
            {
                currentStepIndex++;
                return true;
            }
            else if (currentTrialIndex < CurrentBlock.Trials.Count - 1)
            {
                currentTrialIndex++;
                currentStepIndex = 0;
                return true;
            }
            else if (currentBlockIndex < Blocks.Count - 1)
            {
                currentBlockIndex++;
                currentTrialIndex = 0;
                currentStepIndex = 0;
                return true;
            }
            else
            { return false; }
        }
    }
}
