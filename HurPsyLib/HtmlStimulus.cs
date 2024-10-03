using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HurPsyLib
{
    /// <summary>
    /// This class in intended to represents a viewbox displaying the contents of an HTML file.
    /// It implements the IVisualStimulus interface because the stimulus will appear as a visual box displaying some information or instructions.
    /// </summary>
    public class HtmlStimulus : Stimulus, IVisualStimulus
    {
        /// <summary>
        /// The required IVisualStimulus property to get/set the display box size
        /// </summary>
        [DataMember]
        public HurPsySize VisualSize { get; set; }

        /// <summary>
        /// This default constructor starts with a size which will be valid in case an experiment designer has not set any size.
        /// </summary>
        public HtmlStimulus()
        {
            VisualSize = new HurPsySize(250,380);
        }
    }
}
