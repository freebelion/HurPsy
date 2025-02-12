using HurPsyLib;

namespace HurPsyExp.ExpDesign
{
    /// <summary>
    /// This viewmodel class will help data exchange between a `Stimulus` object and its `ItemView` on the design interface.
    /// </summary>
    public class StimulusItemViewModel : ItemViewModel
    {
        /// <summary>
        /// This parametrized constructor creates an `ItemViewModel` instance associated with the given `Stimulus` object 
        /// </summary>
        /// <param name="stim">The `Stimulus` object which will be associated with this viewmodel</param>
        public StimulusItemViewModel(Stimulus stim) : base(stim)
        {
            TempId = stim.Id;
        }

        /// <summary>
        /// This property returns the path of the image file which will serve as the icon representing the stimulus type
        /// </summary>
        public override string IconImage
        {
            get
            {
                if (ItemObject != null && ItemObject is Stimulus)
                {
                    switch ((Stimulus)ItemObject)
                    {
                        case HtmlStimulus htmstim:
                            return @"../Images/HtmlStimulus.png";
                        case ImageStimulus imgstim:
                            return @"../Images/ImageStimulus.png";
                    }
                }

                return string.Empty;
            }
        }
    }
}