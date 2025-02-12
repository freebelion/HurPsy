using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This viewmodel class will help data exchange between a `Block` object and its `ItemView` on the design interface.
    /// </summary>
    public class BlockItemViewModel : ItemViewModel
    {
        /// <summary>
        /// This parametrized constructor creates an `ItemViewModel` instance associated with the given `Block` object
        /// </summary>
        /// <param name="blck"></param>
        public BlockItemViewModel(Block blck) : base(blck)
        {
            TempId = blck.Id;
        }

        /// <summary>
        /// This property returns the path of the image file which will serve as the icon representing a trial block
        /// </summary>
        public override string IconImage
        {
            get
            {
                if (ItemObject != null && ItemObject is Block)
                {
                   return @"../Images/AddBlock.png";
                }

                return string.Empty;
            }
        }
    }
}
