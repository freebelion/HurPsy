using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Xml.Linq;
using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This class will select a template for the viewmodel of the item that is being displayed or edited.
    /// </summary>
    class ItemTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// This property is a boolean flag indicating if an editing template is to be selected.
        /// </summary>
        public bool ItemEdit { get; set; } = false;

        /// <summary>
        /// This is the implementation of the template selection method of the base class.
        /// </summary>
        /// <param name="item">The item to be dipslayed as is or for editing</param>
        /// <param name="container">The container of the item</param>
        /// <returns>The correct template associated with the item</returns>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = (FrameworkElement)container;
            
            return null;
        }
    }
}
