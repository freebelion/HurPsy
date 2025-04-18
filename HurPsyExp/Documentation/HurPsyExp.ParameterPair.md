#### [HurPsyExp](index.md 'index')
### [HurPsyExp](HurPsyExp.md 'HurPsyExp')

## ParameterPair Class

This class will help pass a pair of objects as a CommandParameter.  
The objects will be bound to properties of some controls in templates of AddPairPopup and AddTrialPopup

```csharp
public class ParameterPair : System.Windows.DependencyObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Windows.Threading.DispatcherObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Threading.DispatcherObject 'System.Windows.Threading.DispatcherObject') &#129106; [System.Windows.DependencyObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.DependencyObject 'System.Windows.DependencyObject') &#129106; ParameterPair
### Fields

<a name='HurPsyExp.ParameterPair.Object1Property'></a>

## ParameterPair.Object1Property Field

First bindable object

```csharp
public static readonly DependencyProperty Object1Property;
```

#### Field Value
[System.Windows.DependencyProperty](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.DependencyProperty 'System.Windows.DependencyProperty')

<a name='HurPsyExp.ParameterPair.Object2Property'></a>

## ParameterPair.Object2Property Field

Second bindable object

```csharp
public static readonly DependencyProperty Object2Property;
```

#### Field Value
[System.Windows.DependencyProperty](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.DependencyProperty 'System.Windows.DependencyProperty')
### Properties

<a name='HurPsyExp.ParameterPair.Object1'></a>

## ParameterPair.Object1 Property

The actual Object1 property for this instance

```csharp
public object Object1 { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='HurPsyExp.ParameterPair.Object2'></a>

## ParameterPair.Object2 Property

The actual Object2 property for this instance

```csharp
public object Object2 { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')