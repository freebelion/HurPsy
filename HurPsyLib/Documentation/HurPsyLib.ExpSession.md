### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## ExpSession Class

This class represents an experiment session with simple UserId and RunTime info, along with the actual order of blocks, trials and steps.

```csharp
public class ExpSession : HurPsyLib.Experiment
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [Experiment](HurPsyLib.Experiment.md 'HurPsyLib.Experiment') &#129106; ExpSession
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
### Methods

<a name='HurPsyLib.ExpSession.InitializeSession(HurPsyLib.Experiment)'></a>

## ExpSession.InitializeSession(Experiment) Method

This method handles the initial setup: it clones the collections of the source experiment and reorders them as needed.  
This may consist of shuffling the unfixed trials; further reordering must be done by the user on the application that runs the session.

```csharp
private void InitializeSession(HurPsyLib.Experiment exp);
```
#### Parameters

<a name='HurPsyLib.ExpSession.InitializeSession(HurPsyLib.Experiment).exp'></a>

`exp` [Experiment](HurPsyLib.Experiment.md 'HurPsyLib.Experiment')

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