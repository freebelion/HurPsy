#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpRun](HurPsyExp.ExpRun.md 'HurPsyExp.ExpRun')

## VisualStimulusTemplateSelector Class

```csharp
public class VisualStimulusTemplateSelector : System.Windows.Controls.DataTemplateSelector
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Windows.Controls.DataTemplateSelector](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Controls.DataTemplateSelector 'System.Windows.Controls.DataTemplateSelector') &#129106; VisualStimulusTemplateSelector
### Methods

<a name='HurPsyExp.ExpRun.VisualStimulusTemplateSelector.SelectTemplate(object,System.Windows.DependencyObject)'></a>

## VisualStimulusTemplateSelector.SelectTemplate(object, DependencyObject) Method

This is the implementation of the template selection method of the base class.

```csharp
public override System.Windows.DataTemplate SelectTemplate(object item, System.Windows.DependencyObject container);
```
#### Parameters

<a name='HurPsyExp.ExpRun.VisualStimulusTemplateSelector.SelectTemplate(object,System.Windows.DependencyObject).item'></a>

`item` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The viewmodel of the visual stimulus

<a name='HurPsyExp.ExpRun.VisualStimulusTemplateSelector.SelectTemplate(object,System.Windows.DependencyObject).container'></a>

`container` [System.Windows.DependencyObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.DependencyObject 'System.Windows.DependencyObject')

The container which will display the visual stimulus

#### Returns
[System.Windows.DataTemplate](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.DataTemplate 'System.Windows.DataTemplate')  
The correct template associated with the visual stimulus