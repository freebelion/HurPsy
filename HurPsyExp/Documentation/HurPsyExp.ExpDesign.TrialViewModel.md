#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## TrialViewModel Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public class TrialViewModel : HurPsyExp.ExpDesign.IdObjectViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; [IdObjectViewModel](HurPsyExp.ExpDesign.IdObjectViewModel.md 'HurPsyExp.ExpDesign.IdObjectViewModel') &#129106; TrialViewModel
### Constructors

<a name='HurPsyExp.ExpDesign.TrialViewModel.TrialViewModel(HurPsyLib.ExpTrial)'></a>

## TrialViewModel(ExpTrial) Constructor

The parametrized constructor for this specialized viewmodel

```csharp
public TrialViewModel(HurPsyLib.ExpTrial tr);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.TrialViewModel.TrialViewModel(HurPsyLib.ExpTrial).tr'></a>

`tr` [HurPsyLib.ExpTrial](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.ExpTrial 'HurPsyLib.ExpTrial')

The inner `ExpTrial` object
### Fields

<a name='HurPsyExp.ExpDesign.TrialViewModel.addStepCommand'></a>

## TrialViewModel.addStepCommand Field

The backing field for [AddStepCommand](HurPsyExp.ExpDesign.TrialViewModel.md#HurPsyExp.ExpDesign.TrialViewModel.AddStepCommand 'HurPsyExp.ExpDesign.TrialViewModel.AddStepCommand').

```csharp
private RelayCommand? addStepCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')
### Properties

<a name='HurPsyExp.ExpDesign.TrialViewModel.AddStepCommand'></a>

## TrialViewModel.AddStepCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.TrialViewModel.AddStep](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.TrialViewModel.AddStep 'HurPsyExp.ExpDesign.TrialViewModel.AddStep').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand AddStepCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.TrialViewModel.StepVMs'></a>

## TrialViewModel.StepVMs Property

The observable collection equivalent to the `ExpStep` list in the inner object

```csharp
public System.Collections.ObjectModel.ObservableCollection<HurPsyExp.ExpDesign.StepViewModel> StepVMs { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[StepViewModel](HurPsyExp.ExpDesign.StepViewModel.md 'HurPsyExp.ExpDesign.StepViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')