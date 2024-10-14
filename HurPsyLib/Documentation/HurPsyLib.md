## HurPsyLib Namespace

| Classes | |
| :--- | :--- |
| [Block](HurPsyLib.Block.md 'HurPsyLib.Block') | The class which represents a block of experimental trials as a collection of `Trial` objects. |
| [Experiment](HurPsyLib.Experiment.md 'HurPsyLib.Experiment') | The class which represents the complete definition of a computerized psychology experiment. |
| [HtmlStimulus](HurPsyLib.HtmlStimulus.md 'HurPsyLib.HtmlStimulus') | This class in intended to represents a viewbox displaying the contents of an HTML file.<br/>It implements the VisualStimulus interface because the stimulus will appear as a visual box displaying some information or instructions. |
| [HurPsyCommon](HurPsyLib.HurPsyCommon.md 'HurPsyLib.HurPsyCommon') | This static class serves as a container for global objects utilized by all the `HurPsyLib` objects |
| [HurPsyException](HurPsyLib.HurPsyException.md 'HurPsyLib.HurPsyException') | Customary specialized Exception class |
| [HurPsyPoint](HurPsyLib.HurPsyPoint.md 'HurPsyLib.HurPsyPoint') | This class represents a point object to specify the position of a visual stimulus or its anchor point.<br/>Its whole point is to keep `HurPsyLib` objects independent of the GUIs used for designing or running experiments. |
| [HurPsySize](HurPsyLib.HurPsySize.md 'HurPsyLib.HurPsySize') | This class represents a size object to specify the dimensions of a visual stimulus.<br/>Its whole point is to keep `HurPsyLib` objects independent of the GUIs used for designing or running experiments. |
| [HurPsyTimePeriod](HurPsyLib.HurPsyTimePeriod.md 'HurPsyLib.HurPsyTimePeriod') | The class which encapculates information about a time period, independent of the OS where an expperiment is designed or run. |
| [ImageStimulus](HurPsyLib.ImageStimulus.md 'HurPsyLib.ImageStimulus') | This class is intended to represent an image served as a visual stimulus (hence it implements the VisualStimulus interface) |
| [Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator') | The abstract class which serves as the blueprint for all classes which will help position experimental stimuli according to their own rules |
| [PointLocator](HurPsyLib.PointLocator.md 'HurPsyLib.PointLocator') | This class represents a single-point locator |
| [RectangleLocator](HurPsyLib.RectangleLocator.md 'HurPsyLib.RectangleLocator') | This class is for positioning a visual stimulus in a rectangular area |
| [Step](HurPsyLib.Step.md 'HurPsyLib.Step') | The class which represents a step in an experimental trial.<br/>It contains information on which stimuli will be presented together, at which locations and for how long. |
| [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus') | The abstract class which serves as the blueprint for all classes which will represent different types of experimental stimuli |
| [StimulusLocatorPair](HurPsyLib.StimulusLocatorPair.md 'HurPsyLib.StimulusLocatorPair') | The class which associates a `Stimulus` object with a `Locator` object by pairing their ids.<br/>Any such pairing which appears in a `Step` object representing a trial step will help display a stimulus at the position specified by the associated locator. |
| [Trial](HurPsyLib.Trial.md 'HurPsyLib.Trial') | The class which represents an experimental trial as a collection of `Step` objects representing successive steps where groups of stimuli are presented together |
| [VisualStimulus](HurPsyLib.VisualStimulus.md 'HurPsyLib.VisualStimulus') | This abstract class will be the basis for all classes which will represent visual stimuli.<br/>(It was first designed to be an interface, but that required all derived classes to keep their size and anchor information separately, so I turned it to an abstract class) |

| Enums | |
| :--- | :--- |
| [HurPsyOrigin](HurPsyLib.HurPsyOrigin.md 'HurPsyLib.HurPsyOrigin') | This enum contains the allowed origin preferences when specifying stimulus locations and anchor points for visual stimulus rectangles |
| [HurPsyUnit](HurPsyLib.HurPsyUnit.md 'HurPsyLib.HurPsyUnit') | This enum contains the allowed unit choices which will be used with  stimulus locations and sizes |
