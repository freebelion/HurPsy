﻿using HurPsyLibStrings;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace HurPsyLib
{
	/// <summary>
	/// This class represents a point object to specify a position on the experiment's coordinate system.
	/// Its whole point is to keep `HurPsyLib` objects independent of the GUIs used for designing or running experiments.
	/// </summary>
	[DataContract]
	public class HurPsyPoint
	{
		/// <summary>
		/// Horizontal position in a right-handed Cartesian coordinate system
		/// </summary>
		[DataMember]
		public double X { get; set; }

		/// <summary>
		/// Vertical position in a right-handed Cartesian coordinate system
		/// </summary>
		[DataMember]
		public double Y { get; set; }

		/// <summary>
		/// This default constructor starts with zero positions
		/// </summary>
		public HurPsyPoint()
		{ X = 0; Y = 0; }

		/// <summary>
		/// This parametrized constructor accepts initial positions
		/// </summary>
		/// <param name="pX">Initial horizontal position</param>
		/// <param name="pY">Initial vertical position</param>
		public HurPsyPoint(double pX, double pY)
		{ X = pX; Y = pY; }

		/// <summary>
		/// This function constructs a temporary copy of this instance; it helps avoid accidentally modifying the original location point after copying it for various purposes.
		/// </summary>
		/// <returns></returns>
		public HurPsyPoint ShallowCopy()
		{ return (HurPsyPoint) this.MemberwiseClone(); }
	}

	/// <summary>
	/// This class helps specify the dimensions of a visual stimulus.
	/// Its whole point is to keep `HurPsyLib` objects independent of the GUIs used for designing or running experiments.
	/// </summary>
	[DataContract]
	public class HurPsySize
	{
		/// <summary>
		/// Horizontal size
		/// </summary>
		[DataMember]
		private double sizeX;

		/// <summary>
		/// Vertical size
		/// </summary>
		[DataMember]
		private double sizeY;

        /// <summary>
        /// This default constructor starts with zero dimensions
        /// </summary>
        public HurPsySize()
		{
			sizeX = 0;
			sizeY = 0;
		}

		/// <summary>
		/// This parametrized constructor accepts initial dimensions
		/// </summary>
		/// <param name="sX"></param>
		/// <param name="sY"></param>
		public HurPsySize(double sX, double sY)
		{ sizeX = sX; sizeY = sY; }

		/// <summary>
		/// The property to get/set the horizontal dimension (an exception will be thrown for a negative value)
		/// </summary>
		public double Width
		{
			get { return sizeX; }
			set
			{
				if (value < 0)
				{
					HurPsyCommon.Throw("Error_NegativeDimensionValue");
				}
				else { sizeX = value; }
			}
		}

		/// <summary>
		/// The property to get/set the vertical dimension (an exception will be thrown for a negative value)
		/// </summary>
		public double Height
		{
			get { return sizeY; }
			set
			{
				if (value < 0)
				{
					HurPsyCommon.Throw("Error_NegativeDimensionValue");
				}
				else { sizeY = value; }
			}
		}
	}

	/// <summary>
	/// This class helps specify a time period.
	/// </summary>
	[DataContract]
	public class HurPsyTimePeriod
	{
		/// <summary>
		/// This `TimeSpan` value contains the actual time period information.
		/// </summary>
		[DataMember]
		private TimeSpan period;

		/// <summary>
		/// This default constructor starts with zero time period.
		/// </summary>
		public HurPsyTimePeriod()
		{
			period = TimeSpan.Zero;
		}

		/// <summary>
		/// This property helps get the milliseconds equivalent of the time period or set it with a value in units of milliseconds (An exception will be thrown in case of a negative value)
		/// </summary>
		public double Milliseconds
		{
			get { return period.TotalMilliseconds; }
			set
			{
				if (value < 0)
				{
					HurPsyCommon.Throw("Error_NegativeTimeValue");
				}
				else
				{ period = TimeSpan.FromMilliseconds(value); }
			}
		}

		/// <summary>
		/// This property helps get the seconds equivalent of the time period or set it with a value in units of seconds (An exception will be thrown in case of a negative value)
		/// </summary>
		public double Seconds
		{
			get { return period.TotalSeconds; }
			set
			{
				if (value < 0)
				{
					HurPsyCommon.Throw("Error_NegativeTimeValue");
				}
				else
				{ period = TimeSpan.FromSeconds(value); }
			}
		}

		/// <summary>
		/// This property provides direct access to the `TimeSpan` value in a runtime environment where .NET is available
		/// </summary>
		public TimeSpan Span
		{
			get { return period; }
			set { period = value; }
		}
	}

	/// <summary>
	/// This library's specialized Exception class
	/// </summary>
	public class HurPsyException : Exception
	{
		/// <summary>
		/// This parametrized constructor lets the base class initialize the error message
		/// </summary>
		/// <param name="errorMessage">The error message string</param>
		public HurPsyException(string errorMessage) : base(errorMessage)
		{

		}
	}
}