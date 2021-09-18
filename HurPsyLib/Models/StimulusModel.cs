using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    internal class StimulusModel
    {
        /// <summary>
        /// An ID string which will define a stimulus.
        /// </summary>
        private string id;

        /// <summary>
        /// The name of the file where the stimulus
        /// is stored in the computer environment.
        /// </summary>
        private string filename;

        /// <summary>
        /// A property to get/set the id of the stimulus.
        /// </summary>
        public string ID
        {
            get { return id; }
            set
            {
                id = value;
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
