### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## Locator Class

This abstract class serves as the blueprint for all subclasses which will help position `Stimulus` objects.

```csharp
public abstract class Locator : HurPsyLib.IdObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [IdObject](HurPsyLib.IdObject.md 'HurPsyLib.IdObject') &#129106; Locator

Derived  
&#8627; [PointLocator](HurPsyLib.PointLocator.md 'HurPsyLib.PointLocator')
### Constructors

<a name='HurPsyLib.Locator.Locator()'></a>

## Locator() Constructor

At this time, this default constructor doesn't need to do anything; the base class handles the temporary unique Id

```csharp
public Locator();
```
### Methods

<a name='HurPsyLib.Locator.GetLocation(HurPsyLib.VisualStimulus)'></a>

## Locator.GetLocation(VisualStimulus) Method

Derived classes will have to override this abstract function to produce a location for the given `VisualStimulus` object.

```csharp
public abstract HurPsyLib.HurPsyPoint GetLocation(HurPsyLib.VisualStimulus? vistim=null);
```
#### Parameters

<a name='HurPsyLib.Locator.GetLocation(HurPsyLib.VisualStimulus).vistim'></a>

`vistim` [VisualStimulus](HurPsyLib.VisualStimulus.md 'HurPsyLib.VisualStimulus')

The visual stimulus to be placed

#### Returns
[HurPsyPoint](HurPsyLib.HurPsyPoint.md 'HurPsyLib.HurPsyPoint')  
A location produced according to the method of the derived class