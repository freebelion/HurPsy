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

The default class constructor which starts with an empty filename and empty lists.

```csharp
public Experiment();
```
### Fields

<a name='HurPsyLib.Experiment.locatorDict'></a>

## Experiment.locatorDict Field

The Dictionary collection which helps access Locator objects through their ids.

```csharp
private Dictionary<string,Locator> locatorDict;
```

#### Field Value
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[HurPsyLib.Locator](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Locator 'HurPsyLib.Locator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')

<a name='HurPsyLib.Experiment.stimulusDict'></a>

## Experiment.stimulusDict Field

The Dictionary collection which helps access Stimulus objects through their ids.

```csharp
private Dictionary<string,Stimulus> stimulusDict;
```

#### Field Value
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[HurPsyLib.Stimulus](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Stimulus 'HurPsyLib.Stimulus')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')
### Properties

<a name='HurPsyLib.Experiment.Blocks'></a>

## Experiment.Blocks Property

The list of Block objects which represent the trial blocks that make up the experiment.

```csharp
public System.Collections.Generic.List<HurPsyLib.Block> Blocks { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[HurPsyLib.Block](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Block 'HurPsyLib.Block')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

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
[HurPsyLib.HurPsyOrigin](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.HurPsyOrigin 'HurPsyLib.HurPsyOrigin')
### Methods

<a name='HurPsyLib.Experiment.AddLocator(HurPsyLib.Locator)'></a>

## Experiment.AddLocator(Locator) Method

The method which adds a Locator object to the Dictionary collection associating Locator objects with their ids.

```csharp
public bool AddLocator(HurPsyLib.Locator loc);
```
#### Parameters

<a name='HurPsyLib.Experiment.AddLocator(HurPsyLib.Locator).loc'></a>

`loc` [HurPsyLib.Locator](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Locator 'HurPsyLib.Locator')

Locator object which will be added to the Dictionary collection.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A boolean flag indicating whether the operation was successful

<a name='HurPsyLib.Experiment.AddStimulus(HurPsyLib.Stimulus)'></a>

## Experiment.AddStimulus(Stimulus) Method

The method which adds a Stimulus object to the Dictionary collection associating Stimulus objects with their ids.

```csharp
public bool AddStimulus(HurPsyLib.Stimulus stim);
```
#### Parameters

<a name='HurPsyLib.Experiment.AddStimulus(HurPsyLib.Stimulus).stim'></a>

`stim` [HurPsyLib.Stimulus](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Stimulus 'HurPsyLib.Stimulus')

Stimulus object which will be added to the Dictionary collection.

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A boolean flag indicating whether the operation was successful

<a name='HurPsyLib.Experiment.GetStimuli()'></a>

## Experiment.GetStimuli() Method

The method which constructs a new generic list of Stimulus objects.

```csharp
public System.Collections.Generic.List<HurPsyLib.Stimulus> GetStimuli();
```

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[HurPsyLib.Stimulus](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Stimulus 'HurPsyLib.Stimulus')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')  
The generic list of Stimulus objects

<a name='HurPsyLib.Experiment.GetStimulus(string)'></a>

## Experiment.GetStimulus(string) Method

The method which helps access a Stimulus object through its id.

```csharp
public HurPsyLib.Stimulus GetStimulus(string stimId);
```
#### Parameters

<a name='HurPsyLib.Experiment.GetStimulus(string).stimId'></a>

`stimId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The id of the Stimulus object which will be accessed.

#### Returns
[HurPsyLib.Stimulus](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Stimulus 'HurPsyLib.Stimulus')

<a name='HurPsyLib.Experiment.RemoveStimulus(HurPsyLib.Stimulus)'></a>

## Experiment.RemoveStimulus(Stimulus) Method

The method which removes the Stimulus object with the given id from the Dictionary collection.

```csharp
public void RemoveStimulus(HurPsyLib.Stimulus stim);
```
#### Parameters

<a name='HurPsyLib.Experiment.RemoveStimulus(HurPsyLib.Stimulus).stim'></a>

`stim` [HurPsyLib.Stimulus](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Stimulus 'HurPsyLib.Stimulus')

The Stimulus object to be removed

<a name='HurPsyLib.Experiment.ReplaceStimulusId(string,string)'></a>

## Experiment.ReplaceStimulusId(string, string) Method

The method which updates the id of a Stimulus object in the Dictionary collection.  
This method must be called when an end-user gives a Stimulus object a new id through an experimental design program.  
Otherwise, the Dictionary collection associating Stimulus objects with their ids will be out of date.

```csharp
public void ReplaceStimulusId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyLib.Experiment.ReplaceStimulusId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Previous id of the Stimulus object

<a name='HurPsyLib.Experiment.ReplaceStimulusId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

New if od the Stimulus object

<a name='HurPsyLib.Experiment.StimulusIdExists(string)'></a>

## Experiment.StimulusIdExists(string) Method

The boolean function to check whether a Stimulus with the given id already exists in the Dictionary collection.

```csharp
public bool StimulusIdExists(string stimId);
```
#### Parameters

<a name='HurPsyLib.Experiment.StimulusIdExists(string).stimId'></a>

`stimId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The Stimulus id which will be checked

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
A boolean flag indicating the presence of the given id