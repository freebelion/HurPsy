#### [HurPsyExp](index.md 'index')
### [HurPsyExp](HurPsyExp.md 'HurPsyExp')

## Utility Class

This static class will handle mundane operations like opening and saving files, etc. which fall outside the jurisdiction of the design app.

```csharp
public static class Utility
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; Utility
### Fields

<a name='HurPsyExp.Utility.MM2DIU'></a>

## Utility.MM2DIU Field

Millimeters to DIU conversion ratio

```csharp
private const double MM2DIU = 3,77952755;
```

#### Field Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyExp.Utility.Rnd'></a>

## Utility.Rnd Field

The pseudo-random number generator which will be used while an experiment runs

```csharp
public static Random Rnd;
```

#### Field Value
[System.Random](https://docs.microsoft.com/en-us/dotnet/api/System.Random 'System.Random')
### Methods

<a name='HurPsyExp.Utility.ConvertFromDIU(double,HurPsyLib.HurPsyUnit)'></a>

## Utility.ConvertFromDIU(double, HurPsyUnit) Method

This function will convert a dimension in device-independent-units (WPF equivalent of a standard pixel dimension) to the experiment unit passed as the second parameter.  
(Normally, this design and run application will only use millimeters as its standard unit, but this function will come into use when more unit choices become available)

```csharp
public static double ConvertFromDIU(double diuValue, HurPsyLib.HurPsyUnit unit);
```
#### Parameters

<a name='HurPsyExp.Utility.ConvertFromDIU(double,HurPsyLib.HurPsyUnit).diuValue'></a>

`diuValue` [System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

The value in DIUs

<a name='HurPsyExp.Utility.ConvertFromDIU(double,HurPsyLib.HurPsyUnit).unit'></a>

`unit` [HurPsyLib.HurPsyUnit](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.HurPsyUnit 'HurPsyLib.HurPsyUnit')

The desired unit for the result

#### Returns
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')  
The converted value (NaN, if no valid unit choice is provided)

<a name='HurPsyExp.Utility.CopyStimulusFile(HurPsyLib.Stimulus,string)'></a>

## Utility.CopyStimulusFile(Stimulus, string) Method

This method will copy the file containing a stimulus definition to the directory where the experiment files are kept.  
(This helps package all files pertaining to an experiment and share with other experimenters, so they can run the experiment after extracting all those files into the same directory)

```csharp
public static bool CopyStimulusFile(HurPsyLib.Stimulus stim, string expDirectoryPath);
```
#### Parameters

<a name='HurPsyExp.Utility.CopyStimulusFile(HurPsyLib.Stimulus,string).stim'></a>

`stim` [HurPsyLib.Stimulus](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Stimulus 'HurPsyLib.Stimulus')

The `Stimulus` object representing the stimulus

<a name='HurPsyExp.Utility.CopyStimulusFile(HurPsyLib.Stimulus,string).expDirectoryPath'></a>

`expDirectoryPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The full path of the directory where the experiment files are kept

#### Returns
[System.Boolean](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean 'System.Boolean')

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

<a name='HurPsyExp.Utility.FindStimulusFile(HurPsyLib.Stimulus,string)'></a>

## Utility.FindStimulusFile(Stimulus, string) Method

This method will try to locate a file containing the definition of a stimulus.  
(If the stimulus could not be recovered from the file path recorded in its definition, maybe because the experiment definiton was shared or moved to a different location, this method will look into the directory containing the experiment definition)

```csharp
public static void FindStimulusFile(HurPsyLib.Stimulus stim, string expDirectoryPath);
```
#### Parameters

<a name='HurPsyExp.Utility.FindStimulusFile(HurPsyLib.Stimulus,string).stim'></a>

`stim` [HurPsyLib.Stimulus](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Stimulus 'HurPsyLib.Stimulus')

The `Stimulus` object representing the stimulus

<a name='HurPsyExp.Utility.FindStimulusFile(HurPsyLib.Stimulus,string).expDirectoryPath'></a>

