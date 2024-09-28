### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## StimulusLocatorPair Class

The class which associates a `Stimulus` object with a `Locator` object by pairing their ids.  
Any such pairing which appears in a `Step` object representing a trial step will help display a stimulus at the position specified by the associated locator.

```csharp
public class StimulusLocatorPair
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; StimulusLocatorPair
### Constructors

<a name='HurPsyLib.StimulusLocatorPair.StimulusLocatorPair()'></a>

## StimulusLocatorPair() Constructor

This default constructor creates an id pair with empty id strings.

```csharp
public StimulusLocatorPair();
```

<a name='HurPsyLib.StimulusLocatorPair.StimulusLocatorPair(string,string)'></a>

## StimulusLocatorPair(string, string) Constructor

This parametrized constructor creates a pair of given ids.

```csharp
public StimulusLocatorPair(string stimId, string locId);
```
#### Parameters

<a name='HurPsyLib.StimulusLocatorPair.StimulusLocatorPair(string,string).stimId'></a>

`stimId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `Stimulus` id of the pair

<a name='HurPsyLib.StimulusLocatorPair.StimulusLocatorPair(string,string).locId'></a>

`locId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The `Locator` id of the pair
### Properties

<a name='HurPsyLib.StimulusLocatorPair.LocatorId'></a>

## StimulusLocatorPair.LocatorId Property

The `Locator` id making up the pair.

```csharp
public string LocatorId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.StimulusLocatorPair.StimulusId'></a>

## StimulusLocatorPair.StimulusId Property

The `Stimulus` id making up the pair.

```csharp
public string StimulusId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')