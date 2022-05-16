using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    /// <summary>
    /// This class will specify a point location
    /// for a stimulus object.
    /// </summary>
    internal class PointPositionModel : PositionModel
    {
        // The point location to be assigned to the stimulus
        private PointModel pointLocation;

        /// <summary>
        /// The default constructor which creates an empty point location
        /// </summary>
        public PointPositionModel()
        {
            pointLocation = new PointModel();
        }

        /// <summary>
        /// The accessor for the X coordinate of the point location
        /// </summary>
        public double LocationX
        {
            get { return pointLocation.X; }
            set { pointLocation.X = value; }
        }

        /// <summary>
        /// The accessor for the Y coordinate of the point location
        /// </summary>
        public double LocationY
        {
            get { return pointLocation.Y; }
            set { pointLocation.Y = value; }
        }

        public override PointModel getLocation()
        {
            return pointLocation;
        }
    }
}
