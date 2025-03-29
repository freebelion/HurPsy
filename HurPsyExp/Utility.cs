using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace HurPsyExp
{
    /// <summary>
    /// This class is actually a collection of static methods that will be used throughout the application.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// This function will open a open-file selection dialog and return the selected files' paths as an array of strings
        /// </summary>
        /// <param name="filenameFilter">The filename filter for the file selection dialog</param>
        /// <param name="openMultiple">The boolean flag indicating if multiple selections are permitted</param>
        /// <returns>An array containing the chosen files' paths</returns>
        public static string[]? OpenFiles(string filenameFilter, bool openMultiple)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = filenameFilter;
            opf.Multiselect = openMultiple;
            opf.InitialDirectory = Directory.GetCurrentDirectory();

            if (opf.ShowDialog() == true)
            { return opf.FileNames; }
            else { return null; }
        }

        /// <summary>
        /// This function will open a save-file selection dialog and return the selected file' path as a string
        /// </summary>
        /// <param name="filenameFilter">The filename filter for the file selection dialog</param>
        /// <returns>The full path for the file</returns>
        public static string? FileSaveName(string filenameFilter)
        {
            SaveFileDialog svf = new SaveFileDialog();
            svf.Filter = filenameFilter;

            if (svf.ShowDialog() == true)
            {
                return svf.FileName;
            }
            else { return null; }
        }
    }
}
