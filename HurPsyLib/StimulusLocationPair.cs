using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    public class StimulusLocationPair
    {
        public string StimulusId { get; set; }
        public HurPsyPoint? StimulusLocation { get; set; }

        public StimulusLocationPair()
        {
            StimulusId = string.Empty;
            StimulusLocation = null;
        }
    }
}
