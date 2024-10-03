### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## HtmlStimulus Class

This class in intended to represents a viewbox displaying the contents of an HTML file.  
It implements the IVisualStimulus interface because the stimulus will appear as a visual box displaying some information or instructions.

```csharp
public class HtmlStimulus : HurPsyLib.Stimulus,
HurPsyLib.IVisualStimulus
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus') &#129106; HtmlStimulus

Implements [IVisualStimulus](HurPsyLib.IVisualStimulus.md 'HurPsyLib.IVisualStimulus')
### Constructors

<a name='HurPsyLib.HtmlStimulus.HtmlStimulus()'></a>

## HtmlStimulus() Constructor

This default constructor starts with a size which will be valid in case an experiment designer has not set any size.

```csharp
public HtmlStimulus();
```
### Properties

<a name='HurPsyLib.HtmlStimulus.VisualSize'></a>

## HtmlStimulus.VisualSize Property

The required IVisualStimulus property to get/set the display box size

```csharp
public HurPsyLib.HurPsySize VisualSize { get; set; }
```

Implements [VisualSize](HurPsyLib.IVisualStimulus.md#HurPsyLib.IVisualStimulus.VisualSize 'HurPsyLib.IVisualStimulus.VisualSize')

#### Property Value
[HurPsySize](HurPsyLib.HurPsySize.md 'HurPsyLib.HurPsySize')