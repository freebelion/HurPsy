## HurPsyLib Namespace

| Classes | |
| :--- | :--- |
| [Block](HurPsyLib.Block.md 'HurPsyLib.Block') | The class which represents a block of experimental trials as a collection of `Trial` objects. |
| [Experiment](HurPsyLib.Experiment.md 'HurPsyLib.Experiment') | The class which represents the complete definition of a computerized psychology experiment. |
| [HurPsyException](HurPsyLib.HurPsyException.md 'HurPsyLib.HurPsyException') | Customary specialized Exception class |
| [Step](HurPsyLib.Step.md 'HurPsyLib.Step') | The class which represents a step in an experimental trial.<br/>It contains information on which stimuli will be presented together, at which locations and for how long. |
| [StimulusLocatorPair](HurPsyLib.StimulusLocatorPair.md 'HurPsyLib.StimulusLocatorPair') | The class which associates a `Stimulus` object with a `Locator` object by pairing their ids.<br/>Any such pairing which appears in a `Step` object representing a trial step will help display a stimulus at the position specified by the associated locator. |
| [Trial](HurPsyLib.Trial.md 'HurPsyLib.Trial') | The class which represents an experimental trial as a collection of `Step` objects representing successive steps where groups of stimuli are presented together |
