### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## ExpStep Class

This class represents a trial step of an experiment,  
a step being a collection of stimuli presented together, for a specified period of time.

```csharp
public class ExpStep
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ExpStep
### Constructors

<a name='HurPsyLib.ExpStep.ExpStep()'></a>

## ExpStep() Constructor

This default constructor starts with the defaults.

```csharp
public ExpStep();
```
### Properties

<a name='HurPsyLib.ExpStep.StepPairs'></a>

## ExpStep.StepPairs Property

The Id pairs making up this step

```csharp
public System.Collections.Generic.List<HurPsyLib.ExpPair> StepPairs { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[ExpPair](HurPsyLib.ExpPair.md 'HurPsyLib.ExpPair')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyLib.ExpStep.StepTime'></a>

## ExpStep.StepTime Property

The time period of presentation

```csharp
public HurPsyLib.HurPsyTimePeriod StepTime { get; set; }
```

#### Property Value
[HurPsyTimePeriod](HurPsyLib.HurPsyTimePeriod.md 'HurPsyLib.HurPsyTimePeriod')
### Methods

<a name='HurPsyLib.ExpStep.AddPair(string,string)'></a>

## ExpStep.AddPair(string, string) Method

This method adds a new `Stimulus`-`Locator` pair.

```csharp
public void AddPair(string stimId, string locId);
```
#### Parameters

<a name='HurPsyLib.ExpStep.AddPair(string,string).stimId'></a>

`stimId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

`Stimulus` Id

<a name='HurPsyLib.ExpStep.AddPair(string,string).locId'></a>

`locId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

`Locator` Id

<a name='HurPsyLib.ExpStep.AddPairs(HurPsyLib.ExpPair[])'></a>

## ExpStep.AddPairs(ExpPair[]) Method

This method adds an array of pairs.

```csharp
public void AddPairs(HurPsyLib.ExpPair[] pairs);
```
#### Parameters

<a name='HurPsyLib.ExpStep.AddPairs(HurPsyLib.ExpPair[]).pairs'></a>

`pairs` [ExpPair](HurPsyLib.ExpPair.md 'HurPsyLib.ExpPair')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The array of previously formed pairs

<a name='HurPsyLib.ExpStep.ChangeLocatorId(string,string)'></a>

## ExpStep.ChangeLocatorId(string, string) Method

Replace an old `Locator` Id with a new one.

```csharp
public void ChangeLocatorId(string oldId, string newid);
```
#### Parameters

<a name='HurPsyLib.ExpStep.ChangeLocatorId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

old Id string

<a name='HurPsyLib.ExpStep.ChangeLocatorId(string,string).newid'></a>

`newid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

new Id string

<a name='HurPsyLib.ExpStep.ChangeStimulusId(string,string)'></a>

## ExpStep.ChangeStimulusId(string, string) Method

Replace an old `Stimulus` Id with a new one.

```csharp
public void ChangeStimulusId(string oldId, string newid);
```
#### Parameters

<a name='HurPsyLib.ExpStep.ChangeStimulusId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

old Id string

<a name='HurPsyLib.ExpStep.ChangeStimulusId(string,string).newid'></a>

`newid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

new Id string

<a name='HurPsyLib.ExpStep.RemoveLocatorId(string)'></a>

## ExpStep.RemoveLocatorId(string) Method

This method removes all pairs with the given `Locator` Id

```csharp
public void RemoveLocatorId(string locid);
```
#### Parameters

<a name='HurPsyLib.ExpStep.RemoveLocatorId(string).locid'></a>

`locid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.ExpStep.RemoveStimulusId(string)'></a>

## ExpStep.RemoveStimulusId(string) Method

This method removes all pairs with the given `Stimulus` Id

```csharp
public void RemoveStimulusId(string stimid);
```
#### Parameters

<a name='HurPsyLib.ExpStep.RemoveStimulusId(string).stimid'></a>

`stimid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')