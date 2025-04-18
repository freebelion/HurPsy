#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## IdObjectEditTemplateSelector Class

This class will select a template for an experiment item of `IdObject` type.

```csharp
internal class IdObjectEditTemplateSelector : System.Windows.Controls.DataTemplateSelector
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Windows.Controls.DataTemplateSelector](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.DataTemplateSelector 'System.Windows.Controls.DataTemplateSelector') &#129106; IdObjectEditTemplateSelector
### Methods

<a name='HurPsyExp.ExpDesign.IdObjectEditTemplateSelector.SelectTemplate(object,System.Windows.DependencyObject)'></a>

## IdObjectEditTemplateSelector.SelectTemplate(object, DependencyObject) Method

This is the implementation of the template selection method of the base class.

```csharp
public override System.Windows.DataTemplate SelectTemplate(object item, System.Windows.DependencyObject container);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.IdObjectEditTemplateSelector.SelectTemplate(object,System.Windows.DependencyObject).item'></a>

`item` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The item to be dipslayed as is or for editing

<a name='HurPsyExp.ExpDesign.IdObjectEditTemplateSelector.SelectTemplate(object,System.Windows.DependencyObject).container'></a>

`container` [System.Windows.DependencyObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.DependencyObject 'System.Windows.DependencyObject')

The container of the item

#### Returns
[System.Windows.DataTemplate](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.DataTemplate 'System.Windows.DataTemplate')  
The correct template associated with the item