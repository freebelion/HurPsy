### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## HurPsyException Class

Customary specialized Exception class

```csharp
public class HurPsyException : System.Exception
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.Exception](https://docs.microsoft.com/en-us/dotnet/api/System.Exception 'System.Exception') &#129106; HurPsyException
### Methods

<a name='HurPsyLib.HurPsyException.LibError(string)'></a>

## HurPsyException.LibError(string) Method

This static method provides a shortcut to throw an exception  
referring to a named string resource in HurPsyLibStrings assembly.

```csharp
public static void LibError(string strResourceName);
```
#### Parameters

<a name='HurPsyLib.HurPsyException.LibError(string).strResourceName'></a>

`strResourceName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

#### Exceptions

[HurPsyException](HurPsyLib.HurPsyException.md 'HurPsyLib.HurPsyException')