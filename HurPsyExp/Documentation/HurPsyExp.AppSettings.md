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

<a name='HurPsyExp.AppSettings.fontSize'></a>

## AppSettings.fontSize Field

The font size of the user interface

```csharp
private double fontSize;
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
### Properties

<a name='HurPsyExp.AppSettings.FontSize'></a>

## AppSettings.FontSize Property

The font size of the user interface

```csharp
public double FontSize { get; set; }
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