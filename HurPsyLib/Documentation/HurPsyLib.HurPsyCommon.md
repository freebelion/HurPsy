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

<a name='HurPsyLib.HurPsyCommon.Throw(string)'></a>

## HurPsyCommon.Throw(string) Method

This static method will throw an exception displaying the named string resource from the **HurPsyLibStrings** assembly.

```csharp
public static void Throw(string strid);
```
#### Parameters

<a name='HurPsyLib.HurPsyCommon.Throw(string).strid'></a>

`strid` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Name of the string resource