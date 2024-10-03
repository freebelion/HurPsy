### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## Experiment Class

The class which represents the complete definition of a computerized psychology experiment.

```csharp
public class Experiment
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Experiment
### Constructors

<a name='HurPsyLib.Experiment.Experiment()'></a>

## Experiment() Constructor

This default constructor which starts with an empty filename and empty lists.

```csharp
public Experiment();
```
### Fields

<a name='HurPsyLib.Experiment.locatorDict'></a>

## Experiment.locatorDict Field

The Dictionary collection which helps access `Locator` objects through their ids.

```csharp
private Dictionary<string,Locator> locatorDict;
```

#### Field Value
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

<a name='HurPsyLib.Experiment.stimulusDict'></a>

## Experiment.stimulusDict Field

The Dictionary collection which helps access `Stimulus` objects through their ids.

```csharp
private Dictionary<string,Stimulus> stimulusDict;
```

#### Field Value
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')
### Properties

<a name='HurPsyLib.Experiment.Blocks'></a>

## Experiment.Blocks Property

The list of `Block` objects which represent the trial blocks that make up the experiment.

```csharp
public System.Collections.Generic.List<HurPsyLib.Block> Blocks { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Block](HurPsyLib.Block.md 'HurPsyLib.Block')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyLib.Experiment.FileName'></a>

## Experiment.FileName Property

The property which helps get/set the name of the file where the experiment definition will be saved.

```csharp
public string FileName { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.Experiment.Origin'></a>

## Experiment.Origin Property

The property which helps get/set the origin choice for the experiment.

```csharp
public HurPsyLib.HurPsyOrigin Origin { get; set; }
```

#### Property Value
[HurPsyOrigin](HurPsyLib.HurPsyOrigin.md 'HurPsyLib.HurPsyOrigin')
### Methods

<a name='HurPsyLib.Experiment.AddLocator(HurPsyLib.Locator)'></a>

## Experiment.AddLocator(Locator) Method

The function which adds a `Locator` object to `locatorDict` collection and reports on the result

```csharp
public bool AddLocator(HurPsyLib.Locator loc);
```
#### Parameters

<a name='HurPsyLib.Experiment.AddLocator(HurPsyLib.Locator).loc'></a>

`loc` [Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')

The `Locator` object which will be added to the collection.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A boolean flag indicating if the operation was successful

<a name='HurPsyLib.Experiment.AddNewBlock()'></a>

## Experiment.AddNewBlock() Method

The function which adds a newly created trial block to `Blocks` collection and returns a reference to it

```csharp
public HurPsyLib.Block AddNewBlock();
```

#### Returns
[Block](HurPsyLib.Block.md 'HurPsyLib.Block')  
A reference to the newly added `Block` object

<a name='HurPsyLib.Experiment.AddStimulus(HurPsyLib.Stimulus)'></a>

## Experiment.AddStimulus(Stimulus) Method

The function which adds a `Stimulus` object to `stimulusDict` collection and returns on the result

```csharp
public bool AddStimulus(HurPsyLib.Stimulus stim);
```
#### Parameters

<a name='HurPsyLib.Experiment.AddStimulus(HurPsyLib.Stimulus).stim'></a>

`stim` [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')

The `Stimulus` object which will be added

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A boolean flag indicating if the operation was successful

<a name='HurPsyLib.Experiment.GetLocator(string)'></a>

## Experiment.GetLocator(string) Method

The function which returns the `Locator` object with the given id

```csharp
public HurPsyLib.Locator GetLocator(string locId);
```
#### Parameters

<a name='HurPsyLib.Experiment.GetLocator(string).locId'></a>

`locId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The id of the `Locator` object which will be accessed

