### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## ExpPair Class

This class represents an association between a `Stimulus` and a `Locator` which specifies a location for the stimulus.

```csharp
public class ExpPair
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; ExpPair
### Constructors

<a name='HurPsyLib.ExpPair.ExpPair()'></a>

## ExpPair() Constructor

This default constructor starts with empty Id strings.

```csharp
public ExpPair();
```

<a name='HurPsyLib.ExpPair.ExpPair(string,string)'></a>

## ExpPair(string, string) Constructor

This parametrized constructor uses the given Ids for initialization.

```csharp
public ExpPair(string locId, string stimId);
```
#### Parameters

<a name='HurPsyLib.ExpPair.ExpPair(string,string).locId'></a>

`locId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Locator mId

<a name='HurPsyLib.ExpPair.ExpPair(string,string).stimId'></a>

`stimId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Stimulus Id
### Properties

<a name='HurPsyLib.ExpPair.LocatorId'></a>

## ExpPair.LocatorId Property

The Id representing the `Locator` of the pair

```csharp
public string LocatorId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyLib.ExpPair.StimulusId'></a>

## ExpPair.StimulusId Property

The Id representing the `Stimulus` of the pair

```csharp
public string StimulusId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')