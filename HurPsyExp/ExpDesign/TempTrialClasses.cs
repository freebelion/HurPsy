using CommunityToolkit.Mvvm.ComponentModel;
using HurPsyLib;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Controls.Primitives;

namespace HurPsyExp.ExpDesign
{

    public partial class IdSelection : ObservableObject
    {
        [ObservableProperty]
        private bool selected;

        [ObservableProperty]
        private string id;

        public IdSelection()
        { Selected = false; Id = string.Empty; }

        public IdSelection(string id, bool idsel = false)
        { Selected = idsel; Id = id; }
    }

    public partial class PairSet
    {
        public List<StimulusLocatorPair> StimLocPairs { get; set; }

        public PairSet()
        {
            StimLocPairs = new List<StimulusLocatorPair>();
        }

        public void AddStimLocPair(string stimId, string locId)
        {
            StimLocPairs.Add(new StimulusLocatorPair(stimId, locId));
        }
    }

    public partial class ChoiceSet
    {
        public List<IdSelection> IdChoices {  get; set; }

        public ChoiceSet()
        { 
            IdChoices = new List<IdSelection>();
        }

        public void AddChoice(string choiceId)
        {
            IdChoices.Add(new IdSelection(choiceId));
        }
    }

    /// <summary>
    /// This class will serve as a boilerplate for one or more steps
    /// that an experiment designer wants to add to a trial.
    /// </summary>
    public class TempStep
    {
        // Every temp step will have a list of IdSelection list.
        // Each member of that list will be a set of Stimulus choices
        // associated with Locator choices of the TempTrial object
        // which contains this TempStap object.
        public List<ChoiceSet> StimulusChoiceSets { get; set; }

        public TempStep()
        {
            StimulusChoiceSets = new List<ChoiceSet>();
        }

        public void AddStimulusChoiceSet(List<string> stimulusIds)
        {
            ChoiceSet newset = new ChoiceSet();
            
            // Create new IdSelection objects with incoming list of Stimnulus Ids
            foreach (string id in stimulusIds)
            { newset.AddChoice(id); }

            StimulusChoiceSets.Add(newset);
        }

        public List<Step> ConstructExperimentSteps(List<string> locatorIds)
        {
            List<Step> expSteps = new List<Step>();

            int locCount = locatorIds.Count;

            PairSet[] pairSets = new PairSet[locCount];

            // Make up stimulus-locator pairs with stimulus choices associated with locator Ids
            for(int i=0; i < locCount; i++)
            {
                pairSets[i] = new PairSet();
                ChoiceSet chset = StimulusChoiceSets[i];

                foreach (IdSelection stimChoice in chset.IdChoices)
                {
                    if (stimChoice.Selected)
                    { pairSets[i].AddStimLocPair(stimChoice.Id, locatorIds[i]); }
                }
            }

            // Construct experiment steps with permutations of those stimulus-locator pairs
            int[] index = new int[locCount];
            for (int i = 0; i < locCount; i++)
            {
                index[i] = pairSets[i].StimLocPairs.Count-1;
            }

            return expSteps;
        }
    }

    /// <summary>
    /// This class will serve as a boilerplate for one or more trials
    /// that an experiment designer wants to add to a block.
    /// When the designer presses the "Add Trial(s)" button on AddTrialView,
    /// trials with the steps formed by combinations of desired pairs
    /// will be added to the active block.
    /// </summary>
    public class TempTrial
    {
        private List<string> stimulusIds;
        public List<string> LocatorIds { get; set; }
        public ObservableCollection<TempStep> TempSteps { get; set; }

        public TempTrial()
        {
            stimulusIds = new List<string>();
            LocatorIds = new List<string>();
            TempSteps = new ObservableCollection<TempStep>();
            // Add at least one TempStep
            TempSteps.Add(new TempStep());
        }

        public void AddStimulusId(string stimId)
        { stimulusIds.Add(stimId); }

        public void AddLocatorId(string locId)
        {
            LocatorIds.Add(locId);

            foreach(TempStep tmpstp in TempSteps)
            {
                tmpstp.AddStimulusChoiceSet(stimulusIds);
            }
        }

        public void Clear()
        {
            LocatorIds.Clear();
            TempSteps.Clear();
            stimulusIds.Clear();
            // Add at least one TempStep
            TempSteps.Add(new TempStep());
        }
    }
}