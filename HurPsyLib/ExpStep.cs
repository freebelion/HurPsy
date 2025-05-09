using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This class represents a trial step of an experiment,
    /// a step being a collection of stimuli presented together, for a specified period of time.
    /// </summary>
    [DataContract]
    public class ExpStep : IdObject
    {
        /// <summary>
        /// The Id pairs making up this step
        /// </summary>
        [DataMember]
        public List<ExpPair> StepPairs { get; set; }

        /// <summary>
        /// The time period of presentation
        /// </summary>
        [DataMember]
        public HurPsyTimePeriod StepTime { get; set; }

        [DataMember]
        public string? AllowedResponseId { get; set; }

        [DataMember]
        public string? ExpectedResponseId { get; set; }

        /// <summary>
        /// This default constructor starts with the defaults.
        /// </summary>
        public ExpStep()
        {
            StepPairs = [];
            StepTime = new();
            AllowedResponseId = null;
            ExpectedResponseId = null;
        }

        /// <summary>
        /// This method adds a new `Stimulus`-`Locator` pair.
        /// </summary>
        /// <param name="pr">`ExpPair` object to be added</param>
        public void AddPair(ExpPair pr) => StepPairs.Add(pr);

        /// <summary>
        /// This method adds an array of pairs.
        /// </summary>
        /// <param name="pairs">The array of previously formed pairs</param>
        public void AddPairs(ExpPair[] pairs)
        {
            StepPairs.AddRange(pairs);
        }

        /// <summary>
        /// Replace an old `Stimulus` Id with a new one.
        /// </summary>
        /// <param name="oldId">old Id string</param>
        /// <param name="newid">new Id string</param>
        public void ChangeStimulusId(string oldId, string newid)
        {
            foreach (ExpPair pair in StepPairs)
            {
                if (pair.StimulusId == oldId)
                { pair.StimulusId = newid; }
            }
        }

        /// <summary>
        /// Replace an old `Locator` Id with a new one.
        /// </summary>
        /// <param name="oldId">old Id string</param>
        /// <param name="newid">new Id string</param>
        public void ChangeLocatorId(string oldId, string newid)
        {
            foreach (ExpPair pair in StepPairs)
            {
                if (pair.LocatorId == oldId)
                { pair.LocatorId = newid; }
            }
        }

        /// <summary>
        /// This method removes all pairs with the given `Stimulus` Id
        /// </summary>
        /// <param name="stimid"></param>
        public void RemoveStimulusId(string stimid)
        {
            StepPairs.RemoveAll(pair => pair.StimulusId == stimid);
        }

        /// <summary>
        /// This method removes all pairs with the given `Locator` Id
        /// </summary>
        /// <param name="locid"></param>
        public void RemoveLocatorId(string locid)
        {
            StepPairs.RemoveAll(pair => pair.LocatorId == locid);
        }
    }
}
