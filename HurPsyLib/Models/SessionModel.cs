using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    /// <summary>
    /// This class will represent an experimental session
    /// made up of a number of trial blocks.
    /// </summary>
    internal class SessionModel
    {
        // The name of the experiment
        private string experimentName;
        // The id string that defines the experimental session
        private string sessionID;
        // The starting time of the experimental session
        private DateTime sessionTime;
        // The list of blocks making up the block
        private List<BlockModel> trialBlocks;
        // The trial which starts the session
        private TrialModel startTrial;
        // The trial which ends the session
        private TrialModel endTrial;

        /// <summary>
        /// The constructor will require the name of the experiment,
        /// create a Guid-based session ID, create an empty list of trial blocks,
        /// along with two trials to appear at the beginning and the end of the session.
        /// </summary>
        /// <param name="expname"></param>
        public SessionModel(string expname)
        {
            experimentName = expname;
            sessionID = Guid.NewGuid().ToString();
            trialBlocks = new List<BlockModel>();
            startTrial = new TrialModel();
            endTrial = new TrialModel();
        }

        /// <summary>
        /// The read-only accessor property for the name of the experiment
        /// </summary>
        public string ExperimentName
        {
            get { return experimentName; }
        }

        /// <summary>
        /// The read-only accessor property for the session ID
        /// </summary>
        public string SessionID
        {
            get { return sessionID; }
        }

        /// <summary>
        /// The function to add a new trial block
        /// </summary>
        public void AddBlock()
        {
            trialBlocks.Add(new BlockModel());
        }

        /// <summary>
        /// The function to access the trial block at a given index
        /// </summary>
        /// <param name="index">The index value for the list of trial blocks</param>
        /// <returns>The BlockModel object at the given index</returns>
        public BlockModel GetTrialBlock(int index)
        {
            if (index >= 0 && index < trialBlocks.Count)
            { return trialBlocks[index]; }
            else
            { return null; }
        }

        /// <summary>
        /// The accessor property for the starting trial for this block
        /// </summary>
        /// <returns>The reference to the startTrial object</returns>
        public TrialModel StartTrial
        {
            get { return startTrial; }
        }

        /// <summary>
        /// The accessor property for the ending trial for this block
        /// </summary>
        /// <returns>The reference to the endTrial object</returns>
        public TrialModel EndTrial
        {
            get { return endTrial; }
        }
    }
}
