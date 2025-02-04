using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HurPsyLib
{
    /// <summary>
    /// This class represents a viewbox displaying the contents of an HTML file.
    /// It implements the `VisualStimulus` interface to determinee the size of the visual box.
    /// </summary>
    public class HtmlStimulus : VisualStimulus
    {
        /// <summary>
        /// This default constructor starts with a default size.
        /// </summary>
        public HtmlStimulus()
        {
            VisualSize = new HurPsySize(250,380);
            VisualSize.Unit = HurPsyUnit.MM;
        }
    }
}
