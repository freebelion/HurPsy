### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## VisualStimulus Class

This abstract class will be the basis for all classes which will represent visual stimuli.  
(It was first designed to be an interface, but that required all derived classes to keep their size and anchor information separately, so I turned it to an abstract class)

```csharp
public abstract class VisualStimulus : HurPsyLib.Stimulus
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus') &#129106; VisualStimulus

Derived  
&#8627; [HtmlStimulus](HurPsyLib.HtmlStimulus.md 'HurPsyLib.HtmlStimulus')  
&#8627; [ImageStimulus](HurPsyLib.ImageStimulus.md 'HurPsyLib.ImageStimulus')
### Constructors

<a name='HurPsyLib.VisualStimulus.VisualStimulus()'></a>

## VisualStimulus() Constructor

This default constructor starts with an empty (zero) size

```csharp
public VisualStimulus();
```
### Properties

<a name='HurPsyLib.VisualStimulus.AnchorChoice'></a>

## VisualStimulus.AnchorChoice Property

Any object representing a visual stimulus must have a property to get/set its preferred anchor point  
(which is the middle center of the stimulus object, by default)

```csharp
public HurPsyLib.HurPsyOrigin AnchorChoice { get; set; }
```

#### Property Value
[HurPsyOrigin](HurPsyLib.HurPsyOrigin.md 'HurPsyLib.HurPsyOrigin')

<a name='HurPsyLib.VisualStimulus.VisualSize'></a>

## VisualStimulus.VisualSize Property

Any object representing a visual stimulus must have a property to get/set the stimulus size  
(which has a unit of millimeters, by default)

```csharp
public HurPsyLib.HurPsySize VisualSize { get; set; }
```

#### Property Value
[HurPsySize](HurPsyLib.HurPsySize.md 'HurPsyLib.HurPsySize')