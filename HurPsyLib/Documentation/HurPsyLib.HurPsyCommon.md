### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## HurPsyCommon Class

This static class serves as a container for global objects utilized by all the `HurPsyLib` objects

```csharp
public static class HurPsyCommon
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; HurPsyCommon
### Fields

<a name='HurPsyLib.HurPsyCommon.Rnd'></a>

## HurPsyCommon.Rnd Field

The pseudo-random number generator shared by HurPsyLib` objects

```csharp
public static Random Rnd;
```

#### Field Value
[System.Random](https://docs.microsoft.com/en-us/dotnet/api/System.Random 'System.Random')
### Methods

<a name='HurPsyLib.HurPsyCommon.GetObjectGuid(object)'></a>

## HurPsyCommon.GetObjectGuid(object) Method

This function returns a temporfary unique id generated with the type name of any object

```csharp
public static string GetObjectGuid(object obj);
```
#### Parameters

<a name='HurPsyLib.HurPsyCommon.GetObjectGuid(object).obj'></a>

`obj` [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object')

The object which needs the temporary unique id

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')