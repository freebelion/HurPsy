#### [HurPsyExp](index.md 'index')
### [HurPsyExp](HurPsyExp.md 'HurPsyExp')

## App Class

Interaction logic for App.xaml

```csharp
public class App : System.Windows.Application
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Windows.Threading.DispatcherObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Threading.DispatcherObject 'System.Windows.Threading.DispatcherObject') &#129106; [System.Windows.Application](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Application 'System.Windows.Application') &#129106; App
### Methods

<a name='HurPsyExp.App.Application_Startup(object,System.Windows.StartupEventArgs)'></a>

## App.Application_Startup(object, StartupEventArgs) Method

The handler function for the application's Startup event.  
At this stage, the application will let the user  
to open up a window to design an experiment,  
or open up another window to run an experiment.  
This is an implementation based on a tutorial found at:  
https://wpf-tutorial.com/wpf-application/working-with-app-xaml/

```csharp
private void Application_Startup(object sender, System.Windows.StartupEventArgs e);
```
#### Parameters

<a name='HurPsyExp.App.Application_Startup(object,System.Windows.StartupEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='HurPsyExp.App.Application_Startup(object,System.Windows.StartupEventArgs).e'></a>

`e` [System.Windows.StartupEventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.StartupEventArgs 'System.Windows.StartupEventArgs')

<a name='HurPsyExp.App.InitializeComponent()'></a>

## App.InitializeComponent() Method

InitializeComponent

```csharp
public void InitializeComponent();
```

<a name='HurPsyExp.App.Main()'></a>

## App.Main() Method

Application Entry Point.

```csharp
public static void Main();
```