using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    /// <summary>
    /// This class will be the mediator helping the app
    /// to count and name the instances of all object types.
    /// </summary>
    internal static class InstanceCounter
    {
        /// This collection will keep track of
        /// the instances of the object types.
        /// </summary>
        private static Dictionary<Type, int> typeCounters;

        /// <summary>
        /// This collection will keep track of the IDs assigned to
        /// instances of the object types.
        /// </summary>
        private static List<string> objectIDs =
            new List<string>();

        static InstanceCounter()
        {
            typeCounters = new Dictionary<Type, int>();
            objectIDs = new List<string>();
        }

        /// <summary>
        /// This method increments the instance count of the given type,
        /// after (if necessary) adding the given type to the counter list.
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns>The ID string assigned to the instance</returns>
        public static string CreateInstance(Type objectType)
        {
            if (!(typeCounters.ContainsKey(objectType)))
            { typeCounters.Add(objectType, 0); }

            typeCounters[objectType]++;
            return objectType.Name + typeCounters[objectType].ToString();
        }

        public static bool CreateInstanceID(string assignedID)
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
