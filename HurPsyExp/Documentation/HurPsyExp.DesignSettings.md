#### [HurPsyExp](index.md 'index')
### [HurPsyExp](HurPsyExp.md 'HurPsyExp')

## DesignSettings Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public class DesignSettings : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; DesignSettings
### Constructors

<a name='HurPsyExp.DesignSettings.DesignSettings()'></a>

## DesignSettings() Constructor

This default constructor assigns initial values to all the properties as deemed fit by the programmer

```csharp
public DesignSettings();
```
### Fields

<a name='HurPsyExp.DesignSettings.commandButtonHeight'></a>

## DesignSettings.commandButtonHeight Field

The preferred height for toolbar buttons

```csharp
private double commandButtonHeight;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.decrementCommand'></a>

## DesignSettings.decrementCommand Field

The backing field for [DecrementCommand](HurPsyExp.DesignSettings.md#HurPsyExp.DesignSettings.DecrementCommand 'HurPsyExp.DesignSettings.DecrementCommand').

```csharp
private RelayCommand<string>? decrementCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')

<a name='HurPsyExp.DesignSettings.elementsPanelWidth'></a>

## DesignSettings.elementsPanelWidth Field

The width of the panel which holds the elements' definitions

```csharp
private double elementsPanelWidth;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.experimentPanelWidth'></a>

## DesignSettings.experimentPanelWidth Field

The width of the panel which helps arrange the trials and blocks

```csharp
private double experimentPanelWidth;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.imagePreviewHeight'></a>

## DesignSettings.imagePreviewHeight Field

The preferred height for the icon images in the item views

```csharp
private double imagePreviewHeight;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.incrementCommand'></a>

## DesignSettings.incrementCommand Field

The backing field for [IncrementCommand](HurPsyExp.DesignSettings.md#HurPsyExp.DesignSettings.IncrementCommand 'HurPsyExp.DesignSettings.IncrementCommand').

```csharp
private RelayCommand<string>? incrementCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')

<a name='HurPsyExp.DesignSettings.menuFontSize'></a>

## DesignSettings.menuFontSize Field

The font size for the menu options

```csharp
private double menuFontSize;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.smallFontSize'></a>

## DesignSettings.smallFontSize Field

The size of the small font used in item views

```csharp
private double smallFontSize;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.typicalStepTime'></a>

## DesignSettings.typicalStepTime Field

The preferred time (in milliseconds) for experiment steps

```csharp
private double typicalStepTime;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.uIFontSize'></a>

## DesignSettings.uIFontSize Field

The font size of the user interface

```csharp
private double uIFontSize;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
### Properties

<a name='HurPsyExp.DesignSettings.CommandButtonHeight'></a>

## DesignSettings.CommandButtonHeight Property

The preferred height for toolbar buttons

```csharp
public double CommandButtonHeight { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.DecrementCommand'></a>

## DesignSettings.DecrementCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [HurPsyExp.DesignSettings.Decrement(System.String)](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.DesignSettings.Decrement#HurPsyExp_DesignSettings_Decrement_System_String_ 'HurPsyExp.DesignSettings.Decrement(System.String)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<string> DecrementCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.DesignSettings.ElementsPanelWidth'></a>

## DesignSettings.ElementsPanelWidth Property

The width of the panel which holds the elements' definitions

```csharp
public double ElementsPanelWidth { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.ExperimentPanelWidth'></a>

## DesignSettings.ExperimentPanelWidth Property

The width of the panel which helps arrange the trials and blocks

```csharp
public double ExperimentPanelWidth { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.ImagePreviewHeight'></a>

## DesignSettings.ImagePreviewHeight Property

The preferred height for the icon images in the item views

```csharp
public double ImagePreviewHeight { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.IncrementCommand'></a>

## DesignSettings.IncrementCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [HurPsyExp.DesignSettings.Increment(System.String)](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.DesignSettings.Increment#HurPsyExp_DesignSettings_Increment_System_String_ 'HurPsyExp.DesignSettings.Increment(System.String)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<string> IncrementCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.DesignSettings.MaxButtonHeight'></a>

## DesignSettings.MaxButtonHeight Property

Maximum size for a command button or an image preview  
(Being an app-level setting, this property value won't be serialized)

```csharp
public double MaxButtonHeight { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.MaxFontSize'></a>

## DesignSettings.MaxFontSize Property

Maximum font size allowed by the app  
(Being an app-level setting, this property value won't be serialized)

```csharp
public double MaxFontSize { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.MaxPanelWidth'></a>

## DesignSettings.MaxPanelWidth Property

Maximum width for the panels that collapse and open horizontally  
(Being an app-level setting, this property value won't be serialized)

```csharp
public double MaxPanelWidth { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.MenuFontSize'></a>

## DesignSettings.MenuFontSize Property

The font size for the menu options

```csharp
public double MenuFontSize { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.MinButtonHeight'></a>

## DesignSettings.MinButtonHeight Property

Mininum size for a command button or an image preview  
(Being an app-level setting, this property value won't be serialized)

```csharp
public double MinButtonHeight { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.MinFontSize'></a>

## DesignSettings.MinFontSize Property

Minimum font size allowed by the app  
(Being an app-level setting, this property value won't be serialized)

```csharp
public double MinFontSize { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.MinPanelWidth'></a>

## DesignSettings.MinPanelWidth Property

Mininum width for the panels that collapse and open horizontally  
(Being an app-level setting, this property value won't be serialized)

```csharp
public double MinPanelWidth { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.SmallFontSize'></a>

## DesignSettings.SmallFontSize Property

The size of the small font used in item views

```csharp
public double SmallFontSize { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.TypicalStepTime'></a>

## DesignSettings.TypicalStepTime Property

The preferred time (in milliseconds) for experiment steps

```csharp
public double TypicalStepTime { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.DesignSettings.UIFontSize'></a>

## DesignSettings.UIFontSize Property

The font size of the user interface

```csharp
public double UIFontSize { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
### Methods

<a name='HurPsyExp.DesignSettings.DeSerializeJson()'></a>

## DesignSettings.DeSerializeJson() Method

This method loads up the Json-Serialized instance of `DesignSettings` and transfers the previously saved user preferences.  
Since the design settings were referred in multiple independent XAML files, I kept an object of `DesignSettings` as a resource in `App.xaml` file.  
Since it was a `StaticResource`, that object could not be loaded directly from a file. That's why its user-defined properties are transferred from the loaded copy.

```csharp
public void DeSerializeJson();
```

<a name='HurPsyExp.DesignSettings.SerializeJson()'></a>

## DesignSettings.SerializeJson() Method

This method serializes this object via Json

```csharp
public void SerializeJson();
```