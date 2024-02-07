using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    [DataContract]
    public class ImageStimulus : Stimulus, IVisualStimulus
    {
        [DataMember]
        public HurPsySize VisualSize { get; set; }

        public ImageStimulus()
        {
            VisualSize = new HurPsySize(10, 10);
        }
    }
}
