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

<a name='HurPsyLib.Experiment.StimulusDict'></a>

## Experiment.StimulusDict Field

This `Dictionary` collection helps access `Stimulus` objects through their ids.

```csharp
private Dictionary<string,Stimulus> StimulusDict;
```

#### Field Value
[System.Collections.Generic.Dictionary&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[,](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')[Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.Dictionary-2 'System.Collections.Generic.Dictionary`2')
### Methods

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

<a name='HurPsyLib.Experiment.StimulusIdExists(string)'></a>

## Experiment.StimulusIdExists(string) Method

This function checks whether a certain stimulus Id already exists in the dictionary collection

```csharp
public bool StimulusIdExists(string stimId);
```
#### Parameters

<a name='HurPsyLib.Experiment.StimulusIdExists(string).stimId'></a>

`stimId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')