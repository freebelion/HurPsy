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

<a name='HurPsyExp.ExpDesign.DesignWindow.DesignWindow(HurPsyLib.Experiment)'></a>

## DesignWindow(Experiment) Constructor

This default constructor simply initailizes the visual components of the window.

```csharp
public DesignWindow(HurPsyLib.Experiment? exp=null);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignWindow.DesignWindow(HurPsyLib.Experiment).exp'></a>

`exp` [HurPsyLib.Experiment](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Experiment 'HurPsyLib.Experiment')
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

<a name='HurPsyExp.ExpDesign.DesignWindow.DrawScaleCanvas()'></a>

## DesignWindow.DrawScaleCanvas() Method

This inner method draws a grid inside the `ScaleCanvas` on the settings panel on the right,  
so that a user can calculate the scale correction factor for placing visual stimuli on the screen.

```csharp
private void DrawScaleCanvas();
```

<a name='HurPsyExp.ExpDesign.DesignWindow.InitializeComponent()'></a>

## DesignWindow.InitializeComponent() Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent()](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Markup.IComponentConnector.InitializeComponent 'System.Windows.Markup.IComponentConnector.InitializeComponent')

<a name='HurPsyExp.ExpDesign.DesignWindow.Window_Loaded(object,System.Windows.RoutedEventArgs)'></a>

## DesignWindow.Window_Loaded(object, RoutedEventArgs) Method

When this window is loaded, the window adopts its `dataContext` and draws the grid which will be used to calculate the scale factor.

```csharp
private void Window_Loaded(object sender, System.Windows.RoutedEventArgs e);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignWindow.Window_Loaded(object,System.Windows.RoutedEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='HurPsyExp.ExpDesign.DesignWindow.Window_Loaded(object,System.Windows.RoutedEventArgs).e'></a>

`e` [System.Windows.RoutedEventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs')