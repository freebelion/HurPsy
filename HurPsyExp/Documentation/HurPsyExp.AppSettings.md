#### [HurPsyExp](index.md 'index')
### [HurPsyExp](HurPsyExp.md 'HurPsyExp')

## AppSettings Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public class AppSettings : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; AppSettings
### Constructors

<a name='HurPsyExp.AppSettings.AppSettings()'></a>

## AppSettings() Constructor

This default constructor assigns initial values to all the properties as deemed fit by the programmer

```csharp
public AppSettings();
```
### Fields

<a name='HurPsyExp.AppSettings.commandButtonHeight'></a>

## AppSettings.commandButtonHeight Field

The preferred height for toolbar buttons

```csharp
private double commandButtonHeight;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.decrementCommand'></a>

## AppSettings.decrementCommand Field

The backing field for [DecrementCommand](HurPsyExp.AppSettings.md#HurPsyExp.AppSettings.DecrementCommand 'HurPsyExp.AppSettings.DecrementCommand').

```csharp
private RelayCommand<string>? decrementCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')

<a name='HurPsyExp.AppSettings.designLayout'></a>

## AppSettings.designLayout Field

The current choice for the DesignWindow layout

```csharp
private LayoutChoice designLayout;
```

#### Field Value
[LayoutChoice](HurPsyExp.LayoutChoice.md 'HurPsyExp.LayoutChoice')

<a name='HurPsyExp.AppSettings.fontSize'></a>

## AppSettings.fontSize Field

The font size of the user interface

```csharp
private double fontSize;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.iconImageHeight'></a>

## AppSettings.iconImageHeight Field

The preferred height for the icon images in the item views

```csharp
private double iconImageHeight;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.incrementCommand'></a>

## AppSettings.incrementCommand Field

The backing field for [IncrementCommand](HurPsyExp.AppSettings.md#HurPsyExp.AppSettings.IncrementCommand 'HurPsyExp.AppSettings.IncrementCommand').

```csharp
private RelayCommand<string>? incrementCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')

<a name='HurPsyExp.AppSettings.menuFontSize'></a>

## AppSettings.menuFontSize Field

The font size for the menu options

```csharp
private double menuFontSize;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.smallFontSize'></a>

## AppSettings.smallFontSize Field

The size of the small font used in item views

```csharp
private double smallFontSize;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.switchLayoutCommand'></a>

## AppSettings.switchLayoutCommand Field

The backing field for [SwitchLayoutCommand](HurPsyExp.AppSettings.md#HurPsyExp.AppSettings.SwitchLayoutCommand 'HurPsyExp.AppSettings.SwitchLayoutCommand').

```csharp
private RelayCommand<LayoutChoice>? switchLayoutCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')[LayoutChoice](HurPsyExp.LayoutChoice.md 'HurPsyExp.LayoutChoice')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')

<a name='HurPsyExp.AppSettings.windowHeight'></a>

## AppSettings.windowHeight Field

User-chosen window height (saved between sessions)

```csharp
private double windowHeight;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.windowWidth'></a>

## AppSettings.windowWidth Field

User-chosen window width (saved between sessions)

```csharp
private double windowWidth;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
### Properties

<a name='HurPsyExp.AppSettings.CommandButtonHeight'></a>

## AppSettings.CommandButtonHeight Property

The preferred height for toolbar buttons

