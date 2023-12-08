using System.Windows.Controls;
using System.Windows;
using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    public class StimulusTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object stim, DependencyObject container)
        {
            FrameworkElement element = (FrameworkElement)container;

            if (element != null && stim != null && stim is Stimulus)
            {
                switch (stim)
                {
                    case ImageStimulus imgstim:
                        return (DataTemplate)element.FindResource("ImageStimulusTemplate");
                }
            }

            return null;
        }
    }

    public class LocatorTemplateSelector : DataTemplateSelector
    {
        public override DataTemplate SelectTemplate(object loc, DependencyObject container)
        {
            FrameworkElement element = (FrameworkElement)container;

            if (element != null && loc != null && loc is Locator)
            {
                switch (loc)
                {
                    case PointLocator ploc:
                        return (DataTemplate)element.FindResource("PointLocatorTemplate");
                }
            }

            return null;
        }
    }
}