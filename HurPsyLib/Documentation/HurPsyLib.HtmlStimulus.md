### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## HtmlStimulus Class

This class in intended to represents a viewbox displaying the contents of an HTML file.  
It implements the VisualStimulus interface because the stimulus will appear as a visual box displaying some information or instructions.

```csharp
public class HtmlStimulus : HurPsyLib.VisualStimulus
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus') &#129106; [VisualStimulus](HurPsyLib.VisualStimulus.md 'HurPsyLib.VisualStimulus') &#129106; HtmlStimulus
### Constructors

<a name='HurPsyLib.HtmlStimulus.HtmlStimulus()'></a>

## HtmlStimulus() Constructor

This default constructor starts with a size which will be valid in case an experiment designer has not set any size.

```csharp
public HtmlStimulus();
```