#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## DesignViewModel Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public class DesignViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; DesignViewModel
### Constructors

<a name='HurPsyExp.ExpDesign.DesignViewModel.DesignViewModel(HurPsyLib.Experiment)'></a>

## DesignViewModel(Experiment) Constructor

This default constructor starts with a new experiment definition and empty VM collections

```csharp
public DesignViewModel(HurPsyLib.Experiment? exp=null);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.DesignViewModel(HurPsyLib.Experiment).exp'></a>

`exp` [HurPsyLib.Experiment](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Experiment 'HurPsyLib.Experiment')
### Fields

<a name='HurPsyExp.ExpDesign.DesignViewModel.addingBlockCommand'></a>

## DesignViewModel.addingBlockCommand Field

The backing field for [AddingBlockCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddingBlockCommand 'HurPsyExp.ExpDesign.DesignViewModel.AddingBlockCommand').

```csharp
private RelayCommand? addingBlockCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.addingBlockMode'></a>

## DesignViewModel.addingBlockMode Field

This will be an indicator that the user will be adding new `Block` definitions

```csharp
private bool addingBlockMode;
```

#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.DesignViewModel.addingLocatorCommand'></a>

## DesignViewModel.addingLocatorCommand Field

The backing field for [AddingLocatorCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddingLocatorCommand 'HurPsyExp.ExpDesign.DesignViewModel.AddingLocatorCommand').

```csharp
private RelayCommand<Type>? addingLocatorCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.addingLocatorMode'></a>

## DesignViewModel.addingLocatorMode Field

This will be an indicator that the user will be adding new `Locator` definitions

```csharp
private bool addingLocatorMode;
```

#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.DesignViewModel.addingMode'></a>

## DesignViewModel.addingMode Field

The boolean indicator of Add Items Mode

```csharp
private bool addingMode;
```

#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.DesignViewModel.addingStimulusCommand'></a>

## DesignViewModel.addingStimulusCommand Field

The backing field for [AddingStimulusCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddingStimulusCommand 'HurPsyExp.ExpDesign.DesignViewModel.AddingStimulusCommand').

```csharp
private RelayCommand<Type>? addingStimulusCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.addingStimulusMode'></a>

## DesignViewModel.addingStimulusMode Field

This will be an indicator that the user will be adding new `Stimulus` definitions

```csharp
private bool addingStimulusMode;
```

#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.DesignViewModel.chooseContentCommand'></a>

## DesignViewModel.chooseContentCommand Field

The backing field for [ChooseContentCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.ChooseContentCommand 'HurPsyExp.ExpDesign.DesignViewModel.ChooseContentCommand').

```csharp
private RelayCommand<ContentChoice>? chooseContentCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')[ContentChoice](HurPsyExp.ContentChoice.md 'HurPsyExp.ContentChoice')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.currentExperiment'></a>

## DesignViewModel.currentExperiment Field

The `Experiment` object managed by this viewmodel

```csharp
private Experiment currentExperiment;
```

#### Field Value
[HurPsyLib.Experiment](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Experiment 'HurPsyLib.Experiment')

<a name='HurPsyExp.ExpDesign.DesignViewModel.displayContent'></a>

## DesignViewModel.displayContent Field

The current content set by this viewmodel (it will change depending on the choice clicked on **SingleLayoutMenu** defined in **DesignLayouts.xaml**)

```csharp
private ObservableCollection<IdObjectViewModel> displayContent;
```

#### Field Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[IdObjectViewModel](HurPsyExp.ExpDesign.IdObjectViewModel.md 'HurPsyExp.ExpDesign.IdObjectViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.displayContentChoice'></a>

## DesignViewModel.displayContentChoice Field

This field stores the current layout choice for `DesignWindow`

```csharp
private ContentChoice displayContentChoice;
```

#### Field Value
[ContentChoice](HurPsyExp.ContentChoice.md 'HurPsyExp.ContentChoice')

<a name='HurPsyExp.ExpDesign.DesignViewModel.displayContentLabel'></a>

## DesignViewModel.displayContentLabel Field

The label indicating the current display content (it will apear on **SingleLayoutLabel** defined in **DesignLayouts.xaml**)

```csharp
private string displayContentLabel;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.DesignViewModel.editMode'></a>

## DesignViewModel.editMode Field

The boolean indicator of editing Mode

```csharp
private bool editMode;
```

#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.DesignViewModel.experimentName'></a>

## DesignViewModel.experimentName Field

A property to expose the experiment's name

