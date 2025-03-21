### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## PointLocator Class

This class stores a specific location point and uses its coordinates to produce a location for any visual stimulus

```csharp
public class PointLocator : HurPsyLib.Locator
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [IdObject](HurPsyLib.IdObject.md 'HurPsyLib.IdObject') &#129106; [Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator') &#129106; PointLocator
### Constructors

<a name='HurPsyLib.PointLocator.PointLocator()'></a>

## PointLocator() Constructor

This default constructor starts with a location point at the origin (normally, the center of the screen)

```csharp
public PointLocator();
```

<a name='HurPsyLib.PointLocator.PointLocator(double,double)'></a>

## PointLocator(double, double) Constructor

This parametreized constructor initializes the location point at the given coordinates

```csharp
public PointLocator(double locX, double locY);
```
#### Parameters

<a name='HurPsyLib.PointLocator.PointLocator(double,double).locX'></a>

`locX` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

X coordinate

<a name='HurPsyLib.PointLocator.PointLocator(double,double).locY'></a>

`locY` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Y coordinate
### Properties

<a name='HurPsyLib.PointLocator.LocatorPoint'></a>

## PointLocator.LocatorPoint Property

The location point

```csharp
public HurPsyLib.HurPsyPoint LocatorPoint { get; set; }
```

#### Property Value
[HurPsyPoint](HurPsyLib.HurPsyPoint.md 'HurPsyLib.HurPsyPoint')
### Methods

<a name='HurPsyLib.PointLocator.GetLocation(HurPsyLib.VisualStimulus)'></a>

## PointLocator.GetLocation(VisualStimulus) Method

When prompted to produce a location, this class simply returns a temporary copy of the location point

```csharp
public override HurPsyLib.HurPsyPoint GetLocation(HurPsyLib.VisualStimulus? vistim=null);
```
#### Parameters

<a name='HurPsyLib.PointLocator.GetLocation(HurPsyLib.VisualStimulus).vistim'></a>

`vistim` [VisualStimulus](HurPsyLib.VisualStimulus.md 'HurPsyLib.VisualStimulus')

The visual stimulus to be placed

#### Returns
[HurPsyPoint](HurPsyLib.HurPsyPoint.md 'HurPsyLib.HurPsyPoint')  
A temporary copy of the location point