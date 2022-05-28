using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    /// <summary>
    /// This class will represent a block of trials
    /// </summary>
    internal class BlockModel
    {
        // The id string that defines the block
        private string blockID;
        // The list of trials making up the block
        private List<TrialModel> blockTrials;
        // The list of in-between trials (one for every block trial)
        private List<TrialModel> interimTrials;
        // The start-of-the-block trial
        private TrialModel startTrial;
        // The end-of-the-block trial
        private TrialModel endTrial;

        /// <summary>
        /// The constructor will assign a unique ID temporarily,
        /// while also creating the starting and ending trials,
        /// along with an empty list of trials which will make up this block.
        /// </summary>
        public BlockModel()
        {
            blockID = InstanceCounter.CreateInstanceID(this.GetType());
            blockTrials = new List<TrialModel>();
            interimTrials = new List<TrialModel>();
            startTrial = new TrialModel();
            endTrial = new TrialModel();
        }

        /// <summary>
        /// The acessor property for the ID string of the block
        /// </summary>
        public string ID
        {
            get { return blockID; }
            set
            {
                // The given ID will be assigned only if verified to be unique
                if (InstanceCounter.UniqueInstanceID(value))
                {
                    blockID = value;
                }
            }
        }

        /// <summary>
        /// The function to add a new or existing TrialModel object
        /// </summary>
        /// <param name="trial"></param>
        public void AddTrial(TrialModel trial = null)
        {
            // If no existing trial is specified, create a new one
            if(trial == null)
            { trial = new TrialModel(); }

            // and add the new trial to the list
            blockTrials.Add(trial);
            // along with a corresponding interim trial
            interimTrials.Add(new TrialModel());
        }

        /// <summary>
        /// The function to access the block trial at a given index
        /// </summary>
        /// <param name="index">The index value for the list of block trials</param>
        /// <returns>The TrialModel object at the given index</returns>
        public TrialModel GetBlockTrial(int index)
        {
            if (index >= 0 && index < blockTrials.Count)
            { return blockTrials[index]; }
            else
            { return null; }
        }

        /// <summary>
        /// The function to access the interim trial at a given index
        /// </summary>
        /// <param name="index">The index value for the list of interim trials</param>
        /// <returns>The TrialModel object at the given index</returns>
        public TrialModel GetInterimTrial(int index)
        {
            if (index >= 0 && index < interimTrials.Count)
            { return interimTrials[index]; }
            else
            { return null; }
        }

        /// <summary>
        /// The function to access the end trial for this block
        /// </summary>
        /// <returns>The reference to the endTrial object</returns>
        public TrialModel GetEndTrial()
        {
            return endTrial;
        }
    }
}
