using HurPsyStrings;
using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public class HurPsyPoint
{
    [DataMember]
    public double X { get; set; }
    [DataMember]
    public double Y { get; set; }
    
    public HurPsyPoint()
    { X = 0; Y = 0; } 

    public HurPsyPoint(double pX, double pY)
    { X = pX; Y = pY; }   
}

[DataContract]
public class HurPsySize
{
    [DataMember]
    private double sizeX;
    [DataMember]
    private double sizeY;
    
    public HurPsySize()
    { sizeX = 0; sizeY = 0; }

    public HurPsySize(double sX, double sY)
    { sizeX = sX; sizeY = sY; }

    public double Width
    {
        get { return sizeX; }
        set
        {
            if (value < 0)
            { HurPsyException.LibError("Error_NegativeDimensionValue"); }
            else { sizeX = value; }
        }
    }

    public double Height
    {
        get { return sizeY; }
        set
        {
            if (value < 0)
            { HurPsyException.LibError("Error_NegativeDimensionValue"); }
            else { sizeY = value; }
        }
    }
}

[DataContract]
public class HurPsyTimePeriod
{
    [DataMember]
    private TimeSpan period;

    public HurPsyTimePeriod()
    {
        period = TimeSpan.Zero;
    }

    public double Milliseconds
    {
        get { return period.TotalMilliseconds; }
        set
        {
            if (value < 0)
            { HurPsyException.LibError("Error_NegativeTimeValue"); }
            else
            { period = TimeSpan.FromMilliseconds(value); }
        }
    }

    public double Seconds
    {
        get { return period.TotalSeconds; }
        set
        {
            if (value < 0)
            { HurPsyException.LibError("Error_NegativeTimeValue"); }
            else
            { period = TimeSpan.FromSeconds(value); }
        }
    }
}

/// <summary>
/// Customary specialized Exception class
/// </summary>
public class HurPsyException : Exception
{
    public HurPsyException(string errorMessage) : base(errorMessage)
    {

    }

    /// <summary>
    /// This static method provides a shortcut to throw an exception
    /// referring to a named string resource in HurPsyStrings assembly.
    /// </summary>
    /// <param name="strResourceName"></param>
    /// <exception cref="HurPsyException"></exception>
    public static void LibError(string strResourceName)
    {
        throw new HurPsyException(LibStrings.GetString(strResourceName));
    }
}