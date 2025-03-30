using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using HurPsyLib;

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
        /// The label indicating the current display content (it will apear on **SingleLayoutLabel** defined in **DesignLayouts.xaml**)
        /// </summary>
        [ObservableProperty]
        private string displayContentLabel = string.Empty;

        /// <summary>
        /// The boolean indicator of Item Editing mode
        /// </summary>
        [ObservableProperty]
        private bool editMode = false;

        /// <summary>
        /// The boolean indicator of Add Items Mode
        /// </summary>
        [ObservableProperty]
        private bool addingMode;

        /// <summary>
        /// This will be an indicator that the user will be adding new `Stimulus` definitions
        /// </summary>
        [ObservableProperty]
        private bool addingStimulusMode;

        /// <summary>
        /// This will be an indicator that the user will be adding new `Locator` definitions
        /// </summary>
        [ObservableProperty]
        private bool addingLocatorMode;

        #endregion

        #region Experiment Items
        /// <summary>
        /// The `Experiment` object managed by this viewmodel
        /// </summary>
        private Experiment _experiment;

        /// <summary>
        /// Collection of viewmodels associated with experiment `Stimulus` objects
        /// </summary>
        public ObservableCollection<IdObjectViewModel> StimulusVMs { get; set; }

        /// <summary>
        /// Collection of viewmodels associated with experiment `Locator` objects
        /// </summary>
        public ObservableCollection<IdObjectViewModel> LocatorVMs { get; set; }
        #endregion

        #region Constructor(s)
        /// <summary>
        /// This default constructor starts with a new experiment definition and empty VM collections
        /// </summary>
        public DesignViewModel()
        {
            _experiment = new Experiment();

            StimulusVMs = [];
            LocatorVMs = [];

            AddingMode = false;
            DisplayContent = [];
            DisplayContentChoice = ContentChoice.StimulusDefinitions;
            // Start with StimulusDefinitions content, until a diferent decision is made.
            ChooseContent(DisplayContentChoice);
        }
        #endregion

        #region Methods
        /// <summary>
        /// This little function creates a VM associated with an experiment item and initializes it.
        /// </summary>
        /// <param name="idobj"></param>
        /// <returns></returns>
        private IdObjectViewModel CreateVM(IdObject idobj)
        {
            IdObjectViewModel idobjvm = new(idobj) { Editable = EditMode };
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
        }

        /// <summary>
        /// This method will create the viewmodel objects for a loaded experiment
        /// </summary>
        private void CreateVMs()
        {
            ClearVMs();

            List<Stimulus> StimulusItems = _experiment.GetStimulusItems();
            foreach (var item in StimulusItems)
            { StimulusVMs.Add(CreateVM(item)); }

            List<Locator> LocatorItems = _experiment.GetLocatorItems();
            foreach (var item in LocatorItems)
            { LocatorVMs.Add(CreateVM(item)); }
        }

        /// <summary>
        /// This method displays an open file dialog to let the user choose images to serve as `ImageStimulus` elements.
        /// </summary>
        private void AddingImageStimulus()
        {
            string[]? selectedFiles = Utility.OpenFiles(HurPsyExpStrings.StringResources.Filter_ImageFiles, true);

            if (selectedFiles != null && selectedFiles.Length > 0)
            {
                foreach (string strFile in selectedFiles)
                {
                    ImageStimulus imgstim = new();
                    string? basename = System.IO.Path.GetFileNameWithoutExtension(strFile);
                    if(basename != null) { imgstim.Id = basename; }
                    imgstim.FileName = strFile;
                    _experiment.AddStimulus(imgstim);
                    IdObjectViewModel stimvm = CreateVM(imgstim);
                    DisplayContent.Add(stimvm);
                }
            }
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
            _experiment = new Experiment();
        }

        /// <summary>
        /// The command implementation for loading an experiment definition from a file.
        /// </summary>
        [RelayCommand]
        private void LoadExperiment()
        {
            string[]? selectedFiles = Utility.OpenFiles(HurPsyExpStrings.StringResources.Filter_ExperimentFiles, false);

            if(selectedFiles != null && System.IO.File.Exists(selectedFiles[0]))
            {
                string openfilename = selectedFiles[0];
                Experiment? tryexp = Utility.LoadFromXml<Experiment>(openfilename);
                if (tryexp != null)
                {
                    _experiment = tryexp;
                    _experiment.FileName = openfilename;
                    CreateVMs();
                    ChooseContent(DisplayContentChoice);
                }
                else
                { throw new HurPsyException(HurPsyLibStrings.StringResources.Error_ExperimentNotLoaded + openfilename); }
            }
        }

        /// <summary>
        /// The command implementation for saving an experiment definition onto the same file.
        /// If the experiment did not yet have a valid file, SaveExperimentAs command implementation will be called.
        /// </summary>
        [RelayCommand]
        private void SaveExperiment()
        {
            if (System.IO.File.Exists(_experiment.FileName))
            {
                Utility.SaveToXml<Experiment>(_experiment, _experiment.FileName);
            }
            else { SaveExperimentAs(); }
        }

        /// <summary>
        /// The command implementation for saving an experiment definition onto a file.
        /// </summary>
        [RelayCommand]
        private void SaveExperimentAs()
        {
            string? savefilename = Utility.FileSaveName(HurPsyExpStrings.StringResources.Filter_ExperimentFiles);

            if (savefilename != null)
            {
                _experiment.FileName = savefilename;
                Utility.SaveToXml<Experiment>(_experiment, savefilename);
            }
        }

        /// <summary>
        /// This command implementation changes the display content according to the user's choice.
        /// </summary>
        /// <param name="newchoice"></param>
        [RelayCommand]
        private void ChooseContent(ContentChoice newchoice)
        {
            // Cancel the adding mode, if active.
            if(AddingMode) { AddingMode = false; }

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
            }
            // Set the items as editable, if editing mode was already on
            EditingItems();
        }

        /// <summary>
        /// This command implementation will turn on the editing mode for all the displayed items.
        /// </summary>
        [RelayCommand]
        private void EditingItems()
        {
            foreach (IdObjectViewModel idobjvm in DisplayContent)
            {
                idobjvm.Editable = EditMode;
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
                    _experiment.AddLocator(ploc);
                    IdObjectViewModel plocvm = CreateVM(ploc);
                    DisplayContent.Add(plocvm);
                    break;
            }
        }

        #endregion

        #region Events
        /// <summary>
        /// This method handles MVVM Toolkit's value changed event; it modifies the boolean flags for hiding/showing the menus that will add Stimulus/Locator/Block, etc.
        /// </summary>
        /// <param name="value"></param>
        partial void OnAddingModeChanged(bool value)
        {
            AddingStimulusMode = AddingMode && (DisplayContentChoice == ContentChoice.StimulusDefinitions);
            AddingLocatorMode = AddingMode && (DisplayContentChoice == ContentChoice.LocatorDefinitions);
        }

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
                {
                    case Stimulus stim:
                        if(!_experiment.StimulusIdChanged(stim, e.NewId))
                        { idobjvm.TempId = stim.Id; }
                        break;
                    case Locator loc:
                        if (!_experiment.LocatorIdChanged(loc, e.NewId))
                        { idobjvm.TempId = loc.Id; }
                        break;
                }
            }
        }

        #endregion
    }
}
