### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## PointLocator Class

This class represents a single-point locator

```csharp
public class PointLocator : HurPsyLib.Locator
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator') &#129106; PointLocator
### Constructors

<a name='HurPsyLib.PointLocator.PointLocator()'></a>

## PointLocator() Constructor

This default constructor starts with a point location at the origin (normally at the center of the screen)

```csharp
public PointLocator();
```

<a name='HurPsyLib.PointLocator.PointLocator(double,double)'></a>

## PointLocator(double, double) Constructor

This parametrized constructor accepts the coordinates of a point

```csharp
public PointLocator(double locX, double locY);
```
#### Parameters

<a name='HurPsyLib.PointLocator.PointLocator(double,double).locX'></a>

`locX` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The horizontal position of the location point

<a name='HurPsyLib.PointLocator.PointLocator(double,double).locY'></a>

`locY` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The vertical position of the location point
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

The required implementation of the function inherited from the abstracxt base class simply specific the inner location point as the stimulus location

```csharp
public override HurPsyLib.HurPsyPoint GetLocation(HurPsyLib.VisualStimulus? vistim=null);
```
#### Parameters

<a name='HurPsyLib.PointLocator.GetLocation(HurPsyLib.VisualStimulus).vistim'></a>

`vistim` [VisualStimulus](HurPsyLib.VisualStimulus.md 'HurPsyLib.VisualStimulus')

The visual stimulus which will be positioned by this locator instance

#### Returns
[HurPsyPoint](HurPsyLib.HurPsyPoint.md 'HurPsyLib.HurPsyPoint')  
A tempotrary copy of the inner location point, so that subsequent operations will not modify `LocatorPoint`