#### Returns
[Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')  
The `Locator` object with the given id

#### Exceptions

[HurPsyException](HurPsyLib.HurPsyException.md 'HurPsyLib.HurPsyException')  
An exception will be thrown if a `Locator` object with the given id cannot be found.

<a name='HurPsyLib.Experiment.GetLocators()'></a>

## Experiment.GetLocators() Method

The function which returns a new generic list of `Locator` objects.

```csharp
public System.Collections.Generic.List<HurPsyLib.Locator> GetLocators();
```

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
A generic list of all the `Locator` objects in the experiment definition

<a name='HurPsyLib.Experiment.GetStimuli()'></a>

## Experiment.GetStimuli() Method

The function which returns a new generic list of `Stimulus` objects.

```csharp
public System.Collections.Generic.List<HurPsyLib.Stimulus> GetStimuli();
```

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
A generic list of all the `Stimulus` objects in the experiment definition

<a name='HurPsyLib.Experiment.GetStimulus(string)'></a>

## Experiment.GetStimulus(string) Method

The function which returns the `Stimulus` object with the given id

```csharp
public HurPsyLib.Stimulus GetStimulus(string stimId);
```
#### Parameters

<a name='HurPsyLib.Experiment.GetStimulus(string).stimId'></a>

`stimId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The id of the `Stimulus` object which will be accessed

#### Returns
[Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')  
The `Stimulus` object with the given id

#### Exceptions

[HurPsyException](HurPsyLib.HurPsyException.md 'HurPsyLib.HurPsyException')  
An exception will be thrown if a `Stimulus` object with the given id cannot be found.

<a name='HurPsyLib.Experiment.LoadFromXml(string)'></a>

## Experiment.LoadFromXml(string) Method

The function which loads an experiment definition from an XML file by using a `DataContractSerializer`

```csharp
public static HurPsyLib.Experiment LoadFromXml(string fileName);
```
#### Parameters

<a name='HurPsyLib.Experiment.LoadFromXml(string).fileName'></a>

`fileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the XML file

#### Returns
[Experiment](HurPsyLib.Experiment.md 'HurPsyLib.Experiment')  
The `Experiment` object which contains the experiment definition loaded from the file

#### Exceptions

[HurPsyException](HurPsyLib.HurPsyException.md 'HurPsyLib.HurPsyException')  
An exception will be thrown if a valid definition of an experiment could not be loaded from the file.

<a name='HurPsyLib.Experiment.LocatorIdExists(string)'></a>

## Experiment.LocatorIdExists(string) Method

The boolean function which checks whether a `Locator` id exists in `locatorDict` collection.

```csharp
public bool LocatorIdExists(string locId);
```
#### Parameters

<a name='HurPsyLib.Experiment.LocatorIdExists(string).locId'></a>

`locId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A boolean flag indicating the presence of the given id

<a name='HurPsyLib.Experiment.RemoveBlock(HurPsyLib.Block)'></a>

## Experiment.RemoveBlock(Block) Method

The method which removes a `Block` objects from `Blocks` collection.

```csharp
public void RemoveBlock(HurPsyLib.Block blck);
```
#### Parameters

<a name='HurPsyLib.Experiment.RemoveBlock(HurPsyLib.Block).blck'></a>

`blck` [Block](HurPsyLib.Block.md 'HurPsyLib.Block')

The `Block` object which will be removed

<a name='HurPsyLib.Experiment.RemoveLocator(string)'></a>

## Experiment.RemoveLocator(string) Method

The method which removes the `Locator` object with the given id from `locatorDict` collection.

```csharp
public void RemoveLocator(string locId);
```
#### Parameters

<a name='HurPsyLib.Experiment.RemoveLocator(string).locId'></a>

`locId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The id of the `Locator` object which will be removed

<a name='HurPsyLib.Experiment.RemoveStimulus(string)'></a>

## Experiment.RemoveStimulus(string) Method

The method which removes the `Stimulus` object with the given id from `stimulusDict` collection.

```csharp
public void RemoveStimulus(string stimId);
```
#### Parameters

<a name='HurPsyLib.Experiment.RemoveStimulus(string).stimId'></a>

`stimId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The id of the`Stimulus` object which will be removed

<a name='HurPsyLib.Experiment.ReplaceLocatorId(string,string)'></a>

## Experiment.ReplaceLocatorId(string, string) Method

The method which updates the id of a `Locator` object in `locatorDict` collection.  
This method must be called when an end-user gives a `Locator` object a new id through an experimental design program.  
Otherwise, `locatorDict` collection will be out of date.

```csharp
public void ReplaceLocatorId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyLib.Experiment.ReplaceLocatorId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Previous id of the `Locator` object

<a name='HurPsyLib.Experiment.ReplaceLocatorId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

New id of the `Locator` object

<a name='HurPsyLib.Experiment.ReplaceStimulusId(string,string)'></a>

## Experiment.ReplaceStimulusId(string, string) Method

The method which updates the id of a `Stimulus` object in `stimulusDict` collection.  
This method must be called when an end-user gives a `Stimulus` object a new id through an experiment design program.  
Otherwise, `stimulusDict` collection will be out of date.

```csharp
public void ReplaceStimulusId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyLib.Experiment.ReplaceStimulusId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Previous id of the `Stimulus` object

<a name='HurPsyLib.Experiment.ReplaceStimulusId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

New id of the `Stimulus` object

<a name='HurPsyLib.Experiment.SaveToXml(string)'></a>

## Experiment.SaveToXml(string) Method

The method which saves the experiment definition to an XML file using a `DataContractSerializer`

```csharp
public void SaveToXml(string fileName);
```
#### Parameters

<a name='HurPsyLib.Experiment.SaveToXml(string).fileName'></a>

`fileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the XML file

<a name='HurPsyLib.Experiment.StimulusIdExists(string)'></a>

## Experiment.StimulusIdExists(string) Method

The boolean function which checks if a `Stimulus` id exists in `stimulusDict` collection.

```csharp
public bool StimulusIdExists(string stimId);
```
#### Parameters

<a name='HurPsyLib.Experiment.StimulusIdExists(string).stimId'></a>

`stimId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `Stimulus` id which will be checked

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A boolean flag indicating the presence of the given id