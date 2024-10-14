### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## RectangleLocator Class

This class is for positioning a visual stimulus in a rectangular area

```csharp
public class RectangleLocator : HurPsyLib.Locator
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator') &#129106; RectangleLocator
### Constructors

<a name='HurPsyLib.RectangleLocator.RectangleLocator()'></a>

## RectangleLocator() Constructor

This default constructor creates a zero-size rectangle at the origin point

```csharp
public RectangleLocator();
```
### Properties

<a name='HurPsyLib.RectangleLocator.RectangleLocation'></a>

## RectangleLocator.RectangleLocation Property

The anchor point of the positioning rectangle (taken to be the center of the rectangle due to the default origin choice)  
Note that extra code might have to be written if more origin choices are implemented in the `HurPsyOrigin` enumeration.

```csharp
public HurPsyLib.HurPsyPoint RectangleLocation { get; set; }
```

#### Property Value
[HurPsyPoint](HurPsyLib.HurPsyPoint.md 'HurPsyLib.HurPsyPoint')

<a name='HurPsyLib.RectangleLocator.RectangleSize'></a>

## RectangleLocator.RectangleSize Property

The size of the positioning rectangle

```csharp
public HurPsyLib.HurPsySize RectangleSize { get; set; }
```

#### Property Value
[HurPsySize](HurPsyLib.HurPsySize.md 'HurPsyLib.HurPsySize')
### Methods

<a name='HurPsyLib.RectangleLocator.GetLocation(HurPsyLib.VisualStimulus)'></a>

## RectangleLocator.GetLocation(VisualStimulus) Method

The required implementation of the function inherited from the abstract base class will specify a randomized position within the underlying rectangle

```csharp
public override HurPsyLib.HurPsyPoint GetLocation(HurPsyLib.VisualStimulus? vistim=null);
```
#### Parameters

<a name='HurPsyLib.RectangleLocator.GetLocation(HurPsyLib.VisualStimulus).vistim'></a>

`vistim` [VisualStimulus](HurPsyLib.VisualStimulus.md 'HurPsyLib.VisualStimulus')

The visual stimulus which will be positioned by this locator instance

#### Returns
[HurPsyPoint](HurPsyLib.HurPsyPoint.md 'HurPsyLib.HurPsyPoint')  
A randomized location within the underlying rectangle (with the guarantee that the visual stoimulus will not extend beyond that rectangle)