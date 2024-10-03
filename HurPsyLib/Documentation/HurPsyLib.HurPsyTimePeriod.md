### [HurPsyLib](HurPsyLib.md 'HurPsyLib')

## HurPsyTimePeriod Class

The class which encapculates information about a time period, independent of the OS where an expperiment is designed or run.

```csharp
public class HurPsyTimePeriod
```

Inheritance [System.Object](https://docs.microsoft.com/en-us/dotnet/api/System.Object 'System.Object') &#129106; HurPsyTimePeriod
### Constructors

<a name='HurPsyLib.HurPsyTimePeriod.HurPsyTimePeriod()'></a>

## HurPsyTimePeriod() Constructor

This default constructor starts with zero time period

```csharp
public HurPsyTimePeriod();
```
### Fields

<a name='HurPsyLib.HurPsyTimePeriod.period'></a>

## HurPsyTimePeriod.period Field

The `TimeSpan` value which contains the actual time period information

```csharp
private TimeSpan period;
```

#### Field Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')
### Properties

<a name='HurPsyLib.HurPsyTimePeriod.Milliseconds'></a>

## HurPsyTimePeriod.Milliseconds Property

This property helps get the milliseconds equivalent of the time period or set it with a value in units of milliseconds (An exception will be thrown in case of a negative value)

```csharp
public double Milliseconds { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyLib.HurPsyTimePeriod.Seconds'></a>

## HurPsyTimePeriod.Seconds Property

This property helps get the seconds equivalent of the time period or set it with a value in units of seconds (An exception will be thrown in case of a negative value)

```csharp
public double Seconds { get; set; }
```

#### Property Value
[System.Double](https://docs.microsoft.com/en-us/dotnet/api/System.Double 'System.Double')

<a name='HurPsyLib.HurPsyTimePeriod.Span'></a>

## HurPsyTimePeriod.Span Property

This property provides direct access to the `TimeSpan` value in a runtime environment where .NET is available

```csharp
public System.TimeSpan Span { get; set; }
```

#### Property Value
[System.TimeSpan](https://docs.microsoft.com/en-us/dotnet/api/System.TimeSpan 'System.TimeSpan')