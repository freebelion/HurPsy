using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    public class StimulusLocatorPair
    {
        public string StimulusId { get; set; }
        public string LocatorId { get; set; }
        
        public StimulusLocatorPair()
        {
            StimulusId = string.Empty;
            LocatorId = string.Empty;
        }

        public StimulusLocatorPair(string stimId, string locId)
        {
            StimulusId = stimId;
            LocatorId = locId;
        }
    }
}
