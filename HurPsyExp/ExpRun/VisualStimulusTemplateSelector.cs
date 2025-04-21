using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using HurPsyExp.ExpDesign;
using HurPsyLib;

namespace HurPsyExp.ExpRun
{
    public class VisualStimulusTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// This is the implementation of the template selection method of the base class.
        /// </summary>
        /// <param name="item">The viewmodel of the visual stimulus</param>
        /// <param name="container">The container which will display the visual stimulus</param>
        /// <returns>The correct template associated with the visual stimulus</returns>
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            FrameworkElement element = (FrameworkElement)container;

            VisualStimulusViewModel? vistimvm = item as VisualStimulusViewModel;

            if (vistimvm != null)
            {
                switch (vistimvm.VisualObject)
                {
                    case double dbl:
                        return (DataTemplate)element.FindResource("VisualGridTemplate");
                    case BitmapImage bmp:
                        return (DataTemplate)element.FindResource("ImageStimulusTemplate");
                }
            }

            return null;
        }
    }
}
