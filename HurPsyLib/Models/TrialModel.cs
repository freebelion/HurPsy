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
        private StimulusModel[] trialStimuli;
        private RegionModel[] trialRegions;

        /// <summary>
        /// The only constructor function for this model class
        /// receives the references of pre-constructed arrays,
        /// because stimulus objects and their locations must be
        /// determined according to the rules of the experiment.
        /// </summary>
        /// <param name="stimuliArray"></param>
        /// <param name="regionArray"></param>
        public TrialModel(StimulusModel[] stimuliArray, RegionModel[] regionArray)
        {
            trialStimuli = stimuliArray;
            trialRegions = regionArray;
        }
    }
}
