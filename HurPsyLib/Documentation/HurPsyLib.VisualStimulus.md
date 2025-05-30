### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## VisualStimulus Class

This abstract class will be the basis for all classes which will represent visual stimuli.

```csharp
public abstract class VisualStimulus : HurPsyLib.Stimulus
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [IdObject](HurPsyLib.IdObject.md 'HurPsyLib.IdObject') &#129106; [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus') &#129106; VisualStimulus

Derived  
&#8627; [ImageStimulus](HurPsyLib.ImageStimulus.md 'HurPsyLib.ImageStimulus')
### Constructors

<a name='HurPsyLib.VisualStimulus.VisualStimulus()'></a>

## VisualStimulus() Constructor

This default constructor starts with an empty (zero) size

```csharp
public VisualStimulus();
```
### Properties

<a name='HurPsyLib.VisualStimulus.VisualSize'></a>

## VisualStimulus.VisualSize Property

Any object representing a visual stimulus must have a property to get/set the stimulus size  
(which has a unit of millimeters, by default)

```csharp
public HurPsyLib.HurPsySize VisualSize { get; set; }
```

#### Property Value
[HurPsySize](HurPsyLib.HurPsySize.md 'HurPsyLib.HurPsySize')