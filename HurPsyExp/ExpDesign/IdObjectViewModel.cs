using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This custom `EventArgs` class will report an Id change for `IdObject` instances
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
    /// This class can serve as the viewmodel for any object of the type `IdObject` defined in `HurPsyLib`
    /// </summary>
    public partial class IdObjectViewModel : ObservableObject
    {
        #region Data members
        /// <summary>
        /// This field references the inner element of the type `IdObject`. (MVVM Toolkit generates the observable property based on this field)
        /// </summary>
        [ObservableProperty]
        private IdObject? itemObject;

        /// <summary>
        /// This field indicates the selection status of the inner element.
        /// </summary>
        [ObservableProperty]
        private bool isSelected;

        /// <summary>
        /// This field stores a temporary Id string which may end up as the final `Id` of the inner element.
        /// </summary>
        [ObservableProperty]
        private string tempId;

        /// <summary>
        /// The path of the image resource as the icon representing the inner element
        /// </summary>
        public string IconImage
        {
            get
            {
                if(ItemObject is Stimulus)
                {
                    switch(ItemObject)
                    {
                        case ImageStimulus imgstim:
                            return @"../Images/ImageStimulus.png";
                    }
                }
                else if (ItemObject is Locator)
                {
                    switch (ItemObject)
                    {
                        case PointLocator ploc:
                            return @"../Images/PointLocator.png";
                    }
                }

                return null;
            }
        }
        #endregion

        #region Constructor(s)
        /// <summary>
        /// This parametrized constructor creates a viewmodel object based on the given `IdObject` instance.
        /// </summary>
        /// <param name="innerElement">The inner element</param>
        public IdObjectViewModel(IdObject innerElement)
        {
            TempId = innerElement.Id;
            ItemObject = innerElement;
            IsSelected = false;
        }
        #endregion

        #region Commands
        /// <summary>
        /// This method serves the command that toggles the selection status in cases where `IsSelected` property is not bound to the selection  status of a visual element.
        /// </summary>
        [RelayCommand]
        private void ToggleSelect()
        {
            IsSelected = !IsSelected;
        }
        #endregion

        #region Event handler
        /// <summary>
        /// The instances of this class can issue `IdChanged` events
        /// </summary>
        public event EventHandler<IdChangeEventArgs>? IdChanged;

        /// <summary>
        /// This method issues a `IdChanged` event when the calue of `TempId` changes
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="NotImplementedException"></exception>
        partial void OnTempIdChanged(string value)
        {
            string? oldId = null;

            if (ItemObject != null)
            { oldId = ItemObject.Id; }

            string newId = value;

            IdChanged?.Invoke(this, new IdChangeEventArgs(oldId, newId));
        }
        #endregion
    }
}
