﻿using System;
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
    /// This class will select a template for an experiment item of `IdObject` type.
    /// </summary>
    class IdObjectEditTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// This is the implementation of the template selection method of the base class.
        /// </summary>
        /// <param name="item">The item to be dipslayed as is or for editing</param>
        /// <param name="container">The container of the item</param>
        /// <returns>The correct template associated with the item</returns>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = (FrameworkElement)container;
            
            IdObjectViewModel? idobjvm = item as IdObjectViewModel;

            if (idobjvm != null)
            {
                switch (idobjvm.ItemObject)
                {
                    case ImageStimulus imgstim:
                        return (DataTemplate)element.FindResource("ImageStimulusEditTemplate");
                    case PointLocator ploc:
                        return (DataTemplate)element.FindResource("PointLocatorEditTemplate");
                    case ExpBlock blck:
                        return (DataTemplate)element.FindResource("BlockEditTemplate");
                }
            }

            return null;
        }
    }
}
