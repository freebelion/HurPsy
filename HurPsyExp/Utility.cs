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
    public static class Utility
    {
        const double MM2DIU = 3.77952755;

        public static Random Rnd = new Random();

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
            string[]? selectedFiles = Utility.OpenFiles(StringResources.FileFilter_Experiment, openMultiple: false);

            if (selectedFiles != null && selectedFiles.Length == 1)
            {
                string expFileName = selectedFiles[0];

                string? expDirectoryPath = Path.GetDirectoryName(expFileName);

                if (expDirectoryPath != null)
                {
                    Experiment exp;
                    // Load the experiment definition from the selected file
                    exp = Experiment.LoadFromXml(expFileName);
                    exp.FileName = expFileName; // remember the full file path
                    // Make sure the stimulus files exist and change their paths if necessary
                    List<Stimulus> stimuli = exp.GetStimuli();
                    stimuli.ForEach(stim => { FindStimulusFile(stim, expDirectoryPath); });

                    // Change the working directory for the application
                    Directory.SetCurrentDirectory(expDirectoryPath);
                    // Load the stimulus objects to make the experiment object usable
                    return exp;
                }
            }
            return null;
        }

        public static void SaveExperiment(Experiment exp)
        {
            string? expFileName = Utility.FileSaveName(StringResources.FileFilter_Experiment);

            if (expFileName != null)
            {// save the experiment definition
                string? expDirectoryPath = Path.GetDirectoryName(expFileName);
                exp.FileName = expFileName;
                exp.SaveToXml(expFileName);

                if (expDirectoryPath != null)
                {
                    // Carry all the files containing the stimuli to the same directory
                    List<Stimulus> stimuli = exp.GetStimuli();
                    stimuli.ForEach(stim => { CopyStimulusFile(stim, expDirectoryPath); });
                    
                    // Change the working directory for the application
                    Directory.SetCurrentDirectory(expDirectoryPath);
                }
            }
        }

        public static bool CopyStimulusFile(Stimulus stim, string expDirectoryPath)
        {
            // If the original stimulus file exists,
            // simply copy it to the same directory as the experiment file
            if (File.Exists(stim.FileName))
            {
                string newFileName = Path.Combine(expDirectoryPath, Path.GetFileName(stim.FileName));
                File.Copy(stim.FileName, newFileName, overwrite:true);
                stim.FileName = newFileName;
                return true;
            }
            // If, somehow, the original file did not exist
            // report failure so another method can be tried.
            return false;
        }

        public static void FindStimulusFile(Stimulus stim, string expDirectoryPath)
        {
            // If the image stimulus file does not exist in its recorded location,
            if (!File.Exists(stim.FileName))
            {// change its path to the directory containing the experiment file.
                stim.FileName = Path.Combine(expDirectoryPath, Path.GetFileName(stim.FileName));
                // If it is not there either, abandon ship!
                if (!File.Exists(stim.FileName))
                {
                    throw new HurPsyException(HurPsyExpStrings.StringResources.Error_StimulusFileNotFound
                                                + "(Id: " + stim.Id + ", Searched Path: " + stim.FileName + ")");
                }
            }
        }

        public static void SaveImage(BitmapImage bmpimg, string filePath)
        {// source: https://stackoverflow.com/questions/35804375/how-do-i-save-a-bitmapimage-from-memory-into-a-file-in-wpf-c
            BitmapEncoder bmpenc = new PngBitmapEncoder();
            bmpenc.Frames.Add(BitmapFrame.Create(bmpimg));
            
            using (var fileStream = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                bmpenc.Save(fileStream);
            }
        }

        public static BitmapImage LoadImage(string filename)
        {// source: https://stackoverflow.com/questions/11202807/garbage-collection-fails-to-reclaim-bitmapimage
            BitmapImage bmpImage = new BitmapImage();

            bmpImage.BeginInit();
            bmpImage.UriSource = new Uri(filename, UriKind.RelativeOrAbsolute);
            bmpImage.CacheOption = BitmapCacheOption.OnLoad; // needed to release the file after loading image
            bmpImage.EndInit();
            bmpImage.Freeze(); // turns out to be necessary; see the source
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

        public static double GetDIUValue(double mmValue)
        {  return MM2DIU * mmValue; }

        public static double GetMMValue(double diuValue)
        { return diuValue / MM2DIU; }

        public static Point GetDIULocation(IVisualStimulus vistim, Locator loc)
        {
            Point pnt = new Point();
            // Ask the Locator to produce a position in millimeters
            HurPsyPoint psypnt = loc.GetLocation(vistim);
            // Locator will give a center position
            // in millimeters (or some other unit);
            // first, get the position of the top-left corner of stimulus
            psypnt.X -= vistim.VisualSize.Width / 2;
            psypnt.Y += vistim.VisualSize.Height / 2;

            // then convert the values to DIU
            pnt.X = GetDIUValue(psypnt.X);
            // We need to flip the sign for Y due to windows coordinate system.
            pnt.Y = -GetDIUValue(psypnt.Y);

            return pnt;
        }

        public static Size GetDIUSize(IVisualStimulus vistim)
        {
            Size sz = new Size();
            sz.Width = GetDIUValue(vistim.VisualSize.Width);
            sz.Height = GetDIUValue(vistim.VisualSize.Height);
            return sz;
        }
    }   
}
