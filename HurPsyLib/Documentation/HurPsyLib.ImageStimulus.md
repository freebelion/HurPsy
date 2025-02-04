### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## ImageStimulus Class

This class represents an image served as a visual stimulus (hence it implements the `VisualStimulus` interface)

```csharp
public class ImageStimulus : HurPsyLib.VisualStimulus
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus') &#129106; [VisualStimulus](HurPsyLib.VisualStimulus.md 'HurPsyLib.VisualStimulus') &#129106; ImageStimulus
### Constructors

<a name='HurPsyLib.ImageStimulus.ImageStimulus()'></a>

## ImageStimulus() Constructor

This default constructor starts with an image size of 10 mm by 10 mm (didn't want to cause surprise by starting with zero size)

```csharp
public ImageStimulus();
```