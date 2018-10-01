﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;
using JetBrains.Annotations;
using UnitsNet.Units;

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     In geometry, an angle is the figure formed by two rays, called the sides of the angle, sharing a common endpoint, called the vertex of the angle.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart
    public partial class Angle : IQuantity
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly AngleUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public AngleUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static Angle()
        {
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">Numeric value.</param>
        /// <param name="unit">The unit representation to contruct this quantity with.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
#if WINDOWS_UWP
        private
#else
        public
#endif
        Angle(double numericValue, AngleUnit unit)
        {
            _value = numericValue;
            _unit = unit;
        }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.Angle;

        /// <summary>
        ///     The base unit of Angle, which is Degree. All conversions go via this value.
        /// </summary>
        public static AngleUnit BaseUnit => AngleUnit.Degree;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the Angle quantity.
        /// </summary>
        public static AngleUnit[] Units { get; } = Enum.GetValues(typeof(AngleUnit)).Cast<AngleUnit>().Except(new AngleUnit[]{ AngleUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get Angle in Arcminutes.
        /// </summary>
        public double Arcminutes => As(AngleUnit.Arcminute);

        /// <summary>
        ///     Get Angle in Arcseconds.
        /// </summary>
        public double Arcseconds => As(AngleUnit.Arcsecond);

        /// <summary>
        ///     Get Angle in Centiradians.
        /// </summary>
        public double Centiradians => As(AngleUnit.Centiradian);

        /// <summary>
        ///     Get Angle in Deciradians.
        /// </summary>
        public double Deciradians => As(AngleUnit.Deciradian);

        /// <summary>
        ///     Get Angle in Degrees.
        /// </summary>
        public double Degrees => As(AngleUnit.Degree);

        /// <summary>
        ///     Get Angle in Gradians.
        /// </summary>
        public double Gradians => As(AngleUnit.Gradian);

        /// <summary>
        ///     Get Angle in Microdegrees.
        /// </summary>
        public double Microdegrees => As(AngleUnit.Microdegree);

        /// <summary>
        ///     Get Angle in Microradians.
        /// </summary>
        public double Microradians => As(AngleUnit.Microradian);

        /// <summary>
        ///     Get Angle in Millidegrees.
        /// </summary>
        public double Millidegrees => As(AngleUnit.Millidegree);

        /// <summary>
        ///     Get Angle in Milliradians.
        /// </summary>
        public double Milliradians => As(AngleUnit.Milliradian);

        /// <summary>
        ///     Get Angle in Nanodegrees.
        /// </summary>
        public double Nanodegrees => As(AngleUnit.Nanodegree);

        /// <summary>
        ///     Get Angle in Nanoradians.
        /// </summary>
        public double Nanoradians => As(AngleUnit.Nanoradian);

        /// <summary>
        ///     Get Angle in Radians.
        /// </summary>
        public double Radians => As(AngleUnit.Radian);

        /// <summary>
        ///     Get Angle in Revolutions.
        /// </summary>
        public double Revolutions => As(AngleUnit.Revolution);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Degree.
        /// </summary>
        public static Angle Zero => new Angle(0, BaseUnit);

        /// <summary>
        ///     Get Angle from Arcminutes.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromArcminutes(double arcminutes)
#else
        public static Angle FromArcminutes(QuantityValue arcminutes)
#endif
        {
            double value = (double) arcminutes;
            return new Angle(value, AngleUnit.Arcminute);
        }

        /// <summary>
        ///     Get Angle from Arcseconds.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromArcseconds(double arcseconds)
#else
        public static Angle FromArcseconds(QuantityValue arcseconds)
#endif
        {
            double value = (double) arcseconds;
            return new Angle(value, AngleUnit.Arcsecond);
        }

        /// <summary>
        ///     Get Angle from Centiradians.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromCentiradians(double centiradians)
#else
        public static Angle FromCentiradians(QuantityValue centiradians)
#endif
        {
            double value = (double) centiradians;
            return new Angle(value, AngleUnit.Centiradian);
        }

        /// <summary>
        ///     Get Angle from Deciradians.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromDeciradians(double deciradians)
#else
        public static Angle FromDeciradians(QuantityValue deciradians)
#endif
        {
            double value = (double) deciradians;
            return new Angle(value, AngleUnit.Deciradian);
        }

        /// <summary>
        ///     Get Angle from Degrees.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromDegrees(double degrees)
#else
        public static Angle FromDegrees(QuantityValue degrees)
#endif
        {
            double value = (double) degrees;
            return new Angle(value, AngleUnit.Degree);
        }

        /// <summary>
        ///     Get Angle from Gradians.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromGradians(double gradians)
#else
        public static Angle FromGradians(QuantityValue gradians)
#endif
        {
            double value = (double) gradians;
            return new Angle(value, AngleUnit.Gradian);
        }

        /// <summary>
        ///     Get Angle from Microdegrees.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromMicrodegrees(double microdegrees)
#else
        public static Angle FromMicrodegrees(QuantityValue microdegrees)
#endif
        {
            double value = (double) microdegrees;
            return new Angle(value, AngleUnit.Microdegree);
        }

        /// <summary>
        ///     Get Angle from Microradians.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromMicroradians(double microradians)
#else
        public static Angle FromMicroradians(QuantityValue microradians)
#endif
        {
            double value = (double) microradians;
            return new Angle(value, AngleUnit.Microradian);
        }

        /// <summary>
        ///     Get Angle from Millidegrees.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromMillidegrees(double millidegrees)
#else
        public static Angle FromMillidegrees(QuantityValue millidegrees)
#endif
        {
            double value = (double) millidegrees;
            return new Angle(value, AngleUnit.Millidegree);
        }

        /// <summary>
        ///     Get Angle from Milliradians.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromMilliradians(double milliradians)
#else
        public static Angle FromMilliradians(QuantityValue milliradians)
#endif
        {
            double value = (double) milliradians;
            return new Angle(value, AngleUnit.Milliradian);
        }

        /// <summary>
        ///     Get Angle from Nanodegrees.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromNanodegrees(double nanodegrees)
#else
        public static Angle FromNanodegrees(QuantityValue nanodegrees)
#endif
        {
            double value = (double) nanodegrees;
            return new Angle(value, AngleUnit.Nanodegree);
        }

        /// <summary>
        ///     Get Angle from Nanoradians.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromNanoradians(double nanoradians)
#else
        public static Angle FromNanoradians(QuantityValue nanoradians)
#endif
        {
            double value = (double) nanoradians;
            return new Angle(value, AngleUnit.Nanoradian);
        }

        /// <summary>
        ///     Get Angle from Radians.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromRadians(double radians)
#else
        public static Angle FromRadians(QuantityValue radians)
#endif
        {
            double value = (double) radians;
            return new Angle(value, AngleUnit.Radian);
        }

        /// <summary>
        ///     Get Angle from Revolutions.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Angle FromRevolutions(double revolutions)
#else
        public static Angle FromRevolutions(QuantityValue revolutions)
#endif
        {
            double value = (double) revolutions;
            return new Angle(value, AngleUnit.Revolution);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="AngleUnit" /> to <see cref="Angle" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Angle unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Angle From(double value, AngleUnit fromUnit)
#else
        public static Angle From(QuantityValue value, AngleUnit fromUnit)
#endif
        {
            return new Angle((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(AngleUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Angle)) throw new ArgumentException("Expected type Angle.", nameof(obj));

            return CompareTo((Angle)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(Angle other)
        {
            if(other is null)
                throw new ArgumentNullException(nameof(other));

            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Angle within the given absolute or relative tolerance.
        ///     </para>
        ///     <para>
        ///     Relative tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a percentage of this quantity's value. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison. A relative tolerance of 0.01 means the absolute difference must be within +/- 1% of
        ///     this quantity's value to be considered equal.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within +/- 1% of a (0.02m or 2cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Relative);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Absolute tolerance is defined as the maximum allowable absolute difference between this quantity's value and
        ///     <paramref name="other"/> as a fixed number in this quantity's unit. <paramref name="other"/> will be converted into
        ///     this quantity's unit for comparison.
        ///     <example>
        ///     In this example, the two quantities will be equal if the value of b is within 0.01 of a (0.01m or 1cm).
        ///     <code>
        ///     var a = Length.FromMeters(2.0);
        ///     var b = Length.FromInches(50.0);
        ///     a.Equals(b, 0.01, ComparisonType.Absolute);
        ///     </code>
        ///     </example>
        ///     </para>
        ///     <para>
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        ///     </para>
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The absolute or relative tolerance value. Must be greater than or equal to 0.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the absolute difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(Angle other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current Angle.</returns>
        public override int GetHashCode()
        {
            return new { Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(AngleUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this Angle to another Angle with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Angle with the specified unit.</returns>
        public Angle ToUnit(AngleUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Angle(convertedValue, unit);
        }

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnit()
        {
            switch(Unit)
            {
                case AngleUnit.Arcminute: return _value/60;
                case AngleUnit.Arcsecond: return _value/3600;
                case AngleUnit.Centiradian: return (_value*180/Math.PI) * 1e-2d;
                case AngleUnit.Deciradian: return (_value*180/Math.PI) * 1e-1d;
                case AngleUnit.Degree: return _value;
                case AngleUnit.Gradian: return _value*0.9;
                case AngleUnit.Microdegree: return (_value) * 1e-6d;
                case AngleUnit.Microradian: return (_value*180/Math.PI) * 1e-6d;
                case AngleUnit.Millidegree: return (_value) * 1e-3d;
                case AngleUnit.Milliradian: return (_value*180/Math.PI) * 1e-3d;
                case AngleUnit.Nanodegree: return (_value) * 1e-9d;
                case AngleUnit.Nanoradian: return (_value*180/Math.PI) * 1e-9d;
                case AngleUnit.Radian: return _value*180/Math.PI;
                case AngleUnit.Revolution: return _value*360;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(AngleUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case AngleUnit.Arcminute: return baseUnitValue*60;
                case AngleUnit.Arcsecond: return baseUnitValue*3600;
                case AngleUnit.Centiradian: return (baseUnitValue/180*Math.PI) / 1e-2d;
                case AngleUnit.Deciradian: return (baseUnitValue/180*Math.PI) / 1e-1d;
                case AngleUnit.Degree: return baseUnitValue;
                case AngleUnit.Gradian: return baseUnitValue/0.9;
                case AngleUnit.Microdegree: return (baseUnitValue) / 1e-6d;
                case AngleUnit.Microradian: return (baseUnitValue/180*Math.PI) / 1e-6d;
                case AngleUnit.Millidegree: return (baseUnitValue) / 1e-3d;
                case AngleUnit.Milliradian: return (baseUnitValue/180*Math.PI) / 1e-3d;
                case AngleUnit.Nanodegree: return (baseUnitValue) / 1e-9d;
                case AngleUnit.Nanoradian: return (baseUnitValue/180*Math.PI) / 1e-9d;
                case AngleUnit.Radian: return baseUnitValue/180*Math.PI;
                case AngleUnit.Revolution: return baseUnitValue/360;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="ArgumentException">
        ///     Expected string to have one or two pairs of quantity and unit in the format
        ///     "&lt;quantity&gt; &lt;unit&gt;". Eg. "5.5 m" or "1ft 2in"
        /// </exception>
        /// <exception cref="AmbiguousUnitParseException">
        ///     More than one unit is represented by the specified unit abbreviation.
        ///     Example: Volume.Parse("1 cup") will throw, because it can refer to any of
        ///     <see cref="VolumeUnit.MetricCup" />, <see cref="VolumeUnit.UsLegalCup" /> and <see cref="VolumeUnit.UsCustomaryCup" />.
        /// </exception>
        /// <exception cref="UnitsNetException">
        ///     If anything else goes wrong, typically due to a bug or unhandled case.
        ///     We wrap exceptions in <see cref="UnitsNetException" /> to allow you to distinguish
        ///     Units.NET exceptions from other exceptions.
        /// </exception>
        public static Angle Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out Angle result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static AngleUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        #endregion

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(Unit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(AngleUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of Angle
        /// </summary>
        public static Angle MaxValue => new Angle(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Angle
        /// </summary>
        public static Angle MinValue => new Angle(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Angle.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Angle.BaseDimensions;
    }
}
