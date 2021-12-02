using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib.Models
{
    /// <summary>
    /// This class will be the mediator helping base classes
    /// to count and name the instances of their derived classes.
    /// </summary>
    internal class InstanceCounter
    {
        /// This collection will keep track of
        /// the instances of derived types.
        /// </summary>
        private Dictionary<Type, int> typeCounters;

        /// <summary>
        /// This collection will keep track of the IDs assigned to
        /// instances of derived types.
        /// </summary>
        private List<string> objectIDs =
            new List<string>();

        public InstanceCounter()
        {
            typeCounters = new Dictionary<Type, int>();
            objectIDs = new List<string>();
        }

        /// <summary>
        /// This method increments the instance count of the given type,
        /// after (if necessary) adding the given type to the counter list.
        /// </summary>
        /// <param name="derivedType"></param>
        /// <returns>The ID string assigned to the instance</returns>
        public string AddInstance(Type derivedType)
        {
            if (!(typeCounters.ContainsKey(derivedType)))
            { typeCounters.Add(derivedType, 0); }

            typeCounters[derivedType]++;
            return derivedType.Name + typeCounters[derivedType].ToString();
        }

        public bool AddInstanceID(string assignedID)
        {
            // A new ID will be assigned only if it is unique
            if (!(objectIDs.Contains(assignedID)))
            {
                //  then it will be remembered
                objectIDs.Add(assignedID);
                return true;
            }
            else { return false; }
        }
    }
}
