### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## StimulusLocatorPair Class

This class associates a `Stimulus` object with a `Locator` object by pairing their ids.  
Such pairs appear in `Step` objects representing trial steps where `Stimulus` objects appear at positions determined by their associated `Locator` objects.

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

The `Locator` id of the pair.

```csharp
public string LocatorId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.StimulusLocatorPair.StimulusId'></a>

## StimulusLocatorPair.StimulusId Property

The `Stimulus` id of the pair.

```csharp
public string StimulusId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')