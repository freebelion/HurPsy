using System.Windows.Controls;
using System.Windows;
using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    public class ItemViewTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = (FrameworkElement)container;

            if (element != null && item != null && item is ItemViewModel)
            {
                ItemViewModel itemvm = (ItemViewModel)item;

                object? itemObject = itemvm.ItemObject;

                if (itemObject != null)
                {
                    switch (itemObject)
                    {
                        case HtmlStimulus htmstim:
                            return (DataTemplate)element.FindResource("VisualStimulusItemTemplate");
                        case ImageStimulus imgstim:
                            return (DataTemplate)element.FindResource("VisualStimulusItemTemplate");
                        case PointLocator ploc:
                            return (DataTemplate)element.FindResource("PointLocatorItemTemplate");
                    }
                }
            }

            return null;
        }
    }
}