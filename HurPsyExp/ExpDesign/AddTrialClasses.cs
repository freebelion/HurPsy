using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This class represents a set of `Locator`-`Stimulus` Id pairs selected by the user on **AddTrialPopup**
    /// </summary>
    public partial class IdPairSet
    {
        /// <summary>
        /// `Locator` Id selected by the user
        /// </summary>
        public string? LocatorId {  get; set; }

        /// <summary>
        /// The number of times this Id pairing set will be repeated (for each one of `SelectedStimulusIds`)
        /// </summary>
        public int RepeatCount { get; set; }

        /// <summary>
        /// The collection of `Stimulus` Ids which will be paired with the selected `Locator` Id
        /// </summary>
        public ObservableCollection<string> SelectedStimulusIds { get; set; }

        /// <summary>
        /// Default constructor starts with defaults
        /// </summary>
        public IdPairSet()
        {
            LocatorId = null;
            RepeatCount = 1;
            SelectedStimulusIds = [];
        }

        /// <summary>
        /// This command implementation handles the `SelectionChanged` event in the `ListBox` displaying `Stimulus` Ids
        /// </summary>
        /// <param name="e"></param>
        [RelayCommand]
        private void IdSelectionChanged(SelectionChangedEventArgs e)
        {
            // Add the newly selected Ids
            foreach(string idstr in e.AddedItems)
            { SelectedStimulusIds.Add(idstr); }

            // Remove the unselected Ids
            foreach (string idstr in e.RemovedItems)
            { SelectedStimulusIds.Remove(idstr); }
        }
    }

    /// <summary>
    /// This class represents the pattern the for multiple trials to be added according to the Id-pair sets decided by the user.
    /// </summary>
    public partial class TrialPattern
    {
        /// <summary>
        /// The collection of id-pair sets
        /// </summary>
        public ObservableCollection<IdPairSet> IdPairSets { get; set; }

        /// <summary>
        /// The default consturctor starts with an empty list of sets
        /// </summary>
        public TrialPattern()
        {
            IdPairSets = [];
        }

        /// <summary>
        /// This command implementation creates a new Id-pair set which shows up on **AddTrialPopup**
        /// </summary>
        [RelayCommand]
        private void AddIdPairSet()
        {
            IdPairSets.Add(new IdPairSet());
        }

        /// <summary>
        /// This method will construct an array of steps to be used in multiple single-step trials.
        /// </summary>
        /// <returns></returns>
        public List<ExpStep> ConstructTrialSteps()
        {
            List<List<ExpPair>> pairLists = new List<List<ExpPair>>();

            foreach(IdPairSet idprset in IdPairSets)
            {
                if (idprset.LocatorId == null) continue;

                List<ExpPair> pairList = new List<ExpPair>();

                foreach(string stimId in idprset.SelectedStimulusIds)
                {
                    pairList.Add(new ExpPair(idprset.LocatorId, stimId));
                }

                if (pairList.Count > 0)
                { pairLists.Add(pairList); }
            }

            List<ExpStep> expSteps = new List<ExpStep>();
            if (pairLists.Count == 0) { return expSteps; }

            // Construct experiment steps with permutations of those stimulus-locator pairs
            List<ExpPair[]> pairPerms = Utility.GetPermutations(pairLists);

            foreach (ExpPair[] pairSet in pairPerms)
            {
                ExpStep stp = new ExpStep();
                stp.AddPairs(pairSet);
                expSteps.Add(stp);
            }
            return expSteps;
        }
    }
}
