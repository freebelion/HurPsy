#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpRun](HurPsyExp.ExpRun.md 'HurPsyExp.ExpRun')

## RunWindow Class

This class definition describes the interaction logic for `RunWindow.xaml`.

```csharp
public class RunWindow : System.Windows.Window,
System.Windows.Markup.IComponentConnector,
System.Windows.Markup.IStyleConnector
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Windows.Threading.DispatcherObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Threading.DispatcherObject 'System.Windows.Threading.DispatcherObject') &#129106; [System.Windows.DependencyObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.DependencyObject 'System.Windows.DependencyObject') &#129106; [System.Windows.Media.Visual](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Media.Visual 'System.Windows.Media.Visual') &#129106; [System.Windows.UIElement](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.UIElement 'System.Windows.UIElement') &#129106; [System.ComponentModel.ISupportInitialize](https://docs.microsoft.com/en-us/dotnet/api/System.ComponentModel.ISupportInitialize 'System.ComponentModel.ISupportInitialize') &#129106; [System.Windows.FrameworkElement](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.FrameworkElement 'System.Windows.FrameworkElement') &#129106; [System.Windows.Controls.Control](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.Control 'System.Windows.Controls.Control') &#129106; [System.Windows.Controls.ContentControl](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.ContentControl 'System.Windows.Controls.ContentControl') &#129106; [System.Windows.Window](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Window 'System.Windows.Window') &#129106; RunWindow

Implements [System.Windows.Markup.IComponentConnector](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Markup.IComponentConnector 'System.Windows.Markup.IComponentConnector'), [System.Windows.Markup.IStyleConnector](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Markup.IStyleConnector 'System.Windows.Markup.IStyleConnector')
### Constructors

<a name='HurPsyExp.ExpRun.RunWindow.RunWindow()'></a>

## RunWindow() Constructor

This default constructor will initialize this window's components, create the viewmodel object and specify the event handler for the timer

```csharp
public RunWindow();
```
### Fields

<a name='HurPsyExp.ExpRun.RunWindow.stepTimer'></a>

## RunWindow.stepTimer Field

This timer will be used to display timed steps.

```csharp
private DispatcherTimer stepTimer;
```

#### Field Value
[System.Windows.Threading.DispatcherTimer](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Threading.DispatcherTimer 'System.Windows.Threading.DispatcherTimer')
### Properties

<a name='HurPsyExp.ExpRun.RunWindow.RunVM'></a>

## RunWindow.RunVM Property

The viewmodel object will be responsible for advancing through trial steps, trials and blocks.

```csharp
public HurPsyExp.ExpRun.RunViewModel RunVM { get; set; }
```

#### Property Value
[HurPsyExp.ExpRun.RunViewModel](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpRun.RunViewModel 'HurPsyExp.ExpRun.RunViewModel')
### Methods

<a name='HurPsyExp.ExpRun.RunWindow.DisplayCurrentStep()'></a>

## RunWindow.DisplayCurrentStep() Method

This little function will display the current trial step.  
Currently, it assumes every step will be on display for a specific period of time,  
but there may be cases a display time is not specified because the current step may need to stay on display until an acceptable response is given.

```csharp
public void DisplayCurrentStep();
```

<a name='HurPsyExp.ExpRun.RunWindow.Image_Loaded(object,System.Windows.RoutedEventArgs)'></a>

## RunWindow.Image_Loaded(object, RoutedEventArgs) Method

This method handles the `Loaded` event of an `Image` control, which will be come onto the screen if an `ImageStimulus` is to be displayed.

```csharp
private void Image_Loaded(object sender, System.Windows.RoutedEventArgs e);
```
#### Parameters

<a name='HurPsyExp.ExpRun.RunWindow.Image_Loaded(object,System.Windows.RoutedEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='HurPsyExp.ExpRun.RunWindow.Image_Loaded(object,System.Windows.RoutedEventArgs).e'></a>

`e` [System.Windows.RoutedEventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs')

Additional event info

#### Exceptions

[HurPsyLib.HurPsyException](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.HurPsyException 'HurPsyLib.HurPsyException')  
The object firing the event (which the `Image` control)

<a name='HurPsyExp.ExpRun.RunWindow.InitializeComponent()'></a>

## RunWindow.InitializeComponent() Method

InitializeComponent

```csharp
public void InitializeComponent();
```

Implements [InitializeComponent()](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Markup.IComponentConnector.InitializeComponent 'System.Windows.Markup.IComponentConnector.InitializeComponent')

<a name='HurPsyExp.ExpRun.RunWindow.StepEnded()'></a>

## RunWindow.StepEnded() Method

This method performs the end-of-step operations.

```csharp
private void StepEnded();
```

<a name='HurPsyExp.ExpRun.RunWindow.StepTimer_Tick(object,System.EventArgs)'></a>

## RunWindow.StepTimer_Tick(object, EventArgs) Method

This method handles the timer's `Tick` event and takes the necessary actions to end the current step.

```csharp
private void StepTimer_Tick(object? sender, System.EventArgs e);
```
#### Parameters

<a name='HurPsyExp.ExpRun.RunWindow.StepTimer_Tick(object,System.EventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The object firing the event (which is `stepTimer`)

<a name='HurPsyExp.ExpRun.RunWindow.StepTimer_Tick(object,System.EventArgs).e'></a>

`e` [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs')

Additional event info

<a name='HurPsyExp.ExpRun.RunWindow.WebBrowser_Loaded(object,System.Windows.RoutedEventArgs)'></a>

## RunWindow.WebBrowser_Loaded(object, RoutedEventArgs) Method

This method handles the `Loaded` event of the `WebBrowser control, which will be come onto the screen if a `HtmlStimulus` is to be displayed.

