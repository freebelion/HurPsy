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
    /// It implements the VisualStimulus interface because the stimulus will appear as a visual box displaying some information or instructions.
    /// </summary>
    public class HtmlStimulus : VisualStimulus
    {
        /// <summary>
        /// This default constructor starts with a size which will be valid in case an experiment designer has not set any size.
        /// </summary>
        public HtmlStimulus()
        {
            VisualSize = new HurPsySize(250,380);
        }
    }
}
