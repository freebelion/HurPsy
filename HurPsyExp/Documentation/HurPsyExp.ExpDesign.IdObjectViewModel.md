#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## IdObjectViewModel Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public class IdObjectViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; IdObjectViewModel

Derived  
&#8627; [BlockViewModel](HurPsyExp.ExpDesign.BlockViewModel.md 'HurPsyExp.ExpDesign.BlockViewModel')  
&#8627; [StepViewModel](HurPsyExp.ExpDesign.StepViewModel.md 'HurPsyExp.ExpDesign.StepViewModel')  
&#8627; [TrialViewModel](HurPsyExp.ExpDesign.TrialViewModel.md 'HurPsyExp.ExpDesign.TrialViewModel')
### Constructors

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.IdObjectViewModel(HurPsyLib.IdObject)'></a>

## IdObjectViewModel(IdObject) Constructor

This parametrized constructor creates a viewmodel instance referencing an experiment element

```csharp
public IdObjectViewModel(HurPsyLib.IdObject innerObject);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.IdObjectViewModel(HurPsyLib.IdObject).innerObject'></a>

`innerObject` [HurPsyLib.IdObject](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.IdObject 'HurPsyLib.IdObject')
### Fields

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.editable'></a>

## IdObjectViewModel.editable Field

`Editable` property toggles the editable status of the experiment elements

```csharp
private bool editable;
```

#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.itemObject'></a>

## IdObjectViewModel.itemObject Field

This field stores the reference for the actual experiment element represented by this instance

```csharp
private IdObject itemObject;
```

#### Field Value
[HurPsyLib.IdObject](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.IdObject 'HurPsyLib.IdObject')

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.selected'></a>

## IdObjectViewModel.selected Field

`Selected` property toggles the selection status of the experiment elements

```csharp
private bool selected;
```

#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.tempId'></a>

## IdObjectViewModel.tempId Field

`TempId` property keeps the newly modified Id until the change is validated.

```csharp
private string tempId;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.toggleSelectCommand'></a>

## IdObjectViewModel.toggleSelectCommand Field

The backing field for [ToggleSelectCommand](HurPsyExp.ExpDesign.IdObjectViewModel.md#HurPsyExp.ExpDesign.IdObjectViewModel.ToggleSelectCommand 'HurPsyExp.ExpDesign.IdObjectViewModel.ToggleSelectCommand').

```csharp
private RelayCommand? toggleSelectCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')
### Properties

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.Editable'></a>

## IdObjectViewModel.Editable Property

`Editable` property toggles the editable status of the experiment elements

```csharp
public bool Editable { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.IconImage'></a>

## IdObjectViewModel.IconImage Property

The path of the image file for the icon representing the inner element

```csharp
public object? IconImage { get; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.ItemObject'></a>

## IdObjectViewModel.ItemObject Property

This field stores the reference for the actual experiment element represented by this instance

```csharp
public HurPsyLib.IdObject ItemObject { get; set; }
```

#### Property Value
[HurPsyLib.IdObject](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.IdObject 'HurPsyLib.IdObject')

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.Selected'></a>

## IdObjectViewModel.Selected Property

`Selected` property toggles the selection status of the experiment elements

```csharp
public bool Selected { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.TempId'></a>

## IdObjectViewModel.TempId Property

`TempId` property keeps the newly modified Id until the change is validated.

```csharp
public string TempId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.ToggleSelectCommand'></a>

## IdObjectViewModel.ToggleSelectCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [ToggleSelect()](HurPsyExp.ExpDesign.IdObjectViewModel.md#HurPsyExp.ExpDesign.IdObjectViewModel.ToggleSelect() 'HurPsyExp.ExpDesign.IdObjectViewModel.ToggleSelect()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand ToggleSelectCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')
### Methods

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.OnTempIdChanged(string)'></a>

## IdObjectViewModel.OnTempIdChanged(string) Method

This method issues the `IdChanged` event with the newly modified `TempId`

```csharp
private void OnTempIdChanged(string value);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.OnTempIdChanged(string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.ToggleSelect()'></a>

## IdObjectViewModel.ToggleSelect() Method

This method toggles the selection status

```csharp
private void ToggleSelect();
```
### Events

<a name='HurPsyExp.ExpDesign.IdObjectViewModel.IdChanged'></a>

## IdObjectViewModel.IdChanged Event

The instances of this class can issue `IdChanged` events when a new Id is to be assigned to the inner element.

```csharp
public event EventHandler<IdChangeEventArgs>? IdChanged;
```

#### Event Type
[System.EventHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')[IdChangeEventArgs](HurPsyExp.ExpDesign.IdChangeEventArgs.md 'HurPsyExp.ExpDesign.IdChangeEventArgs')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')