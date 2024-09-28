### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## Trial Class

The class which represents an experimental trial as a collection of `Step` objects representing successive steps where groups of stimuli are presented together

```csharp
public class Trial
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Trial
### Constructors

<a name='HurPsyLib.Trial.Trial()'></a>

## Trial() Constructor

This default constructor starts with an empty list of steps and unfixed order number  
If true, the trial represented by the object will not be affected by shuffling of trials.

```csharp
public Trial();
```
### Properties

<a name='HurPsyLib.Trial.IsFixed'></a>

## Trial.IsFixed Property

The boolean flag which indicates whether this trial's order in the block is fixed

```csharp
public bool IsFixed { get; set; }
```

#### Property Value
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

<a name='HurPsyLib.Trial.Steps'></a>

## Trial.Steps Property

The collection of `Step` objects representing successive steps making up the trial

```csharp
public System.Collections.Generic.List<HurPsyLib.Step> Steps { get; set; }
```

#### Property Value
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[Step](HurPsyLib.Step.md 'HurPsyLib.Step')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')
### Methods

<a name='HurPsyLib.Trial.AddStep(HurPsyLib.Step)'></a>

## Trial.AddStep(Step) Method

The function which adds a `Step` object to the collection of steps and returns a reference to it

```csharp
public HurPsyLib.Step AddStep(HurPsyLib.Step? newstep=null);
```
#### Parameters

<a name='HurPsyLib.Trial.AddStep(HurPsyLib.Step).newstep'></a>

`newstep` [Step](HurPsyLib.Step.md 'HurPsyLib.Step')

The `Step` object which will be added (null by default, if a new `Step` object must be created and added)

#### Returns
[Step](HurPsyLib.Step.md 'HurPsyLib.Step')  
The newly added object

<a name='HurPsyLib.Trial.ChangeLocatorId(string,string)'></a>

## Trial.ChangeLocatorId(string, string) Method

The method which updates the id of a `Locator` object by scanning through `Steps` collection

```csharp
public void ChangeLocatorId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyLib.Trial.ChangeLocatorId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The old locator id

<a name='HurPsyLib.Trial.ChangeLocatorId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The new locator id

<a name='HurPsyLib.Trial.ChangeStimulusId(string,string)'></a>

## Trial.ChangeStimulusId(string, string) Method

The method which updates the id of a `Stimulus` object by scanning through `Steps` collection

```csharp
public void ChangeStimulusId(string oldId, string newId);
```
#### Parameters

<a name='HurPsyLib.Trial.ChangeStimulusId(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The old stimulus id

<a name='HurPsyLib.Trial.ChangeStimulusId(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The new stimulus id