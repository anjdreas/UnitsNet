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
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
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

// Windows Runtime Component does not support CultureInfo type, so use culture name string instead for public methods: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
using Culture = System.String;
#else
using Culture = System.IFormatProvider;
#endif

// ReSharper disable once CheckNamespace

namespace UnitsNet
{
    /// <summary>
    ///     A unit for expressing the integral of apparent power over time, equal to the product of 1 volt-ampere and 1 hour, or to 3600 joules.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class ApparentEnergy
#else
    public partial struct ApparentEnergy : IComparable, IComparable<ApparentEnergy>
#endif
    {
        /// <summary>
        ///     Base unit of ApparentEnergy.
        /// </summary>
        private readonly double _voltampereHours;

        // Windows Runtime Component requires a default constructor
#if WINDOWS_UWP
        public ApparentEnergy() : this(0)
        {
        }
#endif

        public ApparentEnergy(double voltamperehours)
        {
            _voltampereHours = Convert.ToDouble(voltamperehours);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        private
#else
        public
#endif
        ApparentEnergy(long voltamperehours)
        {
            _voltampereHours = Convert.ToDouble(voltamperehours);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
#if WINDOWS_UWP
        private
#else
        public
#endif
        ApparentEnergy(decimal voltamperehours)
        {
            _voltampereHours = Convert.ToDouble(voltamperehours);
        }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.ApparentEnergy;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static ApparentEnergyUnit BaseUnit
        {
            get { return ApparentEnergyUnit.VoltampereHour; }
        }

        /// <summary>
        ///     All units of measurement for the ApparentEnergy quantity.
        /// </summary>
        public static ApparentEnergyUnit[] Units { get; } = Enum.GetValues(typeof(ApparentEnergyUnit)).Cast<ApparentEnergyUnit>().ToArray();

        /// <summary>
        ///     Get ApparentEnergy in KilovoltampereHours.
        /// </summary>
        public double KilovoltampereHours
        {
            get { return (_voltampereHours) / 1e3d; }
        }

        /// <summary>
        ///     Get ApparentEnergy in MegavoltampereHours.
        /// </summary>
        public double MegavoltampereHours
        {
            get { return (_voltampereHours) / 1e6d; }
        }

        /// <summary>
        ///     Get ApparentEnergy in VoltampereHours.
        /// </summary>
        public double VoltampereHours
        {
            get { return _voltampereHours; }
        }

        #endregion

        #region Static

        public static ApparentEnergy Zero
        {
            get { return new ApparentEnergy(); }
        }

        /// <summary>
        ///     Get ApparentEnergy from KilovoltampereHours.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ApparentEnergy FromKilovoltampereHours(double kilovoltamperehours)
        {
            double value = (double) kilovoltamperehours;
            return new ApparentEnergy((value) * 1e3d);
        }
#else
        public static ApparentEnergy FromKilovoltampereHours(QuantityValue kilovoltamperehours)
        {
            double value = (double) kilovoltamperehours;
            return new ApparentEnergy(((value) * 1e3d));
        }
#endif

        /// <summary>
        ///     Get ApparentEnergy from MegavoltampereHours.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ApparentEnergy FromMegavoltampereHours(double megavoltamperehours)
        {
            double value = (double) megavoltamperehours;
            return new ApparentEnergy((value) * 1e6d);
        }
#else
        public static ApparentEnergy FromMegavoltampereHours(QuantityValue megavoltamperehours)
        {
            double value = (double) megavoltamperehours;
            return new ApparentEnergy(((value) * 1e6d));
        }
#endif

        /// <summary>
        ///     Get ApparentEnergy from VoltampereHours.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static ApparentEnergy FromVoltampereHours(double voltamperehours)
        {
            double value = (double) voltamperehours;
            return new ApparentEnergy(value);
        }
#else
        public static ApparentEnergy FromVoltampereHours(QuantityValue voltamperehours)
        {
            double value = (double) voltamperehours;
            return new ApparentEnergy((value));
        }
#endif

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Get nullable ApparentEnergy from nullable KilovoltampereHours.
        /// </summary>
        public static ApparentEnergy? FromKilovoltampereHours(QuantityValue? kilovoltamperehours)
        {
            if (kilovoltamperehours.HasValue)
            {
                return FromKilovoltampereHours(kilovoltamperehours.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ApparentEnergy from nullable MegavoltampereHours.
        /// </summary>
        public static ApparentEnergy? FromMegavoltampereHours(QuantityValue? megavoltamperehours)
        {
            if (megavoltamperehours.HasValue)
            {
                return FromMegavoltampereHours(megavoltamperehours.Value);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        ///     Get nullable ApparentEnergy from nullable VoltampereHours.
        /// </summary>
        public static ApparentEnergy? FromVoltampereHours(QuantityValue? voltamperehours)
        {
            if (voltamperehours.HasValue)
            {
                return FromVoltampereHours(voltamperehours.Value);
            }
            else
            {
                return null;
            }
        }

#endif

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ApparentEnergyUnit" /> to <see cref="ApparentEnergy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ApparentEnergy unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static ApparentEnergy From(double value, ApparentEnergyUnit fromUnit)
#else
        public static ApparentEnergy From(QuantityValue value, ApparentEnergyUnit fromUnit)
#endif
        {
            switch (fromUnit)
            {
                case ApparentEnergyUnit.KilovoltampereHour:
                    return FromKilovoltampereHours(value);
                case ApparentEnergyUnit.MegavoltampereHour:
                    return FromMegavoltampereHours(value);
                case ApparentEnergyUnit.VoltampereHour:
                    return FromVoltampereHours(value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }

        // Windows Runtime Component does not support nullable types (double?): https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ApparentEnergyUnit" /> to <see cref="ApparentEnergy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ApparentEnergy unit value.</returns>
        public static ApparentEnergy? From(QuantityValue? value, ApparentEnergyUnit fromUnit)
        {
            if (!value.HasValue)
            {
                return null;
            }
            switch (fromUnit)
            {
                case ApparentEnergyUnit.KilovoltampereHour:
                    return FromKilovoltampereHours(value.Value);
                case ApparentEnergyUnit.MegavoltampereHour:
                    return FromMegavoltampereHours(value.Value);
                case ApparentEnergyUnit.VoltampereHour:
                    return FromVoltampereHours(value.Value);

                default:
                    throw new NotImplementedException("fromUnit: " + fromUnit);
            }
        }
#endif

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(ApparentEnergyUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <param name="culture">Culture to use for localization. Defaults to Thread.CurrentUICulture.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(ApparentEnergyUnit unit, [CanBeNull] Culture culture)
        {
            return UnitSystem.GetCached(culture).GetDefaultAbbreviation(unit);
        }

        #endregion

        #region Arithmetic Operators

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static ApparentEnergy operator -(ApparentEnergy right)
        {
            return new ApparentEnergy(-right._voltampereHours);
        }

        public static ApparentEnergy operator +(ApparentEnergy left, ApparentEnergy right)
        {
            return new ApparentEnergy(left._voltampereHours + right._voltampereHours);
        }

        public static ApparentEnergy operator -(ApparentEnergy left, ApparentEnergy right)
        {
            return new ApparentEnergy(left._voltampereHours - right._voltampereHours);
        }

        public static ApparentEnergy operator *(double left, ApparentEnergy right)
        {
            return new ApparentEnergy(left*right._voltampereHours);
        }

        public static ApparentEnergy operator *(ApparentEnergy left, double right)
        {
            return new ApparentEnergy(left._voltampereHours*(double)right);
        }

        public static ApparentEnergy operator /(ApparentEnergy left, double right)
        {
            return new ApparentEnergy(left._voltampereHours/(double)right);
        }

        public static double operator /(ApparentEnergy left, ApparentEnergy right)
        {
            return Convert.ToDouble(left._voltampereHours/right._voltampereHours);
        }
#endif

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if (obj == null) throw new ArgumentNullException("obj");
            if (!(obj is ApparentEnergy)) throw new ArgumentException("Expected type ApparentEnergy.", "obj");
            return CompareTo((ApparentEnergy) obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(ApparentEnergy other)
        {
            return _voltampereHours.CompareTo(other._voltampereHours);
        }

        // Windows Runtime Component does not allow operator overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
        public static bool operator <=(ApparentEnergy left, ApparentEnergy right)
        {
            return left._voltampereHours <= right._voltampereHours;
        }

        public static bool operator >=(ApparentEnergy left, ApparentEnergy right)
        {
            return left._voltampereHours >= right._voltampereHours;
        }

        public static bool operator <(ApparentEnergy left, ApparentEnergy right)
        {
            return left._voltampereHours < right._voltampereHours;
        }

        public static bool operator >(ApparentEnergy left, ApparentEnergy right)
        {
            return left._voltampereHours > right._voltampereHours;
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(ApparentEnergy left, ApparentEnergy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._voltampereHours == right._voltampereHours;
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(ApparentEnergy left, ApparentEnergy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left._voltampereHours != right._voltampereHours;
        }
#endif

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return _voltampereHours.Equals(((ApparentEnergy) obj)._voltampereHours);
        }

        /// <summary>
        ///     Compare equality to another ApparentEnergy by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        public bool Equals(ApparentEnergy other, ApparentEnergy maxError)
        {
            return Math.Abs(_voltampereHours - other._voltampereHours) <= maxError._voltampereHours;
        }

        public override int GetHashCode()
        {
            return _voltampereHours.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value in new unit if successful, exception otherwise.</returns>
        /// <exception cref="NotImplementedException">If conversion was not successful.</exception>
        public double As(ApparentEnergyUnit unit)
        {
            switch (unit)
            {
                case ApparentEnergyUnit.KilovoltampereHour:
                    return KilovoltampereHours;
                case ApparentEnergyUnit.MegavoltampereHour:
                    return MegavoltampereHours;
                case ApparentEnergyUnit.VoltampereHour:
                    return VoltampereHours;

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
        public static ApparentEnergy Parse(string str)
        {
            return Parse(str, null);
        }

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
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
        public static ApparentEnergy Parse(string str, [CanBeNull] Culture culture)
        {
            if (str == null) throw new ArgumentNullException("str");

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            return QuantityParser.Parse<ApparentEnergy, ApparentEnergyUnit>(str, formatProvider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    ApparentEnergyUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromVoltampereHours(x.VoltampereHours + y.VoltampereHours));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, out ApparentEnergy result)
        {
            return TryParse(str, null, out result);
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="culture">Format to use when parsing number and unit. If it is null, it defaults to <see cref="NumberFormatInfo.CurrentInfo"/> for parsing the number and <see cref="CultureInfo.CurrentUICulture"/> for parsing the unit abbreviation by culture/language.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] Culture culture, out ApparentEnergy result)
        {
            try
            {
                result = Parse(str, culture);
                return true;
            }
            catch
            {
                result = default(ApparentEnergy);
                return false;
            }
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ApparentEnergyUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
        /// <example>
        ///     Length.ParseUnit("m", new CultureInfo("en-US"));
        /// </example>
        /// <exception cref="ArgumentNullException">The value of 'str' cannot be null. </exception>
        /// <exception cref="UnitsNetException">Error parsing string.</exception>
        public static ApparentEnergyUnit ParseUnit(string str, [CanBeNull] string cultureName)
        {
            return ParseUnit(str, cultureName == null ? null : new CultureInfo(cultureName));
        }

        /// <summary>
        ///     Parse a unit string.
        /// </summary>
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
        static ApparentEnergyUnit ParseUnit(string str, IFormatProvider formatProvider = null)
        {
            if (str == null) throw new ArgumentNullException("str");

            var unitSystem = UnitSystem.GetCached(formatProvider);
            var unit = unitSystem.Parse<ApparentEnergyUnit>(str.Trim());

            if (unit == ApparentEnergyUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized ApparentEnergyUnit.");
                newEx.Data["input"] = str;
                newEx.Data["formatprovider"] = formatProvider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is VoltampereHour
        /// </summary>
        public static ApparentEnergyUnit ToStringDefaultUnit { get; set; } = ApparentEnergyUnit.VoltampereHour;

        /// <summary>
        ///     Get default string representation of value and unit.
        /// </summary>
        /// <returns>String representation.</returns>
        public override string ToString()
        {
            return ToString(ToStringDefaultUnit);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using current UI culture and two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <returns>String representation.</returns>
        public string ToString(ApparentEnergyUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <returns>String representation.</returns>
        public string ToString(ApparentEnergyUnit unit, [CanBeNull] Culture culture)
        {
            return ToString(unit, culture, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(ApparentEnergyUnit unit, [CanBeNull] Culture culture, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, culture, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="culture">Culture to use for localization and number formatting.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(ApparentEnergyUnit unit, [CanBeNull] Culture culture, [NotNull] string format,
            [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

        // Windows Runtime Component does not support CultureInfo type, so use culture name string for public methods instead: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if WINDOWS_UWP
            IFormatProvider formatProvider = culture == null ? null : new CultureInfo(culture);
#else
            IFormatProvider formatProvider = culture;
#endif
            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, formatProvider, args);
            return string.Format(formatProvider, format, formatArgs);
        }

        /// <summary>
        /// Represents the largest possible value of ApparentEnergy
        /// </summary>
        public static ApparentEnergy MaxValue
        {
            get
            {
                return new ApparentEnergy(double.MaxValue);
            }
        }

        /// <summary>
        /// Represents the smallest possible value of ApparentEnergy
        /// </summary>
        public static ApparentEnergy MinValue
        {
            get
            {
                return new ApparentEnergy(double.MinValue);
            }
        }
    }
}
