#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## TrialPattern Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public class TrialPattern
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; TrialPattern
### Constructors

<a name='HurPsyExp.ExpDesign.TrialPattern.TrialPattern()'></a>

## TrialPattern() Constructor

The default consturctor starts with an empty list of sets

```csharp
public TrialPattern();
```
### Fields

<a name='HurPsyExp.ExpDesign.TrialPattern.addIdPairSetCommand'></a>

## TrialPattern.addIdPairSetCommand Field

The backing field for [AddIdPairSetCommand](HurPsyExp.ExpDesign.TrialPattern.md#HurPsyExp.ExpDesign.TrialPattern.AddIdPairSetCommand 'HurPsyExp.ExpDesign.TrialPattern.AddIdPairSetCommand').

```csharp
private RelayCommand? addIdPairSetCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')
### Properties

<a name='HurPsyExp.ExpDesign.TrialPattern.AddIdPairSetCommand'></a>

## TrialPattern.AddIdPairSetCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [AddIdPairSet()](HurPsyExp.ExpDesign.TrialPattern.md#HurPsyExp.ExpDesign.TrialPattern.AddIdPairSet() 'HurPsyExp.ExpDesign.TrialPattern.AddIdPairSet()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand AddIdPairSetCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.TrialPattern.IdPairSets'></a>

## TrialPattern.IdPairSets Property

The collection of id-pair sets

```csharp
public System.Collections.ObjectModel.ObservableCollection<HurPsyExp.ExpDesign.IdPairSet> IdPairSets { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[IdPairSet](HurPsyExp.ExpDesign.IdPairSet.md 'HurPsyExp.ExpDesign.IdPairSet')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')
### Methods

<a name='HurPsyExp.ExpDesign.TrialPattern.AddIdPairSet()'></a>

## TrialPattern.AddIdPairSet() Method

This command implementation creates a new Id-pair set which shows up on **AddTrialPopup**

```csharp
private void AddIdPairSet();
```

<a name='HurPsyExp.ExpDesign.TrialPattern.ConstructTrialSteps()'></a>

## TrialPattern.ConstructTrialSteps() Method

This method will construct an array of steps to be used in multiple single-step trials.

```csharp
public System.Collections.Generic.List<HurPsyLib.ExpStep> ConstructTrialSteps();
```

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[HurPsyLib.ExpStep](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.ExpStep 'HurPsyLib.ExpStep')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')