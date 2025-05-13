using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HurPsyExpStrings;
using HurPsyLib;
using System.IO;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This VM class will handle the exchange of data between the experiment definition and the design interface
    /// </summary>
    public partial class DesignViewModel : ObservableObject
    {
        #region Design Properties

        /// <summary>
        /// This field stores the current layout choice for `DesignWindow`
        /// </summary>
        [ObservableProperty]
        private ContentChoice displayContentChoice;

        /// <summary>
        /// The current content set by this viewmodel (it will change depending on the choice clicked on **SingleLayoutMenu** defined in **DesignLayouts.xaml**)
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<IdObjectViewModel> displayContent;

        /// <summary>
        /// Currently selected item
        /// </summary>
        [ObservableProperty]
        private IdObjectViewModel? selectedItemVM;

        /// <summary>
        /// The label indicating the current display content (it will apear on **SingleLayoutLabel** defined in **DesignLayouts.xaml**)
        /// </summary>
        [ObservableProperty]
        private string displayContentLabel;

        /// <summary>
        /// The boolean indicator of Add Items Mode
        /// </summary>
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(AddingStimulusMode))]
        [NotifyPropertyChangedFor(nameof(AddingLocatorMode))]
        [NotifyPropertyChangedFor(nameof(AddingResponseMode))]
        [NotifyPropertyChangedFor(nameof(AddingBlockMode))]
        private bool addingMode;

        /// <summary>
        /// This will be an indicator that the user will be adding new `Stimulus` definitions
        /// </summary>
        public bool AddingStimulusMode => AddingMode && (DisplayContentChoice == ContentChoice.StimulusDefinitions);

        /// <summary>
        /// This will be an indicator that the user will be adding new `Locator` definitions
        /// </summary>
        public bool AddingLocatorMode => AddingMode && (DisplayContentChoice == ContentChoice.LocatorDefinitions);

        /// <summary>
        /// This will be an indicator that the user will be adding new `Response` definitions
        /// </summary>
        public bool AddingResponseMode => AddingMode && (DisplayContentChoice == ContentChoice.ResponseDefinitions);

        /// <summary>
        /// This will be an indicator that the user will be adding new `Block` definitions
        /// </summary>
        public bool AddingBlockMode => AddingMode && (DisplayContentChoice == ContentChoice.BlockDefinitions);

        #endregion

        #region Experiment Items
        /// <summary>
        /// The `Experiment` object managed by this viewmodel
        /// </summary>
        private Experiment currentExperiment;

        /// <summary>
        /// A property to expose the experiment's name
        /// </summary>
        [ObservableProperty]
        private string experimentName;

        /// <summary>
        /// Collection of viewmodels associated with the experiment's `Stimulus` objects
        /// </summary>
        public ObservableCollection<IdObjectViewModel> StimulusVMs { get; set; }

        /// <summary>
        /// A list containing only the Ids of `Stimulus` objects (used with one time binding for adding pairs to steps or trials to blocks)
        /// </summary>
        public List<string> StimulusIds
        {
            get
            {
                List<string> stimIdList = new List<string>();
                foreach (var stimvm in StimulusVMs)
                { stimIdList.Add(stimvm.ItemObject.Id); }
                return stimIdList;
            }
        }

        /// <summary>
        /// Collection of viewmodels associated with the experiment's `Locator` objects
        /// </summary>
        public ObservableCollection<IdObjectViewModel> LocatorVMs { get; set; }

        /// <summary>
        /// A list containing only the Ids of `Locator` objects (used with one time binding for adding pairs to steps or trials to blocks)
        /// </summary>
        public List<string> LocatorIds
        {
            get
            {
                List<string> locIdList = new List<string>();
                foreach (var locvm in LocatorVMs)
                { locIdList.Add(locvm.ItemObject.Id); }
                return locIdList;
            }
        }

        /// <summary>
        /// Collection of viewmodels associated with the experiment's `Response` objects
        /// </summary>
        public ObservableCollection<IdObjectViewModel> ResponseVMs { get; set; }

        /// <summary>
        /// Collection of viewmodels associated with the experiment's trial blocks
        /// </summary>
        public ObservableCollection<IdObjectViewModel> BlockVMs { get; set; }
        #endregion

        #region Constructor(s)
        /// <summary>
        /// This default constructor starts with a new experiment definition and empty VM collections
        /// </summary>
        public DesignViewModel(Experiment? exp = null)
        {
            if (exp != null)
            { currentExperiment = exp; }
            else { currentExperiment = new Experiment(); }

            ExperimentName = currentExperiment.Name;

            StimulusVMs = [];
            LocatorVMs = [];
            ResponseVMs = [];
            BlockVMs = [];
          
            AddingMode = false;
            DisplayContent = [];
            SelectedItemVM = null;
            DisplayContentChoice = ContentChoice.NoDefinitions;
            DisplayContentLabel = StringResources.Header_Definitions;

            // LoadTestExperiment();
        }
        #endregion

        #region Methods
        private void LoadExperimentFromFile(string openfilename)
        {
            Experiment? tryexp = Utility.LoadFromXml<Experiment>(openfilename);
            if (tryexp != null)
            {
                currentExperiment = tryexp;
                ExperimentName = currentExperiment.Name;
                currentExperiment.FilePath = openfilename;
                CreateVMs();
                DisplayContentChoice = ContentChoice.BlockDefinitions;
                ChooseContent(DisplayContentChoice);
            }
            else
            { throw new HurPsyException(HurPsyLibStrings.StringResources.Error_ExperimentNotLoaded + openfilename); }
        }

        /// <summary>
        /// Relay the name change to the source experiment.
        /// </summary>
        /// <param name="value"></param>
        partial void OnExperimentNameChanged(string value)
        {
            currentExperiment.Name = value;
        }

        /// <summary>
        /// This little function creates a viewmodel object associated with an experiment item and initializes it.
        /// </summary>
        /// <param name="idobj"></param>
        /// <returns></returns>
        private IdObjectViewModel CreateVM(IdObject idobj)
        {
            IdObjectViewModel idobjvm ;

            if(idobj is ExpBlock blck) // An experiment block requires its own specialized viewmodel
            { idobjvm = new BlockViewModel(blck); }
            else
            { idobjvm = new IdObjectViewModel(idobj); }

            idobjvm.IdChanged += ItemIdChanged;
            return idobjvm;
        }

        /// <summary>
        /// This short method will clear viewmodel collections in preparations for renewing the experiment definition.
        /// </summary>
        private void ClearVMs()
        {
            StimulusVMs.Clear();
            LocatorVMs.Clear();
            BlockVMs.Clear();
        }

        /// <summary>
        /// This method will create the viewmodel objects for the items in a loaded experiment.
        /// </summary>
        private void CreateVMs()
        {
            ClearVMs();

            List<Stimulus> StimulusItems = currentExperiment.GetStimulusItems();
            foreach (var item in StimulusItems)
            { StimulusVMs.Add(CreateVM(item)); }

            List<Locator> LocatorItems = currentExperiment.GetLocatorItems();
            foreach (var item in LocatorItems)
            { LocatorVMs.Add(CreateVM(item)); }

            List<Response> ResponseItems = currentExperiment.GetResponseItems();
            foreach (var item in ResponseItems)
            { ResponseVMs.Add(CreateVM(item)); }

            foreach (var item in currentExperiment.Blocks)
            { BlockVMs.Add(CreateVM(item)); }
        }

        /// <summary>
        /// This method displays an open file dialog to let the user choose images to serve as `ImageStimulus` elements.
        /// </summary>
        private void AddingImageStimulus()
        {
            string[]? selectedFiles = Utility.FileOpenDialog(HurPsyExpStrings.StringResources.Filter_ImageFiles, true);

            if (selectedFiles != null && selectedFiles.Length > 0)
            {
                foreach (string strFilePath in selectedFiles)
                {
                    ImageStimulus imgstim = new();
                    string? basename = Path.GetFileNameWithoutExtension(strFilePath);
                    if(basename != null) { imgstim.Id = basename; }
                    // copy the stimulus file onto the same directory as the experiment
                    CopyStimulusItem(imgstim, strFilePath);
                    currentExperiment.AddStimulus(imgstim);
                    IdObjectViewModel stimvm = CreateVM(imgstim);
                    StimulusVMs.Add(stimvm);
                }
            }
        }

        private void CopyStimulusItem(Stimulus stim, string oldStimulusFilePath)
        {
            // If the experiment definition doesn't yet have a file, make sure the user saves it first
            if(string.IsNullOrEmpty(currentExperiment.FilePath))
            {
                MessageBox.Show(HurPsyExpStrings.StringResources.Warning_SaveExperimentFirst);
                SaveExperimentAs();
            }

            // Get the directory path for the experiment's definition file
            string? expDirectoryPath = Path.GetDirectoryName(currentExperiment.FilePath);
            if (expDirectoryPath != null)
            {
                stim.FileName = Path.GetFileName(oldStimulusFilePath);
                string newStimulusFilePath = Path.Combine(expDirectoryPath, stim.FileName);
                // Check if the stimulus file is actually in the old place
                if (File.Exists(oldStimulusFilePath))
                {
                    File.Copy(oldStimulusFilePath, newStimulusFilePath, true);
                }
                else
                {
                    MessageBox.Show(StringResources.Error_CannotFindStimulusFile + oldStimulusFilePath);
                    Application.Current.Shutdown();
                }
            }
        }

        private void LoadTestExperiment()
        {
            LoadExperimentFromFile(@"C:\Users\freeb\Documents\HurPsyTest\deney1\deney1.xml");           
        }
        #endregion

        #region Commands
        /// <summary>
        /// The command implementation for creating a new experiment definition.
        /// </summary>
        [RelayCommand]
        private void NewExperiment()
        {
            ClearVMs();
            currentExperiment = new Experiment();
            ExperimentName = currentExperiment.Name;
        }

        /// <summary>
        /// The command implementation for loading an experiment definition from a file.
        /// </summary>
        [RelayCommand]
        private void LoadExperiment()
        {
            string[]? selectedFiles = Utility.FileOpenDialog(HurPsyExpStrings.StringResources.Filter_ExperimentFiles, false);

            if(selectedFiles != null && File.Exists(selectedFiles[0]))
            {
                LoadExperimentFromFile(selectedFiles[0]);
            }
        }

        /// <summary>
        /// The command implementation for saving an experiment definition onto the same file
        /// If the experiment did not yet have a valid file, SaveExperimentAs command implementation will be called.
        /// </summary>
        [RelayCommand]
        private void SaveExperiment()
        {
            if (File.Exists(currentExperiment.FilePath))
            {
                Utility.SaveToXml<Experiment>(currentExperiment, currentExperiment.FilePath);
            }
            else { SaveExperimentAs(); }
        }

        /// <summary>
        /// The command implementation for saving an experiment definition onto a file
        /// </summary>
        [RelayCommand]
        private void SaveExperimentAs()
        {
            string? savefilename = Utility.FileSaveDialog(currentExperiment.Name + ".xml", HurPsyExpStrings.StringResources.Filter_ExperimentFiles);

            if (savefilename != null)
            {
                // Record the old file directory, just in case
                string? oldDirectoryPath = Path.GetDirectoryName(currentExperiment.FilePath);

                // Do the file save and record the directory path again
                currentExperiment.FilePath = savefilename;
                Utility.SaveToXml<Experiment>(currentExperiment, savefilename);
                string? newDirectoryPath = Path.GetDirectoryName(currentExperiment.FilePath);

                // If the old and new directory paths different, copy the stimulus files to the new path
                if (oldDirectoryPath != null && newDirectoryPath != null && newDirectoryPath != oldDirectoryPath)
                {
                    var stimItems = currentExperiment.GetStimulusItems();
                    foreach(Stimulus stim in stimItems)
                    {
                        string oldStimulusFilePath = Path.Combine(oldDirectoryPath, stim.FileName);
                        CopyStimulusItem(stim, oldStimulusFilePath);
                    }
                }
            }
        }

        [RelayCommand]
        private void RunExperiment(Window designWindow)
        {
            designWindow.Close();
            ExpRun.RunWindow runWindow = new ExpRun.RunWindow(currentExperiment);
            runWindow.Show();
        }

        /// <summary>
        /// This command implementation changes the display content according to the user's choice.
        /// </summary>
        /// <param name="newchoice"></param>
        [RelayCommand]
        private void ChooseContent(ContentChoice newchoice)
        {
            // Disable AddingMode if it was active
            AddingMode = false;

            DisplayContentChoice = newchoice;
            
            switch(DisplayContentChoice)
            {
                case ContentChoice.StimulusDefinitions:
                    DisplayContent = StimulusVMs;
                    DisplayContentLabel = HurPsyExpStrings.StringResources.Header_StimulusDefinitions;
                    break;
                case ContentChoice.LocatorDefinitions:
                    DisplayContent = LocatorVMs;
                    DisplayContentLabel = HurPsyExpStrings.StringResources.Header_LocatorDefinitions;
                    break;
                case ContentChoice.ResponseDefinitions:
                    DisplayContent = ResponseVMs;
                    DisplayContentLabel = HurPsyExpStrings.StringResources.Header_ResponseDefinitions;
                    break;
                case ContentChoice.BlockDefinitions:
                    DisplayContent = BlockVMs;
                    DisplayContentLabel = HurPsyExpStrings.StringResources.Header_BlockDefinitions;
                    break;
            }
        }

        /// <summary>
        /// This command implementation is the first step in adding `Stimulus` definitions to the experiment.
        /// </summary>
        /// <param name="stimType">The subtype of `Stimulus`</param>
        [RelayCommand]
        private void AddingStimulus(Type stimType)
        {
            switch(stimType.Name)
            {
                case "ImageStimulus":
                    AddingImageStimulus();
                    break;
            }
        }

        /// <summary>
        /// This command implementation is the first step in adding `Locator` definitions to the experiment.
        /// </summary>
        /// <param name="locType">The subtype of `Locator`</param>
        [RelayCommand]
        private void AddingLocator(Type locType)
        {
            switch (locType.Name)
            {
                case "PointLocator":
                    PointLocator ploc = new();
                    currentExperiment.AddLocator(ploc);
                    IdObjectViewModel plocvm = CreateVM(ploc);
                    LocatorVMs.Add(plocvm);
                    break;
            }
        }

        /// <summary>
        /// This command implementation is the first step in adding `Response` definitions to the experiment.
        /// </summary>
        /// <param name="resType">The subtype of `Response`</param>
        [RelayCommand]
        private void AddingResponse(Type resType)
        {
            switch (resType.Name)
            {
                case "KeyResponse":
                    KeyResponse krep = new();
                    currentExperiment.AddResponse(krep);
                    IdObjectViewModel krepvm = CreateVM(krep);
                    ResponseVMs.Add(krepvm);
                    break;
            }
        }

        /// <summary>
        /// This command implementation adds a new trial block.
        /// </summary>
        [RelayCommand]
        private void AddingBlock()
        {
            ExpBlock blck = new();
            currentExperiment.AddBlock(blck);
            IdObjectViewModel blckvm = CreateVM(blck);
            BlockVMs.Add(blckvm);
        }
        
        #endregion

        #region Events
        
        /// <summary>
        /// This is for handling the Id change events for `IdObjectViewModel` objects.
        /// </summary>
        /// <param name="sender">`IdObjectViewModel` objects which reports a change in its `TempId` property</param>
        /// <param name="e">Id change parameters</param>
        private void ItemIdChanged(object? sender, IdChangeEventArgs e)
        {
            IdObjectViewModel? idobjvm = sender as IdObjectViewModel;

            if (idobjvm != null && !string.IsNullOrEmpty(e.NewId))
            {
                switch(idobjvm.ItemObject)
                {// In cases Id change is rejected (due to duplicate Ids) revert the viewmodel TempId to the object Id.
                    case Stimulus stim:
                        if(!currentExperiment.StimulusIdChanged(stim, e.NewId))
                        { idobjvm.TempId = stim.Id; }
                        break;
                    case Locator loc:
                        if (!currentExperiment.LocatorIdChanged(loc, e.NewId))
                        { idobjvm.TempId = loc.Id; }
                        break;
                    case ExpBlock blck:
                        blck.Id = e.NewId;
                        break;
                }
            }
        }

        #endregion
    }
}
