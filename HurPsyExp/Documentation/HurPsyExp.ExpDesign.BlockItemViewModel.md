#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## BlockItemViewModel Class

Supports all classes in the .NET Framework class hierarchy and provides low-level services to derived classes. This is the ultimate base class of all classes in the .NET Framework; it is the root of the type hierarchy.

```csharp
public class BlockItemViewModel : HurPsyExp.ExpDesign.ItemViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; [ItemViewModel](HurPsyExp.ExpDesign.ItemViewModel.md 'HurPsyExp.ExpDesign.ItemViewModel') &#129106; BlockItemViewModel
### Constructors

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.BlockItemViewModel(HurPsyLib.Block)'></a>

## BlockItemViewModel(Block) Constructor

This parametrized constructor creates an `ItemViewModel` instance associated with the given `Block` object

```csharp
public BlockItemViewModel(HurPsyLib.Block blck);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.BlockItemViewModel(HurPsyLib.Block).blck'></a>

`blck` [HurPsyLib.Block](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Block 'HurPsyLib.Block')
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

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.LocatorIds'></a>

## BlockItemViewModel.LocatorIds Field

The list of `Locator` Ids used in all the trial blocks

```csharp
public static List<string> LocatorIds;
```

#### Field Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.StimulusIds'></a>

## BlockItemViewModel.StimulusIds Field

The list of `Stimulus` Ids used in all the trial blocks

```csharp
public static List<string> StimulusIds;
```

#### Field Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
### Properties

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.AddingTrialCommand'></a>

## BlockItemViewModel.AddingTrialCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand&lt;&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1') instance wrapping [AddingTrial(Expander)](HurPsyExp.ExpDesign.BlockItemViewModel.md#HurPsyExp.ExpDesign.BlockItemViewModel.AddingTrial(System.Windows.Controls.Expander) 'HurPsyExp.ExpDesign.BlockItemViewModel.AddingTrial(System.Windows.Controls.Expander)').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand<System.Windows.Controls.Expander> AddingTrialCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand&lt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')[System.Windows.Controls.Expander](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.Expander 'System.Windows.Controls.Expander')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand-1 'CommunityToolkit.Mvvm.Input.IRelayCommand`1')

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.AddStepCommand'></a>

## BlockItemViewModel.AddStepCommand Property

Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [AddStep()](HurPsyExp.ExpDesign.BlockItemViewModel.md#HurPsyExp.ExpDesign.BlockItemViewModel.AddStep() 'HurPsyExp.ExpDesign.BlockItemViewModel.AddStep()').

```csharp
public CommunityToolkit.Mvvm.Input.IRelayCommand AddStepCommand { get; }
```

#### Property Value
[CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand')

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.TrialPattern'></a>

## BlockItemViewModel.TrialPattern Property

This property will act as an intermediary while adding experiment trials according to a pattern

```csharp
public HurPsyExp.ExpDesign.TempTrial TrialPattern { get; set; }
```

#### Property Value
[TempTrial](HurPsyExp.ExpDesign.TempTrial.md 'HurPsyExp.ExpDesign.TempTrial')

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.TrialVMs'></a>

## BlockItemViewModel.TrialVMs Property

The viewmodel objects associated with the block trials

```csharp
public System.Collections.ObjectModel.ObservableCollection<HurPsyExp.ExpDesign.TrialItemViewModel> TrialVMs { get; set; }
```

#### Property Value
[System.Collections.ObjectModel.ObservableCollection&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')[TrialItemViewModel](HurPsyExp.ExpDesign.TrialItemViewModel.md 'HurPsyExp.ExpDesign.TrialItemViewModel')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.ObjectModel.ObservableCollection-1 'System.Collections.ObjectModel.ObservableCollection`1')
### Methods

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.AddedTrial()'></a>

## BlockItemViewModel.AddedTrial() Method

This method will take care of the final actions after some trials have been added to the block

```csharp
private void AddedTrial();
```

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.AddingTrial(System.Windows.Controls.Expander)'></a>

## BlockItemViewModel.AddingTrial(Expander) Method

This method handles the process of adding new trials

```csharp
public void AddingTrial(System.Windows.Controls.Expander blckexp);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.AddingTrial(System.Windows.Controls.Expander).blckexp'></a>

`blckexp` [System.Windows.Controls.Expander](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.Expander 'System.Windows.Controls.Expander')

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.AddLocatorId(string)'></a>

## BlockItemViewModel.AddLocatorId(string) Method

This static method adds a locator Id to the list shared by all the blocks

```csharp
public static void AddLocatorId(string locId);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.AddLocatorId(string).locId'></a>

`locId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The locator Id to be added

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.AddStep()'></a>

## BlockItemViewModel.AddStep() Method

This method will add a new step to a selected trial  
(but it won't be used until multi-step trials are implemented)

```csharp
public void AddStep();
```

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.AddStimulusId(string)'></a>

## BlockItemViewModel.AddStimulusId(string) Method

This static method adds a stimulus Id to the list shared by all the blocks

```csharp
public static void AddStimulusId(string stimId);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.AddStimulusId(string).stimId'></a>

`stimId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The stimulus Id to be added

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.ChangeLocatorId(string,string)'></a>

## BlockItemViewModel.ChangeLocatorId(string, string) Method

This method will handle a locator Id change within the block represented by this object

```csharp
public void ChangeLocatorId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.ChangeLocatorId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.ChangeLocatorId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.ChangeStimulusId(string,string)'></a>

## BlockItemViewModel.ChangeStimulusId(string, string) Method

This method will handle a stimulus Id change within the block represented by this object

```csharp
public void ChangeStimulusId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.ChangeStimulusId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.ChangeStimulusId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.DeleteLocatorId(string)'></a>

## BlockItemViewModel.DeleteLocatorId(string) Method

This static method will remove a locator with the given Id from the list chared by all the trial blocks

```csharp
public static void DeleteLocatorId(string locId);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.DeleteLocatorId(string).locId'></a>

`locId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The Id of the locator to be removed

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.DeleteStimulusId(string)'></a>

## BlockItemViewModel.DeleteStimulusId(string) Method

This static method will remove a stimulus with the given Id from the list chared by all the trial blocks

```csharp
public static void DeleteStimulusId(string stimId);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.DeleteStimulusId(string).stimId'></a>

`stimId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The Id of the stimulus to be removed

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.RefreshTrialVMs()'></a>

## BlockItemViewModel.RefreshTrialVMs() Method

This private method will recreate the viewmodel objects associated with the block trials

```csharp
private void RefreshTrialVMs();
```

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.ReplaceLocatorId(string,string)'></a>

## BlockItemViewModel.ReplaceLocatorId(string, string) Method

This static method will handle an Id change for a locator

```csharp
public static void ReplaceLocatorId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.ReplaceLocatorId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The previous Id string for the locator

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.ReplaceLocatorId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The new Id string for the locator

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.ReplaceStimulusId(string,string)'></a>

## BlockItemViewModel.ReplaceStimulusId(string, string) Method

This static method will handle an Id change for a stimulus

```csharp
public static void ReplaceStimulusId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.ReplaceStimulusId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The previous Id string for the stimulus

<a name='HurPsyExp.ExpDesign.BlockItemViewModel.ReplaceStimulusId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The new Id string for the stimulus