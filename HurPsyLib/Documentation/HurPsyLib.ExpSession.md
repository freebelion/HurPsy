### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## ExpSession Class

This class represents an experiment session with simple UserId and RunTime info, along with the actual order of blocks, trials and steps.

```csharp
public class ExpSession
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ExpSession
### Constructors

<a name='HurPsyLib.ExpSession.ExpSession(HurPsyLib.Experiment)'></a>

## ExpSession(Experiment) Constructor

This parametrized constructor starts with an empty or an existing experiment.

```csharp
public ExpSession(HurPsyLib.Experiment? exp);
```
#### Parameters

<a name='HurPsyLib.ExpSession.ExpSession(HurPsyLib.Experiment).exp'></a>

`exp` [Experiment](HurPsyLib.Experiment.md 'HurPsyLib.Experiment')
### Properties

<a name='HurPsyLib.ExpSession.CurrentStep'></a>

## ExpSession.CurrentStep Property

This `Session` object will keep track of the current step for the `RunViewModel`.

```csharp
public HurPsyLib.ExpStep CurrentStep { get; }
```

#### Property Value
[ExpStep](HurPsyLib.ExpStep.md 'HurPsyLib.ExpStep')

<a name='HurPsyLib.ExpSession.ExperimentFilePath'></a>

## ExpSession.ExperimentFilePath Property

A shorthand access to the source experiment's file path

```csharp
public string ExperimentFilePath { get; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Methods

<a name='HurPsyLib.ExpSession.GetLocatorItem(string)'></a>

## ExpSession.GetLocatorItem(string) Method

This inline function will help access a `Locator` object through its Id

```csharp
public HurPsyLib.Locator GetLocatorItem(string locId);
```
#### Parameters

<a name='HurPsyLib.ExpSession.GetLocatorItem(string).locId'></a>

`locId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The Id string

#### Returns
[Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')  
The `Locator` object with that Id

<a name='HurPsyLib.ExpSession.GetLocatorItems()'></a>

## ExpSession.GetLocatorItems() Method

This inline function will return a list containing `Locator` definitions in the experiment

```csharp
public System.Collections.Generic.List<HurPsyLib.Locator> GetLocatorItems();
```

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyLib.ExpSession.GetStimulusItem(string)'></a>

## ExpSession.GetStimulusItem(string) Method

This inline function will help access a `Stimulus` object through its Id

```csharp
public HurPsyLib.Stimulus GetStimulusItem(string stimId);
```
#### Parameters

<a name='HurPsyLib.ExpSession.GetStimulusItem(string).stimId'></a>

`stimId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The Id string

#### Returns
[Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')  
The `Stimulus` object with that Id

<a name='HurPsyLib.ExpSession.GetStimulusItems()'></a>

## ExpSession.GetStimulusItems() Method

This inline function will return a list containing `Stimulus` definitions in the experiment

```csharp
public System.Collections.Generic.List<HurPsyLib.Stimulus> GetStimulusItems();
```

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyLib.ExpSession.InitializeSession()'></a>

## ExpSession.InitializeSession() Method

This method handles the initial setup: it clones the collections of the source experiment and reorders them as needed.  
This may consist of shuffling the unfixed trials; further reordering must be done by the user on the application that runs the session.

```csharp
private void InitializeSession();
```

<a name='HurPsyLib.ExpSession.NextStep()'></a>

## ExpSession.NextStep() Method

This function progresses through the experiment session.

```csharp
public bool NextStep();
```

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyLib.ExpSession.ShuffleTrials(System.Collections.Generic.List_HurPsyLib.ExpTrial_)'></a>

## ExpSession.ShuffleTrials(List<ExpTrial>) Method

This method shuffles a collection of `Trials` to be used in experiment runs.

```csharp
private static void ShuffleTrials(System.Collections.Generic.List<HurPsyLib.ExpTrial> tempTrials);
```
#### Parameters

<a name='HurPsyLib.ExpSession.ShuffleTrials(System.Collections.Generic.List_HurPsyLib.ExpTrial_).tempTrials'></a>

`tempTrials` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[ExpTrial](HurPsyLib.ExpTrial.md 'HurPsyLib.ExpTrial')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyLib.ExpSession.StartSession()'></a>

## ExpSession.StartSession() Method

Initial arragements for starting an experiment run

```csharp
public void StartSession();
```