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
    ///     Torque, moment or moment of force (see the terminology below), is the tendency of a force to rotate an object about an axis,[1] fulcrum, or pivot. Just as a force is a push or a pull, a torque can be thought of as a twist to an object. Mathematically, torque is defined as the cross product of the lever-arm distance and force, which tends to produce rotation. Loosely speaking, torque is a measure of the turning force on an object such as a bolt or a flywheel. For example, pushing or pulling the handle of a wrench connected to a nut or bolt produces a torque (turning force) that loosens or tightens the nut or bolt.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct Torque : IComparable, IComparable<Torque>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable Torque from nullable KilogramForceCentimeters.
        /// </summary>
        public static Torque? FromKilogramForceCentimeters(QuantityValue? kilogramforcecentimeters)
        {
            return kilogramforcecentimeters.HasValue ? FromKilogramForceCentimeters(kilogramforcecentimeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable KilogramForceMeters.
        /// </summary>
        public static Torque? FromKilogramForceMeters(QuantityValue? kilogramforcemeters)
        {
            return kilogramforcemeters.HasValue ? FromKilogramForceMeters(kilogramforcemeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable KilogramForceMillimeters.
        /// </summary>
        public static Torque? FromKilogramForceMillimeters(QuantityValue? kilogramforcemillimeters)
        {
            return kilogramforcemillimeters.HasValue ? FromKilogramForceMillimeters(kilogramforcemillimeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable KilonewtonCentimeters.
        /// </summary>
        public static Torque? FromKilonewtonCentimeters(QuantityValue? kilonewtoncentimeters)
        {
            return kilonewtoncentimeters.HasValue ? FromKilonewtonCentimeters(kilonewtoncentimeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable KilonewtonMeters.
        /// </summary>
        public static Torque? FromKilonewtonMeters(QuantityValue? kilonewtonmeters)
        {
            return kilonewtonmeters.HasValue ? FromKilonewtonMeters(kilonewtonmeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable KilonewtonMillimeters.
        /// </summary>
        public static Torque? FromKilonewtonMillimeters(QuantityValue? kilonewtonmillimeters)
        {
            return kilonewtonmillimeters.HasValue ? FromKilonewtonMillimeters(kilonewtonmillimeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable KilopoundForceFeet.
        /// </summary>
        public static Torque? FromKilopoundForceFeet(QuantityValue? kilopoundforcefeet)
        {
            return kilopoundforcefeet.HasValue ? FromKilopoundForceFeet(kilopoundforcefeet.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable KilopoundForceInches.
        /// </summary>
        public static Torque? FromKilopoundForceInches(QuantityValue? kilopoundforceinches)
        {
            return kilopoundforceinches.HasValue ? FromKilopoundForceInches(kilopoundforceinches.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable MeganewtonCentimeters.
        /// </summary>
        public static Torque? FromMeganewtonCentimeters(QuantityValue? meganewtoncentimeters)
        {
            return meganewtoncentimeters.HasValue ? FromMeganewtonCentimeters(meganewtoncentimeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable MeganewtonMeters.
        /// </summary>
        public static Torque? FromMeganewtonMeters(QuantityValue? meganewtonmeters)
        {
            return meganewtonmeters.HasValue ? FromMeganewtonMeters(meganewtonmeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable MeganewtonMillimeters.
        /// </summary>
        public static Torque? FromMeganewtonMillimeters(QuantityValue? meganewtonmillimeters)
        {
            return meganewtonmillimeters.HasValue ? FromMeganewtonMillimeters(meganewtonmillimeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable MegapoundForceFeet.
        /// </summary>
        public static Torque? FromMegapoundForceFeet(QuantityValue? megapoundforcefeet)
        {
            return megapoundforcefeet.HasValue ? FromMegapoundForceFeet(megapoundforcefeet.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable MegapoundForceInches.
        /// </summary>
        public static Torque? FromMegapoundForceInches(QuantityValue? megapoundforceinches)
        {
            return megapoundforceinches.HasValue ? FromMegapoundForceInches(megapoundforceinches.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable NewtonCentimeters.
        /// </summary>
        public static Torque? FromNewtonCentimeters(QuantityValue? newtoncentimeters)
        {
            return newtoncentimeters.HasValue ? FromNewtonCentimeters(newtoncentimeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable NewtonMeters.
        /// </summary>
        public static Torque? FromNewtonMeters(QuantityValue? newtonmeters)
        {
            return newtonmeters.HasValue ? FromNewtonMeters(newtonmeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable NewtonMillimeters.
        /// </summary>
        public static Torque? FromNewtonMillimeters(QuantityValue? newtonmillimeters)
        {
            return newtonmillimeters.HasValue ? FromNewtonMillimeters(newtonmillimeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable PoundForceFeet.
        /// </summary>
        public static Torque? FromPoundForceFeet(QuantityValue? poundforcefeet)
        {
            return poundforcefeet.HasValue ? FromPoundForceFeet(poundforcefeet.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable PoundForceInches.
        /// </summary>
        public static Torque? FromPoundForceInches(QuantityValue? poundforceinches)
        {
            return poundforceinches.HasValue ? FromPoundForceInches(poundforceinches.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable TonneForceCentimeters.
        /// </summary>
        public static Torque? FromTonneForceCentimeters(QuantityValue? tonneforcecentimeters)
        {
            return tonneforcecentimeters.HasValue ? FromTonneForceCentimeters(tonneforcecentimeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable TonneForceMeters.
        /// </summary>
        public static Torque? FromTonneForceMeters(QuantityValue? tonneforcemeters)
        {
            return tonneforcemeters.HasValue ? FromTonneForceMeters(tonneforcemeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Get nullable Torque from nullable TonneForceMillimeters.
        /// </summary>
        public static Torque? FromTonneForceMillimeters(QuantityValue? tonneforcemillimeters)
        {
            return tonneforcemillimeters.HasValue ? FromTonneForceMillimeters(tonneforcemillimeters.Value) : default(Torque?);
        }

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TorqueUnit" /> to <see cref="Torque" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Torque unit value.</returns>
        public static Torque? From(QuantityValue? value, TorqueUnit fromUnit)
        {
            return value.HasValue ? new Torque((double)value.Value, fromUnit) : default(Torque?);
        }

        #endregion

        #region Arithmetic Operators

        public static Torque operator -(Torque right)
        {
            return new Torque(-right.Value, right.Unit);
        }

        public static Torque operator +(Torque left, Torque right)
        {
            return new Torque(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Torque operator -(Torque left, Torque right)
        {
            return new Torque(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Torque operator *(double left, Torque right)
        {
            return new Torque(left * right.Value, right.Unit);
        }

        public static Torque operator *(Torque left, double right)
        {
            return new Torque(left.Value * right, left.Unit);
        }

        public static Torque operator /(Torque left, double right)
        {
            return new Torque(left.Value / right, left.Unit);
        }

        public static double operator /(Torque left, Torque right)
        {
            return left.NewtonMeters / right.NewtonMeters;
        }

        #endregion

        public static bool operator <=(Torque left, Torque right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Torque left, Torque right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Torque left, Torque right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Torque left, Torque right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Torque left, Torque right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Torque left, Torque right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }

        #region Parsing

        /// <summary>
        ///     Parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
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
        public static Torque Parse(string str, [CanBeNull] IFormatProvider provider)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            provider = provider ?? UnitSystem.DefaultCulture;

            return QuantityParser.Parse<Torque, TorqueUnit>(str, provider,
                delegate(string value, string unit, IFormatProvider formatProvider2)
                {
                    double parsedValue = double.Parse(value, formatProvider2);
                    TorqueUnit parsedUnit = ParseUnit(unit, formatProvider2);
                    return From(parsedValue, parsedUnit);
                }, (x, y) => FromNewtonMeters(x.NewtonMeters + y.NewtonMeters));
        }

        /// <summary>
        ///     Try to parse a string with one or two quantities of the format "&lt;quantity&gt; &lt;unit&gt;".
        /// </summary>
        /// <param name="str">String to parse. Typically in the form: {number} {unit}</param>
        /// <param name="provider">Format to use when parsing number and unit. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="result">Resulting unit quantity if successful.</param>
        /// <example>
        ///     Length.Parse("5.5 m", new CultureInfo("en-US"));
        /// </example>
        public static bool TryParse([CanBeNull] string str, [CanBeNull] IFormatProvider provider, out Torque result)
        {
            provider = provider ?? UnitSystem.DefaultCulture;

            try
            {
                result = Parse(str, provider);
                return true;
            }
            catch
            {
                result = default(Torque);
                return false;
            }
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
        public static TorqueUnit ParseUnit(string str, IFormatProvider provider = null)
        {
            if (str == null) throw new ArgumentNullException(nameof(str));

            var unitSystem = UnitSystem.GetCached(provider);
            var unit = unitSystem.Parse<TorqueUnit>(str.Trim());

            if (unit == TorqueUnit.Undefined)
            {
                var newEx = new UnitsNetException("Error parsing string. The unit is not a recognized TorqueUnit.");
                newEx.Data["input"] = str;
                newEx.Data["provider"] = provider?.ToString() ?? "(null)";
                throw newEx;
            }

            return unit;
        }

        #endregion

        #region ToString Methods

        /// <summary>
        ///     Get string representation of value and unit. Using two significant digits after radix.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <returns>String representation.</returns>
        public string ToString(TorqueUnit unit, [CanBeNull] IFormatProvider provider)
        {
            return ToString(unit, provider, 2);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="significantDigitsAfterRadix">The number of significant digits after the radix point.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(TorqueUnit unit, [CanBeNull] IFormatProvider provider, int significantDigitsAfterRadix)
        {
            double value = As(unit);
            string format = UnitFormatter.GetFormat(value, significantDigitsAfterRadix);
            return ToString(unit, provider, format);
        }

        /// <summary>
        ///     Get string representation of value and unit.
        /// </summary>
        /// <param name="provider">Format to use for localization and number formatting. Defaults to <see cref="UnitSystem.DefaultCulture" />.</param>
        /// <param name="unit">Unit representation to use.</param>
        /// <param name="format">String format to use. Default:  "{0:0.##} {1} for value and unit abbreviation respectively."</param>
        /// <param name="args">Arguments for string format. Value and unit are implictly included as arguments 0 and 1.</param>
        /// <returns>String representation.</returns>
        [UsedImplicitly]
        public string ToString(TorqueUnit unit, [CanBeNull] IFormatProvider provider, [NotNull] string format, [NotNull] params object[] args)
        {
            if (format == null) throw new ArgumentNullException(nameof(format));
            if (args == null) throw new ArgumentNullException(nameof(args));

            provider = provider ?? UnitSystem.DefaultCulture;

            double value = As(unit);
            object[] formatArgs = UnitFormatter.GetFormatArgs(unit, value, provider, args);
            return string.Format(provider, format, formatArgs);
        }

        #endregion
    }
}
