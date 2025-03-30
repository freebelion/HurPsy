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

This default constructor starts with empty collections and assigns the default values to other properties.

```csharp
public Experiment();
```
### Fields

<a name='HurPsyLib.Experiment.filename'></a>

## Experiment.filename Field

Full path of the file where the experiment definition is stored

```csharp
private string filename;
```

#### Field Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.Experiment.LocatorDict'></a>

## Experiment.LocatorDict Field

This `Dictionary` collection helps access `Locator` objects through their ids.

```csharp
private Dictionary<string,Locator> LocatorDict;
```

#### Field Value
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

<a name='HurPsyLib.Experiment.StimulusDict'></a>

## Experiment.StimulusDict Field

This `Dictionary` collection helps access `Stimulus` objects through their ids.

```csharp
private Dictionary<string,Stimulus> StimulusDict;
```

#### Field Value
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')
### Methods

<a name='HurPsyLib.Experiment.AddLocator(HurPsyLib.Locator)'></a>

## Experiment.AddLocator(Locator) Method

This function attempts to add the given `Locator` object to the dictionary collection and reports on the outcome.

```csharp
public bool AddLocator(HurPsyLib.Locator loc);
```
#### Parameters

<a name='HurPsyLib.Experiment.AddLocator(HurPsyLib.Locator).loc'></a>

`loc` [Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')

The object to be added

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The success of the operation

<a name='HurPsyLib.Experiment.AddStimulus(HurPsyLib.Stimulus)'></a>

## Experiment.AddStimulus(Stimulus) Method

This function attempts to add the given `Stimulus` object to the dictionary collection and reports on the outcome.

```csharp
public bool AddStimulus(HurPsyLib.Stimulus stim);
```
#### Parameters

<a name='HurPsyLib.Experiment.AddStimulus(HurPsyLib.Stimulus).stim'></a>

`stim` [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')

The object to be added

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The success of the operation

<a name='HurPsyLib.Experiment.FileExists()'></a>

## Experiment.FileExists() Method

A function thyat verifies the validity of file where this experiment definition is stored

```csharp
public bool FileExists();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
Validity status of the file

<a name='HurPsyLib.Experiment.GetLocatorItems()'></a>

## Experiment.GetLocatorItems() Method

This inline function will return a list containing `Locator` definitions in the experiment

```csharp
public System.Collections.Generic.List<HurPsyLib.Locator> GetLocatorItems();
```

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyLib.Experiment.GetStimulusItems()'></a>

## Experiment.GetStimulusItems() Method

This inline function will return a list containing `Stimulus` definitions in the experiment

```csharp
public System.Collections.Generic.List<HurPsyLib.Stimulus> GetStimulusItems();
```

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyLib.Experiment.LoadFromXml(string)'></a>

## Experiment.LoadFromXml(string) Method

This static method loads an experiment definition from an XML file and returns its reference.

```csharp
public static HurPsyLib.Experiment LoadFromXml(string openfilename);
```
#### Parameters

<a name='HurPsyLib.Experiment.LoadFromXml(string).openfilename'></a>

`openfilename` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The full path of the XML file containing the experiment definition

#### Returns
[Experiment](HurPsyLib.Experiment.md 'HurPsyLib.Experiment')  
The reference of the `Experiment` object with the loaded content.

#### Exceptions

[HurPsyException](HurPsyLib.HurPsyException.md 'HurPsyLib.HurPsyException')

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

<a name='HurPsyLib.Experiment.SaveToXml(string)'></a>

## Experiment.SaveToXml(string) Method

This method saves the experiment definition onto an XML file.

```csharp
public void SaveToXml(string? savefilename=null);
```
#### Parameters

<a name='HurPsyLib.Experiment.SaveToXml(string).savefilename'></a>

`savefilename` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The full file path (if none given, the existing filename will be used)

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