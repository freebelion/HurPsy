### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## KeyResponse Class

This class represents a keyboard response

```csharp
public class KeyResponse : HurPsyLib.Response
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [IdObject](HurPsyLib.IdObject.md 'HurPsyLib.IdObject') &#129106; [Response](HurPsyLib.Response.md 'HurPsyLib.Response') &#129106; KeyResponse
### Constructors

<a name='HurPsyLib.KeyResponse.KeyResponse()'></a>

## KeyResponse() Constructor

This default constructor assumes that the key response can be any key.

```csharp
public KeyResponse();
```

<a name='HurPsyLib.KeyResponse.KeyResponse(int)'></a>

## KeyResponse(int) Constructor

This parametrized constructor starts with the given key code.

```csharp
public KeyResponse(int kcode);
```
#### Parameters

<a name='HurPsyLib.KeyResponse.KeyResponse(int).kcode'></a>

`kcode` [System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
### Fields

<a name='HurPsyLib.KeyResponse.ANYKEY'></a>

## KeyResponse.ANYKEY Field

The specific code for any key (which corresponds to Key.None enumeration value for WPF)  
A programmer may have to define another value for a different OS.

```csharp
private const int ANYKEY = 0;
```

#### Field Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
### Properties

<a name='HurPsyLib.KeyResponse.KeyCode'></a>

## KeyResponse.KeyCode Property

An integer code representing the key pressed on the keyboard  
(It may be an integer equivalent of an enumerated value provided by the OS;  
 if not, a programmer will have to find a define an enumeration representing the keys.)

```csharp
public int KeyCode { get; set; }
```

#### Property Value
[System.Int32](https://docs.microsoft.com/en-us/dotnet/api/System.Int32 'System.Int32')
### Methods

<a name='HurPsyLib.KeyResponse.Equals(HurPsyLib.Response)'></a>

## KeyResponse.Equals(Response) Method

This implementation checks for equality of the key response represented by this object with another.

```csharp
public override bool Equals(HurPsyLib.Response rep);
```
#### Parameters

<a name='HurPsyLib.KeyResponse.Equals(HurPsyLib.Response).rep'></a>

`rep` [Response](HurPsyLib.Response.md 'HurPsyLib.Response')

The other key response object

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')  
The indicator of equality