```csharp
private string experimentName;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

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

<a name='HurPsyExp.ExpDesign.DesignViewModel.runExperimentCommand'></a>

## DesignViewModel.runExperimentCommand Field

The backing field for [RunExperimentCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.RunExperimentCommand 'HurPsyExp.ExpDesign.DesignViewModel.RunExperimentCommand').

```csharp
private RelayCommand<Window>? runExperimentCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')[System.Windows.Window](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Window 'System.Windows.Window')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.saveExperimentAsCommand'></a>

## DesignViewModel.saveExperimentAsCommand Field

The backing field for [SaveExperimentAsCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.SaveExperimentAsCommand 'HurPsyExp.ExpDesign.DesignViewModel.SaveExperimentAsCommand').

```csharp
private RelayCommand? saveExperimentAsCommand;
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

<a name='HurPsyExp.ExpDesign.DesignViewModel.selectedItemVM'></a>

## DesignViewModel.selectedItemVM Field

Currently selected item

```csharp
private IdObjectViewModel? selectedItemVM;
```

#### Field Value
[IdObjectViewModel](HurPsyExp.ExpDesign.IdObjectViewModel.md 'HurPsyExp.ExpDesign.IdObjectViewModel')
### Properties

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddingBlockCommand'></a>

## DesignViewModel.AddingBlockCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [AddingBlock()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddingBlock() 'HurPsyExp.ExpDesign.DesignViewModel.AddingBlock()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand AddingBlockCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddingBlockMode'></a>

## DesignViewModel.AddingBlockMode Property

This will be an indicator that the user will be adding new `Block` definitions

```csharp
public bool AddingBlockMode { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddingLocatorCommand'></a>

## DesignViewModel.AddingLocatorCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [AddingLocator(Type)](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddingLocator(System.Type) 'HurPsyExp.ExpDesign.DesignViewModel.AddingLocator(System.Type)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<System.Type> AddingLocatorCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddingLocatorMode'></a>

## DesignViewModel.AddingLocatorMode Property

This will be an indicator that the user will be adding new `Locator` definitions

```csharp
public bool AddingLocatorMode { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddingMode'></a>

## DesignViewModel.AddingMode Property

The boolean indicator of Add Items Mode

```csharp
public bool AddingMode { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddingStimulusCommand'></a>

## DesignViewModel.AddingStimulusCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [AddingStimulus(Type)](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddingStimulus(System.Type) 'HurPsyExp.ExpDesign.DesignViewModel.AddingStimulus(System.Type)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<System.Type> AddingStimulusCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddingStimulusMode'></a>

## DesignViewModel.AddingStimulusMode Property

This will be an indicator that the user will be adding new `Stimulus` definitions

```csharp
public bool AddingStimulusMode { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.DesignViewModel.BlockVMs'></a>

## DesignViewModel.BlockVMs Property

Collection of viewmodels associated with the experiment's trial blocks

```csharp
public System.Collections.ObjectModel.ObservableCollection<HurPsyExp.ExpDesign.IdObjectViewModel> BlockVMs { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[IdObjectViewModel](HurPsyExp.ExpDesign.IdObjectViewModel.md 'HurPsyExp.ExpDesign.IdObjectViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.ChooseContentCommand'></a>

## DesignViewModel.ChooseContentCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [ChooseContent(ContentChoice)](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.ChooseContent(HurPsyExp.ContentChoice) 'HurPsyExp.ExpDesign.DesignViewModel.ChooseContent(HurPsyExp.ContentChoice)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<HurPsyExp.ContentChoice> ChooseContentCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[ContentChoice](HurPsyExp.ContentChoice.md 'HurPsyExp.ContentChoice')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.DisplayContent'></a>

## DesignViewModel.DisplayContent Property

The current content set by this viewmodel (it will change depending on the choice clicked on **SingleLayoutMenu** defined in **DesignLayouts.xaml**)

```csharp
public System.Collections.ObjectModel.ObservableCollection<HurPsyExp.ExpDesign.IdObjectViewModel> DisplayContent { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[IdObjectViewModel](HurPsyExp.ExpDesign.IdObjectViewModel.md 'HurPsyExp.ExpDesign.IdObjectViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.DisplayContentChoice'></a>

## DesignViewModel.DisplayContentChoice Property

This field stores the current layout choice for `DesignWindow`

```csharp
public HurPsyExp.ContentChoice DisplayContentChoice { get; set; }
```

#### Property Value
[ContentChoice](HurPsyExp.ContentChoice.md 'HurPsyExp.ContentChoice')

<a name='HurPsyExp.ExpDesign.DesignViewModel.DisplayContentLabel'></a>

## DesignViewModel.DisplayContentLabel Property

The label indicating the current display content (it will apear on **SingleLayoutLabel** defined in **DesignLayouts.xaml**)

```csharp
public string DisplayContentLabel { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.DesignViewModel.EditMode'></a>

## DesignViewModel.EditMode Property

The boolean indicator of editing Mode

```csharp
public bool EditMode { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.DesignViewModel.ExperimentName'></a>

## DesignViewModel.ExperimentName Property

A property to expose the experiment's name

```csharp
public string ExperimentName { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.DesignViewModel.LoadExperimentCommand'></a>

## DesignViewModel.LoadExperimentCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [LoadExperiment()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.LoadExperiment() 'HurPsyExp.ExpDesign.DesignViewModel.LoadExperiment()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand LoadExperimentCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.LocatorIds'></a>

## DesignViewModel.LocatorIds Property

A list containing only the Ids of `Locator` objects (used with one time binding for adding pairs to steps or trials to blocks)

```csharp
public System.Collections.Generic.List<string> LocatorIds { get; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.LocatorVMs'></a>

## DesignViewModel.LocatorVMs Property

Collection of viewmodels associated with the experiment's `Locator` objects

```csharp
public System.Collections.ObjectModel.ObservableCollection<HurPsyExp.ExpDesign.IdObjectViewModel> LocatorVMs { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[IdObjectViewModel](HurPsyExp.ExpDesign.IdObjectViewModel.md 'HurPsyExp.ExpDesign.IdObjectViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.NewExperimentCommand'></a>

## DesignViewModel.NewExperimentCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [NewExperiment()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.NewExperiment() 'HurPsyExp.ExpDesign.DesignViewModel.NewExperiment()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand NewExperimentCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.RunExperimentCommand'></a>

## DesignViewModel.RunExperimentCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [HurPsyExp.ExpDesign.DesignViewModel.RunExperiment(System.Windows.Window)](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.DesignViewModel.RunExperiment#HurPsyExp_ExpDesign_DesignViewModel_RunExperiment_System_Windows_Window_ 'HurPsyExp.ExpDesign.DesignViewModel.RunExperiment(System.Windows.Window)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<System.Windows.Window> RunExperimentCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[System.Windows.Window](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Window 'System.Windows.Window')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.SaveExperimentAsCommand'></a>

## DesignViewModel.SaveExperimentAsCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [SaveExperimentAs()](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.SaveExperimentAs() 'HurPsyExp.ExpDesign.DesignViewModel.SaveExperimentAs()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand SaveExperimentAsCommand { get; }
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

<a name='HurPsyExp.ExpDesign.DesignViewModel.SelectedItemVM'></a>

## DesignViewModel.SelectedItemVM Property

Currently selected item

```csharp
public HurPsyExp.ExpDesign.IdObjectViewModel? SelectedItemVM { get; set; }
```

#### Property Value
[IdObjectViewModel](HurPsyExp.ExpDesign.IdObjectViewModel.md 'HurPsyExp.ExpDesign.IdObjectViewModel')

<a name='HurPsyExp.ExpDesign.DesignViewModel.StimulusIds'></a>

## DesignViewModel.StimulusIds Property

A list containing only the Ids of `Stimulus` objects (used with one time binding for adding pairs to steps or trials to blocks)

```csharp
public System.Collections.Generic.List<string> StimulusIds { get; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyExp.ExpDesign.DesignViewModel.StimulusVMs'></a>

## DesignViewModel.StimulusVMs Property

Collection of viewmodels associated with the experiment's `Stimulus` objects

```csharp
public System.Collections.ObjectModel.ObservableCollection<HurPsyExp.ExpDesign.IdObjectViewModel> StimulusVMs { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[IdObjectViewModel](HurPsyExp.ExpDesign.IdObjectViewModel.md 'HurPsyExp.ExpDesign.IdObjectViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')
### Methods

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddingBlock()'></a>

## DesignViewModel.AddingBlock() Method

This command implementation adds a new trial block.

```csharp
private void AddingBlock();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddingImageStimulus()'></a>

## DesignViewModel.AddingImageStimulus() Method

This method displays an open file dialog to let the user choose images to serve as `ImageStimulus` elements.

```csharp
private void AddingImageStimulus();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddingLocator(System.Type)'></a>

## DesignViewModel.AddingLocator(Type) Method

This command implementation is the first step in adding `Locator` definitions to the experiment.

```csharp
private void AddingLocator(System.Type locType);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddingLocator(System.Type).locType'></a>

`locType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The subtype of `Locator`

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddingStimulus(System.Type)'></a>

## DesignViewModel.AddingStimulus(Type) Method

This command implementation is the first step in adding `Stimulus` definitions to the experiment.

```csharp
private void AddingStimulus(System.Type stimType);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddingStimulus(System.Type).stimType'></a>

`stimType` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

The subtype of `Stimulus`

<a name='HurPsyExp.ExpDesign.DesignViewModel.ChooseContent(HurPsyExp.ContentChoice)'></a>

## DesignViewModel.ChooseContent(ContentChoice) Method

This command implementation changes the display content according to the user's choice.

```csharp
private void ChooseContent(HurPsyExp.ContentChoice newchoice);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.ChooseContent(HurPsyExp.ContentChoice).newchoice'></a>

`newchoice` [ContentChoice](HurPsyExp.ContentChoice.md 'HurPsyExp.ContentChoice')

<a name='HurPsyExp.ExpDesign.DesignViewModel.ClearVMs()'></a>

## DesignViewModel.ClearVMs() Method

This short method will clear viewmodel collections in preparations for renewing the experiment definition.

```csharp
private void ClearVMs();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.CreateVM(HurPsyLib.IdObject)'></a>

## DesignViewModel.CreateVM(IdObject) Method

This little function creates a viewmodel object associated with an experiment item and initializes it.

```csharp
private HurPsyExp.ExpDesign.IdObjectViewModel CreateVM(HurPsyLib.IdObject idobj);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.CreateVM(HurPsyLib.IdObject).idobj'></a>

`idobj` [HurPsyLib.IdObject](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.IdObject 'HurPsyLib.IdObject')

#### Returns
[IdObjectViewModel](HurPsyExp.ExpDesign.IdObjectViewModel.md 'HurPsyExp.ExpDesign.IdObjectViewModel')

<a name='HurPsyExp.ExpDesign.DesignViewModel.CreateVMs()'></a>

## DesignViewModel.CreateVMs() Method

This method will create the viewmodel objects for the items in a loaded experiment.

```csharp
private void CreateVMs();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.ItemIdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs)'></a>

## DesignViewModel.ItemIdChanged(object, IdChangeEventArgs) Method

This is for handling the Id change events for `IdObjectViewModel` objects.

```csharp
private void ItemIdChanged(object? sender, HurPsyExp.ExpDesign.IdChangeEventArgs e);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.ItemIdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

`IdObjectViewModel` objects which reports a change in its `TempId` property

<a name='HurPsyExp.ExpDesign.DesignViewModel.ItemIdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs).e'></a>

`e` [IdChangeEventArgs](HurPsyExp.ExpDesign.IdChangeEventArgs.md 'HurPsyExp.ExpDesign.IdChangeEventArgs')

Id change parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.LoadExperiment()'></a>

## DesignViewModel.LoadExperiment() Method

The command implementation for loading an experiment definition from a file.

```csharp
private void LoadExperiment();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.NewExperiment()'></a>

## DesignViewModel.NewExperiment() Method

The command implementation for creating a new experiment definition.

```csharp
private void NewExperiment();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.OnAddingModeChanged(bool)'></a>

## DesignViewModel.OnAddingModeChanged(bool) Method

This method handles MVVM Toolkit's value changed event for `AddingMode` property; it modifies the boolean flags for hiding/showing the menus that will add Stimulus/Locator/Block, etc.

```csharp
private void OnAddingModeChanged(bool value);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.OnAddingModeChanged(bool).value'></a>

`value` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.DesignViewModel.OnExperimentNameChanged(string)'></a>

## DesignViewModel.OnExperimentNameChanged(string) Method

Relay the name change to the source experiment.

```csharp
private void OnExperimentNameChanged(string value);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.OnExperimentNameChanged(string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.DesignViewModel.SaveExperiment()'></a>

## DesignViewModel.SaveExperiment() Method

The command implementation for saving an experiment definition onto the same file  
If the experiment did not yet have a valid file, SaveExperimentAs command implementation will be called.

```csharp
private void SaveExperiment();
```

<a name='HurPsyExp.ExpDesign.DesignViewModel.SaveExperimentAs()'></a>

## DesignViewModel.SaveExperimentAs() Method

The command implementation for saving an experiment definition onto a file

```csharp
private void SaveExperimentAs();
```