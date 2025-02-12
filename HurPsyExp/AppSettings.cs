using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace HurPsyExp
{
    /// <summary>
    /// This class houses the settings related to the visual appearance of the experiment design/run interfaces.
    /// It is derived from `ObservableObject` class of the Mvvm Communigty Toolkit, so it acts as its own viewmodel.
    /// For that reason, it cannot implement DataContract serialization; instead, it is (de)serialized by the `App` class via a JsonSeralizer.
    /// </summary>
    public partial class AppSettings : ObservableObject
    {
        /// <summary>
        /// Minimum font size allowed by the app
        /// (Being an app-level setting, this property value won't be serialized)
        /// </summary>
        [JsonIgnore]
        public double MinFontSize { get; private set; }

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
        private double fontSize;

        /// <summary>
        /// The font size for the menu options
        /// </summary>
        [ObservableProperty]
        private double menuFontSize;
        
        /// <summary>
        /// The size of the small font used in item views
        /// </summary>
        [ObservableProperty]
        private double smallFontSize;

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
        /// The preferred height for toolbar buttons
        /// </summary>
        [ObservableProperty]
        private double commandButtonHeight;

        /// <summary>
        /// The preferred height for the icon images in the item views
        /// </summary>
        [ObservableProperty]
        private double imagePreviewHeight;

        /// <summary>
        /// This default constructor assigns initial values to all the properties as deemed fit by the programmer
        /// </summary>
        public AppSettings()
        {
            MinFontSize = 10;
            MaxFontSize = 60;
            FontSize = 20;
            MenuFontSize = 16;
            SmallFontSize = 14;

            MinPanelWidth = 100;
            MaxPanelWidth = 500;
            ElementsPanelWidth = 250;
            ExperimentPanelWidth = 250;

            MinButtonHeight = 8;
            MaxButtonHeight = 64;
            CommandButtonHeight = 24;
            ImagePreviewHeight = 24;
        }

        /// <summary>
        /// This method, when executed as a command, will increment the value of the property associated with the named slider.
        /// </summary>
        /// <param name="sliderName">The name of the NumericUpDownSlider where the increment button was clicked</param>
        [RelayCommand]
        public void Increment(string sliderName)
        {
            switch (sliderName)
            {
                case "Slider_FontSize":
                    FontSize++;
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

        /// <summary>
        /// This method, when executed as a command, will decrement the value of the property associated with the named slider.
        /// </summary>
        /// <param name="sliderName">The name of the NumericUpDownSlider where the increment button was clicked</param>
        [RelayCommand]
        public void Decrement(string sliderName)
        {
            switch (sliderName)
            {
                case "Slider_FontSize":
                    FontSize--;
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
    }
}
