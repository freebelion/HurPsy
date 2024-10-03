### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## Stimulus Class

The abstract class which serves as the blueprint for all classes which will represent different types of experimental stimuli

```csharp
public abstract class Stimulus
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Stimulus

Derived  
&#8627; [HtmlStimulus](HurPsyLib.HtmlStimulus.md 'HurPsyLib.HtmlStimulus')  
&#8627; [ImageStimulus](HurPsyLib.ImageStimulus.md 'HurPsyLib.ImageStimulus')
### Constructors

<a name='HurPsyLib.Stimulus.Stimulus()'></a>

## Stimulus() Constructor

Every instance of any class representing an experimental stimulus will start with a temporary unique id and an empty filename

```csharp
public Stimulus();
```
### Properties

<a name='HurPsyLib.Stimulus.FileName'></a>

## Stimulus.FileName Property

`FileName` will contain the full path of the file containing the actual Stimulus object

```csharp
public string FileName { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.Stimulus.Id'></a>

## Stimulus.Id Property

`Id` will serve as a uniquely identifying string for each instance

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')