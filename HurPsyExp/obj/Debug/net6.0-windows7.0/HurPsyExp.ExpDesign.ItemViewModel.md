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

| Fields | |
| :--- | :--- |
| [toggleSelectCommand](HurPsyExp.ExpDesign.ItemViewModel.toggleSelectCommand.md 'HurPsyExp.ExpDesign.ItemViewModel.toggleSelectCommand') | The backing field for [ToggleSelectCommand](HurPsyExp.ExpDesign.ItemViewModel.ToggleSelectCommand.md 'HurPsyExp.ExpDesign.ItemViewModel.ToggleSelectCommand'). |

| Properties | |
| :--- | :--- |
| [ToggleSelectCommand](HurPsyExp.ExpDesign.ItemViewModel.ToggleSelectCommand.md 'HurPsyExp.ExpDesign.ItemViewModel.ToggleSelectCommand') | Gets an [CommunityToolkit.Mvvm.Input.IRelayCommand](https://docs.microsoft.com/en-us/dotnet/api/CommunityToolkit.Mvvm.Input.IRelayCommand 'CommunityToolkit.Mvvm.Input.IRelayCommand') instance wrapping [HurPsyExp.ExpDesign.ItemViewModel.ToggleSelect](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.ItemViewModel.ToggleSelect 'HurPsyExp.ExpDesign.ItemViewModel.ToggleSelect'). |

| Methods | |
| :--- | :--- |
| [OnTempIdChanged(string)](HurPsyExp.ExpDesign.ItemViewModel.OnTempIdChanged(string).md 'HurPsyExp.ExpDesign.ItemViewModel.OnTempIdChanged(string)') | Executes the logic for when [HurPsyExp.ExpDesign.ItemViewModel.TempId](https://docs.microsoft.com/en-us/dotnet/api/HurPsyExp.ExpDesign.ItemViewModel.TempId 'HurPsyExp.ExpDesign.ItemViewModel.TempId') just changed. |
