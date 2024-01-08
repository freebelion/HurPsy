using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HurPsyLib;
using HurPsyExpStrings;
using System.Windows.Controls;
using System.Windows;
using Microsoft.Win32;
using System.Runtime.Serialization;
using System.Xml;
using System.Windows.Media.Imaging;

namespace HurPsyExp
{
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

        public static List<T[]> GetPermutations<T>(params List<T>[] arrays)
        {
            List<List<T>> lists = new List<List<T>>();
            lists.AddRange(arrays.ToList());
            return GetPermutations(lists);
        }

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

        public static Experiment? LoadExperiment()
        {
            string[]? selectedFiles = UtilityClass.OpenFiles(StringResources.FileFilter_Experiment, false);

            if (selectedFiles != null && selectedFiles.Length == 1)
            {
                string expFileName = selectedFiles[0];

                string? expDirectoryPath = Path.GetDirectoryName(expFileName);
                if (expDirectoryPath != null)
                {
                    Experiment exp;
                    // Load the experiment definition from the selected file
                    exp = Experiment.LoadFromXml(expFileName);
                    // Load the stimulus objects to make the experiment object usable
                    LoadStimulusObjects(exp);
                    // Change the working directory for the application
                    // so that stimulus filenames will work without full paths.
                    Directory.SetCurrentDirectory(expDirectoryPath);
                    return exp;
                }
            }
            return null;
        }

        public static void LoadStimulusObjects(Experiment exp)
        {
            // Load the actual Stimulus objects from files named in the experiment definition
            foreach (Stimulus stim in exp.StimulusDict.Values)
            {
                switch(stim)
                {
                    case ImageStimulus imgstim:
                        LoadImageStimulus(imgstim);
                        break;
                }
            }
        }

        public static void LoadImageStimulus(ImageStimulus imgstim)
        {
            BitmapImage stimImage = LoadImageObject(imgstim.FileName);
            imgstim.StimulusObject = stimImage;
            imgstim.ImageSize.Width = stimImage.Width;
            imgstim.ImageSize.Height = stimImage.Height;
        }

        public static BitmapImage LoadImageObject(string filename)
        {
            BitmapImage bmpImage = new BitmapImage();
            bmpImage.BeginInit();
            bmpImage.UriSource = new Uri(filename, UriKind.Absolute);
            bmpImage.CacheOption = BitmapCacheOption.OnLoad;
            bmpImage.EndInit();

            return bmpImage;
        }

        public static T? LoadObjectFromXml<T>(string fileName) where T : class
        {
            DataContractSerializer ser =
                    new DataContractSerializer(typeof(T));
            FileStream fs = new FileStream(fileName, FileMode.Open);
            XmlDictionaryReader reader =
                    XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas());

            T? obj = (T?)ser.ReadObject(reader);
            return obj;
        }
    }   
}
