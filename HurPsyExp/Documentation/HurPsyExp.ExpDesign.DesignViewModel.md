#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## DesignViewModel Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public class DesignViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; DesignViewModel
### Constructors

<a name='HurPsyExp.ExpDesign.DesignViewModel.DesignViewModel()'></a>

## DesignViewModel() Constructor

This default constructor simply starts with empty lists of the inner viewmodel objects

```csharp
public DesignViewModel();
```
### Fields

<a name='HurPsyExp.ExpDesign.DesignViewModel._experiment'></a>

## DesignViewModel._experiment Field

The reference variable for the object representing the experiment's definition

```csharp
private Experiment _experiment;
```

#### Field Value
[HurPsyLib.Experiment](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Experiment 'HurPsyLib.Experiment')

<a name='HurPsyExp.ExpDesign.DesignViewModel.addBlockCommand'></a>

## DesignViewModel.addBlockCommand Field

The backing field for [AddBlockCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddBlockCommand 'HurPsyExp.ExpDesign.DesignViewModel.AddBlockCommand').

```csharp
private RelayCommand? addBlockCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.addHtmlStimulusCommand'></a>

## DesignViewModel.addHtmlStimulusCommand Field

The backing field for [AddHtmlStimulusCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddHtmlStimulusCommand 'HurPsyExp.ExpDesign.DesignViewModel.AddHtmlStimulusCommand').

```csharp
private RelayCommand? addHtmlStimulusCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.addPointLocatorCommand'></a>

## DesignViewModel.addPointLocatorCommand Field

The backing field for [AddPointLocatorCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddPointLocatorCommand 'HurPsyExp.ExpDesign.DesignViewModel.AddPointLocatorCommand').

```csharp
private RelayCommand? addPointLocatorCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.deleteBlockCommand'></a>

## DesignViewModel.deleteBlockCommand Field

The backing field for [DeleteBlockCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.DeleteBlockCommand 'HurPsyExp.ExpDesign.DesignViewModel.DeleteBlockCommand').

```csharp
private RelayCommand? deleteBlockCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.deleteLocatorCommand'></a>

## DesignViewModel.deleteLocatorCommand Field

The backing field for [DeleteLocatorCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.DeleteLocatorCommand 'HurPsyExp.ExpDesign.DesignViewModel.DeleteLocatorCommand').

```csharp
private RelayCommand? deleteLocatorCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.deleteStimulusCommand'></a>

## DesignViewModel.deleteStimulusCommand Field

The backing field for [DeleteStimulusCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.DeleteStimulusCommand 'HurPsyExp.ExpDesign.DesignViewModel.DeleteStimulusCommand').

```csharp
private RelayCommand? deleteStimulusCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.loadExperimentCommand'></a>

## DesignViewModel.loadExperimentCommand Field

The backing field for [LoadExperimentCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.LoadExperimentCommand 'HurPsyExp.ExpDesign.DesignViewModel.LoadExperimentCommand').

```csharp
private RelayCommand? loadExperimentCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.newExperimentCommand'></a>

## DesignViewModel.newExperimentCommand Field

The backing field for [NewExperimentCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.NewExperimentCommand 'HurPsyExp.ExpDesign.DesignViewModel.NewExperimentCommand').

```csharp
private RelayCommand? newExperimentCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.saveExperimentCommand'></a>

## DesignViewModel.saveExperimentCommand Field

The backing field for [SaveExperimentCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.SaveExperimentCommand 'HurPsyExp.ExpDesign.DesignViewModel.SaveExperimentCommand').

```csharp
private RelayCommand? saveExperimentCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.selectImagesCommand'></a>

## DesignViewModel.selectImagesCommand Field

The backing field for [SelectImagesCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.SelectImagesCommand 'HurPsyExp.ExpDesign.DesignViewModel.SelectImagesCommand').

```csharp
private RelayCommand? selectImagesCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')
### Properties

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddBlockCommand'></a>

## DesignViewModel.AddBlockCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [AddBlock()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddBlock() 'HurPsyExp.ExpDesign.DesignViewModel.AddBlock()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand AddBlockCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddHtmlStimulusCommand'></a>

