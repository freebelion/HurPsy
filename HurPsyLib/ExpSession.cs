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
    public class ExpSession
    {
        #region Data members and properties
        // Simple session info
        [DataMember]
        private Guid userId;
        [DataMember]
        private DateTime sessionStart;
        [DataMember]
        private DateTime sessionEnd;
        [DataMember]
        private Experiment sourceExperiment;
        
        // Index values for current experiment objects
        private int currentBlockIndex;
        private int currentTrialIndex;
        private int currentStepIndex;

        // References to current experiment objects
        private ExpBlock CurrentBlock
        {
            get { return sourceExperiment.Blocks[currentBlockIndex]; }
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
            {
                sourceExperiment = exp;
                InitializeSession();
            }
        }
        #endregion

        #region Methods
        /// <summary>
        /// This method handles the initial setup: it clones the collections of the source experiment and reorders them as needed.
        /// This may consist of shuffling the unfixed trials; further reordering must be done by the user on the application that runs the session.
        /// </summary>
        private void InitializeSession()
        {
            foreach (ExpBlock blck in sourceExperiment.Blocks)
            {
                // Shuffle the block trials if needed.
                if(blck.MustShuffleTrials)
                { ShuffleTrials(blck.Trials); }
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
            else if (currentBlockIndex < sourceExperiment.Blocks.Count - 1)
            {
                currentBlockIndex++;
                currentTrialIndex = 0;
                currentStepIndex = 0;
                return true;
            }
            else
            { return false; }
        }

        /// <summary>
        /// A shorthand access to the source experiment's file path
        /// </summary>
        public string ExperimentFilePath { get => sourceExperiment.FilePath; }

        /// <summary>
        /// This inline function will return a list containing `Stimulus` definitions in the experiment
        /// </summary>
        /// <returns></returns>
        public List<Stimulus> GetStimulusItems() => sourceExperiment.GetStimulusItems();

        /// <summary>
        /// This inline function will help access a `Stimulus` object through its Id
        /// </summary>
        /// <param name="stimId">The Id string</param>
        /// <returns>The `Stimulus` object with that Id</returns>
        public Stimulus GetStimulusItem(string stimId) => sourceExperiment.GetStimulusItem(stimId);

        /// <summary>
        /// This inline function will return a list containing `Locator` definitions in the experiment
        /// </summary>
        /// <returns></returns>
        public List<Locator> GetLocatorItems() => sourceExperiment.GetLocatorItems();

        /// <summary>
        /// This inline function will help access a `Locator` object through its Id
        /// </summary>
        /// <param name="locId">The Id string</param>
        /// <returns>The `Locator` object with that Id</returns>
        public Locator GetLocatorItem(string locId) => sourceExperiment.GetLocatorItem(locId);
    }
}
