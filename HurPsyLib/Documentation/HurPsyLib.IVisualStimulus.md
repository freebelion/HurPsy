### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## IVisualStimulus Interface

A common interface which must be implemented by all classes which will represent visual stimuli

```csharp
public interface IVisualStimulus
```

Derived  
&#8627; [HtmlStimulus](HurPsyLib.HtmlStimulus.md 'HurPsyLib.HtmlStimulus')  
&#8627; [ImageStimulus](HurPsyLib.ImageStimulus.md 'HurPsyLib.ImageStimulus')
### Properties

<a name='HurPsyLib.IVisualStimulus.VisualSize'></a>

## IVisualStimulus.VisualSize Property

Any object representing a visual stimulus must have a property to get/set the stimulus size

```csharp
HurPsyLib.HurPsySize VisualSize { get; set; }
```

#### Property Value
[HurPsySize](HurPsyLib.HurPsySize.md 'HurPsyLib.HurPsySize')