## DesignViewModel.AddHtmlStimulusCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [AddHtmlStimulus()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddHtmlStimulus() 'HurPsyExp.ExpDesign.DesignViewModel.AddHtmlStimulus()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand AddHtmlStimulusCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddPointLocatorCommand'></a>

## DesignViewModel.AddPointLocatorCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [AddPointLocator()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddPointLocator() 'HurPsyExp.ExpDesign.DesignViewModel.AddPointLocator()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand AddPointLocatorCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.BlockVMs'></a>

## DesignViewModel.BlockVMs Property

Observable collection of the viewmodels which will help edit/display trial blocks

```csharp
public System.Collections.ObjectModel.ObservableCollection<HurPsyExp.ExpDesign.BlockItemViewModel> BlockVMs { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[BlockItemViewModel](HurPsyExp.ExpDesign.BlockItemViewModel.md 'HurPsyExp.ExpDesign.BlockItemViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.DeleteBlockCommand'></a>

## DesignViewModel.DeleteBlockCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [DeleteBlock()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.DeleteBlock() 'HurPsyExp.ExpDesign.DesignViewModel.DeleteBlock()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand DeleteBlockCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.DeleteLocatorCommand'></a>

## DesignViewModel.DeleteLocatorCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [DeleteLocator()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.DeleteLocator() 'HurPsyExp.ExpDesign.DesignViewModel.DeleteLocator()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand DeleteLocatorCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.DeleteStimulusCommand'></a>

## DesignViewModel.DeleteStimulusCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [DeleteStimulus()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.DeleteStimulus() 'HurPsyExp.ExpDesign.DesignViewModel.DeleteStimulus()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand DeleteStimulusCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.LoadExperimentCommand'></a>

## DesignViewModel.LoadExperimentCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [LoadExperiment()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.LoadExperiment() 'HurPsyExp.ExpDesign.DesignViewModel.LoadExperiment()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand LoadExperimentCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.LocatorVMs'></a>

## DesignViewModel.LocatorVMs Property

Observable collection of the viewmodels which will help edit/display locator definitions

```csharp
public System.Collections.ObjectModel.ObservableCollection<HurPsyExp.ExpDesign.LocatorItemViewModel> LocatorVMs { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[HurPsyExp.ExpDesign.LocatorItemViewModel](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.LocatorItemViewModel 'HurPsyExp.ExpDesign.LocatorItemViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.NewExperimentCommand'></a>

## DesignViewModel.NewExperimentCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [NewExperiment()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.NewExperiment() 'HurPsyExp.ExpDesign.DesignViewModel.NewExperiment()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand NewExperimentCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.SaveExperimentCommand'></a>

## DesignViewModel.SaveExperimentCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [SaveExperiment()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.SaveExperiment() 'HurPsyExp.ExpDesign.DesignViewModel.SaveExperiment()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand SaveExperimentCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.SelectImagesCommand'></a>

## DesignViewModel.SelectImagesCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [SelectImages()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.SelectImages() 'HurPsyExp.ExpDesign.DesignViewModel.SelectImages()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand SelectImagesCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.StimulusVMs'></a>

## DesignViewModel.StimulusVMs Property

Observable collection of the viewmodels which will help edit/display stimulus definitions

```csharp
public System.Collections.ObjectModel.ObservableCollection<HurPsyExp.ExpDesign.StimulusItemViewModel> StimulusVMs { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[HurPsyExp.ExpDesign.StimulusItemViewModel](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.StimulusItemViewModel 'HurPsyExp.ExpDesign.StimulusItemViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')
### Methods

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddBlock()'></a>

## DesignViewModel.AddBlock() Method

This method will create and add a block of trials to the experiment definition when the associated command is executed.

```csharp
public void AddBlock();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddHtmlStimulus()'></a>

## DesignViewModel.AddHtmlStimulus() Method

The method which will load and HTML stimulus from a file selected by the user when the associated command is executed.  
(Choosing the file is left to the `Utility.OpenFiles()` method, because it depends on the runtime environment)

```csharp
public void AddHtmlStimulus();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddLocatorVM(HurPsyLib.Locator)'></a>

## DesignViewModel.AddLocatorVM(Locator) Method

This method will create and add a viewmodel object associated with a `Locator` object

```csharp
private void AddLocatorVM(HurPsyLib.Locator loc);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddLocatorVM(HurPsyLib.Locator).loc'></a>

`loc` [HurPsyLib.Locator](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Locator 'HurPsyLib.Locator')

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddPointLocator()'></a>

## DesignViewModel.AddPointLocator() Method

This method will create and add a `PointLocator` object to the experiment definition

```csharp
public void AddPointLocator();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddStimulusVM(HurPsyLib.Stimulus)'></a>

## DesignViewModel.AddStimulusVM(Stimulus) Method

Create and add a viewmodel object associated with a `Stimulus` object

```csharp
private void AddStimulusVM(HurPsyLib.Stimulus stim);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddStimulusVM(HurPsyLib.Stimulus).stim'></a>

`stim` [HurPsyLib.Stimulus](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Stimulus 'HurPsyLib.Stimulus')

<a name='HurPsyExp.ExpDesign.DesignViewModel.ClearVMs()'></a>

## DesignViewModel.ClearVMs() Method

This private method clears all lists of viewmodel objects before loading or starting a new experiment definition.

```csharp
private void ClearVMs();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.DeleteBlock()'></a>

## DesignViewModel.DeleteBlock() Method

This method will deleted a block of trials selected on the experiment design interface when the associated command is executed.

```csharp
public void DeleteBlock();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.DeleteLocator()'></a>

## DesignViewModel.DeleteLocator() Method

This method which delete the `Locator` objects selected on the experiment design interface when the associated command is executed.

```csharp
private void DeleteLocator();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.DeleteStimulus()'></a>

## DesignViewModel.DeleteStimulus() Method

This method which delete the `Stimulus` objects selected on the experiment design interface when the associated command is executed.

```csharp
private void DeleteStimulus();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.LoadExperiment()'></a>

## DesignViewModel.LoadExperiment() Method

The method which will load an experiment definition from a file when the associated command is executed  
(Choosing the definition file and loading of the experiment is left to `Utility.LoadExperiment()` method because it depends on the runtime environment)

```csharp
public void LoadExperiment();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.Locvm_IdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs)'></a>

## DesignViewModel.Locvm_IdChanged(object, IdChangeEventArgs) Method

This method will handle the `IdChanged` events for `LocatorVM` objects

```csharp
private void Locvm_IdChanged(object? sender, HurPsyExp.ExpDesign.IdChangeEventArgs e);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.Locvm_IdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The object reporting the id change

<a name='HurPsyExp.ExpDesign.DesignViewModel.Locvm_IdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs).e'></a>

`e` [HurPsyExp.ExpDesign.IdChangeEventArgs](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.IdChangeEventArgs 'HurPsyExp.ExpDesign.IdChangeEventArgs')

Additional event info

<a name='HurPsyExp.ExpDesign.DesignViewModel.NewExperiment()'></a>

## DesignViewModel.NewExperiment() Method

The method which will create a new experiment definition when the associated command is executed

```csharp
public void NewExperiment();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.SaveExperiment()'></a>

## DesignViewModel.SaveExperiment() Method

The method which will save an experiment definition to a file when the associated command is executed  
(Creating the definition file and saving the experiment definition is left to `Utility.SaveExperiment()` method because it depends on the runtime environment)

```csharp
public void SaveExperiment();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.SelectImages()'></a>

## DesignViewModel.SelectImages() Method

The method which will load image stimuli from files selected by the user when the associated command is executed.  
(Choosing the image files is left to the `Utility.OpenFiles()` method, because it depends on the runtime environment)

```csharp
public void SelectImages();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.Stimvm_IdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs)'></a>

## DesignViewModel.Stimvm_IdChanged(object, IdChangeEventArgs) Method

This method will handle the `IdChanged` events for `StimulusVM` objects

```csharp
private void Stimvm_IdChanged(object? sender, HurPsyExp.ExpDesign.IdChangeEventArgs e);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.Stimvm_IdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The object reporting the id change

<a name='HurPsyExp.ExpDesign.DesignViewModel.Stimvm_IdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs).e'></a>

`e` [HurPsyExp.ExpDesign.IdChangeEventArgs](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.IdChangeEventArgs 'HurPsyExp.ExpDesign.IdChangeEventArgs')

Additional event info