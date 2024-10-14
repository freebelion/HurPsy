#### [HurPsyExp](index.md 'index')
### [HurPsyExp](HurPsyExp.md 'HurPsyExp')

## StartupDialog Class

This class definition defines the interaction logic for `StartupDialog.xaml`.  
It contains the event handlers which display the design window or the run window, depending on the user's choice.

```csharp
public class StartupDialog : System.Windows.Window,
System.Windows.Markup.IComponentConnector
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Windows.Threading.DispatcherObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Threading.DispatcherObject 'System.Windows.Threading.DispatcherObject') &#129106; [System.Windows.DependencyObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.DependencyObject 'System.Windows.DependencyObject') &#129106; [System.Windows.Media.Visual](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Media.Visual 'System.Windows.Media.Visual') &#129106; [System.Windows.UIElement](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.UIElement 'System.Windows.UIElement') &#129106; [System.ComponentModel.ISupportInitialize](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.ISupportInitialize 'System.ComponentModel.ISupportInitialize') &#129106; [System.Windows.FrameworkElement](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.FrameworkElement 'System.Windows.FrameworkElement') &#129106; [System.Windows.Controls.Control](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.Control 'System.Windows.Controls.Control') &#129106; [System.Windows.Controls.ContentControl](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.ContentControl 'System.Windows.Controls.ContentControl') &#129106; [System.Windows.Window](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Window 'System.Windows.Window') &#129106; StartupDialog

Implements [System.Windows.Markup.IComponentConnector](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Markup.IComponentConnector 'System.Windows.Markup.IComponentConnector')
### Constructors

<a name='HurPsyExp.StartupDialog.StartupDialog()'></a>

## StartupDialog() Constructor

The usual default constructor simply calls the component initializer.

```csharp
public StartupDialog();
```
### Methods

<a name='HurPsyExp.StartupDialog.DesignExperiment(object,System.Windows.RoutedEventArgs)'></a>

## StartupDialog.DesignExperiment(object, RoutedEventArgs) Method

If an experiment is to be designed, a design window is displayed and takes over the rest.

```csharp
private void DesignExperiment(object sender, System.Windows.RoutedEventArgs e);
```
#### Parameters

<a name='HurPsyExp.StartupDialog.DesignExperiment(object,System.Windows.RoutedEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The object firing the event (the radio button for the "Design an Experiment" choice)

<a name='HurPsyExp.StartupDialog.DesignExperiment(object,System.Windows.RoutedEventArgs).e'></a>

`e` [System.Windows.RoutedEventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs')

Additional event info

<a name='HurPsyExp.StartupDialog.InitializeComponent()'></a>

## StartupDialog.InitializeComponent() Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent()](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Markup.IComponentConnector.InitializeComponent 'System.Windows.Markup.IComponentConnector.InitializeComponent')

<a name='HurPsyExp.StartupDialog.RunExperiment(object,System.Windows.RoutedEventArgs)'></a>

## StartupDialog.RunExperiment(object, RoutedEventArgs) Method

If an experiment is to be designed, a run window is displayed and takes over the rest.

```csharp
private void RunExperiment(object sender, System.Windows.RoutedEventArgs e);
```
#### Parameters

<a name='HurPsyExp.StartupDialog.RunExperiment(object,System.Windows.RoutedEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The object firing the event (the radio button for the "Run an Experiment" choice)

<a name='HurPsyExp.StartupDialog.RunExperiment(object,System.Windows.RoutedEventArgs).e'></a>

`e` [System.Windows.RoutedEventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs')

Additional event info