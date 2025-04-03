### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## ExpBlock Class

This class represents a block of experiment trials.

```csharp
public class ExpBlock : HurPsyLib.IdObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [IdObject](HurPsyLib.IdObject.md 'HurPsyLib.IdObject') &#129106; ExpBlock
### Constructors

<a name='HurPsyLib.ExpBlock.ExpBlock()'></a>

## ExpBlock() Constructor

This default constructor starts with the defaults

```csharp
public ExpBlock();
```
### Properties

<a name='HurPsyLib.ExpBlock.MustShuffleTrials'></a>

## ExpBlock.MustShuffleTrials Property

The boolean indicator for having the trials shuffle at each run of the experiment

```csharp
public bool MustShuffleTrials { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyLib.ExpBlock.Trials'></a>

## ExpBlock.Trials Property

The list of trials making up this block

```csharp
public System.Collections.Generic.List<HurPsyLib.ExpTrial> Trials { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[ExpTrial](HurPsyLib.ExpTrial.md 'HurPsyLib.ExpTrial')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
### Methods

<a name='HurPsyLib.ExpBlock.AddTrial(HurPsyLib.ExpTrial)'></a>

## ExpBlock.AddTrial(ExpTrial) Method

Add a trial to the block

```csharp
public void AddTrial(HurPsyLib.ExpTrial tr);
```
#### Parameters

<a name='HurPsyLib.ExpBlock.AddTrial(HurPsyLib.ExpTrial).tr'></a>

`tr` [ExpTrial](HurPsyLib.ExpTrial.md 'HurPsyLib.ExpTrial')

The trial to be added

<a name='HurPsyLib.ExpBlock.ChangeLocatorId(string,string)'></a>

## ExpBlock.ChangeLocatorId(string, string) Method

This method delegates the changing of a `Locator` Id to the trials making up this block.

```csharp
public void ChangeLocatorId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyLib.ExpBlock.ChangeLocatorId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.ExpBlock.ChangeLocatorId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.ExpBlock.ChangeStimulusId(string,string)'></a>

## ExpBlock.ChangeStimulusId(string, string) Method

This method delegates the changing of a `Stimulus` Id to the trials making up this block.

```csharp
public void ChangeStimulusId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyLib.ExpBlock.ChangeStimulusId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.ExpBlock.ChangeStimulusId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.ExpBlock.RemoveLocatorId(string)'></a>

## ExpBlock.RemoveLocatorId(string) Method

This method delegates the removal of a `Locator` Id to the trials making up this block.

```csharp
public void RemoveLocatorId(string locid);
```
#### Parameters

<a name='HurPsyLib.ExpBlock.RemoveLocatorId(string).locid'></a>

`locid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.ExpBlock.RemoveStimulusId(string)'></a>

## ExpBlock.RemoveStimulusId(string) Method

This method delegates the removal of a `Stimulus` Id to the trials making up this block.

```csharp
public void RemoveStimulusId(string stimid);
```
#### Parameters

<a name='HurPsyLib.ExpBlock.RemoveStimulusId(string).stimid'></a>

`stimid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')