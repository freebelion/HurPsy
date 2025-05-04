using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This class represents an experiment trial made up of one or more steps.
    /// </summary>
    [DataContract]
    public class ExpTrial : IdObject
    {
        /// <summary>
        /// The collection of experiment steps that make up this trial
        /// </summary>
        [DataMember]
        public List<ExpStep> Steps { get; set; }

        /// <summary>
        /// The boolean indicator specifying if this trial will be fixed within the block (i.e. not to be shuffled) 
        /// </summary>
        [DataMember]
        public bool IsFixed { get; set; }

        /// <summary>
        /// This default constructor starts with the defaults.
        /// </summary>
        public ExpTrial()
        {
            Steps = [];
            IsFixed = false;
        }

        /// <summary>
        /// This method adds an existing step or creates and adds a new one.
        /// </summary>
        /// <param name="st">The step to be added</param>
        public void AddStep(ExpStep st) => Steps.Add(st);

        /// <summary>
        /// This method delegates the changing of a `Stimulus` Id to the steps making up this trial.
        /// </summary>
        /// <param name="oldId"></param>
        /// <param name="newId"></param>
        public void ChangeStimulusId(string oldId, string newId)
        {
            Steps.ForEach(st => st.ChangeStimulusId(oldId, newId));
        }

        /// <summary>
        /// This method delegates the changing of a `Locator` Id to the steps making up this trial.
        /// </summary>
        /// <param name="oldId"></param>
        /// <param name="newId"></param>
        public void ChangeLocatorId(string oldId, string newId)
        {
            Steps.ForEach(st => st.ChangeLocatorId(oldId, newId));
        }

        /// <summary>
        /// This method delegates the removal of a `Stimulus` Id to the steps making up this trial.
        /// </summary>
        /// <param name="stimid"></param>
        public void RemoveStimulusId(string stimid)
        {
            Steps.ForEach(st => st.RemoveStimulusId(stimid));
        }

        /// <summary>
        /// This method delegates the removal of a `Locator` Id to the steps making up this trial.
        /// </summary>
        /// <param name="locid"></param>
        public void RemoveLocatorId(string locid)
        {
            Steps.ForEach(st => st.RemoveLocatorId(locid));
        }
    }
}
