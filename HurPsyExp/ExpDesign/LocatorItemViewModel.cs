using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
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
            TempId = loc.Id;
        }

        /// <summary>
        /// This property returns the path of the image file which will serve as the icon representing the stimulus type
        /// </summary>
        public override string IconImage
        {
            get
            {
                if (ItemObject != null && ItemObject is Locator)
                {
                    switch ((Locator)ItemObject)
                    {
                        case PointLocator ploc:
                            return @"../Images/PointLocator.png";
                    }
                }

                return string.Empty;
            }
        }
    }
}