```csharp
private void WebBrowser_Loaded(object sender, System.Windows.RoutedEventArgs e);
```
#### Parameters

<a name='HurPsyExp.ExpRun.RunWindow.WebBrowser_Loaded(object,System.Windows.RoutedEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The object firing the event (which the `WebBrowser` control)

<a name='HurPsyExp.ExpRun.RunWindow.WebBrowser_Loaded(object,System.Windows.RoutedEventArgs).e'></a>

`e` [System.Windows.RoutedEventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs')

Additional event info

<a name='HurPsyExp.ExpRun.RunWindow.Window_KeyDown(object,System.Windows.Input.KeyEventArgs)'></a>

## RunWindow.Window_KeyDown(object, KeyEventArgs) Method

This method will handle the `KeyDown` events if the current step requires a key response.

```csharp
private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e);
```
#### Parameters

<a name='HurPsyExp.ExpRun.RunWindow.Window_KeyDown(object,System.Windows.Input.KeyEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The object firing the event (which is any key on the keyboard)

<a name='HurPsyExp.ExpRun.RunWindow.Window_KeyDown(object,System.Windows.Input.KeyEventArgs).e'></a>

`e` [System.Windows.Input.KeyEventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Input.KeyEventArgs 'System.Windows.Input.KeyEventArgs')

Additional event info

<a name='HurPsyExp.ExpRun.RunWindow.Window_Loaded(object,System.Windows.RoutedEventArgs)'></a>

## RunWindow.Window_Loaded(object, RoutedEventArgs) Method

The asssociated viewmodel object will start running the experiment as soon as this window is loaded.

```csharp
private void Window_Loaded(object sender, System.Windows.RoutedEventArgs e);
```
#### Parameters

<a name='HurPsyExp.ExpRun.RunWindow.Window_Loaded(object,System.Windows.RoutedEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='HurPsyExp.ExpRun.RunWindow.Window_Loaded(object,System.Windows.RoutedEventArgs).e'></a>

`e` [System.Windows.RoutedEventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.RoutedEventArgs 'System.Windows.RoutedEventArgs')