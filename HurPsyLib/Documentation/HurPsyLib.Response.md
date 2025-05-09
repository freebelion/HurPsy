### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## Response Class

This abstract class represents a response definition identified by a unique string provided by its base class `IdObject`

```csharp
public abstract class Response : HurPsyLib.IdObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [IdObject](HurPsyLib.IdObject.md 'HurPsyLib.IdObject') &#129106; Response

Derived  
&#8627; [KeyResponse](HurPsyLib.KeyResponse.md 'HurPsyLib.KeyResponse')
### Methods

<a name='HurPsyLib.Response.Equals(HurPsyLib.Response)'></a>

## Response.Equals(Response) Method

Derived classes has to provide a way to check their equality (in terms of content) with another instance of the class.

```csharp
public abstract bool Equals(HurPsyLib.Response rep);
```
#### Parameters

<a name='HurPsyLib.Response.Equals(HurPsyLib.Response).rep'></a>

`rep` [Response](HurPsyLib.Response.md 'HurPsyLib.Response')

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')