#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## IdPairSet Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public class IdPairSet
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IdPairSet
### Constructors

<a name='HurPsyExp.ExpDesign.IdPairSet.IdPairSet()'></a>

## IdPairSet() Constructor

Default constructor starts with defaults

```csharp
public IdPairSet();
```
### Fields

<a name='HurPsyExp.ExpDesign.IdPairSet.idSelectionChangedCommand'></a>

## IdPairSet.idSelectionChangedCommand Field

The backing field for [IdSelectionChangedCommand](HurPsyExp.ExpDesign.IdPairSet.md#HurPsyExp.ExpDesign.IdPairSet.IdSelectionChangedCommand 'HurPsyExp.ExpDesign.IdPairSet.IdSelectionChangedCommand').

```csharp
private RelayCommand<SelectionChangedEventArgs>? idSelectionChangedCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')[System.Windows.Controls.SelectionChangedEventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand-1 'CommunityToolkit.Mvvm.Input.RelayCommand`1')
### Properties

<a name='HurPsyExp.ExpDesign.IdPairSet.IdSelectionChangedCommand'></a>

## IdPairSet.IdSelectionChangedCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [IdSelectionChanged(SelectionChangedEventArgs)](HurPsyExp.ExpDesign.IdPairSet.md#HurPsyExp.ExpDesign.IdPairSet.IdSelectionChanged(System.Windows.Controls.SelectionChangedEventArgs) 'HurPsyExp.ExpDesign.IdPairSet.IdSelectionChanged(System.Windows.Controls.SelectionChangedEventArgs)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<System.Windows.Controls.SelectionChangedEventArgs> IdSelectionChangedCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[System.Windows.Controls.SelectionChangedEventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.ExpDesign.IdPairSet.LocatorId'></a>

## IdPairSet.LocatorId Property

`Locator` Id selected by the user

```csharp
public string? LocatorId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.IdPairSet.RepeatCount'></a>

## IdPairSet.RepeatCount Property

The number of times this Id pairing set will be repeated (for each one of `SelectedStimulusIds`)

```csharp
public int RepeatCount { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')

<a name='HurPsyExp.ExpDesign.IdPairSet.SelectedStimulusIds'></a>

## IdPairSet.SelectedStimulusIds Property

The collection of `Stimulus` Ids which will be paired with the selected `Locator` Id

```csharp
public System.Collections.ObjectModel.ObservableCollection<string> SelectedStimulusIds { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')
### Methods

<a name='HurPsyExp.ExpDesign.IdPairSet.IdSelectionChanged(System.Windows.Controls.SelectionChangedEventArgs)'></a>

## IdPairSet.IdSelectionChanged(SelectionChangedEventArgs) Method

This command implementation handles the `SelectionChanged` event in the `ListBox` displaying `Stimulus` Ids

```csharp
private void IdSelectionChanged(System.Windows.Controls.SelectionChangedEventArgs e);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.IdPairSet.IdSelectionChanged(System.Windows.Controls.SelectionChangedEventArgs).e'></a>

`e` [System.Windows.Controls.SelectionChangedEventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.SelectionChangedEventArgs 'System.Windows.Controls.SelectionChangedEventArgs')