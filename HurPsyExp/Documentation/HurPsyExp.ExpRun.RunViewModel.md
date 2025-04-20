#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpRun](HurPsyExp.ExpRun.md 'HurPsyExp.ExpRun')

## RunViewModel Class

This viewmodel class will handle running an experiment

```csharp
public class RunViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; RunViewModel
### Constructors

<a name='HurPsyExp.ExpRun.RunViewModel.RunViewModel(HurPsyExp.ExpRun.RunWindow,HurPsyLib.Experiment)'></a>

## RunViewModel(RunWindow, Experiment) Constructor

The default constructor starts with a reference to the window element and an existing experiment.  
If no `Experiment` object is forwarded, the user will be prompted to open a file containing an experiment's definition.

```csharp
public RunViewModel(HurPsyExp.ExpRun.RunWindow runwnd, HurPsyLib.Experiment? exp=null);
```
#### Parameters

<a name='HurPsyExp.ExpRun.RunViewModel.RunViewModel(HurPsyExp.ExpRun.RunWindow,HurPsyLib.Experiment).runwnd'></a>

`runwnd` [RunWindow](HurPsyExp.ExpRun.RunWindow.md 'HurPsyExp.ExpRun.RunWindow')

The reference to the window element (for updating the display step by step)

<a name='HurPsyExp.ExpRun.RunViewModel.RunViewModel(HurPsyExp.ExpRun.RunWindow,HurPsyLib.Experiment).exp'></a>

`exp` [HurPsyLib.Experiment](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Experiment 'HurPsyLib.Experiment')

The reference to an existing experiment (if any)
### Fields

<a name='HurPsyExp.ExpRun.RunViewModel._experiment'></a>

## RunViewModel._experiment Field

A reference to the `Experiment` object representing the experiment being run

```csharp
private Experiment _experiment;
```

#### Field Value
[HurPsyLib.Experiment](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Experiment 'HurPsyLib.Experiment')

<a name='HurPsyExp.ExpRun.RunViewModel.runwin'></a>

## RunViewModel.runwin Field

A reference to the `RunWindow` object

```csharp
private RunWindow runwin;
```

#### Field Value
[RunWindow](HurPsyExp.ExpRun.RunWindow.md 'HurPsyExp.ExpRun.RunWindow')
### Properties

<a name='HurPsyExp.ExpRun.RunViewModel.VisualStimuli'></a>

## RunViewModel.VisualStimuli Property

The collection of visual stimulus objects that will be presented together on the same step

```csharp
public System.Collections.ObjectModel.ObservableCollection<HurPsyExp.ExpRun.VisualStimulusViewModel> VisualStimuli { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[VisualStimulusViewModel](HurPsyExp.ExpRun.VisualStimulusViewModel.md 'HurPsyExp.ExpRun.VisualStimulusViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')

<a name='HurPsyExp.ExpRun.RunViewModel.VisualStimulusObjects'></a>

## RunViewModel.VisualStimulusObjects Property

A dictionary collection of actual stimulus objects keyed with their Id strings.

```csharp
private System.Collections.Generic.Dictionary<string,object> VisualStimulusObjects { get; set; }
```

#### Property Value
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')
### Methods

<a name='HurPsyExp.ExpRun.RunViewModel.LoadExperiment()'></a>

## RunViewModel.LoadExperiment() Method

The method which lets the user choose a file to load the experiment definition

```csharp
private static HurPsyLib.Experiment LoadExperiment();
```

#### Returns
[HurPsyLib.Experiment](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Experiment 'HurPsyLib.Experiment')

#### Exceptions

[HurPsyLib.HurPsyException](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.HurPsyException 'HurPsyLib.HurPsyException')

<a name='HurPsyExp.ExpRun.RunViewModel.LoadStep()'></a>

## RunViewModel.LoadStep() Method

This method loads the visual stimulus objects to be used to display the current trial step.

```csharp
private void LoadStep();
```

<a name='HurPsyExp.ExpRun.RunViewModel.LoadVisualStimulusObjects()'></a>

## RunViewModel.LoadVisualStimulusObjects() Method

The inner method to load visual stimulus objects in memory to make them faster to access  
(This method may have to be bound to a user option in the future, if memory requirements will become demanding)

```csharp
private void LoadVisualStimulusObjects();
```

<a name='HurPsyExp.ExpRun.RunViewModel.NextStep()'></a>

## RunViewModel.NextStep() Method

Move on to the next trial step (if any)

```csharp
public void NextStep();
```

<a name='HurPsyExp.ExpRun.RunViewModel.StartExperiment()'></a>

## RunViewModel.StartExperiment() Method

Starting point of the experiment

```csharp
public void StartExperiment();
```