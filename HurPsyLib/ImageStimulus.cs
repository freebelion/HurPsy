using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This class is intended to represent an image served as a visual stimulus (hence it implements the IVisualStimulus interface)
    /// </summary>
    [DataContract]
    public class ImageStimulus : Stimulus, IVisualStimulus
    {
        /// <summary>
        /// The property required by the IVisualStimulus interface to get/set the image size
        /// </summary>
        [DataMember]
        public HurPsySize VisualSize { get; set; }

        /// <summary>
        /// This default constructor starts with an image size of 10 mm by 10 mm (didn't want to cause surprise by starting with zero size)
        /// </summary>
        public ImageStimulus()
        {
            VisualSize = new HurPsySize(10, 10);
        }
    }
}
