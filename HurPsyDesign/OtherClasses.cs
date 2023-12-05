using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HurPsyLib;
using System.Windows.Controls;
using System.Windows;
using Microsoft.Win32;

namespace HurPsyDesign
{
    public enum FileOperationMode
    {
        NewFile,
        OpenFile,
        SaveFile
    }

    public static class UtilityClass
    {
        public static string[]? OpenFiles(string filenameFilter, bool openMultiple)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = filenameFilter;
            opf.Multiselect = openMultiple;
            opf.InitialDirectory = Directory.GetCurrentDirectory();

            if(opf.ShowDialog() == true)
            { return opf.FileNames; }
            else { return null; }
        }

        public static string? FileSaveName(string filenameFilter)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = filenameFilter;
            
            if(svf.ShowDialog() == true)
            {
                return svf.FileName;
            }
            else { return null; }
        }
    }

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

    public class AppSettings
    {

    }
}
