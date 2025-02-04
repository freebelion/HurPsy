### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## Step Class

This class represents a step in an experimental trial.  
It contains information on which stimuli will be presented together, at which locations and for how long.

```csharp
public class Step
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Step
### Constructors

<a name='HurPsyLib.Step.Step()'></a>

## Step() Constructor

This default constructor starts with an empty list of `Stimulus`-`Locator` pairs and zero display time.

```csharp
public Step();
```
### Properties

<a name='HurPsyLib.Step.StepTime'></a>

## Step.StepTime Property

The display time period for this step

```csharp
public HurPsyLib.HurPsyTimePeriod StepTime { get; set; }
```

#### Property Value
[HurPsyTimePeriod](HurPsyLib.HurPsyTimePeriod.md 'HurPsyLib.HurPsyTimePeriod')

<a name='HurPsyLib.Step.StimulusLocators'></a>

## Step.StimulusLocators Property

The list of `StimulusLocatorPair` objects associating `Stimulus` objects with `Locator` objects which will determine their positions.

```csharp
public System.Collections.Generic.List<HurPsyLib.StimulusLocatorPair> StimulusLocators { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[StimulusLocatorPair](HurPsyLib.StimulusLocatorPair.md 'HurPsyLib.StimulusLocatorPair')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
### Methods

<a name='HurPsyLib.Step.AddStimulusLocatorPair(HurPsyLib.StimulusLocatorPair)'></a>

## Step.AddStimulusLocatorPair(StimulusLocatorPair) Method

This function adds a given or new `Stimulus`-`Locator` pair to the pairs list and returns its reference.

```csharp
public HurPsyLib.StimulusLocatorPair AddStimulusLocatorPair(HurPsyLib.StimulusLocatorPair? newpair=null);
```
#### Parameters

<a name='HurPsyLib.Step.AddStimulusLocatorPair(HurPsyLib.StimulusLocatorPair).newpair'></a>

`newpair` [StimulusLocatorPair](HurPsyLib.StimulusLocatorPair.md 'HurPsyLib.StimulusLocatorPair')

The `StimulusLocatorPair` object which will be added to list (by default, it will be null, if an empty one should be created)

#### Returns
[StimulusLocatorPair](HurPsyLib.StimulusLocatorPair.md 'HurPsyLib.StimulusLocatorPair')  
The reference to the newly added `StimulusLocatorPair` object

<a name='HurPsyLib.Step.AddStimulusLocatorPairs(HurPsyLib.StimulusLocatorPair[])'></a>

## Step.AddStimulusLocatorPairs(StimulusLocatorPair[]) Method

This method adds a collection of `StimulusLocatorPair` objects

```csharp
public void AddStimulusLocatorPairs(HurPsyLib.StimulusLocatorPair[] newpairs);
```
#### Parameters

<a name='HurPsyLib.Step.AddStimulusLocatorPairs(HurPsyLib.StimulusLocatorPair[]).newpairs'></a>

`newpairs` [StimulusLocatorPair](HurPsyLib.StimulusLocatorPair.md 'HurPsyLib.StimulusLocatorPair')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The array of `StimulusLocatorPair` objects which will be added

<a name='HurPsyLib.Step.ChangeLocatorId(string,string)'></a>

## Step.ChangeLocatorId(string, string) Method

This method updates a `Locator` id in the pairs making up this step.

```csharp
public void ChangeLocatorId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyLib.Step.ChangeLocatorId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The old id

<a name='HurPsyLib.Step.ChangeLocatorId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The new id

<a name='HurPsyLib.Step.ChangeStimulusId(string,string)'></a>

## Step.ChangeStimulusId(string, string) Method

This method updates a `Stimulus` id in the pairs making up this step.

```csharp
public void ChangeStimulusId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyLib.Step.ChangeStimulusId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The old id

<a name='HurPsyLib.Step.ChangeStimulusId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The new id

<a name='HurPsyLib.Step.RemoveLocatorId(string)'></a>

## Step.RemoveLocatorId(string) Method

This method removes the pairs containing a deleted `Locator` id

```csharp
public void RemoveLocatorId(string removedId);
```
#### Parameters

<a name='HurPsyLib.Step.RemoveLocatorId(string).removedId'></a>

`removedId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The id of the deleted `Locator` object

<a name='HurPsyLib.Step.RemoveStimulusId(string)'></a>

## Step.RemoveStimulusId(string) Method

This method removes the pairs containing a deleted `Stimulus` id.

```csharp
public void RemoveStimulusId(string removedId);
```
#### Parameters

<a name='HurPsyLib.Step.RemoveStimulusId(string).removedId'></a>

`removedId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The id of the deleted `Stimulus` object