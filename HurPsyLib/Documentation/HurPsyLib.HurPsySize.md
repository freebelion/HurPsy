### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## HurPsySize Class

This class represents a size object to specify the dimensions of a visual stimulus.  
Its whole point is to keep `HurPsyLib` objects independent of the GUIs used for designing or running experiments.

```csharp
public class HurPsySize
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; HurPsySize
### Constructors

<a name='HurPsyLib.HurPsySize.HurPsySize()'></a>

## HurPsySize() Constructor

This default constructor starts with zero dimensions

```csharp
public HurPsySize();
```

<a name='HurPsyLib.HurPsySize.HurPsySize(double,double)'></a>

## HurPsySize(double, double) Constructor

This parametrized constructor accepts initial dimensions

```csharp
public HurPsySize(double sX, double sY);
```
#### Parameters

<a name='HurPsyLib.HurPsySize.HurPsySize(double,double).sX'></a>

`sX` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyLib.HurPsySize.HurPsySize(double,double).sY'></a>

`sY` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
### Fields

<a name='HurPsyLib.HurPsySize.sizeX'></a>

## HurPsySize.sizeX Field

Horizontal size

```csharp
private double sizeX;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyLib.HurPsySize.sizeY'></a>

## HurPsySize.sizeY Field

Vertical size

```csharp
private double sizeY;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
### Properties

<a name='HurPsyLib.HurPsySize.Height'></a>

## HurPsySize.Height Property

The property to get/set the vertical dimension (an exception will be thrown for a negative value)

```csharp
public double Height { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyLib.HurPsySize.Unit'></a>

## HurPsySize.Unit Property

The property to get/set the unit choice; it will be fully utilized when more unit choices become available

```csharp
public HurPsyLib.HurPsyUnit Unit { get; set; }
```

#### Property Value
[HurPsyUnit](HurPsyLib.HurPsyUnit.md 'HurPsyLib.HurPsyUnit')

<a name='HurPsyLib.HurPsySize.Width'></a>

## HurPsySize.Width Property

The property to get/set the horizontal dimension (an exception will be thrown for a negative value)

```csharp
public double Width { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')