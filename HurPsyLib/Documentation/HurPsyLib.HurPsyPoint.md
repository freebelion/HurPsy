### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## HurPsyPoint Class

This class represents a point object to specify a position on the experiment's coordinate system.  
Its whole point is to keep `HurPsyLib` objects independent of the GUIs used for designing or running experiments.

```csharp
public class HurPsyPoint
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; HurPsyPoint
### Constructors

<a name='HurPsyLib.HurPsyPoint.HurPsyPoint()'></a>

## HurPsyPoint() Constructor

This default constructor starts with zero positions

```csharp
public HurPsyPoint();
```

<a name='HurPsyLib.HurPsyPoint.HurPsyPoint(double,double)'></a>

## HurPsyPoint(double, double) Constructor

This parametrized constructor accepts initial positions

```csharp
public HurPsyPoint(double pX, double pY);
```
#### Parameters

<a name='HurPsyLib.HurPsyPoint.HurPsyPoint(double,double).pX'></a>

`pX` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Initial horizontal position

<a name='HurPsyLib.HurPsyPoint.HurPsyPoint(double,double).pY'></a>

`pY` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

Initial vertical position
### Properties

<a name='HurPsyLib.HurPsyPoint.Unit'></a>

## HurPsyPoint.Unit Property

The property to get/set the unit choice; it will be fully utilized when more unit choices become available

```csharp
public HurPsyLib.HurPsyUnit Unit { get; set; }
```

#### Property Value
[HurPsyUnit](HurPsyLib.HurPsyUnit.md 'HurPsyLib.HurPsyUnit')

<a name='HurPsyLib.HurPsyPoint.X'></a>

## HurPsyPoint.X Property

Horizontal position in a right-handed Cartesian coordinate system

```csharp
public double X { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyLib.HurPsyPoint.Y'></a>

## HurPsyPoint.Y Property

Vertical position in a right-handed Cartesian coordinate system

```csharp
public double Y { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
### Methods

<a name='HurPsyLib.HurPsyPoint.ShallowCopy()'></a>

## HurPsyPoint.ShallowCopy() Method

This function constructs a temporary copy of this instance; it helps avoid accidentally modifying the original location point after copying it for various purposes.

```csharp
public HurPsyLib.HurPsyPoint ShallowCopy();
```

#### Returns
[HurPsyPoint](HurPsyLib.HurPsyPoint.md 'HurPsyLib.HurPsyPoint')