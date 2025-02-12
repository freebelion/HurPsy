using CommunityToolkit.Mvvm.ComponentModel;
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
    public abstract partial class ItemViewModel : ObservableObject
    {
        /// <summary>
        /// The instances of this class can issue `IdChanged` events
        /// </summary>
        public event EventHandler<IdChangeEventArgs>? IdChanged;

        /// <summary>
        /// When overriden by a derived class, this property will return the path of the image file for the icon representing the ItemObject
        /// </summary>
        public abstract string IconImage {  get; }

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
}
