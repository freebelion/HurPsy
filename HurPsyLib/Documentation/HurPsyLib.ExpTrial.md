### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## ExpTrial Class

This class represents an experiment trial made up of one or more steps.

```csharp
public class ExpTrial
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ExpTrial
### Constructors

<a name='HurPsyLib.ExpTrial.ExpTrial()'></a>

## ExpTrial() Constructor

This default constructor starts with the defaults.

```csharp
public ExpTrial();
```
### Properties

<a name='HurPsyLib.ExpTrial.IsFixed'></a>

## ExpTrial.IsFixed Property

The boolean indicator specifying if this trial will be shuffled within the block

```csharp
public bool IsFixed { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyLib.ExpTrial.Steps'></a>

## ExpTrial.Steps Property

The collection of experiment steps that make up this trial

```csharp
public System.Collections.Generic.List<HurPsyLib.ExpStep> Steps { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[ExpStep](HurPsyLib.ExpStep.md 'HurPsyLib.ExpStep')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
### Methods

<a name='HurPsyLib.ExpTrial.AddStep(HurPsyLib.ExpStep)'></a>

## ExpTrial.AddStep(ExpStep) Method

This method adds an existing step or creates and adds a new one.

```csharp
public void AddStep(HurPsyLib.ExpStep st);
```
#### Parameters

<a name='HurPsyLib.ExpTrial.AddStep(HurPsyLib.ExpStep).st'></a>

`st` [ExpStep](HurPsyLib.ExpStep.md 'HurPsyLib.ExpStep')

The step to be added

<a name='HurPsyLib.ExpTrial.ChangeLocatorId(string,string)'></a>

## ExpTrial.ChangeLocatorId(string, string) Method

This method delegates the changing of a `Locator` Id to the steps making up this trial.

```csharp
public void ChangeLocatorId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyLib.ExpTrial.ChangeLocatorId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.ExpTrial.ChangeLocatorId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.ExpTrial.ChangeStimulusId(string,string)'></a>

## ExpTrial.ChangeStimulusId(string, string) Method

This method delegates the changing of a `Stimulus` Id to the steps making up this trial.

```csharp
public void ChangeStimulusId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyLib.ExpTrial.ChangeStimulusId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.ExpTrial.ChangeStimulusId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.ExpTrial.RemoveLocatorId(string)'></a>

## ExpTrial.RemoveLocatorId(string) Method

This method delegates the removal of a `Locator` Id to the steps making up this trial.

```csharp
public void RemoveLocatorId(string locid);
```
#### Parameters

<a name='HurPsyLib.ExpTrial.RemoveLocatorId(string).locid'></a>

`locid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.ExpTrial.RemoveStimulusId(string)'></a>

## ExpTrial.RemoveStimulusId(string) Method

This method delegates the removal of a `Stimulus` Id to the steps making up this trial.

```csharp
public void RemoveStimulusId(string stimid);
```
#### Parameters

<a name='HurPsyLib.ExpTrial.RemoveStimulusId(string).stimid'></a>

`stimid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')