### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## Block Class

The class which represents a block of experimental trials as a collection of `Trial` objects.

```csharp
public class Block
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Block
### Constructors

<a name='HurPsyLib.Block.Block()'></a>

## Block() Constructor

This default constructor starts with a temporary but unique block id as the name and empty list of trials.

```csharp
public Block();
```
### Fields

<a name='HurPsyLib.Block.blockCount'></a>

## Block.blockCount Field

The static variable through which the class keeps count of `Block` objects  
(as of September 23rd, 2024, I can't remember the reason that made this count necessary)

```csharp
private static int blockCount;
```

#### Field Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
### Properties

<a name='HurPsyLib.Block.MustShuffleTrials'></a>

## Block.MustShuffleTrials Property

The boolean flag which indicates whether the trials (except the fixed ones) making up the block must be shuffled before every run of the experiment.

```csharp
public bool MustShuffleTrials { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyLib.Block.Name'></a>

## Block.Name Property

The string which will hold the hopefully-identifying name given to the block by the designer of the experiment.

```csharp
public string Name { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.Block.Trials'></a>

## Block.Trials Property

The collection of `Trial` objects representing expewrimental trials

```csharp
public System.Collections.Generic.List<HurPsyLib.Trial> Trials { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Trial](HurPsyLib.Trial.md 'HurPsyLib.Trial')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
### Methods

<a name='HurPsyLib.Block.AddTrial(HurPsyLib.Trial)'></a>

## Block.AddTrial(Trial) Method

The function which adds a `Trial` object to the list of trials and returns a reference to it

```csharp
public HurPsyLib.Trial AddTrial(HurPsyLib.Trial? newtrial=null);
```
#### Parameters

<a name='HurPsyLib.Block.AddTrial(HurPsyLib.Trial).newtrial'></a>

`newtrial` [Trial](HurPsyLib.Trial.md 'HurPsyLib.Trial')

The `Trial` object which will be added (null by default, if a new object must be created and added)

#### Returns
[Trial](HurPsyLib.Trial.md 'HurPsyLib.Trial')  
The reference to the newly added object

<a name='HurPsyLib.Block.ChangeLocatorId(string,string)'></a>

## Block.ChangeLocatorId(string, string) Method

The method which updates the id of a `Locator` object by scanning through `Trials` collection

```csharp
public void ChangeLocatorId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyLib.Block.ChangeLocatorId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The old locator id

<a name='HurPsyLib.Block.ChangeLocatorId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The new locator id

<a name='HurPsyLib.Block.ChangeStimulusId(string,string)'></a>

## Block.ChangeStimulusId(string, string) Method

The method which updates the id of a `Stimulus` object by scanning through `Trials` collection

```csharp
public void ChangeStimulusId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyLib.Block.ChangeStimulusId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The old stimulus id

<a name='HurPsyLib.Block.ChangeStimulusId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The new stimulus id

<a name='HurPsyLib.Block.ShuffleTrials()'></a>

## Block.ShuffleTrials() Method

The method which shuffles the order of trials (excluding the fixed ones) making up the block

```csharp
public void ShuffleTrials();
```