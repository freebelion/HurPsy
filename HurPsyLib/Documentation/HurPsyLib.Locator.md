### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## Locator Class

The abstract class which serves as the blueprint for all classes which will help position experimental stimuli according to their own rules

```csharp
public abstract class Locator
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Locator

Derived  
&#8627; [PointLocator](HurPsyLib.PointLocator.md 'HurPsyLib.PointLocator')  
&#8627; [RectangleLocator](HurPsyLib.RectangleLocator.md 'HurPsyLib.RectangleLocator')
### Constructors

<a name='HurPsyLib.Locator.Locator()'></a>

## Locator() Constructor

This default constructor will assign a temporary unique id to every instance, one based on its type

```csharp
public Locator();
```
### Properties

<a name='HurPsyLib.Locator.Id'></a>

## Locator.Id Property

`Id` will serve as a uniquely identifying string for each instance

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Methods

<a name='HurPsyLib.Locator.GetLocation(HurPsyLib.VisualStimulus)'></a>

## Locator.GetLocation(VisualStimulus) Method

Derived classes will have to implement this function to specify a location for a visual stimulus

```csharp
public abstract HurPsyLib.HurPsyPoint GetLocation(HurPsyLib.VisualStimulus? vistim=null);
```
#### Parameters

<a name='HurPsyLib.Locator.GetLocation(HurPsyLib.VisualStimulus).vistim'></a>

`vistim` [VisualStimulus](HurPsyLib.VisualStimulus.md 'HurPsyLib.VisualStimulus')

The visual stimulus which will be positioned according to the outcome

#### Returns
[HurPsyPoint](HurPsyLib.HurPsyPoint.md 'HurPsyLib.HurPsyPoint')  
The position specified for the visual stimulus