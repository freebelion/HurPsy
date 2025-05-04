#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpRun](HurPsyExp.ExpRun.md 'HurPsyExp.ExpRun')

## VisualStimulusViewModel Class

This viewmodel helps displays a visual stimulus on `RunWindow`

```csharp
public class VisualStimulusViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; VisualStimulusViewModel
### Constructors

<a name='HurPsyExp.ExpRun.VisualStimulusViewModel.VisualStimulusViewModel(HurPsyLib.VisualStimulus,HurPsyLib.HurPsyPoint,object)'></a>

## VisualStimulusViewModel(VisualStimulus, HurPsyPoint, object) Constructor

This constructor takes care of unit conversions from mm to device pixels and associates the actual visual stimulus object with this viewmodel object.

```csharp
public VisualStimulusViewModel(HurPsyLib.VisualStimulus vistim, HurPsyLib.HurPsyPoint locpnt, object visobj);
```
#### Parameters

<a name='HurPsyExp.ExpRun.VisualStimulusViewModel.VisualStimulusViewModel(HurPsyLib.VisualStimulus,HurPsyLib.HurPsyPoint,object).vistim'></a>

`vistim` [HurPsyLib.VisualStimulus](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.VisualStimulus 'HurPsyLib.VisualStimulus')

`VisualStimulus` object modeled by this object

<a name='HurPsyExp.ExpRun.VisualStimulusViewModel.VisualStimulusViewModel(HurPsyLib.VisualStimulus,HurPsyLib.HurPsyPoint,object).locpnt'></a>

`locpnt` [HurPsyLib.HurPsyPoint](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.HurPsyPoint 'HurPsyLib.HurPsyPoint')

Location point (in millimeters) calculoated by the `Locator` paired with the `VisualStimulus` object.

<a name='HurPsyExp.ExpRun.VisualStimulusViewModel.VisualStimulusViewModel(HurPsyLib.VisualStimulus,HurPsyLib.HurPsyPoint,object).visobj'></a>

`visobj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The actual visual object to be displayed at the location point.
### Properties

<a name='HurPsyExp.ExpRun.VisualStimulusViewModel.VisualHeight'></a>

## VisualStimulusViewModel.VisualHeight Property

Height (in DIU)

```csharp
public double VisualHeight { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.ExpRun.VisualStimulusViewModel.VisualObject'></a>

## VisualStimulusViewModel.VisualObject Property

The actual visual object (`Shape` or `Image`) to be displayed

```csharp
public object? VisualObject { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='HurPsyExp.ExpRun.VisualStimulusViewModel.VisualWidth'></a>

## VisualStimulusViewModel.VisualWidth Property

Width (in DIU)

```csharp
public double VisualWidth { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.ExpRun.VisualStimulusViewModel.Xpos'></a>

## VisualStimulusViewModel.Xpos Property

X position (in Windows coordinates)

```csharp
public double Xpos { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.ExpRun.VisualStimulusViewModel.Ypos'></a>

## VisualStimulusViewModel.Ypos Property

Y position (in Windows coordinates)

```csharp
public double Ypos { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')