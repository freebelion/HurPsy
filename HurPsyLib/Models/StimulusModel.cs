using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    /// <summary>
    /// This class will be the base for all model classes
    /// which will represent audio/visual stimuli.
    /// </summary>
    internal abstract class StimulusModel
    {
        /// <summary>
        /// This collection will keep track of the stimulus objects
        /// according to their class types
        /// (assuming they are derived from this base model class)
        /// </summary>
        static Dictionary<Type, int> stimulusCounter =
            new Dictionary<Type, int>();

        /// <summary>
        /// This collection will keep track of the IDs assigned to
        /// stimulus objects to ensure a unique name for each object.
        /// </summary>
        static List<string> stimulusIDs =
            new List<string>();

        /// <summary>
        /// Though no instance of this base class can be created,
        /// this constructor will be called any time an instance
        /// of a derived model class is created.
        /// This constructor will assign default IDs based on
        /// the counter of the model class type.
        /// </summary>
        public StimulusModel()
        {
            Type modelType = this.GetType();
            if (!(stimulusCounter.ContainsKey(modelType)))
            { stimulusCounter.Add(modelType, 0); }

            stimulusCounter[modelType]++;
            this.ID = modelType.Name + stimulusCounter[modelType].ToString();
        }

        /// <summary>
        /// An ID string which will define a stimulus object.
        /// </summary>
        private string id;

        /// <summary>
        /// The name of the file where the stimulus object
        /// is stored in the computer environment.
        /// </summary>
        private string filename;

        /// <summary>
        /// A property to get/set the id of the stimulus object.
        /// </summary>
        public string ID
        {
            get { return id; }
            set
            {
                // A new ID will be assigned only if it is unique
                if (!(stimulusIDs.Contains(value)))
                {
                    id = value;
                    // and then it will be remembered
                    stimulusIDs.Add(id);
                }
            }
        }

        /// <summary>
        /// A property to get/set the filename
        /// where the stimulus object is stored.
        /// </summary>
        public string FileName
        {
            get { return filename; }
            set
            {
                filename = value;
            }
        }
    }
}