#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## StepViewModel Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public class StepViewModel : HurPsyExp.ExpDesign.IdObjectViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; [IdObjectViewModel](HurPsyExp.ExpDesign.IdObjectViewModel.md 'HurPsyExp.ExpDesign.IdObjectViewModel') &#129106; StepViewModel
### Constructors

<a name='HurPsyExp.ExpDesign.StepViewModel.StepViewModel(HurPsyLib.ExpStep)'></a>

## StepViewModel(ExpStep) Constructor

The parametrized constructor for this specialized viewmodel

```csharp
public StepViewModel(HurPsyLib.ExpStep st);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.StepViewModel.StepViewModel(HurPsyLib.ExpStep).st'></a>

`st` [HurPsyLib.ExpStep](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.ExpStep 'HurPsyLib.ExpStep')

The inner `ExpStep` object
### Fields

<a name='HurPsyExp.ExpDesign.StepViewModel.addingMode'></a>

## StepViewModel.addingMode Field

This is the basis of the property bound to the `ToggleButton` **btnAddPair**.

```csharp
private bool addingMode;
```

#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.StepViewModel.addPairCommand'></a>

## StepViewModel.addPairCommand Field

The backing field for [AddPairCommand](HurPsyExp.ExpDesign.StepViewModel.md#HurPsyExp.ExpDesign.StepViewModel.AddPairCommand 'HurPsyExp.ExpDesign.StepViewModel.AddPairCommand').

```csharp
private RelayCommand<ExpPair>? addPairCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')[HurPsyLib.ExpPair](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.ExpPair 'HurPsyLib.ExpPair')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')

<a name='HurPsyExp.ExpDesign.StepViewModel.cancelAddPairCommand'></a>

## StepViewModel.cancelAddPairCommand Field

The backing field for [CancelAddPairCommand](HurPsyExp.ExpDesign.StepViewModel.md#HurPsyExp.ExpDesign.StepViewModel.CancelAddPairCommand 'HurPsyExp.ExpDesign.StepViewModel.CancelAddPairCommand').

```csharp
private RelayCommand? cancelAddPairCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')
### Properties

<a name='HurPsyExp.ExpDesign.StepViewModel.AddingMode'></a>

## StepViewModel.AddingMode Property

This is the basis of the property bound to the `ToggleButton` **btnAddPair**.

```csharp
public bool AddingMode { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.StepViewModel.AddPairCommand'></a>

## StepViewModel.AddPairCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [AddPair(ExpPair)](HurPsyExp.ExpDesign.StepViewModel.md#HurPsyExp.ExpDesign.StepViewModel.AddPair(HurPsyLib.ExpPair) 'HurPsyExp.ExpDesign.StepViewModel.AddPair(HurPsyLib.ExpPair)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<HurPsyLib.ExpPair> AddPairCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[HurPsyLib.ExpPair](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.ExpPair 'HurPsyLib.ExpPair')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.ExpDesign.StepViewModel.CancelAddPairCommand'></a>

## StepViewModel.CancelAddPairCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [CancelAddPair()](HurPsyExp.ExpDesign.StepViewModel.md#HurPsyExp.ExpDesign.StepViewModel.CancelAddPair() 'HurPsyExp.ExpDesign.StepViewModel.CancelAddPair()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand CancelAddPairCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.StepViewModel.PairVMs'></a>

## StepViewModel.PairVMs Property

The observable collection equivalent to the `ExpPair` list in the inner object

```csharp
public System.Collections.ObjectModel.ObservableCollection<HurPsyLib.ExpPair> PairVMs { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[HurPsyLib.ExpPair](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.ExpPair 'HurPsyLib.ExpPair')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')
### Methods

<a name='HurPsyExp.ExpDesign.StepViewModel.AddPair(HurPsyLib.ExpPair)'></a>

## StepViewModel.AddPair(ExpPair) Method

This command implementation adds a new `Locator`-`Stimulus` Id pair to the underlying trial step.

```csharp
private void AddPair(HurPsyLib.ExpPair pr);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.StepViewModel.AddPair(HurPsyLib.ExpPair).pr'></a>

`pr` [HurPsyLib.ExpPair](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.ExpPair 'HurPsyLib.ExpPair')

The `ParameterPair` object which brings in the Ids to be paired

<a name='HurPsyExp.ExpDesign.StepViewModel.CancelAddPair()'></a>

## StepViewModel.CancelAddPair() Method

This command implementation cancels adding a new pair and hides the **AddPairPopup* control.

```csharp
private void CancelAddPair();
```