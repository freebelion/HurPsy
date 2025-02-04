## HurPsyLib Namespace

| Classes | |
| :--- | :--- |
| [Block](HurPsyLib.Block.md 'HurPsyLib.Block') | This class represents a block of experimental trials as a collection of `Trial` objects. |
| [Experiment](HurPsyLib.Experiment.md 'HurPsyLib.Experiment') | This class represents the complete definition of a computerized psychology experiment. |
| [HtmlStimulus](HurPsyLib.HtmlStimulus.md 'HurPsyLib.HtmlStimulus') | This class represents a viewbox displaying the contents of an HTML file.<br/>It implements the `VisualStimulus` interface to determinee the size of the visual box. |
| [HurPsyCommon](HurPsyLib.HurPsyCommon.md 'HurPsyLib.HurPsyCommon') | This static class serves as a container for global objects utilized by all the `HurPsyLib` objects |
| [HurPsyException](HurPsyLib.HurPsyException.md 'HurPsyLib.HurPsyException') | This library's specialized Exception class |
| [HurPsyPoint](HurPsyLib.HurPsyPoint.md 'HurPsyLib.HurPsyPoint') | This class represents a point object to specify a position on the experiment's coordinate system.<br/>Its whole point is to keep `HurPsyLib` objects independent of the GUIs used for designing or running experiments. |
| [HurPsySize](HurPsyLib.HurPsySize.md 'HurPsyLib.HurPsySize') | This class helps specify the dimensions of a visual stimulus.<br/>Its whole point is to keep `HurPsyLib` objects independent of the GUIs used for designing or running experiments. |
| [HurPsyTimePeriod](HurPsyLib.HurPsyTimePeriod.md 'HurPsyLib.HurPsyTimePeriod') | This class helps specify a time period. |
| [ImageStimulus](HurPsyLib.ImageStimulus.md 'HurPsyLib.ImageStimulus') | This class represents an image served as a visual stimulus (hence it implements the `VisualStimulus` interface) |
| [Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator') | This abstract class serves as the blueprint for all subclasses which will help position `Stimulus` objects. |
| [PointLocator](HurPsyLib.PointLocator.md 'HurPsyLib.PointLocator') | This class represents a single-point locator |
| [RectangleLocator](HurPsyLib.RectangleLocator.md 'HurPsyLib.RectangleLocator') | This class represents a rectangular area where a stimulus will be positioned |
| [Step](HurPsyLib.Step.md 'HurPsyLib.Step') | This class represents a step in an experimental trial.<br/>It contains information on which stimuli will be presented together, at which locations and for how long. |
| [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus') | This abstract class serves as the blueprint for all classes which will represent different types of experimental stimuli |
| [StimulusLocatorPair](HurPsyLib.StimulusLocatorPair.md 'HurPsyLib.StimulusLocatorPair') | This class associates a `Stimulus` object with a `Locator` object by pairing their ids.<br/>Such pairs appear in `Step` objects representing trial steps where `Stimulus` objects appear at positions determined by their associated `Locator` objects. |
| [Trial](HurPsyLib.Trial.md 'HurPsyLib.Trial') | This class represents an experimental trial as a collection of `Step` objects representing successive steps where groups of stimuli are presented together.<br/>A collection of steps make up a trial when a response is required from the participant. |
| [VisualStimulus](HurPsyLib.VisualStimulus.md 'HurPsyLib.VisualStimulus') | This abstract class will be the basis for all classes which will represent visual stimuli.<br/>(It was first designed to be an interface, but that required all derived classes to keep their size and anchor information separately, so I turned it to an abstract class) |

| Enums | |
| :--- | :--- |
| [HurPsyOrigin](HurPsyLib.HurPsyOrigin.md 'HurPsyLib.HurPsyOrigin') | This `enum` contains the allowed origin preferences when specifying stimulus locations and anchor points for visual stimulus rectangles. |
| [HurPsyUnit](HurPsyLib.HurPsyUnit.md 'HurPsyLib.HurPsyUnit') | This `enum` contains the allowed unit choices which will be used with  stimulus locations and sizes. |
