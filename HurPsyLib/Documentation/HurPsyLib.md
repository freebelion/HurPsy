## HurPsyLib Namespace

| Classes | |
| :--- | :--- |
| [ExpBlock](HurPsyLib.ExpBlock.md 'HurPsyLib.ExpBlock') | This class represents a block of experiment trials. |
| [Experiment](HurPsyLib.Experiment.md 'HurPsyLib.Experiment') | This class represents the complete definition of a computerized psychology experiment. |
| [ExpPair](HurPsyLib.ExpPair.md 'HurPsyLib.ExpPair') | This class represents an association between a `Stimulus` and a `Locator` which specifies a location for the stimulus. |
| [ExpStep](HurPsyLib.ExpStep.md 'HurPsyLib.ExpStep') | This class represents a trial step of an experiment,<br/>a step being a collection of stimuli presented together, for a specified period of time. |
| [ExpTrial](HurPsyLib.ExpTrial.md 'HurPsyLib.ExpTrial') | This class represents an experiment trial made up of one or more steps. |
| [HurPsyCommon](HurPsyLib.HurPsyCommon.md 'HurPsyLib.HurPsyCommon') | This static class serves as a container for global objects utilized by all the `HurPsyLib` objects |
| [HurPsyException](HurPsyLib.HurPsyException.md 'HurPsyLib.HurPsyException') | This library's specialized Exception class |
| [HurPsyPoint](HurPsyLib.HurPsyPoint.md 'HurPsyLib.HurPsyPoint') | This class represents a point object to specify a position on the experiment's coordinate system.<br/>Its whole point is to keep `HurPsyLib` objects independent of the GUIs used for designing or running experiments. |
| [HurPsySize](HurPsyLib.HurPsySize.md 'HurPsyLib.HurPsySize') | This class helps specify the dimensions of a visual stimulus.<br/>Its whole point is to keep `HurPsyLib` objects independent of the GUIs used for designing or running experiments. |
| [HurPsyTimePeriod](HurPsyLib.HurPsyTimePeriod.md 'HurPsyLib.HurPsyTimePeriod') | This class helps specify a time period. |
| [IdObject](HurPsyLib.IdObject.md 'HurPsyLib.IdObject') | This abstract class enables all instances of derived classes to have temporary Ids assigned. |
| [ImageStimulus](HurPsyLib.ImageStimulus.md 'HurPsyLib.ImageStimulus') | This class represents an image served as a visual stimulus (hence it implements the `VisualStimulus` interface) |
| [Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator') | This abstract class serves as the blueprint for all subclasses which will help position `Stimulus` objects. |
| [PointLocator](HurPsyLib.PointLocator.md 'HurPsyLib.PointLocator') | This class stores a specific location point and uses its coordinates to produce a location for any visual stimulus |
| [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus') | This abstract class serves as the blueprint for all classes which will represent different types of experimental stimuli. |
| [VisualStimulus](HurPsyLib.VisualStimulus.md 'HurPsyLib.VisualStimulus') | This abstract class will be the basis for all classes which will represent visual stimuli. |

| Enums | |
| :--- | :--- |
| [HurPsyOrigin](HurPsyLib.HurPsyOrigin.md 'HurPsyLib.HurPsyOrigin') | This `enum` contains the allowed origin preferences when specifying stimulus locations and anchor points for visual stimulus rectangles. |
| [HurPsyUnit](HurPsyLib.HurPsyUnit.md 'HurPsyLib.HurPsyUnit') | This `enum` contains the allowed unit choices which will be used with  stimulus locations and sizes. |
