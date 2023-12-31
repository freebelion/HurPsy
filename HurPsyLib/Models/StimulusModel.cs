﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    /// <summary>
    /// This class will be the base for all model classes
    /// which will represent auditory/visual stimuli.
    /// </summary>
    internal abstract class StimulusModel
    {
        /// <summary>
        /// Though no instance of this base class can be created,
        /// this constructor will be called any time an instance
        /// of a derived model class is created.
        /// It will keep track of the derived class instances
        /// and automatically assign them temporary names.
        /// </summary>
        public StimulusModel()
        {
            id = InstanceCounter.CreateInstanceID(this.GetType());
            filename = string.Empty;
        }

        // An ID string which will define a stimulus object.
        private string id;

        // The name of the file where the stimulus object
        // is stored in the computer environment.
        private string filename;

        /// <summary>
        /// A property to get/set the id of the stimulus object.
        /// </summary>
        public string ID
        {
            get { return id; }
            set
            {
                // The given ID will be assigned only if verified to be unique
                if (InstanceCounter.UniqueInstanceID(value))
                {
                    id = value;
                }
            }
        }

        /// <summary>
        /// A property to get/set the filename
        /// where the stimulus object is stored.
        /// </summary>
        public string FileName
        {
            get { return filename; }
            set
            {
                // REMINDER: The filename is not being validated,
                // because model classes will not get involved with the file system.
                filename = value;
            }
        }
    }
}