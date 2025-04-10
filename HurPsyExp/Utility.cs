﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using HurPsyLib;
using System.Xml;
using Microsoft.Win32;

namespace HurPsyExp
{
    /// <summary>
    /// This class is actually a collection of static methods that will be used throughout the application.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Application-wide pseudo-RNG
        /// </summary>
        public static Random RND { get; private set; } = new Random(Guid.NewGuid().GetHashCode());

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

        /// <summary>
        /// A generic method to save an object onto an XML file
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="obj">The object to be saved (serialized)</param>
        /// <param name="savefilename">The path of the file</param>
        public static void SaveToXml<T>(T obj, string savefilename)
        {
            DataContractSerializer ser = new DataContractSerializer(typeof(T));
            XmlWriterSettings xmlset = new XmlWriterSettings { Indent = true };
            // Using the shorcuts suggested by Visual Stuido here; noobs like me must be careful!
            using FileStream fs = File.Open(savefilename, FileMode.Create);
            using var writer = XmlWriter.Create(fs, xmlset);
            ser.WriteObject(writer, obj);
        }

        /// <summary>
        /// A generic method to load an object from an XML file.
        /// </summary>
        /// <typeparam name="T">Object type</typeparam>
        /// <param name="openfilename">The path of the file</param>
        /// <returns></returns>
        public static T? LoadFromXml<T>(string openfilename)
        {
            using XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(new FileStream(openfilename, FileMode.Open), new XmlDictionaryReaderQuotas());
            DataContractSerializer ser = new DataContractSerializer(typeof(T));
            return (T?)ser.ReadObject(reader);
        }
    }
}
