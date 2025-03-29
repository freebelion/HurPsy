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
            foreach (var item in StimulusItems) { StimulusVMs.Add(new IdObjectViewModel(item)); }

            List<Locator> LocatorItems = _experiment.GetLocatorItems();
            foreach (var item in LocatorItems) { LocatorVMs.Add(new IdObjectViewModel(item)); }
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
                    ImageStimulus imgstim = new ImageStimulus();
                    string? basename = System.IO.Path.GetFileNameWithoutExtension(strFile);
                    if(basename != null) { imgstim.Id = basename; }
                    imgstim.FileName = strFile;
                    IdObjectViewModel stimvm = new(imgstim);
                    stimvm.Editable = EditMode; // keep edit mode the same for new items
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
                _experiment = Experiment.LoadFromXml(selectedFiles[0]);
                CreateVMs();
                ChooseContent(DisplayContentChoice);
            }
        }

        /// <summary>
        /// The command implementation for saving an experiment definition onto the same file.
        /// If the experiment did not yet have a valid file, SaveExperimentAs command implementation will be called.
        /// </summary>
        [RelayCommand]
        private void SaveExperiment()
        {
            if (_experiment.FileExists())
            { _experiment.SaveToXml(); }
            else { SaveExperimentAs(); }
        }

        /// <summary>
        /// The command implementation for saving an experiment definition onto a file.
        /// </summary>
        [RelayCommand]
        private void SaveExperimentAs()
        {
            string? filename = Utility.FileSaveName(HurPsyExpStrings.StringResources.Filter_ExperimentFiles);

            if (filename != null)
            {
                _experiment.SaveToXml(filename);
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
        /// This command implementation, when called with a `true` argument, will bring up **AddingItemsView** which will let the user add new items.
        /// </summary>
        [RelayCommand]
        private void AddingItems()
        {
            // If items are going to be added, DisplayContent will be recreated as a temporary list of new items.
            if (AddingMode) { DisplayContent = []; }
            // Otherwise, DisplayContent will revert to previous display content choice.
            else { ChooseContent(DisplayContentChoice); }
        }

        /// <summary>
        /// This command implementation is the first step in adding `Stimulus` definitions to the experiment.
        /// </summary>
        /// <param name="stimType"></param>
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
        /// <param name="locType"></param>
        [RelayCommand]
        private void AddingLocator(Type locType)
        {
            switch (locType.Name)
            {
                case "PointLocator":
                    PointLocator ploc = new PointLocator();
                    IdObjectViewModel plocvm = new IdObjectViewModel(ploc);
                    plocvm.Editable = EditMode;
                    DisplayContent.Add(plocvm); // keep edit mode the same for new items
                    break;
            }
        }

        /// <summary>
        /// This method will be called by the OK button on AddingItemsToolbar and will add the new items.
        /// </summary>
        [RelayCommand]
        private void AddedItems()
        {
            switch (DisplayContentChoice)
            {
                case ContentChoice.StimulusDefinitions:
                    foreach (var idobjvm in DisplayContent)
                    {
                        _experiment.AddStimulus((Stimulus)idobjvm.ItemObject);
                        StimulusVMs.Add(idobjvm);
                    }
                    break;
                case ContentChoice.LocatorDefinitions:
                    foreach (var idobjvm in DisplayContent)
                    {
                        _experiment.AddLocator((Locator)idobjvm.ItemObject);
                        LocatorVMs.Add(idobjvm);
                    }
                    break;
            }
            // After new items are added, revert to full display of current content choice
            ChooseContent(DisplayContentChoice);
        }

        /// <summary>
        /// This method will be called by the Cancel button on AddingItemsToolbar and will revert to the current content choice without adding the new items.
        /// </summary>
        [RelayCommand]
        private void CancelAdding()
        {
            AddingMode = false;
            ChooseContent(DisplayContentChoice);
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
        #endregion
    }
}
