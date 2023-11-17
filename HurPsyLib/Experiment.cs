using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HurPsyLib
{
    public class Experiment
    {
        public Dictionary<string, Stimulus> StimulusDict { get; private set; }
        public Dictionary<string, Locator> LocatorDict { get; private set; }

        public Experiment()
        {
            StimulusDict = new Dictionary<string, Stimulus>();
            LocatorDict = new Dictionary<string, Locator>();
        }

        public bool AddStimulus(string stimId, Stimulus stim)
        {
            try { StimulusDict.Add(stimId, stim); return true; }
            catch { return false; }
        }

        public bool AddLocator(string locId, Locator loc)
        {
            try { LocatorDict.Add(locId, loc); return true; }
            catch { return false; }
        }
    }
}
