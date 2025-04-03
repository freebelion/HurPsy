using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This class represents a block of experiment trials.
    /// </summary>
    [DataContract]
    public class ExpBlock : IdObject
    {
        /// <summary>
        /// The list of trials making up this block
        /// </summary>
        [DataMember]
        public List<ExpTrial> Trials { get; set; }

        /// <summary>
        /// The boolean indicator for having the trials shuffle at each run of the experiment
        /// </summary>
        [DataMember]
        public bool MustShuffleTrials { get; set; }

        /// <summary>
        /// This default constructor starts with the defaults
        /// </summary>
        public ExpBlock()
        {
            Trials = [];
            MustShuffleTrials = true;
        }

        /// <summary>
        /// Add a trial to the block
        /// </summary>
        /// <param name="tr">The trial to be added</param>
        public void AddTrial(ExpTrial tr) => Trials.Add(tr);

        /// <summary>
        /// This method delegates the changing of a `Stimulus` Id to the trials making up this block.
        /// </summary>
        /// <param name="oldId"></param>
        /// <param name="newId"></param>
        public void ChangeStimulusId(string oldId, string newId)
        {
            Trials.ForEach(tr => tr.ChangeStimulusId(oldId, newId));
        }

        /// <summary>
        /// This method delegates the changing of a `Locator` Id to the trials making up this block.
        /// </summary>
        /// <param name="oldId"></param>
        /// <param name="newId"></param>
        public void ChangeLocatorId(string oldId, string newId)
        {
            Trials.ForEach(tr => tr.ChangeLocatorId(oldId, newId));
        }

        /// <summary>
        /// This method delegates the removal of a `Stimulus` Id to the trials making up this block.
        /// </summary>
        /// <param name="stimid"></param>
        public void RemoveStimulusId(string stimid)
        {
            Trials.ForEach(tr => tr.RemoveStimulusId(stimid));
        }

        /// <summary>
        /// This method delegates the removal of a `Locator` Id to the trials making up this block.
        /// </summary>
        /// <param name="locid"></param>
        public void RemoveLocatorId(string locid)
        {
            Trials.ForEach(tr => tr.RemoveLocatorId(locid));
        }
    }
}
