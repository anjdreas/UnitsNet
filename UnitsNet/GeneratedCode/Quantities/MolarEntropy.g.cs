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
    ///     Molar entropy is amount of energy required to increase temperature of 1 mole substance by 1 Kelvin.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class MolarEntropy
#else
    public partial struct MolarEntropy : IComparable, IComparable<MolarEntropy>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MolarEntropyUnit? _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
#if WINDOWS_UWP
        public double Value => Convert.ToDouble(_value);
#else
        public double Value => _value;
#endif

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public MolarEntropyUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        // Windows Runtime Component requires a default constructor
#if WINDOWS_UWP
        public MolarEntropy()
        {
            _value = 0;
            _unit = BaseUnit;
        }
#endif

        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public MolarEntropy(double joulespermolekelvin)
        {
            _value = Convert.ToDouble(joulespermolekelvin);
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
          MolarEntropy(double numericValue, MolarEntropyUnit unit)
        {
            _value = numericValue;
            _unit = unit;
         }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit JoulePerMoleKelvin.
        /// </summary>
        /// <param name="joulespermolekelvin">Value assuming base unit JoulePerMoleKelvin.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        MolarEntropy(long joulespermolekelvin) : this(Convert.ToDouble(joulespermolekelvin), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit JoulePerMoleKelvin.
        /// </summary>
        /// <param name="joulespermolekelvin">Value assuming base unit JoulePerMoleKelvin.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        MolarEntropy(decimal joulespermolekelvin) : this(Convert.ToDouble(joulespermolekelvin), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.MolarEntropy;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static MolarEntropyUnit BaseUnit => MolarEntropyUnit.JoulePerMoleKelvin;

        /// <summary>
        ///     All units of measurement for the MolarEntropy quantity.
        /// </summary>
        public static MolarEntropyUnit[] Units { get; } = Enum.GetValues(typeof(MolarEntropyUnit)).Cast<MolarEntropyUnit>().ToArray();
        /// <summary>
        ///     Get MolarEntropy in JoulesPerMoleKelvin.
        /// </summary>
        public double JoulesPerMoleKelvin => As(MolarEntropyUnit.JoulePerMoleKelvin);
        /// <summary>
        ///     Get MolarEntropy in KilojoulesPerMoleKelvin.
        /// </summary>
        public double KilojoulesPerMoleKelvin => As(MolarEntropyUnit.KilojoulePerMoleKelvin);
        /// <summary>
        ///     Get MolarEntropy in MegajoulesPerMoleKelvin.
        /// </summary>
        public double MegajoulesPerMoleKelvin => As(MolarEntropyUnit.MegajoulePerMoleKelvin);

        #endregion

        #region Static

        public static MolarEntropy Zero => new MolarEntropy(0, BaseUnit);

        /// <summary>
        ///     Get MolarEntropy from JoulesPerMoleKelvin.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarEntropy FromJoulesPerMoleKelvin(double joulespermolekelvin)
#else
        public static MolarEntropy FromJoulesPerMoleKelvin(QuantityValue joulespermolekelvin)
#endif
        {
            double value = (double) joulespermolekelvin;
            return new MolarEntropy(value, MolarEntropyUnit.JoulePerMoleKelvin);
        }

        /// <summary>
        ///     Get MolarEntropy from KilojoulesPerMoleKelvin.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarEntropy FromKilojoulesPerMoleKelvin(double kilojoulespermolekelvin)
#else
        public static MolarEntropy FromKilojoulesPerMoleKelvin(QuantityValue kilojoulespermolekelvin)
#endif
        {
            double value = (double) kilojoulespermolekelvin;
            return new MolarEntropy(value, MolarEntropyUnit.KilojoulePerMoleKelvin);
        }

        /// <summary>
        ///     Get MolarEntropy from MegajoulesPerMoleKelvin.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static MolarEntropy FromMegajoulesPerMoleKelvin(double megajoulespermolekelvin)
#else
        public static MolarEntropy FromMegajoulesPerMoleKelvin(QuantityValue megajoulespermolekelvin)
#endif
        {
            double value = (double) megajoulespermolekelvin;
            return new MolarEntropy(value, MolarEntropyUnit.MegajoulePerMoleKelvin);
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable MolarEntropy from nullable JoulesPerMoleKelvin.
        /// </summary>
        public static MolarEntropy? FromJoulesPerMoleKelvin(QuantityValue? joulespermolekelvin)
        {
            if (joulespermolekelvin.HasValue)
            {
                return FromJoulesPerMoleKelvin(joulespermolekelvin.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEntropy from nullable KilojoulesPerMoleKelvin.
        /// </summary>
        public static MolarEntropy? FromKilojoulesPerMoleKelvin(QuantityValue? kilojoulespermolekelvin)
        {
            if (kilojoulespermolekelvin.HasValue)
            {
                return FromKilojoulesPerMoleKelvin(kilojoulespermolekelvin.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable MolarEntropy from nullable MegajoulesPerMoleKelvin.
        /// </summary>
        public static MolarEntropy? FromMegajoulesPerMoleKelvin(QuantityValue? megajoulespermolekelvin)
        {
            if (megajoulespermolekelvin.HasValue)
            {
                return FromMegajoulesPerMoleKelvin(megajoulespermolekelvin.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarEntropyUnit" /> to <see cref="MolarEntropy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MolarEntropy unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static MolarEntropy From(double value, MolarEntropyUnit fromUnit)
#else
        public static MolarEntropy From(QuantityValue value, MolarEntropyUnit fromUnit)
#endif
        {
            return new MolarEntropy((double)value, fromUnit);
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MolarEntropyUnit" /> to <see cref="MolarEntropy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MolarEntropy unit value.</returns>
        public static MolarEntropy? From(QuantityValue? value, MolarEntropyUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }

            return new MolarEntropy((double)value.Value, fromUnit);
        }
#endif

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(MolarEntropyUnit unit)
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
          MolarEntropyUnit unit,
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

        #region Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static MolarEntropy operator -(MolarEntropy right)
        {
            return new MolarEntropy(-right.Value, right.Unit);
        }

        public static MolarEntropy operator +(MolarEntropy left, MolarEntropy right)
        {
            return new MolarEntropy(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static MolarEntropy operator -(MolarEntropy left, MolarEntropy right)
        {
            return new MolarEntropy(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static MolarEntropy operator *(double left, MolarEntropy right)
        {
            return new MolarEntropy(left * right.Value, right.Unit);
        }

        public static MolarEntropy operator *(MolarEntropy left, double right)
        {
            return new MolarEntropy(left.Value * right, left.Unit);
        }

        public static MolarEntropy operator /(MolarEntropy left, double right)
        {
            return new MolarEntropy(left.Value / right, left.Unit);
        }

        public static double operator /(MolarEntropy left, MolarEntropy right)
        {
            return left.JoulesPerMoleKelvin / right.JoulesPerMoleKelvin;
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is MolarEntropy)) throw new ArgumentException("Expected type MolarEntropy.", "obj");
            return CompareTo((MolarEntropy) obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(MolarEntropy other)
        {
            return AsBaseUnitJoulesPerMoleKelvin().CompareTo(other.AsBaseUnitJoulesPerMoleKelvin());
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static bool operator <=(MolarEntropy left, MolarEntropy right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(MolarEntropy left, MolarEntropy right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(MolarEntropy left, MolarEntropy right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(MolarEntropy left, MolarEntropy right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(MolarEntropy left, MolarEntropy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(MolarEntropy left, MolarEntropy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
#endif

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return AsBaseUnitJoulesPerMoleKelvin().Equals(((MolarEntropy) obj).AsBaseUnitJoulesPerMoleKelvin());
        }

        /// <summary>
        ///     Compare equality to another MolarEntropy within the given absolute or relative tolerance.
        ///     Relative tolerance is when the difference between the two quantities is not greater than the scale of the values compared to the tolerance.
        ///     If using relative tolerance, this quantity's value will be what the relative tolerance will be calculated against.
        ///     Absolute tolerance is when the difference between the two quantities is not greater than exactly the tolerance value.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">The other quantity to compare to.</param>
        /// <param name="tolerance">The comparison tolerance.</param>
        /// <param name="comparisonType">The comparison type: either relative or absolute.</param>
        /// <returns>True if the difference between the two values is not greater than the specified relative or absolute tolerance.</returns>
        public bool Equals(MolarEntropy other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Compare equality to another MolarEntropy by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        public bool Equals(MolarEntropy other, MolarEntropy maxError)
        {
            return Math.Abs(AsBaseUnitJoulesPerMoleKelvin() - other.AsBaseUnitJoulesPerMoleKelvin()) <= maxError.AsBaseUnitJoulesPerMoleKelvin();
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
        public double As(MolarEntropyUnit unit)
        {
            if (Unit == unit)
            {
                return (double)Value;
            }

            double baseUnitValue = AsBaseUnitJoulesPerMoleKelvin();

            switch (unit)
            {
                case MolarEntropyUnit.JoulePerMoleKelvin: return baseUnitValue;
                case MolarEntropyUnit.KilojoulePerMoleKelvin: return (baseUnitValue) / 1e3d;
                case MolarEntropyUnit.MegajoulePerMoleKelvin: return (baseUnitValue) / 1e6d;

                default:
                    throw new NotImplementedException("unit: " + unit);
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
        public static MolarEntropy Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
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
        public static MolarEntropy Parse(
            string str,
#if WINDOWS_UWP
            [CanBeNull] string cultureName)
#else
            [CanBeNull] IFormatProvider provider)
#endif
        {
            if (str == null) throw new ArgumentNullException("str");

#if WINDOWS_UWP
            // Windows Runtime Component does not support CultureInfo and IFormatProvider types, so we use culture name for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
            IFormatProvider provider = cultureName == null ? UnitSystem.DefaultCulture : new CultureInfo(cultureName);
#else
            provider = provider ?? UnitSystem.DefaultCulture;
#endif

            return QuantityParser.Parse<MolarEntropy, MolarEntropyUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    MolarEntropyUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromJoulesPerMoleKelvin(x.JoulesPerMoleKelvin + y.JoulesPerMoleKelvin));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out MolarEntropy result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use when parsing number and unit. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse(
            [CanBeNull] string str,
#if WINDOWS_UWP
            [CanBeNull] string cultureName,
#else
            [CanBeNull] IFormatProvider provider,
#endif
          out MolarEntropy result)
        {
#if WINDOWS_UWP
            // Windows Runtime Component does not support CultureInfo and IFormatProvider types, so we use culture name for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
            IFormatProvider provider = cultureName == null ? UnitSystem.DefaultCulture : new CultureInfo(cultureName);
#else
            provider = provider ?? UnitSystem.DefaultCulture;
#endif
            try
            {

                result = Parse(
                  str,
#if WINDOWS_UWP
                  cultureName);
#else
                  provider);
#endif

                return true;
            }
            catch
            {
                result = default(MolarEntropy);
                return false;
            }
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
        public static MolarEntropyUnit ParseUnit(string str)
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
        public static MolarEntropyUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        static MolarEntropyUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(provider);
            var unit = unitSystem.Parse<MolarEntropyUnit>(str.Trim());

            if (unit == MolarEntropyUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized MolarEntropyUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        /// <summary>
        ///     Set the default unit used by ToString(). Default is JoulePerMoleKelvin
        /// </summary>
        public static MolarEntropyUnit ToStringDefaultUnit { get; set; } = MolarEntropyUnit.JoulePerMoleKelvin;

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
        public string ToString(MolarEntropyUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <returns>String representation.</returns>
        public string ToString(
          MolarEntropyUnit unit,
#if WINDOWS_UWP
            [CanBeNull] string cultureName)
#else
            [CanBeNull] IFormatProvider provider)
#endif
        {
            return ToString(
              unit,
#if WINDOWS_UWP
              cultureName,
#else
              provider,
#endif
              2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(
            MolarEntropyUnit unit,
#if WINDOWS_UWP
            [CanBeNull] string cultureName,
#else
            [CanBeNull] IFormatProvider provider,
#endif
            int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(
              unit,
#if WINDOWS_UWP
              cultureName,
#else
              provider,
#endif
              format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
#if WINDOWS_UWP
        /// <param name="cultureName">Name of culture (ex: "en-US") to use for localization and number formatting. Defaults to <see cref="UnitSystem" />'s default culture.</param>
#else
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
#endif
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(
            MolarEntropyUnit unit,
#if WINDOWS_UWP
            [CanBeNull] string cultureName,
#else
            [CanBeNull] IFormatProvider provider,
#endif
            [NotNull] string format,
            [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

#if WINDOWS_UWP
            // Windows Runtime Component does not support CultureInfo and IFormatProvider types, so we use culture name for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
            IFormatProvider provider = cultureName == null ? UnitSystem.DefaultCulture : new CultureInfo(cultureName);
#else
            provider = provider ?? UnitSystem.DefaultCulture;
#endif

            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        /// <summary>
        /// Represents the largest possible value of MolarEntropy
        /// </summary>
        public static MolarEntropy MaxValue => new MolarEntropy(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of MolarEntropy
        /// </summary>
        public static MolarEntropy MinValue => new MolarEntropy(double.MinValue, BaseUnit);

        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double AsBaseUnitJoulesPerMoleKelvin()
        {
			if (Unit == MolarEntropyUnit.JoulePerMoleKelvin) { return _value; }

            switch (Unit)
            {
                case MolarEntropyUnit.JoulePerMoleKelvin: return _value;
                case MolarEntropyUnit.KilojoulePerMoleKelvin: return (_value) * 1e3d;
                case MolarEntropyUnit.MegajoulePerMoleKelvin: return (_value) * 1e6d;
                default:
                    throw new NotImplementedException("Unit not implemented: " + Unit);
			}
		}

		/// <summary>Convenience method for working with internal numeric type.</summary>
        private double AsBaseNumericType(MolarEntropyUnit unit) => Convert.ToDouble(As(unit));
	}
}
