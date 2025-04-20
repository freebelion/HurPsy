using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using HurPsyLib;
using System.Xml;
using Microsoft.Win32;
using System.Windows.Media;
using System.Windows;
using System.Windows.Media.Imaging;

namespace HurPsyExp
{
    /// <summary>
    /// This class is actually a collection of static methods that will be used throughout the application.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Millimeters to DIU conversion ratio
        /// </summary>
        public const double MM2DIU = 3.77952755;

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

        /// <summary>
        /// This function will load and return a bitmap image from the file at the given path
        /// </summary>
        /// <param name="filename">The path of the file containing the image</param>
        /// <returns>The image object</returns>
        public static BitmapImage LoadImage(string filename)
        {// source: https://www.ridgesolutions.ie/index.php/2012/02/03/net-wpf-bitmapimage-file-locking
            BitmapImage bmpImage = new BitmapImage();
            var stream = File.OpenRead(filename);
            bmpImage.BeginInit();
            bmpImage.CacheOption = BitmapCacheOption.OnLoad;
            bmpImage.StreamSource = stream;
            bmpImage.EndInit();
            stream.Close();
            stream.Dispose();
            return bmpImage;
        }

        /// <summary>
        /// Recursively finds the specified named parent in a control hierarchy
        /// Source: https://stackoverflow.com/questions/15198104/find-parent-of-control-by-name
        /// </summary>
        /// <typeparam name="T">The type of the targeted Find</typeparam>
        /// <param name="child">The child control to start with</param>
        /// <param name="parentName">The name of the parent to find</param>
        /// <returns></returns>
        public static T FindParent<T>(DependencyObject child, string parentName)
            where T : DependencyObject
        {
            if (child == null) return null;

            T? foundParent = null;
            var currentParent = VisualTreeHelper.GetParent(child);

            do
            {
                var frameworkElement = currentParent as FrameworkElement;
                if (frameworkElement != null && frameworkElement.Name == parentName && frameworkElement is T)
                {
                    foundParent = (T)currentParent;
                    break;
                }

                currentParent = VisualTreeHelper.GetParent(currentParent);

            } while (currentParent != null);

            return foundParent;
        }

        /// <summary>
        /// Finds a Child of a given item in the visual tree. 
        /// Source: https://stackoverflow.com/questions/636383/how-can-i-find-wpf-controls-by-name-or-type
        /// </summary>
        /// <param name="parent">A direct parent of the queried item.</param>
        /// <typeparam name="T">The type of the queried item.</typeparam>
        /// <param name="childName">x:Name or Name of child. </param>
        /// <returns>The first parent item that matches the submitted type parameter or null if not found</returns> 
        public static T FindChild<T>(DependencyObject parent, string childName)
           where T : DependencyObject
        {
            // Confirm parent and childName are valid. 
            if (parent == null) return null;

            T foundChild = null;

            int childrenCount = VisualTreeHelper.GetChildrenCount(parent);
            for (int i = 0; i < childrenCount; i++)
            {
                var child = VisualTreeHelper.GetChild(parent, i);
                // If the child is not of the request child type child
                T childType = child as T;
                if (childType == null)
                {
                    // recursively drill down the tree
                    foundChild = FindChild<T>(child, childName);

                    // If the child is found, break so we do not overwrite the found child. 
                    if (foundChild != null) break;
                }
                else if (!string.IsNullOrEmpty(childName))
                {
                    var frameworkElement = child as FrameworkElement;
                    // If the child's name is set for search
                    if (frameworkElement != null && frameworkElement.Name == childName)
                    {
                        // if the child's name is of the request name
                        foundChild = (T)child;
                        break;
                    }
                }
                else
                {
                    // child element found.
                    foundChild = (T)child;
                    break;
                }
            }

            return foundChild;
        }

        /// <summary>
        /// This privately nested class will help permutation lists for a list of objects
        /// </summary>
        /// <typeparam name="T">The generic type of the objects to be permuted</typeparam>
        private class PermList<T>
        {
            private int _curindex;
            private int _maxindex;
            private List<T> _inlist;

            public PermList()
            {
                _inlist = new List<T>();
                _curindex = 0;
                _maxindex = 0;
            }

            public PermList(IEnumerable<T> startlist) : this()
            {
                _inlist.AddRange(startlist);
                _maxindex = startlist.Count();
            }

            public void Add(T element)
            {
                _inlist.Add(element);
                _maxindex++;
            }

            public void ResetIndex()
            { _curindex = 0; }

            public T GetCurrent()
            { return _inlist[_curindex]; }

            public bool Next()
            {
                if (_curindex < _maxindex - 1)
                { _curindex++; return true; }
                else return false;
            }
        }

        /// <summary>
        /// This function will return a list of permuted arrays constructed from an indeterminate number of arrays which come as parameters
        /// </summary>
        /// <typeparam name="T">Generic type of objects which will be permuted</typeparam>
        /// <param name="arrays">The list of object arrays to be permuted</param>
        /// <returns></returns>
        public static List<T[]> GetPermutations<T>(params List<T>[] arrays)
        {
            List<List<T>> lists = new List<List<T>>();
            lists.AddRange(arrays.ToList());
            return GetPermutations(lists);
        }

        /// <summary>
        /// This function will return a list of permuted arrays constructed from a list of objects which come as a parameter
        /// </summary>
        /// <typeparam name="T">Generic type of objects which will be permuted</typeparam>
        /// <param name="lists">The list of object lists to be permuted</param>
        /// <returns></returns>
        public static List<T[]> GetPermutations<T>(List<List<T>> lists)
        {
            int listCount = lists.Count;
            List<PermList<T>> permlists = new List<PermList<T>>();
            for (int i = 0; i < listCount; i++)
            {
                if (lists[i].Count > 0)
                { permlists.Add(new PermList<T>(lists[i])); }
            }

            List<T[]> permarrays = new List<T[]>();

            int listindex = 0;
            while (true)
            {
            permloopstart:
                T[] perm = new T[listCount];

                for (int i = 0; i < listCount; i++)
                {
                    perm[i] = permlists[i].GetCurrent();
                }

                permarrays.Add(perm);

                if (permlists[listindex].Next())
                { continue; }
                else
                {
                    while (listindex < listCount - 1)
                    {
                        listindex++;

                        if (permlists[listindex].Next())
                        {
                            for (int j = 0; j < listindex; j++)
                            { permlists[j].ResetIndex(); }
                            listindex = 0;
                            goto permloopstart;
                        }
                    }
                }

                break;
            }

            return permarrays;
        }

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = RND.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
