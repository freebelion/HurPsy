#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## ItemViewModel Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public abstract class ItemViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; ItemViewModel

Derived  
&#8627; [BlockItemViewModel](HurPsyExp.ExpDesign.BlockItemViewModel.md 'HurPsyExp.ExpDesign.BlockItemViewModel')
### Fields

<a name='HurPsyExp.ExpDesign.ItemViewModel.toggleSelectCommand'></a>

## ItemViewModel.toggleSelectCommand Field

The backing field for [ToggleSelectCommand](HurPsyExp.ExpDesign.ItemViewModel.md#HurPsyExp.ExpDesign.ItemViewModel.ToggleSelectCommand 'HurPsyExp.ExpDesign.ItemViewModel.ToggleSelectCommand').

```csharp
private RelayCommand? toggleSelectCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')
### Properties

<a name='HurPsyExp.ExpDesign.ItemViewModel.ToggleSelectCommand'></a>

## ItemViewModel.ToggleSelectCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.ItemViewModel.ToggleSelect](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.ItemViewModel.ToggleSelect 'HurPsyExp.ExpDesign.ItemViewModel.ToggleSelect').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand ToggleSelectCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')
### Methods

<a name='HurPsyExp.ExpDesign.ItemViewModel.OnTempIdChanged(string)'></a>

## ItemViewModel.OnTempIdChanged(string) Method

Executes the logic for when [HurPsyExp.ExpDesign.ItemViewModel.TempId](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.ItemViewModel.TempId 'HurPsyExp.ExpDesign.ItemViewModel.TempId') just changed.

```csharp
private void OnTempIdChanged(string value);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.ItemViewModel.OnTempIdChanged(string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The new property value that was set.

### Remarks
This method is invoked right after the value of [HurPsyExp.ExpDesign.ItemViewModel.TempId](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.ItemViewModel.TempId 'HurPsyExp.ExpDesign.ItemViewModel.TempId') is changed.