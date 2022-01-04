using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    /// <summary>
    /// This class will represent image stimulus objects.
    /// </summary>
    internal class ImageStimulusModel : StimulusModel
    {
        // Width of the image stimulus
        private double imageWidth;
        // Height of the image stimulus
        private double imageHeight;

        /// <summary>
        /// This property provides controlled access to image width.
        /// </summary>
        public double Width
        {
            get { return imageWidth; }
            set
            {
                if (value > 0)
                {
                    imageWidth = value;
                }
                else
                {// Throw an exception indicating invalid size value
                    throw (new ApplicationException(HurPsyLibStrings.InvalidImageWidth));
                }
            }
        }

        /// <summary>
        /// This property provides controlled access to image height.
        /// </summary>
        public double Height
        {
            get { return imageHeight; }
            set
            {
                if (value > 0)
                {
                    imageHeight = value;
                }
                else
                {// Throw an exception indicating invalid size value
                    throw (new ApplicationException(HurPsyLibStrings.InvalidImageHeight));
                }
            }
        }
    }
}