`expDirectoryPath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The full path of the directory where the experiment files are kept

#### Exceptions

[HurPsyLib.HurPsyException](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.HurPsyException 'HurPsyLib.HurPsyException')

<a name='HurPsyExp.Utility.GetPermutations_T_(System.Collections.Generic.List_System.Collections.Generic.List_T__)'></a>

## Utility.GetPermutations<T>(List<List<T>>) Method

This function will return a list of permuted arrays constructed from a list of objects which come as a parameter

```csharp
public static System.Collections.Generic.List<T[]> GetPermutations<T>(System.Collections.Generic.List<System.Collections.Generic.List<T>> lists);
```
#### Type parameters

<a name='HurPsyExp.Utility.GetPermutations_T_(System.Collections.Generic.List_System.Collections.Generic.List_T__).T'></a>

`T`

Generic type of objects which will be permuted
#### Parameters

<a name='HurPsyExp.Utility.GetPermutations_T_(System.Collections.Generic.List_System.Collections.Generic.List_T__).lists'></a>

`lists` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](HurPsyExp.Utility.md#HurPsyExp.Utility.GetPermutations_T_(System.Collections.Generic.List_System.Collections.Generic.List_T__).T 'HurPsyExp.Utility.GetPermutations<T>(System.Collections.Generic.List<System.Collections.Generic.List<T>>).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

The list of object lists to be permuted

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](HurPsyExp.Utility.md#HurPsyExp.Utility.GetPermutations_T_(System.Collections.Generic.List_System.Collections.Generic.List_T__).T 'HurPsyExp.Utility.GetPermutations<T>(System.Collections.Generic.List<System.Collections.Generic.List<T>>).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyExp.Utility.GetPermutations_T_(System.Collections.Generic.List_T_[])'></a>

## Utility.GetPermutations<T>(List<T>[]) Method

This function will return a list of permuted arrays constructed from an indeterminate number of arrays which come as parameters

```csharp
public static System.Collections.Generic.List<T[]> GetPermutations<T>(params System.Collections.Generic.List<T>[] arrays);
```
#### Type parameters

<a name='HurPsyExp.Utility.GetPermutations_T_(System.Collections.Generic.List_T_[]).T'></a>

`T`

Generic type of objects which will be permuted
#### Parameters

<a name='HurPsyExp.Utility.GetPermutations_T_(System.Collections.Generic.List_T_[]).arrays'></a>

`arrays` [System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](HurPsyExp.Utility.md#HurPsyExp.Utility.GetPermutations_T_(System.Collections.Generic.List_T_[]).T 'HurPsyExp.Utility.GetPermutations<T>(System.Collections.Generic.List<T>[]).T')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')

The list of object arrays to be permuted

#### Returns
[System.Collections.Generic.List&lt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')[T](HurPsyExp.Utility.md#HurPsyExp.Utility.GetPermutations_T_(System.Collections.Generic.List_T_[]).T 'HurPsyExp.Utility.GetPermutations<T>(System.Collections.Generic.List<T>[]).T')[[]](https://docs.microsoft.com/en-us/dotnet/api/System.Array 'System.Array')[&gt;](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1 'System.Collections.Generic.List`1')

<a name='HurPsyExp.Utility.LoadDataContractObjectFromXml_T_(string)'></a>

## Utility.LoadDataContractObjectFromXml<T>(string) Method

This function will load a generic object with a given type from an XML file by using a `DataContractSerializer`

```csharp
public static T? LoadDataContractObjectFromXml<T>(string fileName)
    where T : class;
```
#### Type parameters

<a name='HurPsyExp.Utility.LoadDataContractObjectFromXml_T_(string).T'></a>

`T`

The object type
#### Parameters

<a name='HurPsyExp.Utility.LoadDataContractObjectFromXml_T_(string).fileName'></a>

`fileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the XML file containing the object structure

#### Returns
[T](HurPsyExp.Utility.md#HurPsyExp.Utility.LoadDataContractObjectFromXml_T_(string).T 'HurPsyExp.Utility.LoadDataContractObjectFromXml<T>(string).T')  
The object loaded from the file (`null` if no valid object could be recovered)

<a name='HurPsyExp.Utility.LoadExperiment()'></a>

## Utility.LoadExperiment() Method

This function will display an open-file dialog and load an experiment definition (if a valid one can be constructed) from the selected file

```csharp
public static HurPsyLib.Experiment? LoadExperiment();
```

#### Returns
[HurPsyLib.Experiment](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Experiment 'HurPsyLib.Experiment')  
The reference of the `Experiment` object (`null` if a valid definition could not be constructed)

<a name='HurPsyExp.Utility.LoadImage(string)'></a>

## Utility.LoadImage(string) Method

This function will load and return a bitmap image from the file at the given path

```csharp
public static System.Windows.Media.Imaging.BitmapImage LoadImage(string filename);
```
#### Parameters

<a name='HurPsyExp.Utility.LoadImage(string).filename'></a>

`filename` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the file containing the image

#### Returns
[System.Windows.Media.Imaging.BitmapImage](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Media.Imaging.BitmapImage 'System.Windows.Media.Imaging.BitmapImage')  
The image object

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

<a name='HurPsyExp.Utility.SaveDataContractObjectToXml_T_(T,string)'></a>

## Utility.SaveDataContractObjectToXml<T>(T, string) Method

This function will save a generic object with a given type to an XML file by using a `DataContractSerializer`

```csharp
public static void SaveDataContractObjectToXml<T>(T obj, string fileName)
    where T : class;
```
#### Type parameters

<a name='HurPsyExp.Utility.SaveDataContractObjectToXml_T_(T,string).T'></a>

`T`

The object type
#### Parameters

<a name='HurPsyExp.Utility.SaveDataContractObjectToXml_T_(T,string).obj'></a>

`obj` [T](HurPsyExp.Utility.md#HurPsyExp.Utility.SaveDataContractObjectToXml_T_(T,string).T 'HurPsyExp.Utility.SaveDataContractObjectToXml<T>(T, string).T')

<a name='HurPsyExp.Utility.SaveDataContractObjectToXml_T_(T,string).fileName'></a>

`fileName` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the XML file containing the object structure

<a name='HurPsyExp.Utility.SaveExperiment(HurPsyLib.Experiment)'></a>

## Utility.SaveExperiment(Experiment) Method

This method will display a save-file dialog and save the given experiment definition into the specified file.

```csharp
public static void SaveExperiment(HurPsyLib.Experiment exp);
```
#### Parameters

<a name='HurPsyExp.Utility.SaveExperiment(HurPsyLib.Experiment).exp'></a>

`exp` [HurPsyLib.Experiment](https://docs.microsoft.com/en-us/dotnet/api/HurPsyLib.Experiment 'HurPsyLib.Experiment')

The experiment definition which will be saved

<a name='HurPsyExp.Utility.SaveImage(System.Windows.Media.Imaging.BitmapImage,string)'></a>

## Utility.SaveImage(BitmapImage, string) Method

This method will save a bitmap image into the file at the given path.

```csharp
public static void SaveImage(System.Windows.Media.Imaging.BitmapImage bmpimg, string filePath);
```
#### Parameters

<a name='HurPsyExp.Utility.SaveImage(System.Windows.Media.Imaging.BitmapImage,string).bmpimg'></a>

`bmpimg` [System.Windows.Media.Imaging.BitmapImage](https://docs.microsoft.com/en-us/dotnet/api/System.Windows.Media.Imaging.BitmapImage 'System.Windows.Media.Imaging.BitmapImage')

The bitmap image object

<a name='HurPsyExp.Utility.SaveImage(System.Windows.Media.Imaging.BitmapImage,string).filePath'></a>

`filePath` [System.String](https://docs.microsoft.com/en-us/dotnet/api/System.String 'System.String')

The path of the file where the image will be saved