### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## IdObject Class

This abstract class enables all instances of derived classes to have temporary Ids assigned.

```csharp
public abstract class IdObject
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; IdObject

Derived  
&#8627; [ExpBlock](HurPsyLib.ExpBlock.md 'HurPsyLib.ExpBlock')  
&#8627; [ExpStep](HurPsyLib.ExpStep.md 'HurPsyLib.ExpStep')  
&#8627; [ExpTrial](HurPsyLib.ExpTrial.md 'HurPsyLib.ExpTrial')  
&#8627; [Locator](HurPsyLib.Locator.md 'HurPsyLib.Locator')  
&#8627; [Stimulus](HurPsyLib.Stimulus.md 'HurPsyLib.Stimulus')
### Constructors

<a name='HurPsyLib.IdObject.IdObject()'></a>

## IdObject() Constructor

This default constructor assigns a temporary unique Id to the object based on its type name.

```csharp
public IdObject();
```
### Properties

<a name='HurPsyLib.IdObject.Id'></a>

## IdObject.Id Property

`Id` will serve as a uniquely identifying string for each instance.

```csharp
public string Id { get; set; }
```

#### Property Value
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')
### Methods

<a name='HurPsyLib.IdObject.CreateId(System.Type)'></a>

## IdObject.CreateId(Type) Method

This statis function is an attempt to create -hopefully unique- temporary Id strings for newly created objects.

```csharp
public static string CreateId(System.Type objty);
```
#### Parameters

<a name='HurPsyLib.IdObject.CreateId(System.Type).objty'></a>

`objty` [System.Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type 'System.Type')

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')