#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## LocatorItemViewModel Class

This viewmodel class will help data exchange between a `Locator` object and its `ItemView` on the design interface.

```csharp
public class LocatorItemViewModel : HurPsyExp.ExpDesign.ItemViewModel
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [CommunityToolkit.Mvvm.ComponentModel.ObservableObject](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.ComponentModel.ObservableObject 'CommunityToolkit.Mvvm.ComponentModel.ObservableObject') &#129106; [ItemViewModel](HurPsyExp.ExpDesign.ItemViewModel.md 'HurPsyExp.ExpDesign.ItemViewModel') &#129106; LocatorItemViewModel
### Constructors

<a name='HurPsyExp.ExpDesign.LocatorItemViewModel.LocatorItemViewModel(HurPsyLib.Locator)'></a>

## LocatorItemViewModel(Locator) Constructor

This parametrized constructor creates an `ItemViewModel` instance associated with the given `Locator` object

```csharp
public LocatorItemViewModel(HurPsyLib.Locator loc);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.LocatorItemViewModel.LocatorItemViewModel(HurPsyLib.Locator).loc'></a>

`loc` [HurPsyLib.Locator](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Locator 'HurPsyLib.Locator')

The `Locator` object which will be associated with this viewmodel