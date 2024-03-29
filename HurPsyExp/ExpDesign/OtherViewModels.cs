﻿using CommunityToolkit.Mvvm.ComponentModel;
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

    public class StimulusItemViewModel : ItemViewModel
    { 
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

        public StimulusItemViewModel(Stimulus stim) : base(stim)
        {
            tempId = stim.Id;
        }      
    }

    public class LocatorItemViewModel : ItemViewModel
    {
        public LocatorItemViewModel(Locator loc) : base(loc)
        {
            tempId = loc.Id;
        }
    }

    public class TrialItemViewModel : ItemViewModel
    {
        public TrialItemViewModel(Trial tri) : base(tri)
        {
            
        }
    }

    public partial class BlockItemViewModel : ItemViewModel
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
            int index = StimulusIds.FindIndex(s => s == oldId);
            if (index != -1)
            {
                StimulusIds[index] = newId;
                return;
            }
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
            int index = LocatorIds.FindIndex(s => s==oldId);
            if (index != -1)
            {
                LocatorIds[index] = newId;
                return;
            }
        }

        public static void DeleteLocatorId(string locId)
        {
            LocatorIds.Remove(locId);
        }

        public ObservableCollection<TrialItemViewModel> TrialVMs { get; set; }

        public BlockItemViewModel(Block blck) : base(blck)
        {
            TrialVMs = new ObservableCollection<TrialItemViewModel>();
        }

        [RelayCommand]
        public void AddingTrial(Expander blckexp)
        {
            TrialPattern.Clear();

            foreach (string stimId in StimulusIds)
            { TrialPattern.AddStimulusId(stimId); }

            foreach (string locId in LocatorIds)
            { TrialPattern.AddLocatorId(locId); }

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