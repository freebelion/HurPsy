using HurPsyLibStrings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace HurPsyLib
{
    /// <summary>
    /// The class which associates a `Stimulus` object with a `Locator` object by pairing their ids.
    /// Any such pairing which appears in a `Step` object representing a trial step will help display a stimulus at the position specified by the associated locator.
    /// </summary>
    [DataContract]
    public class StimulusLocatorPair
    {
        /// <summary>
        /// The `Stimulus` id making up the pair.
        /// </summary>
        [DataMember]
        public string StimulusId { get; set; }

        /// <summary>
        /// The `Locator` id making up the pair.
        /// </summary>
        [DataMember]
        public string LocatorId { get; set; }

        /// <summary>
        /// This default constructor creates an id pair with empty id strings.
        /// </summary>
        public StimulusLocatorPair()
        {
            StimulusId = string.Empty;
            LocatorId = string.Empty;
        }

        /// <summary>
        /// This parametrized constructor creates a pair of given ids.
        /// </summary>
        /// <param name="stimId">The `Stimulus` id of the pair</param>
        /// <param name="locId">The `Locator` id of the pair</param>
        public StimulusLocatorPair(string stimId, string locId)
        {
            StimulusId = stimId;
            LocatorId = locId;
        }
    }

    /// <summary>
    /// The class which represents a step in an experimental trial.
    /// It contains information on which stimuli will be presented together, at which locations and for how long.
    /// </summary>
    [DataContract]
    public class Step
    {
        /// <summary>
        /// The list of `StimulusLocatorPair` objects which represent the stimuli which will be presented together and their locators which will specify stimuli's locations.
        /// </summary>
        [DataMember]
        public List<StimulusLocatorPair> StimulusLocators { get; set; }

        /// <summary>
        /// The display time period for this step
        /// </summary>
        [DataMember]
        public HurPsyTimePeriod StepTime { get; set; }

        /// <summary>
        /// This default constructor starts with an empty list of stimulus-locator pairs and zero display time.
        /// </summary>
        public  Step()
        {
            StimulusLocators = new List<StimulusLocatorPair>();
            StepTime = new HurPsyTimePeriod();
        }

        /// <summary>
        /// The function which adds a stimulus-locator paitr to `StimulusLocators` list and returns its reference
        /// </summary>
        /// <param name="newpair">The `StimulusLocatorPair` object which will be added to list (by default, it will be null, if an empty one should be created)</param>
        /// <returns>The reference to the newly added `StimulusLocatorPair` object</returns>
        public StimulusLocatorPair AddStimulusLocatorPair(StimulusLocatorPair? newpair = null)
        {
            if (newpair == null)
            { newpair = new StimulusLocatorPair(); }
            StimulusLocators.Add(newpair);
            return newpair;
        }

        /// <summary>
        /// The method which adds a collection of `StimulusLocatorPair` objects
        /// </summary>
        /// <param name="newpairs">The list of `StimulusLocatorPair` objects which will be added</param>
        public void AddStimulusLocatorPairs(StimulusLocatorPair[] newpairs)
        {
            for(int i=0; i<newpairs.Length; i++)
            {
                StimulusLocators.Add(newpairs[i]);
            }
        }

        /// <summary>
        /// The method which updates a `Stimulus` id in the pairs making up this step
        /// </summary>
        /// <param name="oldId">The old id</param>
        /// <param name="newId">The new id</param>
        public void ChangeStimulusId(string oldId, string newId)
        {
            foreach (StimulusLocatorPair pair in StimulusLocators)
            {
                if (pair.StimulusId == oldId)
                { pair.StimulusId = newId; }
            }
        }

        /// <summary>
        /// The method which updates a `Locator` id in the pairs making up this step
        /// </summary>
        /// <param name="oldId">The old id</param>
        /// <param name="newId">The new id</param>
        public void ChangeLocatorId(string oldId, string newId)
        {
            foreach (StimulusLocatorPair pair in StimulusLocators)
            {
                if (pair.LocatorId == oldId)
                { pair.LocatorId = newId; }
            }
        }

        /// <summary>
        /// The method which removes pairs containing a deleted `Stimulus` id
        /// </summary>
        /// <param name="removedId">The id of the deleted `Stimulus` object</param>
        public void RemoveStimulusId(string removedId)
        {
            StimulusLocators.RemoveAll(slpair => slpair.StimulusId == removedId);
        }

        /// <summary>
        /// The method which removes pairs containing a deleted `Locator` id
        /// </summary>
        /// <param name="removedId">The id of the deleted `Locator` object</param>
        public void RemoveLocatorId(string removedId)
        {
            StimulusLocators.RemoveAll(slpair => slpair.LocatorId == removedId);
        }
    }

    /// <summary>
    /// The class which represents an experimental trial as a collection of `Step` objects representing successive steps where groups of stimuli are presented together
    /// </summary>
    [DataContract]
    public class  Trial
    {
        /// <summary>
        /// The collection of `Step` objects representing successive steps making up the trial
        /// </summary>
        [DataMember]
        public List<Step> Steps { get; set; }

        /// <summary>
        /// The boolean flag which indicates whether this trial's order in the block is fixed
        /// </summary>
        [DataMember]
        public bool IsFixed { get; set; }

        /// <summary>
        /// This default constructor starts with an empty list of steps and unfixed order number
        /// If true, the trial represented by the object will not be affected by shuffling of trials.
        /// </summary>
        public Trial()
        {
            Steps = new List<Step>();
            IsFixed = false;
        }

        /// <summary>
        /// The function which adds a `Step` object to the collection of steps and returns a reference to it
        /// </summary>
        /// <param name="newstep">The `Step` object which will be added (null by default, if a new `Step` object must be created and added)</param>
        /// <returns>The newly added object</returns>
        public Step AddStep(Step? newstep = null)
        {
            if (newstep == null) { newstep = new Step(); }
            Steps.Add(newstep);
            return newstep;
        }

        /// <summary>
        /// The method which updates the id of a `Stimulus` object by scanning through `Steps` collection
        /// </summary>
        /// <param name="oldId">The old stimulus id</param>
        /// <param name="newId">The new stimulus id</param>
        public void ChangeStimulusId(string oldId, string newId)
        {
            foreach (Step stp in Steps)
            {
                stp.ChangeStimulusId(oldId, newId);
            }
        }

        /// <summary>
        /// The method which updates the id of a `Locator` object by scanning through `Steps` collection
        /// </summary>
        /// <param name="oldId">The old locator id</param>
        /// <param name="newId">The new locator id</param>
        public void ChangeLocatorId(string oldId, string newId)
        {
            foreach (Step stp in Steps)
            {
                stp.ChangeLocatorId(oldId, newId);
            }
        }

        /// <summary>
        /// The method which scans through the steps referring to a deleted `Stimulus` id
        /// </summary>
        /// <param name="removedId">The id of the deleted `Stimulus` object</param>
        public void RemoveStimulusId(string removedId)
        {
            foreach (Step stp in Steps)
            {
                stp.RemoveStimulusId(removedId);
            }
        }

        /// <summary>
        /// The method which scans through the steps referring to a deleted `Locator` id
        /// </summary>
        /// <param name="removedId">The id of the deleted `Locator` object</param>
        public void RemoveLocatorId(string removedId)
        {
            foreach (Step stp in Steps)
            {
                stp.RemoveLocatorId(removedId);
            }
        }
    }

    /// <summary>
    /// The class which represents a block of experimental trials as a collection of `Trial` objects.
    /// </summary>
    [DataContract]
    public class Block
    {
        /// <summary>
        /// The static variable through which the class keeps count of `Block` objects
        /// (as of September 23rd, 2024, I can't remember the reason that made this count necessary)
        /// </summary>
        private static int blockCount = 0;
        
        /// <summary>
        /// The string which will hold the hopefully-identifying name given to the block by the designer of the experiment.
        /// </summary>
        [DataMember]
        public string Name { get; set; }
        
        /// <summary>
        /// The collection of `Trial` objects representing expewrimental trials
        /// </summary>
        [DataMember]
        public List<Trial> Trials { get; set; }
        
        /// <summary>
        /// The boolean flag which indicates whether the trials (except the fixed ones) making up the block must be shuffled before every run of the experiment.
        /// </summary>
        [DataMember]
        public bool MustShuffleTrials { get; set; }

        /// <summary>
        /// This default constructor starts with a temporary but unique block id as the name and empty list of trials.
        /// </summary>
        public Block()
        {
            blockCount++;
            Name = HurPsyCommon.GetObjectGuid(this);
            Trials = new List<Trial>();
            MustShuffleTrials = true;
        }

        /// <summary>
        /// The function which adds a `Trial` object to the list of trials and returns a reference to it
        /// </summary>
        /// <param name="newtrial">The `Trial` object which will be added (null by default, if a new object must be created and added)</param>
        /// <returns>The reference to the newly added object</returns>
        public Trial AddTrial(Trial? newtrial = null)
        {
            if (newtrial == null) { newtrial = new Trial(); }
            Trials.Add(newtrial);
            return newtrial;
        }

        /// <summary>
        /// The method which shuffles the order of trials (excluding the fixed ones) making up the block
        /// </summary>
        public void ShuffleTrials()
        {
            Trial tmp;
            int nrep;

            for(int i=0, j=0; i < Trials.Count - 1; i++)
            {
                if (Trials[i].IsFixed) { continue; }

                nrep = 0;
                do
                {
                    j = HurPsyCommon.Rnd.Next(i, Trials.Count);
                    nrep++; // to avoid an infinite-loop
                } while (Trials[j].IsFixed && nrep < 10);
                if(nrep == 0) { continue; }

                // Non-fixed trials can exchange places
                tmp = Trials[i];
                Trials[i] = Trials[j];
                Trials[j] = tmp;
            }
        }

        /// <summary>
        /// The method which updates the id of a `Stimulus` object by scanning through `Trials` collection
        /// </summary>
        /// <param name="oldId">The old stimulus id</param>
        /// <param name="newId">The new stimulus id</param>
        public void ChangeStimulusId(string oldId, string newId)
        {
            foreach (Trial tr in Trials)
            {
                tr.ChangeStimulusId(oldId, newId);
            }
        }

        /// <summary>
        /// The method which updates the id of a `Locator` object by scanning through `Trials` collection
        /// </summary>
        /// <param name="oldId">The old locator id</param>
        /// <param name="newId">The new locator id</param>
        public void ChangeLocatorId(string oldId, string newId)
        {
            foreach (Trial tr in Trials)
            {
                tr.ChangeLocatorId(oldId, newId);
            }
        }

        /// <summary>
        /// The method which scans through the trials referring to a deleted `Stimulus` id
        /// </summary>
        /// <param name="removedId">The id of the deleted `Stimulus` object</param>
        public void RemoveStimulusId(string removedId)
        {
            foreach (Trial tr in Trials)
            {
                tr.RemoveStimulusId(removedId);
            }
        }

        /// <summary>
        /// The method which scans through the trials referring to a deleted `Locator` id
        /// </summary>
        /// <param name="removedId">The id of the deleted `Locator` object</param>
        public void RemoveLocatorId(string removedId)
        {
            foreach (Trial tr in Trials)
            {
                tr.RemoveLocatorId(removedId);
            }
        }
    }
}