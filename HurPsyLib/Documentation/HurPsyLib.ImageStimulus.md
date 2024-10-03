### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## ImageStimulus Class

This class is intended to represent an image served as a visual stimulus (hence it implements the IVisualStimulus interface)

```csharp
public class ImageStimulus : HurPsyLib.Stimulus,
HurPsyLib.IVisualStimulus
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus') &#129106; ImageStimulus

Implements [IVisualStimulus](HurPsyLib.IVisualStimulus.md 'HurPsyLib.IVisualStimulus')
### Constructors

<a name='HurPsyLib.ImageStimulus.ImageStimulus()'></a>

## ImageStimulus() Constructor

This default constructor starts with an image size of 10 mm by 10 mm (didn't want to cause surprise by starting with zero size)

```csharp
public ImageStimulus();
```
### Properties

<a name='HurPsyLib.ImageStimulus.VisualSize'></a>

## ImageStimulus.VisualSize Property

The property required by the IVisualStimulus interface to get/set the image size

```csharp
public HurPsyLib.HurPsySize VisualSize { get; set; }
```

Implements [VisualSize](HurPsyLib.IVisualStimulus.md#HurPsyLib.IVisualStimulus.VisualSize 'HurPsyLib.IVisualStimulus.VisualSize')

#### Property Value
[HurPsySize](HurPsyLib.HurPsySize.md 'HurPsyLib.HurPsySize')