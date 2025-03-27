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
        private Experiment exp;

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
            exp = new Experiment();

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
                    DisplayContent.Add(new IdObjectViewModel(imgstim));
                }
            }
        }
        #endregion

        #region Commands
        /// <summary>
        /// This method, when executed as a command, changes the display content according to the user's choice.
        /// </summary>
        /// <param name="newchoice"></param>
        [RelayCommand]
        private void ChooseContent(ContentChoice newchoice)
        {
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
        }

        /// <summary>
        /// This method, when executed as a command, will turn on the editing mode for all the displayed items.
        /// </summary>
        /// <param name="editing"></param>
        [RelayCommand]
        private void EditingItems(bool editing)
        {
            if (DisplayContent != null)
            {
                foreach (IdObjectViewModel idobjvm in DisplayContent)
                {
                    idobjvm.Editable = editing;
                }
            }
        }

        /// <summary>
        /// This command implementation, when called with a `true` argument, will bring up **AddingItemsView** which will let the user add new items.
        /// </summary>
        /// <param name="adding"></param>
        [RelayCommand]
        private void AddingItems(bool adding)
        {
            AddingMode = adding;
            // If items are going to be added, DisplayContent will be recreated as a temporary list of new items.
            if (adding) { DisplayContent = []; }
            // Otherwise, DisplayContent will revert to previous display content choice.
            else { ChooseContent(DisplayContentChoice); }

            AddingStimulusMode = AddingMode && (DisplayContentChoice == ContentChoice.StimulusDefinitions);
            AddingLocatorMode = AddingMode && (DisplayContentChoice == ContentChoice.LocatorDefinitions);
        }

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

        [RelayCommand]
        private void AddingLocator(Type locType)
        {
            switch (locType.Name)
            {
                case "PointLocator":
                    PointLocator ploc = new PointLocator();
                    DisplayContent.Add(new IdObjectViewModel(ploc));
                    break;
            }
        }
        #endregion
    }
}
