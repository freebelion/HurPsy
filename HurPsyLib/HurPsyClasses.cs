using HurPsyStrings;
using System.Collections.Generic;
using System.Runtime.Serialization;

[DataContract]
public enum HurPsyUnit
{
    [EnumMember]
    MM,
    [EnumMember]
    Fraction
}

[DataContract]
public enum HurPsyOrigin
{
    [EnumMember]
    MiddleCenter,
    [EnumMember]
    TopLeft
}

[DataContract]
public class HurPsyPoint
{
    [DataMember]
    private double pointX;
    [DataMember]
    private double pointY;
    [DataMember]
    public HurPsyOrigin OriginChoice { get; set; }
    [DataMember]
    public HurPsyUnit LengthUnit { get; set; }

    public HurPsyPoint()
    { pointX = 0; pointY = 0; } 

    public HurPsyPoint(double pX, double pY)
    { pointX = pX; pointY = pY; }   

    public double X
    {
        get { return pointX; }
        set
        {
            if (value < 0)
            {
                HurPsyException.Throw("Error_NegativePositionValue");
            }
            else { pointX = value; }
        }
    }

    public double Y
    {
        get { return pointY; }
        set
        {
            if (value < 0)
            {
                HurPsyException.Throw("Error_NegativePositionValue");
            }
            else { pointY = value; }
        }
    }
  
    public HurPsyPoint ShallowCopy()
    {
        return new HurPsyPoint(pointX, pointY);
    }
}

[DataContract]
public class HurPsySize
{
    [DataMember]
    private double sizeX;
    [DataMember]
    private double sizeY;
    [DataMember]
    public HurPsyOrigin OriginChoice { get; set; }
    [DataMember]
    public HurPsyUnit SizeUnit { get; set; }

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
            {
                HurPsyException.Throw("Error_NegativeDimensionValue");
            }
            else { sizeX = value; }
        }
    }

    public double Height
    {
        get { return sizeY; }
        set
        {
            if (value < 0)
            {
                HurPsyException.Throw("Error_NegativeDimensionValue");
            }
            else { sizeY = value; }
        }
    }

    public HurPsySize ShallowCopy()
    {
        return new HurPsySize(sizeX, sizeY);
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
            { HurPsyException.Throw("Error_NegativeTimeValue"); }
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
            { HurPsyException.Throw("Error_NegativeTimeValue"); }
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
    public static void Throw(string strResourceName)
    {
        throw new HurPsyException(LibStrings.GetString(strResourceName));
    }
}

public static class HurPsyCommon
{
    public static Random Rnd = new Random((int) DateTime.Now.Ticks);
    public static string GetObjectGuid(object obj)
    { return obj.GetType().Name + "_" + Guid.NewGuid().ToString().Substring(0, 8); }
}