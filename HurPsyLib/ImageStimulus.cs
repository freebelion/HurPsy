using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    [DataContract]
    public class ImageStimulus : Stimulus
    {
        [DataMember]
        public HurPsySize ImageSize { get; private set; }

        public ImageStimulus()
        {
            ImageSize = new HurPsySize();
        }
    }
}
