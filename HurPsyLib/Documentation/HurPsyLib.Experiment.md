### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## Experiment Class

This class represents the complete definition of a computerized psychology experiment.

```csharp
public class Experiment
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Experiment
### Constructors

<a name='HurPsyLib.Experiment.Experiment()'></a>

## Experiment() Constructor

This default constructor starts with empty collections and a temporary name and uses that name as a local file path.

```csharp
public Experiment();
```
### Fields

<a name='HurPsyLib.Experiment.LocatorDict'></a>

## Experiment.LocatorDict Field

This `Dictionary` collection helps access `Locator` objects through their ids.

```csharp
private Dictionary<string,Locator> LocatorDict;
```

#### Field Value
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

<a name='HurPsyLib.Experiment.ResponseDict'></a>

## Experiment.ResponseDict Field

This `Dictionary` collection helps access `Response` objects through their ids.

```csharp
private Dictionary<string,Response> ResponseDict;
```

#### Field Value
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Response](HurPsyLib.Response.md 'HurPsyLib.Response')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

<a name='HurPsyLib.Experiment.StimulusDict'></a>

## Experiment.StimulusDict Field

This `Dictionary` collection helps access `Stimulus` objects through their ids.

```csharp
private Dictionary<string,Stimulus> StimulusDict;
```

#### Field Value
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')
### Properties

<a name='HurPsyLib.Experiment.Blocks'></a>

## Experiment.Blocks Property

The experiment's trial blocks

```csharp
public System.Collections.Generic.List<HurPsyLib.ExpBlock> Blocks { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[ExpBlock](HurPsyLib.ExpBlock.md 'HurPsyLib.ExpBlock')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyLib.Experiment.FilePath'></a>

## Experiment.FilePath Property

Full path of the file where the experiment definition is stored

```csharp
public string FilePath { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.Experiment.Name'></a>

## Experiment.Name Property

A name which will help a designer to remember this experiment.

```csharp
public string Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Methods

<a name='HurPsyLib.Experiment.AddBlock(HurPsyLib.ExpBlock)'></a>

## Experiment.AddBlock(ExpBlock) Method

Add a new block

```csharp
public void AddBlock(HurPsyLib.ExpBlock blck);
```
#### Parameters

<a name='HurPsyLib.Experiment.AddBlock(HurPsyLib.ExpBlock).blck'></a>

`blck` [ExpBlock](HurPsyLib.ExpBlock.md 'HurPsyLib.ExpBlock')

The block to be added

<a name='HurPsyLib.Experiment.AddLocator(HurPsyLib.Locator)'></a>

## Experiment.AddLocator(Locator) Method

This function attempts to add the given `Locator` object to the dictionary collection and reports on the outcome.

```csharp
public void AddLocator(HurPsyLib.Locator loc);
```
#### Parameters

<a name='HurPsyLib.Experiment.AddLocator(HurPsyLib.Locator).loc'></a>

`loc` [Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')

The object to be added

<a name='HurPsyLib.Experiment.AddStimulus(HurPsyLib.Stimulus)'></a>

## Experiment.AddStimulus(Stimulus) Method

This function attempts to add the given `Stimulus` object to the dictionary collection and reports on the outcome.

```csharp
public void AddStimulus(HurPsyLib.Stimulus stim);
```
#### Parameters

<a name='HurPsyLib.Experiment.AddStimulus(HurPsyLib.Stimulus).stim'></a>

`stim` [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')

The object to be added

<a name='HurPsyLib.Experiment.GetLocatorItem(string)'></a>

## Experiment.GetLocatorItem(string) Method

This inline function will help access a `Locator` object through its Id

```csharp
public HurPsyLib.Locator GetLocatorItem(string locId);
```
#### Parameters

<a name='HurPsyLib.Experiment.GetLocatorItem(string).locId'></a>

`locId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The Id string

#### Returns
[Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')  
The `Locator` object with that Id

<a name='HurPsyLib.Experiment.GetLocatorItems()'></a>

## Experiment.GetLocatorItems() Method

This inline function will return a list containing `Locator` definitions in the experiment

```csharp
public System.Collections.Generic.List<HurPsyLib.Locator> GetLocatorItems();
```

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyLib.Experiment.GetResponseItems()'></a>

## Experiment.GetResponseItems() Method

This inline function will return a list containing `Locator` definitions in the experiment

```csharp
public System.Collections.Generic.List<HurPsyLib.Response> GetResponseItems();
```

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Response](HurPsyLib.Response.md 'HurPsyLib.Response')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyLib.Experiment.GetStimulusItem(string)'></a>

## Experiment.GetStimulusItem(string) Method

This inline function will help access a `Stimulus` object through its Id

```csharp
public HurPsyLib.Stimulus GetStimulusItem(string stimId);
```
#### Parameters

<a name='HurPsyLib.Experiment.GetStimulusItem(string).stimId'></a>

`stimId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The Id string

#### Returns
[Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')  
The `Stimulus` object with that Id

<a name='HurPsyLib.Experiment.GetStimulusItems()'></a>

## Experiment.GetStimulusItems() Method

This inline function will return a list containing `Stimulus` definitions in the experiment

```csharp
public System.Collections.Generic.List<HurPsyLib.Stimulus> GetStimulusItems();
```

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyLib.Experiment.LocatorIdChanged(HurPsyLib.Locator,string)'></a>

## Experiment.LocatorIdChanged(Locator, string) Method

This function updates the Id of a `Locator` item, provided that the Id is not a duplicate.

```csharp
public bool LocatorIdChanged(HurPsyLib.Locator loc, string newid);
```
#### Parameters

<a name='HurPsyLib.Experiment.LocatorIdChanged(HurPsyLib.Locator,string).loc'></a>

`loc` [Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')

The object whose Id will be changed

<a name='HurPsyLib.Experiment.LocatorIdChanged(HurPsyLib.Locator,string).newid'></a>

`newid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The new Id

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyLib.Experiment.LocatorIdExists(string)'></a>

## Experiment.LocatorIdExists(string) Method

The inline function to check for duplicate locator Ids

```csharp
public bool LocatorIdExists(string newid);
```
#### Parameters

<a name='HurPsyLib.Experiment.LocatorIdExists(string).newid'></a>

`newid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Id to check

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyLib.Experiment.ResponseIdExists(string)'></a>

## Experiment.ResponseIdExists(string) Method

The inline function to check for duplicate `Response` Ids

```csharp
private bool ResponseIdExists(string newid);
```
#### Parameters

<a name='HurPsyLib.Experiment.ResponseIdExists(string).newid'></a>

`newid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Id to check

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyLib.Experiment.ShallowCopy()'></a>

## Experiment.ShallowCopy() Method

This method will help clone the experiment items onto `Session` objects.

```csharp
public HurPsyLib.Experiment ShallowCopy();
```

#### Returns
[Experiment](HurPsyLib.Experiment.md 'HurPsyLib.Experiment')

<a name='HurPsyLib.Experiment.StimulusIdChanged(HurPsyLib.Stimulus,string)'></a>

## Experiment.StimulusIdChanged(Stimulus, string) Method

This function updates the Id of a `Stimulus` item, provided that the Id is not a duplicate.

```csharp
public bool StimulusIdChanged(HurPsyLib.Stimulus stim, string newid);
```
#### Parameters

<a name='HurPsyLib.Experiment.StimulusIdChanged(HurPsyLib.Stimulus,string).stim'></a>

`stim` [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')

The object whose Id will be changed

<a name='HurPsyLib.Experiment.StimulusIdChanged(HurPsyLib.Stimulus,string).newid'></a>

`newid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The new id

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyLib.Experiment.StimulusIdExists(string)'></a>

## Experiment.StimulusIdExists(string) Method

The inline function to check for duplicate stimulus Ids

```csharp
private bool StimulusIdExists(string newid);
```
#### Parameters

<a name='HurPsyLib.Experiment.StimulusIdExists(string).newid'></a>

`newid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Id to check

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')