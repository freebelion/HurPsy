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
    /// <summary>
    /// This static class will handle mundane operations like opening and saving files, etc. which fall outside the jurisdiction of the design app.
    /// </summary>
    public static class Utility
    {
        /// <summary>
        /// Millimeters to DIU conversion ratio
        /// </summary>
        const double MM2DIU = 3.77952755;

        /// <summary>
        /// The pseudo-random number generator which will be used while an experiment runs
        /// </summary>
        public static Random Rnd = new Random();

        /// <summary>
        /// This function will open a open-file selection dialog and return the selected files' paths as an array of strings
        /// </summary>
        /// <param name="filenameFilter">The filename filter for the file selection dialog</param>
        /// <param name="openMultiple">The boolean flag indicating if multiple selections are permitted</param>
        /// <returns></returns>
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
        /// <returns></returns>
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

        /// <summary>
        /// This function will display an open-file dialog and load an experiment definition (if a valid one can be constructed) from the selected file
        /// </summary>
        /// <returns>The reference of the `Experiment` object (`null` if a valid definition could not be constructed)</returns>
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

                    // Change the working directory for the application (if necessary)
                    // Directory.SetCurrentDirectory(expDirectoryPath);
                    // Load the stimulus objects to make the experiment object usable
                    return exp;
                }
            }
            return null;
        }

        /// <summary>
        /// This method will display a save-file dialog and save the given experiment definition into the specified file.
        /// </summary>
        /// <param name="exp">The experiment definition which will be saved</param>
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
                    
                    // Change the working directory for the application (if necessary)
                    // Directory.SetCurrentDirectory(expDirectoryPath);
                }
            }
        }

        /// <summary>
        /// This method will copy the file containing a stimulus definition to the directory where the experiment files are kept.
        /// (This helps package all files pertaining to an experiment and share with other experimenters, so they can run the experiment after extracting all those files into the same directory)
        /// </summary>
        /// <param name="stim">The `Stimulus` object representing the stimulus</param>
        /// <param name="expDirectoryPath">The full path of the directory where the experiment files are kept</param>
        /// <returns></returns>
        public static bool CopyStimulusFile(Stimulus stim, string expDirectoryPath)
        {
            // If the original stimulus file exists, but it's not already in the experiment file's directory,
            // simply copy it to the same directory as the experiment file.
            if (File.Exists(stim.FileName) && (Path.GetDirectoryName(stim.FileName) != expDirectoryPath))
            {
                string newFileName = Path.Combine(expDirectoryPath, Path.GetFileName(stim.FileName));
                // WARNING! The following command will cause an existing file with the same name to be overwritten.
                File.Copy(stim.FileName, newFileName, overwrite:true);
                stim.FileName = newFileName;
                return true;
            }
            // If, somehow, the original file did not exist,
            // report failure so another method can be tried.
            return false;
        }

        /// <summary>
        /// This method will try to locate a file containing the definition of a stimulus.
        /// (If the stimulus could not be recovered from the file path recorded in its definition, maybe because the experiment definiton was shared or moved to a different location, this method will look into the directory containing the experiment definition)
        /// </summary>
        /// <param name="stim">The `Stimulus` object representing the stimulus</param>
        /// <param name="expDirectoryPath">The full path of the directory where the experiment files are kept</param>
        /// <exception cref="HurPsyException"></exception>
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

        /// <summary>
        /// This method will save a bitmap image into the file at the given path.
        /// </summary>
        /// <param name="bmpimg">The bitmap image object</param>
        /// <param name="filePath">The path of the file where the image will be saved</param>
        public static void SaveImage(BitmapImage bmpimg, string filePath)
        {// source: https://stackoverflow.com/questions/35804375/how-do-i-save-a-bitmapimage-from-memory-into-a-file-in-wpf-c
            BitmapEncoder bmpenc = new PngBitmapEncoder();
            bmpenc.Frames.Add(BitmapFrame.Create(bmpimg));
            
            using (var fileStream = new System.IO.FileStream(filePath, System.IO.FileMode.Create))
            {
                bmpenc.Save(fileStream);
            }
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
        /// This function will load a generic object with a given type from an XML file by using a `DataContractSerializer`
        /// </summary>
        /// <typeparam name="T">The object type</typeparam>
        /// <param name="fileName">The path of the XML file containing the object structure</param>
        /// <returns>The object loaded from the file (`null` if no valid object could be recovered)</returns>
        public static T? LoadDataContractObjectFromXml<T>(string fileName) where T : class
        {
            T? obj = null;
            DataContractSerializer ser = new DataContractSerializer(typeof(T));
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                using (var reader = XmlDictionaryReader.CreateTextReader(fs, new XmlDictionaryReaderQuotas()))
                {
                    obj = (T?)ser.ReadObject(reader);
                }
            }

            return obj;
        }

        /// <summary>
        /// This function will save a generic object with a given type to an XML file by using a `DataContractSerializer`
        /// </summary>
        /// <typeparam name="T">The object type</typeparam>
        /// <param name="fileName">The path of the XML file containing the object structure</param>
        /// <returns>The object loaded from the file (`null` if no valid object could be recovered)</returns>
        public static void SaveDataContractObjectToXml<T>(T obj, string fileName) where T : class
        {
            DataContractSerializer ser = new DataContractSerializer(typeof(T));
            XmlWriterSettings settings = new XmlWriterSettings { Indent = true };
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                using (var writer = XmlWriter.Create(fs, settings))
                {
                    ser.WriteObject(writer, obj);
                }
            }
        }

        /// <summary>
        /// This function will convert a dimension in device-independent-units (WPF equivalent of a standard pixel dimension) to the experiment unit passed as the second parameter.
        /// (Normally, this design and run application will only use millimeters as its standard unit, but this function will come into use when more unit choices become available)
        /// </summary>
        /// <param name="diuValue">The value in DIUs</param>
        /// <param name="unit">The desired unit for the result</param>
        /// <returns>The converted value (NaN, if no valid unit choice is provided)</returns>
        public static double ConvertFromDIU(double diuValue, HurPsyUnit unit)
        {
            switch(unit)
            {
                case HurPsyUnit.MM:
                    return diuValue / MM2DIU;
            }
            return double.NaN;
        }

        /// <summary>
        /// This function will convert a value in the experiment unit passed as the second parameter to device-independent-units (WPF equivalent of a standard pixel dimension)
        /// (Normally, this design&run application will only use millimeters as its standard unit, but this function will come into use when more unit choices become available)
        /// </summary>
        /// <param name="unitvalue">The value in the experiment unit</param>
        /// <param name="unit">The experiment unit</param>
        /// <returns>The converted value (NaN, if no valid unit choice is provided)</returns>
        public static double ConvertToDIU(double unitvalue, HurPsyUnit unit)
        {
            switch (unit)
            {
                case HurPsyUnit.MM:
                    return unitvalue * MM2DIU;
            }
            return double.NaN;
        }

        public static Point GetDIULocation(VisualStimulus vistim, Locator loc)
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
            pnt.X = ConvertToDIU(psypnt.X, psypnt.Unit);
            // We need to flip the sign for Y due to windows coordinate system.
            pnt.Y = -ConvertToDIU(psypnt.Y, psypnt.Unit);

            return pnt;
        }

        public static Size GetDIUSize(VisualStimulus vistim)
        {
            Size sz = new Size();
            sz.Width = ConvertToDIU(vistim.VisualSize.Width, vistim.VisualSize.Unit);
            sz.Height = ConvertToDIU(vistim.VisualSize.Height, vistim.VisualSize.Unit);
            return sz;
        }
    }   
}
