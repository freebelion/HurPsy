using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HurPsyExp;
using HurPsyLib;
using Microsoft.Windows.Themes;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This custom `EventArgs` class will report an Id change for items with Ids.
    /// </summary>
    public class IdChangeEventArgs : EventArgs
    {
        /// <summary>
        /// The previous Id string
        /// </summary>
        public string? OldId { get; set; }
        /// <summary>
        /// The new Id string
        /// </summary>
        public string? NewId { get; set; }

        /// <summary>
        /// This parametrized constructor receives the previous and new ids as arguments
        /// </summary>
        /// <param name="oldId">Yes, the value of the previous Id string</param>
        /// <param name="newId">and the value for the new Id string</param>
        public IdChangeEventArgs(string? oldId, string? newId)
        {
            OldId = oldId;
            NewId = newId;
        }
    }

    /// <summary>
    /// This abstract class is the base of viewmodel classes which simply wrap certain experiment elements.
    /// </summary>
    public abstract partial class ItemViewModel: ObservableObject
    {
        /// <summary>
        /// The instances of this class can issue `IdChanged` events
        /// </summary>
        public event EventHandler<IdChangeEventArgs>? IdChanged;

        /// <summary>
        /// `TempId` property keeps the newly modified Id until the change is validated.
        /// </summary>
        [ObservableProperty]
        protected string tempId;

        /// <summary>
        /// `Selected` property toggles the selection status of the experiment elements
        /// </summary>
        [ObservableProperty]
        protected bool selected;

        /// <summary>
        /// `Editable` property toggles the editable status of the experiment elements
        /// </summary>
        [ObservableProperty]
        protected bool editable;

        /// <summary>
        /// This field stores the reference for the actual experiment element represented by this instance
        /// </summary>
        [ObservableProperty]
        protected object? itemObject;

        /// <summary>
        /// This parametreized constructor creates an instance referencing an experiment element
        /// </summary>
        /// <param name="innerObject"></param>
        public ItemViewModel(object innerObject)
        {
            tempId = HurPsyCommon.GetObjectGuid(this);
            itemObject = innerObject;
            editable = true;
        }
    
        /// <summary>
        /// This method issues the `IdChanged` event with the newly modified `TempId`
        /// </summary>
        /// <param name="value"></param>
        partial void OnTempIdChanged(string value)
        {
            IdChanged?.Invoke(this, new IdChangeEventArgs(null, value));
        }
        
        /// <summary>
        /// This method toggles the selection status
        /// </summary>
        [RelayCommand]
        private void ToggleSelect()
        {
            Selected = !Selected;
        }
    }

    /// <summary>
    /// This viewmodel class will help data exchange between a `Stimulus` object and its `ItemView` on the design interface.
    /// </summary>
    public class StimulusItemViewModel : ItemViewModel
    {
        /// <summary>
        /// This property returns the path of the image file which will serve as the icon representing the stimulus type
        /// </summary>
        public string IconImage
        {
            get
            {
                if(ItemObject != null && ItemObject is Stimulus)
                {
                    switch ((Stimulus)ItemObject)
                    {
                        case HtmlStimulus htmstim:
                            return @"../Images/HtmlStimulus.png";
                        case ImageStimulus imgstim:
                            return @"../Images/ImageStimulus.png";
                    }
                }

                return string.Empty;
            }
        }

        /// <summary>
        /// This parametrized constructor creates an `ItemViewModel` instance associated with the given `Stimulus` object 
        /// </summary>
        /// <param name="stim">The `Stimulus` object which will be associated with this viewmodel</param>
        public StimulusItemViewModel(Stimulus stim) : base(stim)
        {
            tempId = stim.Id;
        }      
    }

    /// <summary>
    /// This viewmodel class will help data exchange between a `Locator` object and its `ItemView` on the design interface.
    /// </summary>
    public class LocatorItemViewModel : ItemViewModel
    {
        /// <summary>
        /// This parametrized constructor creates an `ItemViewModel` instance associated with the given `Locator` object
        /// </summary>
        /// <param name="loc">The `Locator` object which will be associated with this viewmodel</param>
        public LocatorItemViewModel(Locator loc) : base(loc)
        {
            tempId = loc.Id;
        }
    }

    /// <summary>
    /// This viewmodel class will help data exchange between a `Trial` object and its `ItemView` on the design interface.
    /// </summary>
    public class TrialItemViewModel : ItemViewModel
    {
        /// <summary>
        /// This parametrized constructor creates an `ItemViewModel` instance associated with the given `Trial` object
        /// </summary>
        /// <param name="tri"></param>
        public TrialItemViewModel(Trial tri) : base(tri)
        {
            
        }
    }

    /// <summary>
    /// This viewmodel class will help data exchange between a `Block` object and its `ItemView` on the design interface.
    /// </summary>
    public partial class BlockItemViewModel : ItemViewModel
    {
        /// <summary>
        /// The list of `Stimulus` Ids used in all the trial blocks
        /// </summary>
        public static List<string> StimulusIds = new List<string>();

        /// <summary>
        /// The list of `Locator` Ids used in all the trial blocks
        /// </summary>
        public static List<string> LocatorIds = new List<string>();
        
        /// <summary>
        /// This static method adds a stimulus Id to the list shared by all the blocks
        /// </summary>
        /// <param name="stimId">The stimulus Id to be added</param>
        public static void AddStimulusId(string stimId)
        {
            StimulusIds.Add(stimId);
        }

        /// <summary>
        /// This static method will handle an Id change for a stimulus
        /// </summary>
        /// <param name="oldId">The previous Id string for the stimulus</param>
        /// <param name="newId">The new Id string for the stimulus</param>
        public static void ReplaceStimulusId(string oldId, string newId)
        {
            int index = StimulusIds.FindIndex(s => s == oldId);
            if (index != -1)
            {
                StimulusIds[index] = newId;
                return;
            }
        }

        /// <summary>
        /// This static method will remove a stimulus with the given Id from the list chared by all the trial blocks
        /// </summary>
        /// <param name="stimId">The Id of the stimulus to be removed</param>
        public static void DeleteStimulusId(string stimId)
        {
            StimulusIds.Remove(stimId);
        }

        /// <summary>
        /// This static method adds a locator Id to the list shared by all the blocks
        /// </summary>
        /// <param name="locId">The locator Id to be added</param>
        public static void AddLocatorId(string locId)
        {
            LocatorIds.Add(locId);
        }

        /// <summary>
        /// This static method will handle an Id change for a locator
        /// </summary>
        /// <param name="oldId">The previous Id string for the locator</param>
        /// <param name="newId">The new Id string for the locator</param>
        public static void ReplaceLocatorId(string oldId, string newId)
        {
            int index = LocatorIds.FindIndex(s => s==oldId);
            if (index != -1)
            {
                LocatorIds[index] = newId;
                return;
            }
        }

        /// <summary>
        /// This static method will remove a locator with the given Id from the list chared by all the trial blocks
        /// </summary>
        /// <param name="locId">The Id of the locator to be removed</param>
        public static void DeleteLocatorId(string locId)
        {
            LocatorIds.Remove(locId);
        }

        /// <summary>
        /// The viewmodel objects associated with the block trials
        /// </summary>
        public ObservableCollection<TrialItemViewModel> TrialVMs { get; set; }

        /// <summary>
        /// This parametrized constructor creates an `ItemViewModel` instance associated with the given `Block` object
        /// </summary>
        /// <param name="blck"></param>
        public BlockItemViewModel(Block blck) : base(blck)
        {
            TrialVMs = new ObservableCollection<TrialItemViewModel>();
        }

        /// <summary>
        /// This property will act as an intermediary while adding experiment trials according to a pattern
        /// </summary>
        public TempTrial TrialPattern { get; set; } = new TempTrial();

        /// <summary>
        /// This method handles the process of adding new trials
        /// </summary>
        /// <param name="blckexp"></param>
        [RelayCommand]
        public void AddingTrial(Expander blckexp)
        {
            // Clear any previous trial patterns
            TrialPattern.Clear();

            // Add the `Stimulus` Ids that will be used to form new trials
            foreach (string stimId in StimulusIds)
            { TrialPattern.AddStimulusId(stimId); }

            // Add the `Locator` Ids that will be used to form new trials
            foreach (string locId in LocatorIds)
            { TrialPattern.AddLocatorId(locId); }

            // Create and displ;ay the dialog form which will let the end user to decide on the new trials' pattern
            AddTrialDialog dlgAddTrial = new AddTrialDialog();
            dlgAddTrial.DataContext = TrialPattern;
            // TODO: Think of the best way to keep the dialog window
            // wholly visible on the screen.
            dlgAddTrial.WindowStartupLocation = WindowStartupLocation.Manual;
            Point dlgloc = blckexp.PointToScreen(new Point(0,0));
            dlgAddTrial.Left = dlgloc.X;
            dlgAddTrial.Top = dlgloc.Y;
            dlgAddTrial.Width = blckexp.ActualWidth;

            if(dlgAddTrial.ShowDialog() == true)
            { AddedTrial(); }
        }

        /// <summary>
        /// This method will add a new step to a selected trial
        /// (but it won't be used until multi-step trials are implemented)
        /// </summary>
        [RelayCommand]
        public void AddStep()
        {
            // not tied to anything yet
        }

        /// <summary>
        /// This method will take care of the final actions after some trials have been added to the block
        /// </summary>
        private void AddedTrial()
        {
            // TODO: Add the instructions to produce trials with steps,
            // according to the combinations of Stimulus and Locator choices
            // in the TrialPattern object
            List<Step> steplist = TrialPattern.SingleStep.ConstructExperimentSteps(TrialPattern.LocatorIds);
            
            Block? blck = this.ItemObject as Block;

            if(blck != null)
            {
                // Construct single-step experiment trials by permuting the combinations in steplist
                foreach (Step stp in steplist)
                {
                    Trial trl = new Trial();
                    trl.AddStep(stp);
                    trl.IsFixed = TrialPattern.CanShuffle;
                    blck.AddTrial(trl);
                    this.TrialVMs.Add(new TrialItemViewModel(trl));
                }
            }

            // clear out the temporary trial object
            TrialPattern.Clear();
        }

        /// <summary>
        /// This method will handle a stimulus Id change within the block represented by this object
        /// </summary>
        /// <param name="oldId"></param>
        /// <param name="newId"></param>
        public void ChangeStimulusId(string oldId, string newId)
        {
            foreach(TrialItemViewModel trivm in this.TrialVMs)
            {
                Trial? trl = trivm.ItemObject as Trial;
                if(trl != null)
                {
                    trl.ChangeStimulusId(oldId, newId);
                }
            }
            // Since we weren't using viewmodels for Step objects,
            // we now need to refresh the list of TrialViewModel objects.
            RefreshTrialVMs();
        }

        /// <summary>
        /// This method will handle a locator Id change within the block represented by this object
        /// </summary>
        /// <param name="oldId"></param>
        /// <param name="newId"></param>
        public void ChangeLocatorId(string oldId, string newId)
        {
            foreach (TrialItemViewModel trivm in this.TrialVMs)
            {
                Trial? trl = trivm.ItemObject as Trial;
                if (trl != null)
                {
                    trl.ChangeLocatorId(oldId, newId);
                }
            }
            // Since we weren't using viewmodels for Step objects,
            // we now need to refresh the list of TrialViewModel objects.
            RefreshTrialVMs();
        }

        /// <summary>
        /// This private method will recreate the viewmodel objects associated with the block trials
        /// </summary>
        private void RefreshTrialVMs()
        {
            TrialVMs.Clear();

            Block? blck = this.ItemObject as Block;

            if (blck != null)
            {
                foreach(Trial trl in blck.Trials)
                {
                    this.TrialVMs.Add(new TrialItemViewModel(trl));
                }
            }
        }
    }
}