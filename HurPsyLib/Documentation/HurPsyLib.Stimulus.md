### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## Stimulus Class

This abstract class serves as the blueprint for all classes which will represent different types of experimental stimuli.

```csharp
public abstract class Stimulus : HurPsyLib.IdObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [IdObject](HurPsyLib.IdObject.md 'HurPsyLib.IdObject') &#129106; Stimulus

Derived  
&#8627; [VisualStimulus](HurPsyLib.VisualStimulus.md 'HurPsyLib.VisualStimulus')
### Constructors

<a name='HurPsyLib.Stimulus.Stimulus()'></a>

## Stimulus() Constructor

This default constructor, after getting the object Id is initialized by the base class, starts with an empty string for the filename.

```csharp
public Stimulus();
```
### Properties

<a name='HurPsyLib.Stimulus.FileName'></a>

## Stimulus.FileName Property

The full path of the file containing the actual Stimulus object

```csharp
public string FileName { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')