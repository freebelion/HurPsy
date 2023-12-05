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
}
