#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## BlockViewModel Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public class BlockViewModel : HurPsyExp.ExpDesign.IdObjectViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; [IdObjectViewModel](HurPsyExp.ExpDesign.IdObjectViewModel.md 'HurPsyExp.ExpDesign.IdObjectViewModel') &#129106; BlockViewModel
### Constructors

<a name='HurPsyExp.ExpDesign.BlockViewModel.BlockViewModel(HurPsyLib.ExpBlock)'></a>

## BlockViewModel(ExpBlock) Constructor

This parametrized constructor defers to the base class.

```csharp
public BlockViewModel(HurPsyLib.ExpBlock blck);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockViewModel.BlockViewModel(HurPsyLib.ExpBlock).blck'></a>

`blck` [HurPsyLib.ExpBlock](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.ExpBlock 'HurPsyLib.ExpBlock')
### Fields

<a name='HurPsyExp.ExpDesign.BlockViewModel.addingMode'></a>

## BlockViewModel.addingMode Field

This is the basis of the property bound to the `ToggleButton` **btnAddMultipleTrial**.

```csharp
private bool addingMode;
```

#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.BlockViewModel.addMultipleTrialCancelCommand'></a>

## BlockViewModel.addMultipleTrialCancelCommand Field

The backing field for [AddMultipleTrialCancelCommand](HurPsyExp.ExpDesign.BlockViewModel.md#HurPsyExp.ExpDesign.BlockViewModel.AddMultipleTrialCancelCommand 'HurPsyExp.ExpDesign.BlockViewModel.AddMultipleTrialCancelCommand').

```csharp
private RelayCommand? addMultipleTrialCancelCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.BlockViewModel.addMultipleTrialCommand'></a>

## BlockViewModel.addMultipleTrialCommand Field

