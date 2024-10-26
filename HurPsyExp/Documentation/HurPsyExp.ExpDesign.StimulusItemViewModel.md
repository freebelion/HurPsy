#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## StimulusItemViewModel Class

This viewmodel class will help data exchange between a `Stimulus` object and its `ItemView` on the design interface.

```csharp
public class StimulusItemViewModel : HurPsyExp.ExpDesign.ItemViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; [ItemViewModel](HurPsyExp.ExpDesign.ItemViewModel.md 'HurPsyExp.ExpDesign.ItemViewModel') &#129106; StimulusItemViewModel
### Constructors

<a name='HurPsyExp.ExpDesign.StimulusItemViewModel.StimulusItemViewModel(HurPsyLib.Stimulus)'></a>

## StimulusItemViewModel(Stimulus) Constructor

This parametrized constructor creates an `ItemViewModel` instance associated with the given `Stimulus` object

```csharp
public StimulusItemViewModel(HurPsyLib.Stimulus stim);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.StimulusItemViewModel.StimulusItemViewModel(HurPsyLib.Stimulus).stim'></a>

`stim` [HurPsyLib.Stimulus](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Stimulus 'HurPsyLib.Stimulus')

The `Stimulus` object which will be associated with this viewmodel
### Properties

<a name='HurPsyExp.ExpDesign.StimulusItemViewModel.IconImage'></a>

## StimulusItemViewModel.IconImage Property

This property returns the path of the image file which will serve as the icon representing the stimulus type

```csharp
public string IconImage { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')