﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HurPsyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;

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
        /// <param name="oldId">previous Id string</param>
        /// <param name="newId">new Id string</param>
        public IdChangeEventArgs(string? oldId, string? newId)
        {
            OldId = oldId;
            NewId = newId;
        }
    }

    /// <summary>
    /// This abstract class is the base of viewmodel classes which simply wrap certain experiment elements.
    /// </summary>
    public partial class IdObjectViewModel : ObservableObject
    {
        #region Members and properties
        /// <summary>
        /// The path of the image file for the icon representing the inner element
        /// </summary>
        public string IconImage
        {
            get
            {
                switch (ItemObject)
                {
                    case ImageStimulus imgstim:
                        return @"../Images/ImageStimulus.png";
                    case PointLocator ploc:
                        return @"../Images/PointLocator.png";
                    case ExpBlock blck:
                        return @"../Images/block.png";
                    case ExpTrial tr:
                        return @"../Images/trial.png";
                }

                return string.Empty;
            }
        }

        /// <summary>
        /// `TempId` property keeps the newly modified Id until the change is validated.
        /// </summary>
        [ObservableProperty]
        private string tempId;

        /// <summary>
        /// `Selected` property toggles the selection status of the experiment elements
        /// </summary>
        [ObservableProperty]
        private bool selected;

        /// <summary>
        /// `Editable` property toggles the editable status of the experiment elements
        /// </summary>
        [ObservableProperty]
        private bool editable;

        /// <summary>
        /// This field stores the reference for the actual experiment element represented by this instance
        /// </summary>
        [ObservableProperty]
        private IdObject itemObject;
        #endregion

        #region Constructor(s)
        /// <summary>
        /// This parametrized constructor creates a viewmodel instance referencing an experiment element
        /// </summary>
        /// <param name="innerObject"></param>
        public IdObjectViewModel(IdObject innerObject)
        {
            ItemObject = innerObject;
            tempId = ItemObject.Id;
            Editable = false;
            Selected = false;
        }
        #endregion

        #region Events
        /// <summary>
        /// The instances of this class can issue `IdChanged` events when a new Id is to be assigned to the inner element.
        /// </summary>
        public event EventHandler<IdChangeEventArgs>? IdChanged;

        /// <summary>
        /// This method issues the `IdChanged` event with the newly modified `TempId`
        /// </summary>
        /// <param name="value"></param>
        partial void OnTempIdChanged(string value)
        {
            IdChanged?.Invoke(this, new IdChangeEventArgs(ItemObject.Id, value));
        }

        #endregion

        #region Commands
        /// <summary>
        /// This method toggles the selection status
        /// </summary>
        [RelayCommand]
        private void ToggleSelect()
        {
            Selected = !Selected;
        }
        #endregion
    }
}
