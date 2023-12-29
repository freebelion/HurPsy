using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HurPsyLib;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Windows;
using System.Windows.Controls;

namespace HurPsyExp.ExpDesign
{
    // Custom EventArgs class for raising events about Id changes
    public class IdChangeEventArgs : EventArgs
    {
        public string? OldId { get; set; }
        public string? NewId { get; set; }

        public IdChangeEventArgs(string? oldId, string? newId)
        {
            OldId = oldId;
            NewId = newId;
        }
    }

    /// <summary>
    /// This abstract class is the base of viewmodel classes
    /// which simply wrap certain model objects.
    /// It has the ability to toggle a boolean property Selected
    /// and a TempId property to serve as a proxy
    /// for the Id properties of Stimulus and Locator objects.
    /// </summary>
    public abstract partial class ItemViewModel: ObservableObject
    {
        public event EventHandler<IdChangeEventArgs>? IdChanged;

        [ObservableProperty]
        protected string tempId;

        [ObservableProperty]
        protected bool selected;

        [ObservableProperty]
        protected bool editable;

        [ObservableProperty]
        protected object? itemObject;

        public ItemViewModel(object innerObject)
        {
            tempId = HurPsyCommon.GetObjectGuid(this);
            itemObject = innerObject;
            editable = true;
        }
    
        partial void OnTempIdChanged(string value)
        {
            IdChanged?.Invoke(this, new IdChangeEventArgs(null, value));
        }
        
        [RelayCommand]
        private void ToggleSelect()
        {
            Selected = !Selected;
        }
    }

    public class StimulusViewModel : ItemViewModel
    {      
        public StimulusViewModel(Stimulus stim) : base(stim)
        {
            tempId = stim.Id;
        }      
    }

    public class LocatorViewModel : ItemViewModel
    {
        public LocatorViewModel(Locator loc) : base(loc)
        {
            tempId = loc.Id;
        }
    }

    public class TrialViewModel : ItemViewModel
    {
        public TrialViewModel(Trial tri) : base(tri)
        {
            
        }
    }

    public partial class BlockViewModel : ItemViewModel
    {
        public static List<string> StimulusIds = new List<string>();
        public static List<string> LocatorIds = new List<string>();
        
        public static void AddStimulusId(string stimId)
        {
            StimulusIds.Add(stimId);
        }

        public TempTrial TrialPattern { get; set; } = new TempTrial();

        public static void ReplaceStimulusId(string oldId, string newId)
        {
            string? idstr = StimulusIds.Find(id => id==oldId);
            if(idstr != null) { idstr = newId; return; }
        }

        public static void DeleteStimulusId(string stimId)
        {
            StimulusIds.Remove(stimId);
        }

        public static void AddLocatorId(string locId)
        {
            LocatorIds.Add(locId);
        }

        public static void ReplaceLocatorId(string oldId, string newId)
        {
            string? idstr = LocatorIds.Find(id => id == oldId);
            if (idstr != null) { idstr = newId; return; }
        }

        public static void DeleteLocatorId(string locId)
        {
            LocatorIds.Remove(locId);
        }

        public ObservableCollection<TrialViewModel> TrialVMs { get; set; }

        public BlockViewModel(Block blck) : base(blck)
        {
            TrialVMs = new ObservableCollection<TrialViewModel>();
        }

        [RelayCommand]
        public void AddingTrial(Expander blckexp)
        {
            foreach(string stimId in StimulusIds)
            { TrialPattern.AddStimulusId(stimId); }

            foreach (string locId in LocatorIds)
            { TrialPattern.AddLocatorId(locId); }

            AddTrialDialog dlgAddTrial = new AddTrialDialog();
            dlgAddTrial.DataContext = this;
            // TODO: If it wil make sense, display the temporary dialog
            // right on the BlockView instance associated with this view model.
            dlgAddTrial.WindowStartupLocation = WindowStartupLocation.Manual;
            Point dlgloc = blckexp.PointToScreen(new Point(0,0));
            dlgAddTrial.Left = dlgloc.X;
            dlgAddTrial.Top = dlgloc.Y;
            dlgAddTrial.Width = blckexp.ActualWidth;

            if(dlgAddTrial.ShowDialog() == true)
            { AddedTrial(); }
        }

        [RelayCommand]
        public void AddStep()
        {
            // not tied to anything yet
        }

        private void AddedTrial()
        {
            // TODO: Add the instructions to produce trials with steps,
            // according to the combinations of Stimulus and Locator choices
            // in the TrialPattern object
            foreach (TempStep tmpstp in TrialPattern.TempSteps)
            {
                tmpstp.ConstructExperimentSteps(TrialPattern.LocatorIds);
            }

            // clear out the temporary trial object
            TrialPattern.Clear();
        }
    }
}