The backing field for [AddMultipleTrialCommand](HurPsyExp.ExpDesign.BlockViewModel.md#HurPsyExp.ExpDesign.BlockViewModel.AddMultipleTrialCommand 'HurPsyExp.ExpDesign.BlockViewModel.AddMultipleTrialCommand').

```csharp
private RelayCommand<TrialPattern>? addMultipleTrialCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')[TrialPattern](HurPsyExp.ExpDesign.TrialPattern.md 'HurPsyExp.ExpDesign.TrialPattern')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')

<a name='HurPsyExp.ExpDesign.BlockViewModel.addSingleTrialCommand'></a>

## BlockViewModel.addSingleTrialCommand Field

The backing field for [AddSingleTrialCommand](HurPsyExp.ExpDesign.BlockViewModel.md#HurPsyExp.ExpDesign.BlockViewModel.AddSingleTrialCommand 'HurPsyExp.ExpDesign.BlockViewModel.AddSingleTrialCommand').

```csharp
private RelayCommand? addSingleTrialCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.BlockViewModel.currentTrial'></a>

## BlockViewModel.currentTrial Field

This field will keep track of the index for the current trial being edited

```csharp
private TrialViewModel? currentTrial;
```

#### Field Value
[TrialViewModel](HurPsyExp.ExpDesign.TrialViewModel.md 'HurPsyExp.ExpDesign.TrialViewModel')

<a name='HurPsyExp.ExpDesign.BlockViewModel.currentTrialIndex'></a>

## BlockViewModel.currentTrialIndex Field

The privately stored index of `CurrentTrial`

```csharp
private int currentTrialIndex;
```

#### Field Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='HurPsyExp.ExpDesign.BlockViewModel.nextTrialCommand'></a>

## BlockViewModel.nextTrialCommand Field

The backing field for [NextTrialCommand](HurPsyExp.ExpDesign.BlockViewModel.md#HurPsyExp.ExpDesign.BlockViewModel.NextTrialCommand 'HurPsyExp.ExpDesign.BlockViewModel.NextTrialCommand').

```csharp
private RelayCommand? nextTrialCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.BlockViewModel.previousTrialCommand'></a>

## BlockViewModel.previousTrialCommand Field

The backing field for [PreviousTrialCommand](HurPsyExp.ExpDesign.BlockViewModel.md#HurPsyExp.ExpDesign.BlockViewModel.PreviousTrialCommand 'HurPsyExp.ExpDesign.BlockViewModel.PreviousTrialCommand').

```csharp
private RelayCommand? previousTrialCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')
### Properties

<a name='HurPsyExp.ExpDesign.BlockViewModel.AddingMode'></a>

## BlockViewModel.AddingMode Property

This is the basis of the property bound to the `ToggleButton` **btnAddMultipleTrial**.

```csharp
public bool AddingMode { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.BlockViewModel.AddMultipleTrialCancelCommand'></a>

## BlockViewModel.AddMultipleTrialCancelCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [AddMultipleTrialCancel()](HurPsyExp.ExpDesign.BlockViewModel.md#HurPsyExp.ExpDesign.BlockViewModel.AddMultipleTrialCancel() 'HurPsyExp.ExpDesign.BlockViewModel.AddMultipleTrialCancel()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand AddMultipleTrialCancelCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.BlockViewModel.AddMultipleTrialCommand'></a>

## BlockViewModel.AddMultipleTrialCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [AddMultipleTrial(TrialPattern)](HurPsyExp.ExpDesign.BlockViewModel.md#HurPsyExp.ExpDesign.BlockViewModel.AddMultipleTrial(HurPsyExp.ExpDesign.TrialPattern) 'HurPsyExp.ExpDesign.BlockViewModel.AddMultipleTrial(HurPsyExp.ExpDesign.TrialPattern)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<HurPsyExp.ExpDesign.TrialPattern> AddMultipleTrialCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[TrialPattern](HurPsyExp.ExpDesign.TrialPattern.md 'HurPsyExp.ExpDesign.TrialPattern')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.ExpDesign.BlockViewModel.AddSingleTrialCommand'></a>

## BlockViewModel.AddSingleTrialCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [AddSingleTrial()](HurPsyExp.ExpDesign.BlockViewModel.md#HurPsyExp.ExpDesign.BlockViewModel.AddSingleTrial() 'HurPsyExp.ExpDesign.BlockViewModel.AddSingleTrial()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand AddSingleTrialCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.BlockViewModel.CurrentTrial'></a>

## BlockViewModel.CurrentTrial Property

This field will keep track of the index for the current trial being edited

```csharp
public HurPsyExp.ExpDesign.TrialViewModel? CurrentTrial { get; set; }
```

#### Property Value
[TrialViewModel](HurPsyExp.ExpDesign.TrialViewModel.md 'HurPsyExp.ExpDesign.TrialViewModel')

<a name='HurPsyExp.ExpDesign.BlockViewModel.CurrentTrialIndex'></a>

## BlockViewModel.CurrentTrialIndex Property

The privately stored index of `CurrentTrial`

```csharp
public int CurrentTrialIndex { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='HurPsyExp.ExpDesign.BlockViewModel.NextTrialCommand'></a>

## BlockViewModel.NextTrialCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [NextTrial()](HurPsyExp.ExpDesign.BlockViewModel.md#HurPsyExp.ExpDesign.BlockViewModel.NextTrial() 'HurPsyExp.ExpDesign.BlockViewModel.NextTrial()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand NextTrialCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.BlockViewModel.PreviousTrialCommand'></a>

## BlockViewModel.PreviousTrialCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [PreviousTrial()](HurPsyExp.ExpDesign.BlockViewModel.md#HurPsyExp.ExpDesign.BlockViewModel.PreviousTrial() 'HurPsyExp.ExpDesign.BlockViewModel.PreviousTrial()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand PreviousTrialCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.BlockViewModel.TrialVMs'></a>

## BlockViewModel.TrialVMs Property

Observable collection of viewmodels representing the block trials

```csharp
public System.Collections.ObjectModel.ObservableCollection<HurPsyExp.ExpDesign.TrialViewModel> TrialVMs { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[TrialViewModel](HurPsyExp.ExpDesign.TrialViewModel.md 'HurPsyExp.ExpDesign.TrialViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')
### Methods

<a name='HurPsyExp.ExpDesign.BlockViewModel.AddMultipleTrial(HurPsyExp.ExpDesign.TrialPattern)'></a>

## BlockViewModel.AddMultipleTrial(TrialPattern) Method

This command implementation adds multiple trials based on the combination of `Stimulus`-`Locator` pairing choices of the user.

```csharp
private void AddMultipleTrial(HurPsyExp.ExpDesign.TrialPattern trpattern);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockViewModel.AddMultipleTrial(HurPsyExp.ExpDesign.TrialPattern).trpattern'></a>

`trpattern` [TrialPattern](HurPsyExp.ExpDesign.TrialPattern.md 'HurPsyExp.ExpDesign.TrialPattern')

<a name='HurPsyExp.ExpDesign.BlockViewModel.AddMultipleTrialCancel()'></a>

## BlockViewModel.AddMultipleTrialCancel() Method

This command implementation will cancel adding multiple trials and close the **AddTrialPopup**.

```csharp
private void AddMultipleTrialCancel();
```

<a name='HurPsyExp.ExpDesign.BlockViewModel.AddSingleTrial()'></a>

## BlockViewModel.AddSingleTrial() Method

This command implementation adds one new single-step trial and moves the `CurrentTrial` to that one.

```csharp
private void AddSingleTrial();
```

<a name='HurPsyExp.ExpDesign.BlockViewModel.AddTrialVM(HurPsyLib.ExpTrial)'></a>

## BlockViewModel.AddTrialVM(ExpTrial) Method

This private method adds a viewmodel object associated with a `ExpTrial` object

```csharp
private void AddTrialVM(HurPsyLib.ExpTrial tr);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockViewModel.AddTrialVM(HurPsyLib.ExpTrial).tr'></a>

`tr` [HurPsyLib.ExpTrial](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.ExpTrial 'HurPsyLib.ExpTrial')

<a name='HurPsyExp.ExpDesign.BlockViewModel.NextTrial()'></a>

## BlockViewModel.NextTrial() Method

This command implementation moves to the next trial as `CurrentTrial`

```csharp
private void NextTrial();
```

<a name='HurPsyExp.ExpDesign.BlockViewModel.OnCurrentTrialIndexChanged(int)'></a>

## BlockViewModel.OnCurrentTrialIndexChanged(int) Method

This inner method updates the `CurrentTrial` property after `CurrentTrialIndex` has changed.

```csharp
private void OnCurrentTrialIndexChanged(int value);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockViewModel.OnCurrentTrialIndexChanged(int).value'></a>

`value` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='HurPsyExp.ExpDesign.BlockViewModel.PreviousTrial()'></a>

## BlockViewModel.PreviousTrial() Method

This command implementation moves to the previous trial as `CurrentTrial`

```csharp
private void PreviousTrial();
```

<a name='HurPsyExp.ExpDesign.BlockViewModel.TrialIdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs)'></a>

## BlockViewModel.TrialIdChanged(object, IdChangeEventArgs) Method

This event handler updates the Id of an `ExpTrial` object when its viewmodel reports an Id change.

```csharp
private void TrialIdChanged(object? sender, HurPsyExp.ExpDesign.IdChangeEventArgs e);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockViewModel.TrialIdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='HurPsyExp.ExpDesign.BlockViewModel.TrialIdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs).e'></a>

`e` [IdChangeEventArgs](HurPsyExp.ExpDesign.IdChangeEventArgs.md 'HurPsyExp.ExpDesign.IdChangeEventArgs')