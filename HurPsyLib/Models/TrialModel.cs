using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    /// <summary>
    /// This class will represent an experimental trial
    /// made up of stimulus objects displayed at certain
    /// positions specified by an array of region models.
    /// </summary>
    internal class TrialModel
    {
        private List<string> stimulusIDs;
        private List<string> regionIDs;
        private ResponseModel referenceResponse;
        private ResponseModel givenResponse;

        /// <summary>
        /// The default constructor creates empty lists for
        /// the IDs of stimulus and region objects
        /// and null references for the expected and actual responses.
        /// </summary>
        /// <param name="stimuliArray"></param>
        /// <param name="regionArray"></param>
        public TrialModel(StimulusModel[] stimuliArray, RegionModel[] regionArray)
        {
            stimulusIDs = new List<string>();
            regionIDs = new List<string>();
            referenceResponse = null;
            givenResponse = null;
        }

        /// <summary>
        /// The accessor for the expected (correct) response
        /// for the actual trial represented by this object.
        /// </summary>
        public ResponseModel CorrectResponse
        {
            get { return referenceResponse; }
            set { referenceResponse = value; }
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
    }
}
