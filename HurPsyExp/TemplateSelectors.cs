using System.Windows.Controls;
using System.Windows;
using HurPsyLib;
using HurPsyExp.ExpDesign;

namespace HurPsyExp
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
                        case ImageStimulus imgstim:
                            return (DataTemplate)element.FindResource("ImageStimulusTemplate");
                        case PointLocator ploc:
                            return (DataTemplate)element.FindResource("PointLocatorTemplate");
                        case Block blck:
                            return (DataTemplate)element.FindResource("BlockTemplate");
                        case Trial tri:
                            return (DataTemplate)element.FindResource("TrialTemplate");
                    }
                }
            }

            return null;
        }
    }
}