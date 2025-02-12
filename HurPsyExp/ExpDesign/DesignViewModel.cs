using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HurPsyLib;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using HurPsy;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This VM class will handle the exchange of data input on the experiment design interface
    /// </summary>
    public partial class DesignViewModel : ObservableObject
    {
        /// <summary>
        /// The reference variable for the object representing the experiment's definition
        /// </summary>
        private Experiment _experiment;

        /// <summary>
        /// Observable collection of the viewmodels which will help edit/display stimulus definitions
        /// </summary>
        public ObservableCollection<StimulusItemViewModel> StimulusItemVMs { get; set; }

        /// <summary>
        /// Observable collection of the viewmodels which will help edit/display locator definitions
        /// </summary>
        public ObservableCollection<LocatorItemViewModel> LocatorItemVMs { get; set; }

        /// <summary>
        /// Observable collection of the viewmodels which will help edit/display locator definitions
        /// </summary>
        public ObservableCollection<BlockItemViewModel> BlockItemVMs { get; set; }

        /// <summary>
        /// This default constructor starts with empty lists of the inner viewmodel objects
        /// </summary>
        public DesignViewModel()
        {
            _experiment = new Experiment();
            
            StimulusItemVMs = new ObservableCollection<StimulusItemViewModel>();
            LocatorItemVMs = new ObservableCollection<LocatorItemViewModel>();
            BlockItemVMs = new ObservableCollection<BlockItemViewModel>();

            // Comment out the following lines when testing is done
            LoadTestExperiment();
        }

        /// <summary>
        /// This internal method loads an experiment from an existing file for testing purposes
        /// </summary>
        private void LoadTestExperiment()
        {
            Experiment? exp = Utility.LoadExperiment("C:\\Users\\freeb\\Documents\\HurPsyTest\\deney1\\deney1.xml");
            if (exp != null) { _experiment = exp; }
            ConstructViewModels();
        }

        /// <summary>
        /// This private method clears all lists of viewmodel objects before loading or starting a new experiment definition.
        /// </summary>
        private void ClearVMs()
        {
            StimulusItemVMs.Clear();
            LocatorItemVMs.Clear();
            BlockItemVMs.Clear();
        }

        /// <summary>
        /// A shortcut function to return the `Stimulus` object with the given id
        /// </summary>
        /// <param name="stimId">The Id of the `Stimulus` object to be accessed</param>
        /// <returns>The `Stimulus` object</returns>
        public Stimulus GetStimulus(string stimId)
        { return _experiment.GetStimulus(stimId); }

        /// <summary>
        /// A shortcut function to return the `Locator` object with the given id
        /// </summary>
        /// <param name="locId">The Id of the `Locator` object to be accessed</param>
        /// <returns>The `Locator` object</returns>
        public Locator GetLocator(string locId)
        { return _experiment.GetLocator(locId); }

        /// <summary>
        /// The method which will create a new experiment definition when the associated command is executed
        /// </summary>
        [RelayCommand]
        public void NewExperiment()
        {
            ClearVMs();
            _experiment = new Experiment();           
        }

        /// <summary>
        /// The method which will load an experiment definition from a file when the associated command is executed
        /// (Choosing the definition file and loading of the experiment is left to `Utility.LoadExperiment()` method because it depends on the runtime environment)
        /// </summary>
        [RelayCommand]
        public void LoadExperiment()
        {
            Experiment? exp = Utility.LoadExperiment();

            if (exp != null)
            {// If an experiment definition was successfully loaded,
                _experiment = exp;

                ConstructViewModels();
            }
        }

        /// <summary>
        /// This internal method constructs the viewmodel objects based on the experiment elements.
        /// </summary>
        private void ConstructViewModels()
        {
            ClearVMs(); // clear all the viewmodel objects

            // Create viewmodels based on the `Stimulus` objects loaded from the experiment definition
            List<Stimulus> expstims = _experiment.GetStimuli();
            foreach (Stimulus stim in expstims)
            {
                AddStimulusVM(stim);
            }

            // Create viewmodels based on the `Locator` objects loaded from the experiment definition
            List<Locator> explocs = _experiment.GetLocators();
            foreach (Locator loc in explocs)
            {
                AddLocatorVM(loc);
            }
            
            //Load experiment blocks and associate them with BlockViewModel objects
            foreach (Block blck in _experiment.Blocks)
            {
                BlockItemViewModel blockvm = new BlockItemViewModel(blck);
                BlockItemVMs.Add(blockvm);
            }
        }

        /// <summary>
        /// The method which will save an experiment definition to a file when the associated command is executed
        /// (Creating the definition file and saving the experiment definition is left to `Utility.SaveExperiment()` method because it depends on the runtime environment)
        /// </summary>
        [RelayCommand]
        public void SaveExperiment()
        {
            Utility.SaveExperiment(_experiment);
        }

        /// <summary>
        /// Create and add a viewmodel object associated with a `Stimulus` object
        /// </summary>
        /// <param name="stim"></param>
        private void AddStimulusVM(Stimulus stim)
        {
            StimulusItemViewModel stimvm = new StimulusItemViewModel(stim);
            // Add an event handler that will respond to IdChanged event of stimvm
            stimvm.IdChanged += StimVM_IdChanged;
            StimulusItemVMs.Add(stimvm);
            // Add the Id to the list of Ids shared by BlockViewModel objects,
            // so that they can be displayed in AddTrialView
            // BlockItemViewModel.AddStimulusId(stim.Id);
        }

        /// <summary>
        /// This method will create and add a viewmodel object associated with a `Locator` object
        /// </summary>
        /// <param name="loc"></param>
        private void AddLocatorVM(Locator loc)
        {
            LocatorItemViewModel locvm = new LocatorItemViewModel(loc);
            // Add an event handler that will respond to IdChanged event of locvm
            locvm.IdChanged += LocVM_IdChanged;
            LocatorItemVMs.Add(locvm);
            // Add the Id to the list of Ids shared by BlockViewModel objects,
            // so that they can be displayed in AddTrialView
            // BlockItemViewModel.AddLocatorId(loc.Id);
        }

        /// <summary>
        /// This method will handle the `IdChanged` events for `StimulusVM` objects
        /// </summary>
        /// <param name="sender">The object reporting the id change</param>
        /// <param name="e">Additional event info</param>
        private void StimVM_IdChanged(object? sender, IdChangeEventArgs e)
        {
            StimulusItemViewModel? stimvm = sender as StimulusItemViewModel;
            if (stimvm != null && e.NewId != null)
            {
                Stimulus? stim = stimvm.ItemObject as Stimulus;
                if (stim != null)
                {
                    string oldId = stim.Id;
                    // Ensure that the new Id is not a duplicate of an existing one
                    if (_experiment.StimulusIdExists(e.NewId) == false)
                    {
                        _experiment.ReplaceStimulusId(oldId, e.NewId);
                        // stim.Id = e.NewId; already been done in the above call
                        // TODO: Go through stimulus selections and the trial steps
                        // where the old Id was used and change them, too
                        //BlockItemViewModel.ReplaceStimulusId(oldId, stim.Id);

                        //foreach (BlockItemViewModel blckvm in this.BlockVMs)
                        //{
                        //    blckvm.ChangeStimulusId(oldId, e.NewId);
                        //}
                    }
                    else
                    {
                        // If the new id is not acceptable, StimulusViewModel object
                        // here reverts to the old id, but this results in
                        // this event handler being called once again.
                        // TODO: Find a way to revert the change without invoking this same method.
                        stimvm.TempId = oldId;
                    }
                }
            }
        }

        /// <summary>
        /// This method will handle the `IdChanged` events for `LocatorVM` objects
        /// </summary>
        /// <param name="sender">The object reporting the id change</param>
        /// <param name="e">Additional event info</param>
        private void LocVM_IdChanged(object? sender, IdChangeEventArgs e)
        {
            LocatorItemViewModel? locvm = sender as LocatorItemViewModel;
            if (locvm != null && e.NewId != null)
            {
                Locator? loc = locvm.ItemObject as Locator;
                if (loc != null)
                {
                    string oldId = loc.Id;
                    // Ensure that the new Id is not a duplicate of an existing one
                    if (_experiment.LocatorIdExists(e.NewId) == false)
                    {
                        _experiment.ReplaceLocatorId(oldId, e.NewId);
                        // TODO: Go through Locator selections and the trial steps
                        // where the old Id was used and change them, too
                        //BlockItemViewModel.ReplaceLocatorId(oldId, loc.Id);

                        //foreach (BlockItemViewModel blckvm in this.BlockVMs)
                        //{
                        //    blckvm.ChangeLocatorId(oldId, e.NewId);
                        //}
                    }
                    else
                    {
                        // If the new id is not acceptible, LocatorViewModel object
                        // here reverts to the old id, but this results in
                        // this event handler being called once again.
                        // TODO: Find a way to revert the change without invoking this same method.
                        locvm.TempId = oldId;
                    }
                }
            }
        }
    }
}
