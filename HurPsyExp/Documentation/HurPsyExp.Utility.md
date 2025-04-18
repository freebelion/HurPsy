#### [HurPsyExp](index.md 'index')
### [HurPsyExp](HurPsyExp.md 'HurPsyExp')

## Utility Class

This class is actually a collection of static methods that will be used throughout the application.

```csharp
public static class Utility
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Utility
### Properties

<a name='HurPsyExp.Utility.RND'></a>

## Utility.RND Property

Application-wide pseudo-RNG

```csharp
public static System.Random RND { get; set; }
```

#### Property Value
[System.Random](https://docs.microsoft.com/en-us/dotnet/api/System.Random 'System.Random')
### Methods

<a name='HurPsyExp.Utility.FileSaveName(string)'></a>

## Utility.FileSaveName(string) Method

This function will open a save-file selection dialog and return the selected file' path as a string

```csharp
public static string? FileSaveName(string filenameFilter);
```
#### Parameters

<a name='HurPsyExp.Utility.FileSaveName(string).filenameFilter'></a>

`filenameFilter` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The filename filter for the file selection dialog

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')  
The full path for the file

<a name='HurPsyExp.Utility.FindChild_T_(System.Windows.DependencyObject,string)'></a>

## Utility.FindChild<T>(DependencyObject, string) Method

Finds a Child of a given item in the visual tree.   
Source: https://stackoverflow.com/questions/636383/how-can-i-find-wpf-controls-by-name-or-type

```csharp
public static T FindChild<T>(System.Windows.DependencyObject parent, string childName)
    where T : System.Windows.DependencyObject;
```
#### Type parameters

<a name='HurPsyExp.Utility.FindChild_T_(System.Windows.DependencyObject,string).T'></a>

`T`

The type of the queried item.
#### Parameters

<a name='HurPsyExp.Utility.FindChild_T_(System.Windows.DependencyObject,string).parent'></a>

`parent` [System.Windows.DependencyObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.DependencyObject 'System.Windows.DependencyObject')

A direct parent of the queried item.

<a name='HurPsyExp.Utility.FindChild_T_(System.Windows.DependencyObject,string).childName'></a>

`childName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

x:Name or Name of child.

#### Returns
[T](HurPsyExp.Utility.md#HurPsyExp.Utility.FindChild_T_(System.Windows.DependencyObject,string).T 'HurPsyExp.Utility.FindChild<T>(System.Windows.DependencyObject, string).T')  
The first parent item that matches the submitted type parameter or null if not found

<a name='HurPsyExp.Utility.FindParent_T_(System.Windows.DependencyObject,string)'></a>

## Utility.FindParent<T>(DependencyObject, string) Method

Recursively finds the specified named parent in a control hierarchy  
Source: https://stackoverflow.com/questions/15198104/find-parent-of-control-by-name

```csharp
public static T FindParent<T>(System.Windows.DependencyObject child, string parentName)
    where T : System.Windows.DependencyObject;
```
#### Type parameters

<a name='HurPsyExp.Utility.FindParent_T_(System.Windows.DependencyObject,string).T'></a>

`T`

The type of the targeted Find
#### Parameters

<a name='HurPsyExp.Utility.FindParent_T_(System.Windows.DependencyObject,string).child'></a>

`child` [System.Windows.DependencyObject](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.DependencyObject 'System.Windows.DependencyObject')

The child control to start with

<a name='HurPsyExp.Utility.FindParent_T_(System.Windows.DependencyObject,string).parentName'></a>

`parentName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The name of the parent to find

#### Returns
[T](HurPsyExp.Utility.md#HurPsyExp.Utility.FindParent_T_(System.Windows.DependencyObject,string).T 'HurPsyExp.Utility.FindParent<T>(System.Windows.DependencyObject, string).T')

<a name='HurPsyExp.Utility.LoadFromXml_T_(string)'></a>

## Utility.LoadFromXml<T>(string) Method

A generic method to load an object from an XML file.

```csharp
public static T? LoadFromXml<T>(string openfilename);
```
#### Type parameters

<a name='HurPsyExp.Utility.LoadFromXml_T_(string).T'></a>

`T`

Object type
#### Parameters

<a name='HurPsyExp.Utility.LoadFromXml_T_(string).openfilename'></a>

`openfilename` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the file

#### Returns
[T](HurPsyExp.Utility.md#HurPsyExp.Utility.LoadFromXml_T_(string).T 'HurPsyExp.Utility.LoadFromXml<T>(string).T')

<a name='HurPsyExp.Utility.OpenFiles(string,bool)'></a>

## Utility.OpenFiles(string, bool) Method

This function will open a open-file selection dialog and return the selected files' paths as an array of strings

```csharp
public static string[]? OpenFiles(string filenameFilter, bool openMultiple);
```
#### Parameters

<a name='HurPsyExp.Utility.OpenFiles(string,bool).filenameFilter'></a>

`filenameFilter` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The filename filter for the file selection dialog

<a name='HurPsyExp.Utility.OpenFiles(string,bool).openMultiple'></a>

`openMultiple` [System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

The boolean flag indicating if multiple selections are permitted

#### Returns
[System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')  
An array containing the chosen files' paths

<a name='HurPsyExp.Utility.SaveToXml_T_(T,string)'></a>

## Utility.SaveToXml<T>(T, string) Method

A generic method to save an object onto an XML file

```csharp
public static void SaveToXml<T>(T obj, string savefilename);
```
#### Type parameters

<a name='HurPsyExp.Utility.SaveToXml_T_(T,string).T'></a>

`T`

Object type
#### Parameters

<a name='HurPsyExp.Utility.SaveToXml_T_(T,string).obj'></a>

`obj` [T](HurPsyExp.Utility.md#HurPsyExp.Utility.SaveToXml_T_(T,string).T 'HurPsyExp.Utility.SaveToXml<T>(T, string).T')

The object to be saved (serialized)

<a name='HurPsyExp.Utility.SaveToXml_T_(T,string).savefilename'></a>

`savefilename` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the file