```csharp
public double CommandButtonHeight { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.DecrementCommand'></a>

## AppSettings.DecrementCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [Decrement(string)](HurPsyExp.AppSettings.md#HurPsyExp.AppSettings.Decrement(string) 'HurPsyExp.AppSettings.Decrement(string)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<string> DecrementCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.AppSettings.DesignLayout'></a>

## AppSettings.DesignLayout Property

The current choice for the DesignWindow layout

```csharp
public HurPsyExp.LayoutChoice DesignLayout { get; set; }
```

#### Property Value
[LayoutChoice](HurPsyExp.LayoutChoice.md 'HurPsyExp.LayoutChoice')

<a name='HurPsyExp.AppSettings.FontSize'></a>

## AppSettings.FontSize Property

The font size of the user interface

```csharp
public double FontSize { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.IconImageHeight'></a>

## AppSettings.IconImageHeight Property

The preferred height for the icon images in the item views

```csharp
public double IconImageHeight { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.IncrementCommand'></a>

## AppSettings.IncrementCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [Increment(string)](HurPsyExp.AppSettings.md#HurPsyExp.AppSettings.Increment(string) 'HurPsyExp.AppSettings.Increment(string)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<string> IncrementCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.AppSettings.MaxButtonHeight'></a>

## AppSettings.MaxButtonHeight Property

Maximum size for a command button or an image preview  
(Being an app-level setting, this property value won't be serialized)

```csharp
public double MaxButtonHeight { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.MaxFontSize'></a>

## AppSettings.MaxFontSize Property

Maximum font size allowed by the app  
(Being an app-level setting, this property value won't be serialized)

```csharp
public double MaxFontSize { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.MenuFontSize'></a>

## AppSettings.MenuFontSize Property

The font size for the menu options

```csharp
public double MenuFontSize { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.MinButtonHeight'></a>

## AppSettings.MinButtonHeight Property

Mininum size for a command button or an image preview  
(Being an app-level setting, this property value won't be serialized)

```csharp
public double MinButtonHeight { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.MinFontSize'></a>

## AppSettings.MinFontSize Property

Minimum font size allowed by the app  
(Being an app-level setting, this property value won't be serialized)

```csharp
public double MinFontSize { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.SmallFontSize'></a>

## AppSettings.SmallFontSize Property

The size of the small font used in item views

```csharp
public double SmallFontSize { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.SwitchLayoutCommand'></a>

## AppSettings.SwitchLayoutCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [SwitchLayout(LayoutChoice)](HurPsyExp.AppSettings.md#HurPsyExp.AppSettings.SwitchLayout(HurPsyExp.LayoutChoice) 'HurPsyExp.AppSettings.SwitchLayout(HurPsyExp.LayoutChoice)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<HurPsyExp.LayoutChoice> SwitchLayoutCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[LayoutChoice](HurPsyExp.LayoutChoice.md 'HurPsyExp.LayoutChoice')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.AppSettings.WindowHeight'></a>

## AppSettings.WindowHeight Property

User-chosen window height (saved between sessions)

```csharp
public double WindowHeight { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.AppSettings.WindowWidth'></a>

## AppSettings.WindowWidth Property

User-chosen window width (saved between sessions)

```csharp
public double WindowWidth { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')
### Methods

<a name='HurPsyExp.AppSettings.Decrement(string)'></a>

## AppSettings.Decrement(string) Method

This method, when executed as a command, will decrement the value of the property associated with the named slider.

```csharp
private void Decrement(string sliderName);
```
#### Parameters

<a name='HurPsyExp.AppSettings.Decrement(string).sliderName'></a>

`sliderName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the NumericUpDownSlider where the increment button was clicked

<a name='HurPsyExp.AppSettings.DeSerializeJson()'></a>

## AppSettings.DeSerializeJson() Method

This method loads up the Json-Serialized instance of `DesignSettings` and transfers the previously saved user preferences.  
Since the design settings were referred in multiple independent XAML files, I kept an object of `DesignSettings` as a resource in `App.xaml` file.  
Since it was a `StaticResource`, that object could not be loaded directly from a file. That's why its user-defined properties are transferred from the loaded copy.

```csharp
public void DeSerializeJson();
```

<a name='HurPsyExp.AppSettings.Increment(string)'></a>

## AppSettings.Increment(string) Method

This method, when executed as a command, will increment the value of the property associated with the named slider.

```csharp
private void Increment(string sliderName);
```
#### Parameters

<a name='HurPsyExp.AppSettings.Increment(string).sliderName'></a>

`sliderName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the NumericUpDownSlider where the increment button was clicked

<a name='HurPsyExp.AppSettings.SerializeJson()'></a>

## AppSettings.SerializeJson() Method

This method serializes this object via Json

```csharp
public void SerializeJson();
```

<a name='HurPsyExp.AppSettings.SwitchLayout(HurPsyExp.LayoutChoice)'></a>

## AppSettings.SwitchLayout(LayoutChoice) Method

This method, when executed as a command, switches the current layout.

```csharp
private void SwitchLayout(HurPsyExp.LayoutChoice newlayout);
```
#### Parameters

<a name='HurPsyExp.AppSettings.SwitchLayout(HurPsyExp.LayoutChoice).newlayout'></a>

`newlayout` [LayoutChoice](HurPsyExp.LayoutChoice.md 'HurPsyExp.LayoutChoice')