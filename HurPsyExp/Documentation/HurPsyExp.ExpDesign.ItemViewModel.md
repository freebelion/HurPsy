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
&#8627; [LocatorItemViewModel](HurPsyExp.ExpDesign.LocatorItemViewModel.md 'HurPsyExp.ExpDesign.LocatorItemViewModel')  
&#8627; [StimulusItemViewModel](HurPsyExp.ExpDesign.StimulusItemViewModel.md 'HurPsyExp.ExpDesign.StimulusItemViewModel')  
&#8627; [TrialItemViewModel](HurPsyExp.ExpDesign.TrialItemViewModel.md 'HurPsyExp.ExpDesign.TrialItemViewModel')
### Constructors

<a name='HurPsyExp.ExpDesign.ItemViewModel.ItemViewModel(object)'></a>

## ItemViewModel(object) Constructor

This parametreized constructor creates an instance referencing an experiment element

```csharp
public ItemViewModel(object innerObject);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.ItemViewModel.ItemViewModel(object).innerObject'></a>

`innerObject` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')
### Fields

<a name='HurPsyExp.ExpDesign.ItemViewModel.editable'></a>

## ItemViewModel.editable Field

`Editable` property toggles the editable status of the experiment elements

```csharp
protected bool editable;
```

#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.ItemViewModel.itemObject'></a>

## ItemViewModel.itemObject Field

This field stores the reference for the actual experiment element represented by this instance

```csharp
protected object? itemObject;
```

#### Field Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='HurPsyExp.ExpDesign.ItemViewModel.selected'></a>

## ItemViewModel.selected Field

`Selected` property toggles the selection status of the experiment elements

```csharp
protected bool selected;
```

#### Field Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.ItemViewModel.tempId'></a>

## ItemViewModel.tempId Field

`TempId` property keeps the newly modified Id until the change is validated.

```csharp
protected string tempId;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.ItemViewModel.toggleSelectCommand'></a>

## ItemViewModel.toggleSelectCommand Field

The backing field for [ToggleSelectCommand](HurPsyExp.ExpDesign.ItemViewModel.md#HurPsyExp.ExpDesign.ItemViewModel.ToggleSelectCommand 'HurPsyExp.ExpDesign.ItemViewModel.ToggleSelectCommand').

```csharp
private RelayCommand? toggleSelectCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')
### Properties

<a name='HurPsyExp.ExpDesign.ItemViewModel.Editable'></a>

## ItemViewModel.Editable Property

`Editable` property toggles the editable status of the experiment elements

```csharp
public bool Editable { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.ItemViewModel.ItemObject'></a>

## ItemViewModel.ItemObject Property

This field stores the reference for the actual experiment element represented by this instance

```csharp
public object? ItemObject { get; set; }
```

#### Property Value
[System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='HurPsyExp.ExpDesign.ItemViewModel.Selected'></a>

## ItemViewModel.Selected Property

`Selected` property toggles the selection status of the experiment elements

```csharp
public bool Selected { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyExp.ExpDesign.ItemViewModel.TempId'></a>

## ItemViewModel.TempId Property

`TempId` property keeps the newly modified Id until the change is validated.

```csharp
public string TempId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.ItemViewModel.ToggleSelectCommand'></a>

## ItemViewModel.ToggleSelectCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [ToggleSelect()](HurPsyExp.ExpDesign.ItemViewModel.md#HurPsyExp.ExpDesign.ItemViewModel.ToggleSelect() 'HurPsyExp.ExpDesign.ItemViewModel.ToggleSelect()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand ToggleSelectCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')
### Methods

<a name='HurPsyExp.ExpDesign.ItemViewModel.OnTempIdChanged(string)'></a>

## ItemViewModel.OnTempIdChanged(string) Method

This method issues the `IdChanged` event with the newly modified `TempId`

```csharp
private void OnTempIdChanged(string value);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.ItemViewModel.OnTempIdChanged(string).value'></a>

`value` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.ItemViewModel.ToggleSelect()'></a>

## ItemViewModel.ToggleSelect() Method

This method toggles the selection status

```csharp
private void ToggleSelect();
```
### Events

<a name='HurPsyExp.ExpDesign.ItemViewModel.IdChanged'></a>

## ItemViewModel.IdChanged Event

The instances of this class can issue `IdChanged` events

```csharp
public event EventHandler<IdChangeEventArgs>? IdChanged;
```

#### Event Type
[System.EventHandler&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')[IdChangeEventArgs](HurPsyExp.ExpDesign.IdChangeEventArgs.md 'HurPsyExp.ExpDesign.IdChangeEventArgs')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.EventHandler-1 'System.EventHandler`1')