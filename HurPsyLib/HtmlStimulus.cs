using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace HurPsyLib
{
    public class HtmlStimulus : Stimulus, IVisualStimulus
    {
        [DataMember]
        public HurPsySize VisualSize { get; set; }

        public HtmlStimulus()
        {
            VisualSize = new HurPsySize(250,380);
        }
    }
}
