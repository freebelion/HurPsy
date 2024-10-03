#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## BlockItemViewModel Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public class BlockItemViewModel : HurPsyExp.ExpDesign.ItemViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; [ItemViewModel](HurPsyExp.ExpDesign.ItemViewModel.md 'HurPsyExp.ExpDesign.ItemViewModel') &#129106; BlockItemViewModel
### Fields

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.addingTrialCommand'></a>

## BlockItemViewModel.addingTrialCommand Field

The backing field for [AddingTrialCommand](HurPsyExp.ExpDesign.BlockItemViewModel.md#HurPsyExp.ExpDesign.BlockItemViewModel.AddingTrialCommand 'HurPsyExp.ExpDesign.BlockItemViewModel.AddingTrialCommand').

```csharp
private RelayCommand<Expander>? addingTrialCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')[System.Windows.Controls.Expander](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.Expander 'System.Windows.Controls.Expander')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.addStepCommand'></a>

## BlockItemViewModel.addStepCommand Field

The backing field for [AddStepCommand](HurPsyExp.ExpDesign.BlockItemViewModel.md#HurPsyExp.ExpDesign.BlockItemViewModel.AddStepCommand 'HurPsyExp.ExpDesign.BlockItemViewModel.AddStepCommand').

```csharp
private RelayCommand? addStepCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')
### Properties

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.AddingTrialCommand'></a>

## BlockItemViewModel.AddingTrialCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [HurPsyExp.ExpDesign.BlockItemViewModel.AddingTrial(System.Windows.Controls.Expander)](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.BlockItemViewModel.AddingTrial#HurPsyExp_ExpDesign_BlockItemViewModel_AddingTrial_System_Windows_Controls_Expander_ 'HurPsyExp.ExpDesign.BlockItemViewModel.AddingTrial(System.Windows.Controls.Expander)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<System.Windows.Controls.Expander> AddingTrialCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[System.Windows.Controls.Expander](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.Expander 'System.Windows.Controls.Expander')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.AddStepCommand'></a>

## BlockItemViewModel.AddStepCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.BlockItemViewModel.AddStep](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.BlockItemViewModel.AddStep 'HurPsyExp.ExpDesign.BlockItemViewModel.AddStep').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand AddStepCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')