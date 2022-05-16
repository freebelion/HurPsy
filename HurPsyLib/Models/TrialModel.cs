using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    /// <summary>
    /// This class will represent an experimental trial made up of
    /// stimulus objects to be displayed at certain positions.
    /// Stimulus objects and positions are determined by the
    /// ID strings of those objects defined for the whole experiment.
    /// </summary>
    internal class TrialModel
    {
        private List<string> stimulusIDs;
        private List<string> positionIDs;
        private ResponseModel correctResponse;
        private ResponseModel givenResponse;
        
        /// <summary>
        /// The default constructor creates empty arrays for
        /// the IDs of stimulus and region objects
        /// and null references for the expected and actual responses.
        /// </summary>
        public TrialModel()
        {
            stimulusIDs = new List<string>();
            positionIDs = new List<string>();
            correctResponse = null;
            givenResponse = null;
        }

        /// <summary>
        /// The accessor for the expected (correct) response
        /// for the actual trial represented by this object.
        /// </summary>
        public ResponseModel CorrectResponse
        {
            get { return correctResponse; }
            set { correctResponse = value; }
        }

        /// <summary>
        /// The accessor for the response given for
        /// the actual trial represented by this object.
        /// </summary>
        public ResponseModel ActualResponse
        {
            get { return givenResponse; }
            set { givenResponse = value; }
        }

        /// <summary>
        /// The accessor property for the number of ID strings
        /// of the stimulus objects making up this trial
        /// </summary>
        public int StimulusCount
        {
            get { return stimulusIDs.Count; }

            set
            {
                // In case a new count value is specified from outside,
                int oldCount = stimulusIDs.Count;
                if(value > oldCount)
                {// add null references to fill the extra places,
                    for(int i = oldCount; i < value; i++)
                    {
                        stimulusIDs.Add(null);
                    }
                }
                else
                {// or remove last elements until the new count value is reached.
                    for (int i = oldCount; i > value; i--)
                    {
                        stimulusIDs.RemoveAt(i - 1);
                    }
                }
            }
        }

        /// <summary>
        /// The accessor property for the number of ID strings
        /// of the stimulus positions for this trial
        /// </summary>
        public int PositionCount
        {
            get { return positionIDs.Count; }

            set
            {
                // In case a new count value is specified from outside,
                int oldCount = positionIDs.Count;
                if (value > oldCount)
                {// add null references to fill the extra places,
                    for (int i = oldCount; i < value; i++)
                    {
                        positionIDs.Add(null);
                    }
                }
                else
                {// or remove last elements until the new count value is reached.
                    for (int i = oldCount; i > value; i--)
                    {
                        positionIDs.RemoveAt(i - 1);
                    }
                }
            }
        }

        /// <summary>
        /// The function to access the stimulus ID string at a given index
        /// </summary>
        /// <param name="index">The index value for the stimulus ID array</param>
        /// <returns>The stimulus ID placed at the given index</returns>
        public string GetStimulusID(int index)
        {
            if(index >= 0 && index < stimulusIDs.Count)
            { return stimulusIDs[index]; }
            else
            { return null; }
        }

        /// <summary>
        /// The function to set the stimulus ID at a given index
        /// </summary>
        /// <param name="index">The index value for the stimulus ID array</param>
        /// <param name="stimID">The stimulus ID to be placed at the given index</param>
        public void SetStimulusID(int index, string stimID)
        {
            if (index >= 0 && index < stimulusIDs.Count)
            { stimulusIDs[index] = stimID; }
        }

        /// <summary>
        /// The function to access the position ID string at a given index
        /// </summary>
        /// <param name="index">The index value for the position ID array</param>
        /// <returns>The position ID placed at the given index</returns>
        public string GetPositionID(int index)
        {
            if (index >= 0 && index < positionIDs.Count)
            { return positionIDs[index]; }
            else
            { return null; }
        }

        /// <summary>
        /// The function to set the position ID at a given index
        /// </summary>
        /// <param name="index">The index value for the position ID array</param>
        /// <param name="positID">The position ID to be placed at the given index</param>
        public void SetPositionID(int index, string positID)
        {
            if (index >= 0 && index < positionIDs.Count)
            { positionIDs[index] = positID; }
        }
    }
}
