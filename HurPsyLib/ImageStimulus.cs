using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This class represents an image served as a visual stimulus (hence it implements the `VisualStimulus` interface)
    /// </summary>
    [DataContract]
    public class ImageStimulus : VisualStimulus
    {
        /// <summary>
        /// This default constructor starts with an image size of 10 mm by 10 mm (I didn't want to cause surprise by starting with zero size)
        /// </summary>
        public ImageStimulus()
        {
            VisualSize = new HurPsySize(10, 10);
            VisualSize.Unit = HurPsyUnit.MM;
        }
    }
}
