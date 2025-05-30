#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpRun](HurPsyExp.ExpRun.md 'HurPsyExp.ExpRun')

## RunWindow Class

Interaction logic for RunWindow.xaml

```csharp
public class RunWindow : System.Windows.Window,
System.Windows.Markup.IComponentConnector
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Windows.Threading.DispatcherObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Threading.DispatcherObject 'System.Windows.Threading.DispatcherObject') &#129106; [System.Windows.DependencyObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.DependencyObject 'System.Windows.DependencyObject') &#129106; [System.Windows.Media.Visual](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Media.Visual 'System.Windows.Media.Visual') &#129106; [System.Windows.UIElement](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.UIElement 'System.Windows.UIElement') &#129106; [System.ComponentModel.ISupportInitialize](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.ISupportInitialize 'System.ComponentModel.ISupportInitialize') &#129106; [System.Windows.FrameworkElement](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.FrameworkElement 'System.Windows.FrameworkElement') &#129106; [System.Windows.Controls.Control](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.Control 'System.Windows.Controls.Control') &#129106; [System.Windows.Controls.ContentControl](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.ContentControl 'System.Windows.Controls.ContentControl') &#129106; [System.Windows.Window](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Window 'System.Windows.Window') &#129106; RunWindow

Implements [System.Windows.Markup.IComponentConnector](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Markup.IComponentConnector 'System.Windows.Markup.IComponentConnector')
### Constructors

<a name='HurPsyExp.ExpRun.RunWindow.RunWindow(HurPsyLib.Experiment)'></a>

## RunWindow(Experiment) Constructor

This default constructor simply initailizes the visual components of the window.

```csharp
public RunWindow(HurPsyLib.Experiment? exp=null);
```
#### Parameters

<a name='HurPsyExp.ExpRun.RunWindow.RunWindow(HurPsyLib.Experiment).exp'></a>

`exp` [HurPsyLib.Experiment](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Experiment 'HurPsyLib.Experiment')
### Properties

<a name='HurPsyExp.ExpRun.RunWindow.RunVM'></a>

## RunWindow.RunVM Property

The viewmodel which will keep updating this window during the run

```csharp
public HurPsyExp.ExpRun.RunViewModel RunVM { get; set; }
```

#### Property Value
[RunViewModel](HurPsyExp.ExpRun.RunViewModel.md 'HurPsyExp.ExpRun.RunViewModel')
### Methods

<a name='HurPsyExp.ExpRun.RunWindow.InitializeComponent()'></a>

## RunWindow.InitializeComponent() Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent()](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Markup.IComponentConnector.InitializeComponent 'System.Windows.Markup.IComponentConnector.InitializeComponent')