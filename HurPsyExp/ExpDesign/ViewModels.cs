using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HurPsyLib;
using System.Collections.ObjectModel;
using System.Security.Cryptography;

namespace HurPsyExp.ExpDesign
{
    public abstract partial class ItemViewModel: ObservableObject
    {
        [ObservableProperty]
        private string id;

        [ObservableProperty]
        private bool selected;

        [ObservableProperty]
        private object? itemObject;

        public ItemViewModel(object innerObject)
        {
            Id = string.Empty;
            ItemObject = innerObject;
        }

        // By intervening in the auto-generated event handler of the Mvvm toolkit,
        // I should be able to do the necessary updating in the places where the old Id was used.
        partial void OnIdChanged(string? oldValue, string newValue)
        {
            
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
            Id = stim.Id;
        }      
    }

    public class LocatorViewModel : ItemViewModel
    {
        public LocatorViewModel(Locator loc) : base(loc)
        {
            Id = loc.Id;
        }
    }

    public class TrialViewModel : ItemViewModel
    {
        public TrialViewModel(Trial tri) : base(tri)
        {
            
        }
    }

    public class BlockViewModel : ItemViewModel
    {
        public ObservableCollection<TrialViewModel> TrialVMs { get; set; }

        public BlockViewModel(Block blck) : base(blck)
        {
            TrialVMs = new ObservableCollection<TrialViewModel>();
        }
    }
}