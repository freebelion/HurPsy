#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## DesignWindow Class

Interaction logic for DesignWindow.xaml

```csharp
public class DesignWindow : System.Windows.Window,
System.Windows.Markup.IComponentConnector
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Windows.Threading.DispatcherObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Threading.DispatcherObject 'System.Windows.Threading.DispatcherObject') &#129106; [System.Windows.DependencyObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.DependencyObject 'System.Windows.DependencyObject') &#129106; [System.Windows.Media.Visual](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Media.Visual 'System.Windows.Media.Visual') &#129106; [System.Windows.UIElement](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.UIElement 'System.Windows.UIElement') &#129106; [System.ComponentModel.ISupportInitialize](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.ISupportInitialize 'System.ComponentModel.ISupportInitialize') &#129106; [System.Windows.FrameworkElement](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.FrameworkElement 'System.Windows.FrameworkElement') &#129106; [System.Windows.Controls.Control](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.Control 'System.Windows.Controls.Control') &#129106; [System.Windows.Controls.ContentControl](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.ContentControl 'System.Windows.Controls.ContentControl') &#129106; [System.Windows.Window](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Window 'System.Windows.Window') &#129106; DesignWindow

Implements [System.Windows.Markup.IComponentConnector](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Markup.IComponentConnector 'System.Windows.Markup.IComponentConnector')
### Constructors

<a name='HurPsyExp.ExpDesign.DesignWindow.DesignWindow()'></a>

## DesignWindow() Constructor

This default constructor simply initailizes the visual components of the window.

```csharp
public DesignWindow();
```
### Properties

<a name='HurPsyExp.ExpDesign.DesignWindow.DesignVM'></a>

## DesignWindow.DesignVM Property

The viewmodel object that will handle data exchange with the visual controls

```csharp
public HurPsyExp.ExpDesign.DesignViewModel DesignVM { get; set; }
```

#### Property Value
[DesignViewModel](HurPsyExp.ExpDesign.DesignViewModel.md 'HurPsyExp.ExpDesign.DesignViewModel')
### Methods

<a name='HurPsyExp.ExpDesign.DesignWindow.InitializeComponent()'></a>

## DesignWindow.InitializeComponent() Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent()](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Markup.IComponentConnector.InitializeComponent 'System.Windows.Markup.IComponentConnector.InitializeComponent')