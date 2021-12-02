using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    internal abstract class RegionModel
    {
        /// <summary>
        /// This intermediary object will keep track of
        /// the region objects according to their class types
        /// (assuming they are derived from this base model class)
        /// </summary>
        static InstanceCounter regionInstanceCounter =
            new InstanceCounter();

        /// <summary>
        /// Though no instance of this base class can be created,
        /// this constructor will be called any time an instance
        /// of a derived model class is created. 
        public RegionModel()
        {
            id = regionInstanceCounter.AddInstance(this.GetType());
        }

        /// <summary>
        /// An ID string which will define a region object.
        /// </summary>
        private string id;

        /// <summary>
        /// A property to get/set the id of the region object.
        /// </summary>
        public string ID
        {
            get { return id; }
            set
            {
                // The given ID will be assigned only if verified to be unique
                if(regionInstanceCounter.AddInstanceID(value))
                {
                    id = value;
                }
            }
        }

        /// <summary>
        /// This abstract method will be overriden by the derived classes
        /// for them to produce a location according to their own positioning rules.
        /// </summary>
        /// <returns>The location produced by the derived regionModel object.</returns>
        public abstract PointModel getLocation();
    }
}
