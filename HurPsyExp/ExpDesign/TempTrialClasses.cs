using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    public class TempStep
    {
        public List<StimulusLocatorPair> TempPairs {  get; set; }

        public TempStep()
        {
            TempPairs = new List<StimulusLocatorPair>();
        }

        public void AddTempPair(string stimId, string locId)
        {
            TempPairs.Add(new StimulusLocatorPair(stimId, locId));
        }
    }

    public class TempTrial
    {
        public List<TempStep> TempSteps { get; set; }

        public TempTrial()
        {
            TempSteps = new List<TempStep>();
        }
    }
}