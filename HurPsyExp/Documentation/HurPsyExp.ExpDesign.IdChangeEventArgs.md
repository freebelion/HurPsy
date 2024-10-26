#### [HurPsyExp](index.md 'index')
### [HurPsyExp.ExpDesign](HurPsyExp.ExpDesign.md 'HurPsyExp.ExpDesign')

## IdChangeEventArgs Class

This custom `EventArgs` class will report an Id change for items with Ids.

```csharp
public class IdChangeEventArgs : System.EventArgs
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; [System.EventArgs](https://docs.microsoft.com/en-us/dotnet/api/System.EventArgs 'System.EventArgs') &#129106; IdChangeEventArgs
### Constructors

<a name='HurPsyExp.ExpDesign.IdChangeEventArgs.IdChangeEventArgs(string,string)'></a>

## IdChangeEventArgs(string, string) Constructor

This parametrized constructor receives the previous and new ids as arguments

```csharp
public IdChangeEventArgs(string? oldId, string? newId);
```
#### Parameters

<a name='HurPsyExp.ExpDesign.IdChangeEventArgs.IdChangeEventArgs(string,string).oldId'></a>

`oldId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

Yes, the value of the previous Id string

<a name='HurPsyExp.ExpDesign.IdChangeEventArgs.IdChangeEventArgs(string,string).newId'></a>

`newId` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

and the value for the new Id string
### Properties

<a name='HurPsyExp.ExpDesign.IdChangeEventArgs.NewId'></a>

## IdChangeEventArgs.NewId Property

The new Id string

```csharp
public string? NewId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

<a name='HurPsyExp.ExpDesign.IdChangeEventArgs.OldId'></a>

## IdChangeEventArgs.OldId Property

The previous Id string

```csharp
public string? OldId { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')