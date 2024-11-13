using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Text.Json.Serialization;
using System.IO;
using System.Text.Json;
using CommunityToolkit.Mvvm.Input;
using HurPsyLib;

namespace HurPsyExp
{
    /// <summary>
    /// This class houses the settings related to the visual appearance of the design interface.
    /// It is derived from `ObservableObject` class of the Mvvm Communigty Toolkit, so it acts as its own viewmodel.
    /// For that reason, it cannot implement DataContract serialization; instead, it is (de)serialized by the `App` class via a JsonSeralizer.
    /// </summary>
    public partial class DesignSettings : ObservableObject
    {
        /// <summary>
        /// Minimum font size allowed by the app
        /// (Being an app-level setting, this property value won't be serialized)
        /// </summary>
        [JsonIgnore]
        public double MinFontSize {  get; private set; }

        /// <summary>
        /// Maximum font size allowed by the app
        /// (Being an app-level setting, this property value won't be serialized)
        /// </summary>
        [JsonIgnore]
        public double MaxFontSize { get; private set; }

        /// <summary>
        /// Mininum width for the panels that collapse and open horizontally
        /// (Being an app-level setting, this property value won't be serialized)
        /// </summary>
        [JsonIgnore] 
        public double MinPanelWidth { get; private set; }

        /// <summary>
        /// Maximum width for the panels that collapse and open horizontally
        /// (Being an app-level setting, this property value won't be serialized)
        /// </summary>
        [JsonIgnore] 
        public double MaxPanelWidth { get; private set; }

        /// <summary>
        /// Mininum size for a command button or an image preview
        /// (Being an app-level setting, this property value won't be serialized)
        /// </summary>
        [JsonIgnore]
        public double MinButtonHeight { get; private set; }

        /// <summary>
        /// Maximum size for a command button or an image preview
        /// (Being an app-level setting, this property value won't be serialized)
        /// </summary>
        [JsonIgnore]
        public double MaxButtonHeight { get; private set; }

        /// <summary>
        /// The font size of the user interface
        /// </summary>
        [ObservableProperty]
        private double uIFontSize;

        /// <summary>
        /// The size of the small font used in item views
        /// </summary>
        [ObservableProperty]
        private double smallFontSize;

        /// <summary>
        /// The font size for the menu options
        /// </summary>
        [ObservableProperty]
        private double menuFontSize;

        /// <summary>
        /// The width of the panel which holds the elements' definitions
        /// </summary>
        [ObservableProperty]
        private double elementsPanelWidth;

        /// <summary>
        /// The width of the panel which helps arrange the trials and blocks
        /// </summary>
        [ObservableProperty]
        private double experimentPanelWidth;

        /// <summary>
        /// The preferred time (in milliseconds) for experiment steps
        /// </summary>
        [ObservableProperty]
        private double typicalStepTime;

        /// <summary>
        /// The preferred height for toolbar buttons
        /// </summary>
        [ObservableProperty]
        private double commandButtonHeight;

        /// <summary>
        /// The preferred height for the icon images in the item views
        /// </summary>
        [ObservableProperty]
        private double imagePreviewHeight;

        [RelayCommand]
        public void Increment(string sliderName)
        {
            switch(sliderName)
            {
                case "Slider_UIFontSize":
                    UIFontSize++;
                    break;
                case "Slider_SmallFontSize":
                    SmallFontSize++;
                    break;
                case "Slider_MenuFontSize":
                    MenuFontSize++;
                    break;
                case "Slider_CommandButtonHeight":
                    CommandButtonHeight++;
                    break;
                case "Slider_ImagePreviewHeight":
                    ImagePreviewHeight++;
                    break;
            }
        }

        [RelayCommand]
        public void Decrement(string sliderName)
        {
            switch (sliderName)
            {
                case "Slider_UIFontSize":
                    UIFontSize--;
                    break;
                case "Slider_SmallFontSize":
                    SmallFontSize--;
                    break;
                case "Slider_MenuFontSize":
                    MenuFontSize--;
                    break;
                case "Slider_CommandButtonHeight":
                    CommandButtonHeight--;
                    break;
                case "Slider_ImagePreviewHeight":
                    ImagePreviewHeight--;
                    break;
            }
        }

        /// <summary>
        /// This default constructor assigns initial values to all the properties as deemed fit by the programmer
        /// </summary>
        public DesignSettings()
        {
            MinFontSize = 6;
            MaxFontSize = 60;
            UIFontSize = 20;
            MenuFontSize = 16;
            SmallFontSize = 14;

            TypicalStepTime = 500;

            MinButtonHeight = 8;
            MaxButtonHeight = 64;
            CommandButtonHeight = 24;
            ImagePreviewHeight = 24;
            
            MinPanelWidth = 100;
            MaxPanelWidth = 500;
            ElementsPanelWidth = 250;
            ExperimentPanelWidth = 250;
        }

        /// <summary>
        /// This method serializes this object via Json
        /// </summary>
        public void SerializeJson()
        {
            using (Stream writer = new FileStream("DesignPreferences.json", FileMode.Create))
            {
                JsonSerializer.Serialize<DesignSettings>(writer, this);
            }
        }

        /// <summary>
        /// This method loads up the Json-Serialized instance of `DesignSettings` and transfers the previously saved user preferences.
        /// Since the design settings were referred in multiple independent XAML files, I kept an object of `DesignSettings` as a resource in `App.xaml` file.
        /// Since it was a `StaticResource`, that object could not be loaded directly from a file. That's why its user-defined properties are transferred from the loaded copy. 
        /// </summary>
        public void DeSerializeJson()
        {
            if (File.Exists("DesignPreferences.json"))
            {
                using (Stream reader = new FileStream("DesignPreferences.json", FileMode.Open))
                {
                    DesignSettings? loadedPreferences = JsonSerializer.Deserialize<DesignSettings>(reader);
                    if (loadedPreferences != null)
                    {
                        this.UIFontSize = loadedPreferences.UIFontSize;
                        this.SmallFontSize = loadedPreferences.SmallFontSize;
                        this.MenuFontSize = loadedPreferences.MenuFontSize;

                        this.TypicalStepTime = loadedPreferences.TypicalStepTime;

                        this.CommandButtonHeight = loadedPreferences.CommandButtonHeight;
                        this.ImagePreviewHeight = loadedPreferences.ImagePreviewHeight;

                        this.ElementsPanelWidth = loadedPreferences.ElementsPanelWidth;
                        this.ExperimentPanelWidth = loadedPreferences.ExperimentPanelWidth;
                    }
                }
            }
        }
    }
}
