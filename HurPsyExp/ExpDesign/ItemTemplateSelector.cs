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
    class ItemTemplateSelector : DataTemplateSelector
    {
        public bool ItemEdit { get; set; } = false;
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = (FrameworkElement)container;
            IdObjectViewModel? idobjvm = item as IdObjectViewModel;

            if (!ItemEdit)
            {
                return (DataTemplate)element.FindResource("ItemDisplayTemplate");
            }

            if (idobjvm != null)
            {
                IdObject? innerElement = idobjvm.ItemObject;

                if (innerElement != null)
                {
                    if (innerElement is Stimulus)
                    {
                        switch (innerElement)
                        {
                            case ImageStimulus imgstim:
                                return (DataTemplate)element.FindResource("ImageStimulusEditTemplate");
                        }
                    }

                    else if (innerElement is Locator)
                    {
                        switch (innerElement)
                        {
                            case PointLocator ploc:
                                return (DataTemplate)element.FindResource("PointLocatorEditTemplate");
                        }
                    }
                }
            }

            return null;
        }
    }
}
