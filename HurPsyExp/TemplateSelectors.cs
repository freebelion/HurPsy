using System.Windows.Controls;
using System.Windows;
using HurPsyLib;
using HurPsyExp.ExpDesign;
using HurPsyExp.ExpRun;

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
                        case HtmlStimulus htmstim:
                            return (DataTemplate)element.FindResource("VisualStimulusTemplate");
                        case ImageStimulus imgstim:
                            return (DataTemplate)element.FindResource("VisualStimulusTemplate");
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

    public class StimulusViewTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate? SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = (FrameworkElement)container;

            if (element != null && item != null && item is StimulusViewModel)
            {
                StimulusViewModel stimvm = (StimulusViewModel)item;

                Stimulus? stimObject = stimvm.InnerStimulus;

                if (stimObject != null)
                {
                    switch (stimObject)
                    {
                        case ImageStimulus imgstim:
                            return (DataTemplate)element.FindResource("ImageStimulusTemplate");
                        case HtmlStimulus htmstim:
                            return (DataTemplate)element.FindResource("HtmlStimulusTemplate");
                    }
                }
            }

            return null;
        }
    }
}