using System.Windows.Controls;
using System.Windows;
using HurPsyLib;
using System.CodeDom;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This custom template selector chooses between stimulus and locator definition templates for the `ContentControl` in `ItemViewTemplate` shared by all items.
    /// </summary>
    public class ItemViewTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// This function overrides the `SelectTemplate` to return the correct item template.
        /// </summary>
        /// <param name="item"></param>
        /// <param name="container"></param>
        /// <returns></returns>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = (FrameworkElement)container;

            if (element != null && item != null)
            {
                if(item is ItemViewModel<Stimulus>)
                {
                    ItemViewModel<Stimulus> stimvm = (ItemViewModel<Stimulus>)item;
                    
                    switch (stimvm.ItemObject)
                    {
                        case HtmlStimulus htmstim:
                            return (DataTemplate)element.FindResource("HtmlStimulusItemTemplate");
                        case ImageStimulus imgstim:
                            return (DataTemplate)element.FindResource("ImageStimulusItemTemplate");
                    }
                }

                else if (item is ItemViewModel<Locator>)
                {
                    ItemViewModel<Locator> locvm = (ItemViewModel<Locator>)item;

                    switch (locvm.ItemObject)
                    {
                        case PointLocator ploc:
                            return (DataTemplate)element.FindResource("PointLocatorItemTemplate");
                    }
                }
            }

            return null;
        }
    }
}