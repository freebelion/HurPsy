using CommunityToolkit.Mvvm.Input;
using HurPsyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This viewmodel class will help data exchange between a `Block` object and its `ItemView` on the design interface.
    /// </summary>
    public partial class BlockItemViewModel : ItemViewModel<Block>
    {
        /// <summary>
        /// This default constructor initializes the class properties after referring to the base class constructor.
        /// </summary>
        /// <param name="blck"></param>
        public BlockItemViewModel(Block blck) : base(blck)
        {
        }

        /// <summary>
        /// This method handles the process of adding new trials
        /// </summary>
        [RelayCommand]
        public void AddingTrial(ItemViewModel<Block> blckvm)
        {
            // Construct a TrialPattern object which will host the Stimulus&Locator choices and the planned new trials
            TrialPattern trPattern = new();
            
            
        }
    }
}
