#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## DesignViewModel Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public class DesignViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; DesignViewModel
### Constructors

<a name='HurPsyExp.ExpDesign.DesignViewModel.DesignViewModel()'></a>

## DesignViewModel() Constructor

This default constructor simply starts with empty lists of the inner viewmodel objects

```csharp
public DesignViewModel();
```
### Fields

<a name='HurPsyExp.ExpDesign.DesignViewModel.addBlockCommand'></a>

## DesignViewModel.addBlockCommand Field

The backing field for [AddBlockCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddBlockCommand 'HurPsyExp.ExpDesign.DesignViewModel.AddBlockCommand').

```csharp
private RelayCommand? addBlockCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.addHtmlStimulusCommand'></a>

## DesignViewModel.addHtmlStimulusCommand Field

The backing field for [AddHtmlStimulusCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddHtmlStimulusCommand 'HurPsyExp.ExpDesign.DesignViewModel.AddHtmlStimulusCommand').

```csharp
private RelayCommand? addHtmlStimulusCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.addPointLocatorCommand'></a>

## DesignViewModel.addPointLocatorCommand Field

The backing field for [AddPointLocatorCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.AddPointLocatorCommand 'HurPsyExp.ExpDesign.DesignViewModel.AddPointLocatorCommand').

```csharp
private RelayCommand? addPointLocatorCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.deleteBlockCommand'></a>

## DesignViewModel.deleteBlockCommand Field

The backing field for [DeleteBlockCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.DeleteBlockCommand 'HurPsyExp.ExpDesign.DesignViewModel.DeleteBlockCommand').

```csharp
private RelayCommand? deleteBlockCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.deleteLocatorCommand'></a>

## DesignViewModel.deleteLocatorCommand Field

The backing field for [DeleteLocatorCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.DeleteLocatorCommand 'HurPsyExp.ExpDesign.DesignViewModel.DeleteLocatorCommand').

```csharp
private RelayCommand? deleteLocatorCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.deleteStimulusCommand'></a>

## DesignViewModel.deleteStimulusCommand Field

The backing field for [DeleteStimulusCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.DeleteStimulusCommand 'HurPsyExp.ExpDesign.DesignViewModel.DeleteStimulusCommand').

```csharp
private RelayCommand? deleteStimulusCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

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

<a name='HurPsyExp.ExpDesign.DesignViewModel.saveExperimentCommand'></a>

## DesignViewModel.saveExperimentCommand Field

The backing field for [SaveExperimentCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.SaveExperimentCommand 'HurPsyExp.ExpDesign.DesignViewModel.SaveExperimentCommand').

```csharp
private RelayCommand? saveExperimentCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.selectImagesCommand'></a>

## DesignViewModel.selectImagesCommand Field

The backing field for [SelectImagesCommand](HurPsyExp.ExpDesign.DesignViewModel.md#HurPsyExp.ExpDesign.DesignViewModel.SelectImagesCommand 'HurPsyExp.ExpDesign.DesignViewModel.SelectImagesCommand').

```csharp
private RelayCommand? selectImagesCommand;
```

#### Field Value
[CommunityToolkit.Mvvm.Input.RelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.RelayCommand 'CommunityToolkit.Mvvm.Input.RelayCommand')
### Properties

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddBlockCommand'></a>

## DesignViewModel.AddBlockCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.DesignViewModel.AddBlock](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.DesignViewModel.AddBlock 'HurPsyExp.ExpDesign.DesignViewModel.AddBlock').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand AddBlockCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddHtmlStimulusCommand'></a>

## DesignViewModel.AddHtmlStimulusCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.DesignViewModel.AddHtmlStimulus](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.DesignViewModel.AddHtmlStimulus 'HurPsyExp.ExpDesign.DesignViewModel.AddHtmlStimulus').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand AddHtmlStimulusCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.AddPointLocatorCommand'></a>

## DesignViewModel.AddPointLocatorCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.DesignViewModel.AddPointLocator](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.DesignViewModel.AddPointLocator 'HurPsyExp.ExpDesign.DesignViewModel.AddPointLocator').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand AddPointLocatorCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.DeleteBlockCommand'></a>

## DesignViewModel.DeleteBlockCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.DesignViewModel.DeleteBlock](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.DesignViewModel.DeleteBlock 'HurPsyExp.ExpDesign.DesignViewModel.DeleteBlock').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand DeleteBlockCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.DeleteLocatorCommand'></a>

## DesignViewModel.DeleteLocatorCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.DesignViewModel.DeleteLocator](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.DesignViewModel.DeleteLocator 'HurPsyExp.ExpDesign.DesignViewModel.DeleteLocator').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand DeleteLocatorCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.DeleteStimulusCommand'></a>

## DesignViewModel.DeleteStimulusCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.DesignViewModel.DeleteStimulus](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.DesignViewModel.DeleteStimulus 'HurPsyExp.ExpDesign.DesignViewModel.DeleteStimulus').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand DeleteStimulusCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.LoadExperimentCommand'></a>

## DesignViewModel.LoadExperimentCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.DesignViewModel.LoadExperiment](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.DesignViewModel.LoadExperiment 'HurPsyExp.ExpDesign.DesignViewModel.LoadExperiment').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand LoadExperimentCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.NewExperimentCommand'></a>

## DesignViewModel.NewExperimentCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.DesignViewModel.NewExperiment](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.DesignViewModel.NewExperiment 'HurPsyExp.ExpDesign.DesignViewModel.NewExperiment').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand NewExperimentCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.SaveExperimentCommand'></a>

## DesignViewModel.SaveExperimentCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.DesignViewModel.SaveExperiment](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.DesignViewModel.SaveExperiment 'HurPsyExp.ExpDesign.DesignViewModel.SaveExperiment').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand SaveExperimentCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.DesignViewModel.SelectImagesCommand'></a>

## DesignViewModel.SelectImagesCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.DesignViewModel.SelectImages](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.DesignViewModel.SelectImages 'HurPsyExp.ExpDesign.DesignViewModel.SelectImages').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand SelectImagesCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')
### Methods

<a name='HurPsyExp.ExpDesign.DesignViewModel.Locvm_IdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs)'></a>

## DesignViewModel.Locvm_IdChanged(object, IdChangeEventArgs) Method

This specialized event handler intervenes  
when the user attempts to change the TempId  
of a LocatorVM object and passes the change  
to the underlying Locator object  
only after certain conditions are met.

```csharp
private void Locvm_IdChanged(object? sender, HurPsyExp.ExpDesign.IdChangeEventArgs e);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.DesignViewModel.Locvm_IdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs).sender'></a>

`sender` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

<a name='HurPsyExp.ExpDesign.DesignViewModel.Locvm_IdChanged(object,HurPsyExp.ExpDesign.IdChangeEventArgs).e'></a>

`e` [HurPsyExp.ExpDesign.IdChangeEventArgs](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.IdChangeEventArgs 'HurPsyExp.ExpDesign.IdChangeEventArgs')