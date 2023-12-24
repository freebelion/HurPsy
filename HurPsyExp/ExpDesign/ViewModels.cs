using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HurPsyLib;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using System.Windows;

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

    public class IdSelection
    {
        public bool Selected { get; set; }
        public string Id { get; set; }

        public IdSelection()
        { Selected = false; Id = string.Empty; }

        public IdSelection(string id, bool idsel = false)
        { Selected = idsel; Id = id; }
    }

    public partial class BlockViewModel : ItemViewModel
    {
        public static List<IdSelection> StimulusSelections = new List<IdSelection>();
        public static List<IdSelection> LocatorSelections = new List<IdSelection>();

        public static void AddStimulusSelection(string stimId)
        {
            StimulusSelections.Add(new IdSelection(stimId));
        }

        public static void AddLocatorSelection(string locId)
        {
            LocatorSelections.Add(new IdSelection(locId));
        }

        [ObservableProperty]
        private bool showAddTrial;

        public ObservableCollection<TrialViewModel> TrialVMs { get; set; }

        public BlockViewModel(Block blck) : base(blck)
        {
            TrialVMs = new ObservableCollection<TrialViewModel>();
        }

        [RelayCommand]
        public void AddingTrial()
        {
            ShowAddTrial = true;
        }

        [RelayCommand]
        public void AddStep()
        {

        }

        [RelayCommand]
        public void AddTrial()
        {
            ShowAddTrial = false;
        }
    }
}