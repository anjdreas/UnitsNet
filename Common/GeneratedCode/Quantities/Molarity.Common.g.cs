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
    ///     Molar concentration, also called molarity, amount concentration or substance concentration, is a measure of the concentration of a solute in a solution, or of any chemical species, in terms of amount of substance in a given volume. 
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class Molarity : IQuantity
#else
    public partial struct Molarity : IQuantity, IComparable, IComparable<Molarity>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MolarityUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public MolarityUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static Molarity()
        {
            BaseDimensions = new BaseDimensions(-3, 0, 0, 0, 0, 1, 0);
        }

        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public Molarity(double molespercubicmeter)
        {
            _value = Convert.ToDouble(molespercubicmeter);
            _unit = BaseUnit;
        }

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="numericValue">Numeric value.</param>
        /// <param name="unit">Unit representation.</param>
        /// <remarks>Value parameter cannot be named 'value' due to constraint when targeting Windows Runtime Component.</remarks>
#if WINDOWS_UWP
        private
#else
        public 
#endif
        Molarity(double numericValue, MolarityUnit unit)
        {
            _value = numericValue;
            _unit = unit;
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit MolesPerCubicMeter.
        /// </summary>
        /// <param name="molespercubicmeter">Value assuming base unit MolesPerCubicMeter.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        Molarity(long molespercubicmeter) : this(Convert.ToDouble(molespercubicmeter), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit MolesPerCubicMeter.
        /// </summary>
        /// <param name="molespercubicmeter">Value assuming base unit MolesPerCubicMeter.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        Molarity(decimal molespercubicmeter) : this(Convert.ToDouble(molespercubicmeter), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.Molarity;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static MolarityUnit BaseUnit => MolarityUnit.MolesPerCubicMeter;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the Molarity quantity.
        /// </summary>
        public static MolarityUnit[] Units { get; } = Enum.GetValues(typeof(MolarityUnit)).Cast<MolarityUnit>().ToArray();

        /// <summary>
        ///     Get Molarity in CentimolesPerLiter.
        /// </summary>
        public double CentimolesPerLiter => As(MolarityUnit.CentimolesPerLiter);

        /// <summary>
        ///     Get Molarity in DecimolesPerLiter.
        /// </summary>
        public double DecimolesPerLiter => As(MolarityUnit.DecimolesPerLiter);

        /// <summary>
        ///     Get Molarity in MicromolesPerLiter.
        /// </summary>
        public double MicromolesPerLiter => As(MolarityUnit.MicromolesPerLiter);

        /// <summary>
        ///     Get Molarity in MillimolesPerLiter.
        /// </summary>
        public double MillimolesPerLiter => As(MolarityUnit.MillimolesPerLiter);

        /// <summary>
        ///     Get Molarity in MolesPerCubicMeter.
        /// </summary>
        public double MolesPerCubicMeter => As(MolarityUnit.MolesPerCubicMeter);

        /// <summary>
        ///     Get Molarity in MolesPerLiter.
        /// </summary>
        public double MolesPerLiter => As(MolarityUnit.MolesPerLiter);

        /// <summary>
        ///     Get Molarity in NanomolesPerLiter.
        /// </summary>
        public double NanomolesPerLiter => As(MolarityUnit.NanomolesPerLiter);

        /// <summary>
        ///     Get Molarity in PicomolesPerLiter.
        /// </summary>
        public double PicomolesPerLiter => As(MolarityUnit.PicomolesPerLiter);

        #endregion

        #region Static

        public static Molarity Zero => new Molarity(0, BaseUnit);

        /// <summary>
        ///     Get Molarity from CentimolesPerLiter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromCentimolesPerLiter(double centimolesperliter)
#else
        public static Molarity FromCentimolesPerLiter(QuantityValue centimolesperliter)
#endif
        {
            double value = (double) centimolesperliter;
            return new Molarity(value, MolarityUnit.CentimolesPerLiter);
        }

        /// <summary>
        ///     Get Molarity from DecimolesPerLiter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromDecimolesPerLiter(double decimolesperliter)
#else
        public static Molarity FromDecimolesPerLiter(QuantityValue decimolesperliter)
#endif
        {
            double value = (double) decimolesperliter;
            return new Molarity(value, MolarityUnit.DecimolesPerLiter);
        }

        /// <summary>
        ///     Get Molarity from MicromolesPerLiter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromMicromolesPerLiter(double micromolesperliter)
#else
        public static Molarity FromMicromolesPerLiter(QuantityValue micromolesperliter)
#endif
        {
            double value = (double) micromolesperliter;
            return new Molarity(value, MolarityUnit.MicromolesPerLiter);
        }

        /// <summary>
        ///     Get Molarity from MillimolesPerLiter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromMillimolesPerLiter(double millimolesperliter)
#else
        public static Molarity FromMillimolesPerLiter(QuantityValue millimolesperliter)
#endif
        {
            double value = (double) millimolesperliter;
            return new Molarity(value, MolarityUnit.MillimolesPerLiter);
        }

        /// <summary>
        ///     Get Molarity from MolesPerCubicMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromMolesPerCubicMeter(double molespercubicmeter)
#else
        public static Molarity FromMolesPerCubicMeter(QuantityValue molespercubicmeter)
#endif
        {
            double value = (double) molespercubicmeter;
            return new Molarity(value, MolarityUnit.MolesPerCubicMeter);
        }

        /// <summary>
        ///     Get Molarity from MolesPerLiter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromMolesPerLiter(double molesperliter)
#else
        public static Molarity FromMolesPerLiter(QuantityValue molesperliter)
#endif
        {
            double value = (double) molesperliter;
            return new Molarity(value, MolarityUnit.MolesPerLiter);
        }

        /// <summary>
        ///     Get Molarity from NanomolesPerLiter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromNanomolesPerLiter(double nanomolesperliter)
#else
        public static Molarity FromNanomolesPerLiter(QuantityValue nanomolesperliter)
#endif
        {
            double value = (double) nanomolesperliter;
            return new Molarity(value, MolarityUnit.NanomolesPerLiter);
        }

        /// <summary>
        ///     Get Molarity from PicomolesPerLiter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static Molarity FromPicomolesPerLiter(double picomolesperliter)
#else
        public static Molarity FromPicomolesPerLiter(QuantityValue picomolesperliter)
#endif
        {
            double value = (double) picomolesperliter;
            return new Molarity(value, MolarityUnit.PicomolesPerLiter);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarityUnit" /> to <see cref="Molarity" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Molarity unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static Molarity From(double value, MolarityUnit fromUnit)
#else
        public static Molarity From(QuantityValue value, MolarityUnit fromUnit)
#endif
        {
            return new Molarity((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(MolarityUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use for localization. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(
          MolarityUnit unit,
#if WINDOWS_UWP
          [CanBeNull] string cultureName)
#else
          [CanBeNull] IFormatProvider provider)
#endif
        {
#if WINDOWS_UWP
            // Windows Runtime Component does not support CultureInfo and IFormatProvider types, so we use culture name for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
            IFormatProvider provider = cultureName == null ? UnitSystem.DefaultCulture : new CultureInfo(cultureName);
#else
            provider = provider ?? UnitSystem.DefaultCulture;
#endif

            return UnitSystem.GetCached(provider).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is Molarity)) throw new ArgumentException("Expected type Molarity.", nameof(obj));

            return CompareTo((Molarity)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(Molarity other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals($quantityName, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is Molarity))
                return false;

            var objQuantity = (Molarity)obj;
            return _value.Equals(objQuantity.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another Molarity within the given absolute or relative tolerance.
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
        public bool Equals(Molarity other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Compare equality to another Molarity by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        [Obsolete("Please use the Equals(Molarity, double, ComparisonType) overload. This method will be removed in a future version.")]
        public bool Equals(Molarity other, Molarity maxError)
        {
            return Math.Abs(_value - other.AsBaseNumericType(this.Unit)) <= maxError.AsBaseNumericType(this.Unit);
        }

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
        public double As(MolarityUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this Molarity to another Molarity with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Molarity with the specified unit.</returns>
        public Molarity ToUnit(MolarityUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new Molarity(convertedValue, unit);
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
                case MolarityUnit.CentimolesPerLiter: return (_value/1e-3) * 1e-2d;
                case MolarityUnit.DecimolesPerLiter: return (_value/1e-3) * 1e-1d;
                case MolarityUnit.MicromolesPerLiter: return (_value/1e-3) * 1e-6d;
                case MolarityUnit.MillimolesPerLiter: return (_value/1e-3) * 1e-3d;
                case MolarityUnit.MolesPerCubicMeter: return _value;
                case MolarityUnit.MolesPerLiter: return _value/1e-3;
                case MolarityUnit.NanomolesPerLiter: return (_value/1e-3) * 1e-9d;
                case MolarityUnit.PicomolesPerLiter: return (_value/1e-3) * 1e-12d;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(MolarityUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case MolarityUnit.CentimolesPerLiter: return (baseUnitValue*1e-3) / 1e-2d;
                case MolarityUnit.DecimolesPerLiter: return (baseUnitValue*1e-3) / 1e-1d;
                case MolarityUnit.MicromolesPerLiter: return (baseUnitValue*1e-3) / 1e-6d;
                case MolarityUnit.MillimolesPerLiter: return (baseUnitValue*1e-3) / 1e-3d;
                case MolarityUnit.MolesPerCubicMeter: return baseUnitValue;
                case MolarityUnit.MolesPerLiter: return baseUnitValue*1e-3;
                case MolarityUnit.NanomolesPerLiter: return (baseUnitValue*1e-3) / 1e-9d;
                case MolarityUnit.PicomolesPerLiter: return (baseUnitValue*1e-3) / 1e-12d;
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
        public static Molarity Parse(string str)
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
        public static bool TryParse([CanBeNull] string str, out Molarity result)
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
        public static MolarityUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        [Obsolete("Use overload that takes IFormatProvider instead of culture name. This method was only added to support WindowsRuntimeComponent and will be removed from other .NET targets.")]
        public static MolarityUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        #endregion

        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        /// <summary>
        ///     Set the default unit used by ToString(). Default is MolesPerCubicMeter
        /// </summary>
        public static MolarityUnit ToStringDefaultUnit { get; set; } = MolarityUnit.MolesPerCubicMeter;

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
        public string ToString(MolarityUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of Molarity
        /// </summary>
        public static Molarity MaxValue => new Molarity(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Molarity
        /// </summary>
        public static Molarity MinValue => new Molarity(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => Molarity.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => Molarity.BaseDimensions;
    }
}
