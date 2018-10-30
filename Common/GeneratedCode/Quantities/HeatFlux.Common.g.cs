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
    ///     Heat flux is the flow of energy per unit of area per unit of time
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    // Windows Runtime Component has constraints on public types: https://msdn.microsoft.com/en-us/library/br230301.aspx#Declaring types in Windows Runtime Components
    // Public structures can't have any members other than public fields, and those fields must be value types or strings.
    // Public classes must be sealed (NotInheritable in Visual Basic). If your programming model requires polymorphism, you can create a public interface and implement that interface on the classes that must be polymorphic.
#if WINDOWS_UWP
    public sealed partial class HeatFlux : IQuantity
#else
    public partial struct HeatFlux : IQuantity, IComparable, IComparable<HeatFlux>
#endif
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly HeatFluxUnit? _unit;

        /// <summary>
        ///     The unit this quantity was constructed with -or- <see cref="BaseUnit" /> if default ctor was used.
        /// </summary>
        public HeatFluxUnit Unit => _unit.GetValueOrDefault(BaseUnit);

        static HeatFlux()
        {
            BaseDimensions = new BaseDimensions(0, 1, -3, 0, 0, 0, 0);
        }

        /// <summary>
        ///     Creates the quantity with the given value in the base unit WattPerSquareMeter.
        /// </summary>
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public HeatFlux(double wattspersquaremeter)
        {
            _value = Convert.ToDouble(wattspersquaremeter);
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
        HeatFlux(double numericValue, HeatFluxUnit unit)
        {
            _value = numericValue;
            _unit = unit;
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit WattPerSquareMeter.
        /// </summary>
        /// <param name="wattspersquaremeter">Value assuming base unit WattPerSquareMeter.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        HeatFlux(long wattspersquaremeter) : this(Convert.ToDouble(wattspersquaremeter), BaseUnit) { }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
        // Windows Runtime Component does not support decimal type
        /// <summary>
        ///     Creates the quantity with the given value assuming the base unit WattPerSquareMeter.
        /// </summary>
        /// <param name="wattspersquaremeter">Value assuming base unit WattPerSquareMeter.</param>
#if WINDOWS_UWP
        private
#else
        [Obsolete("Use the constructor that takes a unit parameter. This constructor will be removed in a future version.")]
        public
#endif
        HeatFlux(decimal wattspersquaremeter) : this(Convert.ToDouble(wattspersquaremeter), BaseUnit) { }

        #region Properties

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public static QuantityType QuantityType => QuantityType.HeatFlux;

        /// <summary>
        ///     The base unit representation of this quantity for the numeric value stored internally. All conversions go via this value.
        /// </summary>
        public static HeatFluxUnit BaseUnit => HeatFluxUnit.WattPerSquareMeter;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public static BaseDimensions BaseDimensions
        {
            get;
        }

        /// <summary>
        ///     All units of measurement for the HeatFlux quantity.
        /// </summary>
        public static HeatFluxUnit[] Units { get; } = Enum.GetValues(typeof(HeatFluxUnit)).Cast<HeatFluxUnit>().Except(new HeatFluxUnit[]{ HeatFluxUnit.Undefined }).ToArray();

        /// <summary>
        ///     Get HeatFlux in BtusPerHourSquareFoot.
        /// </summary>
        public double BtusPerHourSquareFoot => As(HeatFluxUnit.BtuPerHourSquareFoot);

        /// <summary>
        ///     Get HeatFlux in BtusPerMinuteSquareFoot.
        /// </summary>
        public double BtusPerMinuteSquareFoot => As(HeatFluxUnit.BtuPerMinuteSquareFoot);

        /// <summary>
        ///     Get HeatFlux in BtusPerSecondSquareFoot.
        /// </summary>
        public double BtusPerSecondSquareFoot => As(HeatFluxUnit.BtuPerSecondSquareFoot);

        /// <summary>
        ///     Get HeatFlux in BtusPerSecondSquareInch.
        /// </summary>
        public double BtusPerSecondSquareInch => As(HeatFluxUnit.BtuPerSecondSquareInch);

        /// <summary>
        ///     Get HeatFlux in CaloriesPerSecondSquareCentimeter.
        /// </summary>
        public double CaloriesPerSecondSquareCentimeter => As(HeatFluxUnit.CaloriePerSecondSquareCentimeter);

        /// <summary>
        ///     Get HeatFlux in CentiwattsPerSquareMeter.
        /// </summary>
        public double CentiwattsPerSquareMeter => As(HeatFluxUnit.CentiwattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux in DeciwattsPerSquareMeter.
        /// </summary>
        public double DeciwattsPerSquareMeter => As(HeatFluxUnit.DeciwattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux in KilocaloriesPerHourSquareMeter.
        /// </summary>
        public double KilocaloriesPerHourSquareMeter => As(HeatFluxUnit.KilocaloriePerHourSquareMeter);

        /// <summary>
        ///     Get HeatFlux in KilocaloriesPerSecondSquareCentimeter.
        /// </summary>
        public double KilocaloriesPerSecondSquareCentimeter => As(HeatFluxUnit.KilocaloriePerSecondSquareCentimeter);

        /// <summary>
        ///     Get HeatFlux in KilowattsPerSquareMeter.
        /// </summary>
        public double KilowattsPerSquareMeter => As(HeatFluxUnit.KilowattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux in MicrowattsPerSquareMeter.
        /// </summary>
        public double MicrowattsPerSquareMeter => As(HeatFluxUnit.MicrowattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux in MilliwattsPerSquareMeter.
        /// </summary>
        public double MilliwattsPerSquareMeter => As(HeatFluxUnit.MilliwattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux in NanowattsPerSquareMeter.
        /// </summary>
        public double NanowattsPerSquareMeter => As(HeatFluxUnit.NanowattPerSquareMeter);

        /// <summary>
        ///     Get HeatFlux in WattsPerSquareFoot.
        /// </summary>
        public double WattsPerSquareFoot => As(HeatFluxUnit.WattPerSquareFoot);

        /// <summary>
        ///     Get HeatFlux in WattsPerSquareInch.
        /// </summary>
        public double WattsPerSquareInch => As(HeatFluxUnit.WattPerSquareInch);

        /// <summary>
        ///     Get HeatFlux in WattsPerSquareMeter.
        /// </summary>
        public double WattsPerSquareMeter => As(HeatFluxUnit.WattPerSquareMeter);

        #endregion

        #region Static

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit WattPerSquareMeter.
        /// </summary>
        public static HeatFlux Zero => new HeatFlux(0, BaseUnit);

        /// <summary>
        ///     Get HeatFlux from BtusPerHourSquareFoot.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromBtusPerHourSquareFoot(double btusperhoursquarefoot)
#else
        public static HeatFlux FromBtusPerHourSquareFoot(QuantityValue btusperhoursquarefoot)
#endif
        {
            double value = (double) btusperhoursquarefoot;
            return new HeatFlux(value, HeatFluxUnit.BtuPerHourSquareFoot);
        }

        /// <summary>
        ///     Get HeatFlux from BtusPerMinuteSquareFoot.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromBtusPerMinuteSquareFoot(double btusperminutesquarefoot)
#else
        public static HeatFlux FromBtusPerMinuteSquareFoot(QuantityValue btusperminutesquarefoot)
#endif
        {
            double value = (double) btusperminutesquarefoot;
            return new HeatFlux(value, HeatFluxUnit.BtuPerMinuteSquareFoot);
        }

        /// <summary>
        ///     Get HeatFlux from BtusPerSecondSquareFoot.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromBtusPerSecondSquareFoot(double btuspersecondsquarefoot)
#else
        public static HeatFlux FromBtusPerSecondSquareFoot(QuantityValue btuspersecondsquarefoot)
#endif
        {
            double value = (double) btuspersecondsquarefoot;
            return new HeatFlux(value, HeatFluxUnit.BtuPerSecondSquareFoot);
        }

        /// <summary>
        ///     Get HeatFlux from BtusPerSecondSquareInch.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromBtusPerSecondSquareInch(double btuspersecondsquareinch)
#else
        public static HeatFlux FromBtusPerSecondSquareInch(QuantityValue btuspersecondsquareinch)
#endif
        {
            double value = (double) btuspersecondsquareinch;
            return new HeatFlux(value, HeatFluxUnit.BtuPerSecondSquareInch);
        }

        /// <summary>
        ///     Get HeatFlux from CaloriesPerSecondSquareCentimeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromCaloriesPerSecondSquareCentimeter(double caloriespersecondsquarecentimeter)
#else
        public static HeatFlux FromCaloriesPerSecondSquareCentimeter(QuantityValue caloriespersecondsquarecentimeter)
#endif
        {
            double value = (double) caloriespersecondsquarecentimeter;
            return new HeatFlux(value, HeatFluxUnit.CaloriePerSecondSquareCentimeter);
        }

        /// <summary>
        ///     Get HeatFlux from CentiwattsPerSquareMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromCentiwattsPerSquareMeter(double centiwattspersquaremeter)
#else
        public static HeatFlux FromCentiwattsPerSquareMeter(QuantityValue centiwattspersquaremeter)
#endif
        {
            double value = (double) centiwattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.CentiwattPerSquareMeter);
        }

        /// <summary>
        ///     Get HeatFlux from DeciwattsPerSquareMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromDeciwattsPerSquareMeter(double deciwattspersquaremeter)
#else
        public static HeatFlux FromDeciwattsPerSquareMeter(QuantityValue deciwattspersquaremeter)
#endif
        {
            double value = (double) deciwattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.DeciwattPerSquareMeter);
        }

        /// <summary>
        ///     Get HeatFlux from KilocaloriesPerHourSquareMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromKilocaloriesPerHourSquareMeter(double kilocaloriesperhoursquaremeter)
#else
        public static HeatFlux FromKilocaloriesPerHourSquareMeter(QuantityValue kilocaloriesperhoursquaremeter)
#endif
        {
            double value = (double) kilocaloriesperhoursquaremeter;
            return new HeatFlux(value, HeatFluxUnit.KilocaloriePerHourSquareMeter);
        }

        /// <summary>
        ///     Get HeatFlux from KilocaloriesPerSecondSquareCentimeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromKilocaloriesPerSecondSquareCentimeter(double kilocaloriespersecondsquarecentimeter)
#else
        public static HeatFlux FromKilocaloriesPerSecondSquareCentimeter(QuantityValue kilocaloriespersecondsquarecentimeter)
#endif
        {
            double value = (double) kilocaloriespersecondsquarecentimeter;
            return new HeatFlux(value, HeatFluxUnit.KilocaloriePerSecondSquareCentimeter);
        }

        /// <summary>
        ///     Get HeatFlux from KilowattsPerSquareMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromKilowattsPerSquareMeter(double kilowattspersquaremeter)
#else
        public static HeatFlux FromKilowattsPerSquareMeter(QuantityValue kilowattspersquaremeter)
#endif
        {
            double value = (double) kilowattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.KilowattPerSquareMeter);
        }

        /// <summary>
        ///     Get HeatFlux from MicrowattsPerSquareMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromMicrowattsPerSquareMeter(double microwattspersquaremeter)
#else
        public static HeatFlux FromMicrowattsPerSquareMeter(QuantityValue microwattspersquaremeter)
#endif
        {
            double value = (double) microwattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.MicrowattPerSquareMeter);
        }

        /// <summary>
        ///     Get HeatFlux from MilliwattsPerSquareMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromMilliwattsPerSquareMeter(double milliwattspersquaremeter)
#else
        public static HeatFlux FromMilliwattsPerSquareMeter(QuantityValue milliwattspersquaremeter)
#endif
        {
            double value = (double) milliwattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.MilliwattPerSquareMeter);
        }

        /// <summary>
        ///     Get HeatFlux from NanowattsPerSquareMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromNanowattsPerSquareMeter(double nanowattspersquaremeter)
#else
        public static HeatFlux FromNanowattsPerSquareMeter(QuantityValue nanowattspersquaremeter)
#endif
        {
            double value = (double) nanowattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.NanowattPerSquareMeter);
        }

        /// <summary>
        ///     Get HeatFlux from WattsPerSquareFoot.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromWattsPerSquareFoot(double wattspersquarefoot)
#else
        public static HeatFlux FromWattsPerSquareFoot(QuantityValue wattspersquarefoot)
#endif
        {
            double value = (double) wattspersquarefoot;
            return new HeatFlux(value, HeatFluxUnit.WattPerSquareFoot);
        }

        /// <summary>
        ///     Get HeatFlux from WattsPerSquareInch.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromWattsPerSquareInch(double wattspersquareinch)
#else
        public static HeatFlux FromWattsPerSquareInch(QuantityValue wattspersquareinch)
#endif
        {
            double value = (double) wattspersquareinch;
            return new HeatFlux(value, HeatFluxUnit.WattPerSquareInch);
        }

        /// <summary>
        ///     Get HeatFlux from WattsPerSquareMeter.
        /// </summary>
#if WINDOWS_UWP
        [Windows.Foundation.Metadata.DefaultOverload]
        public static HeatFlux FromWattsPerSquareMeter(double wattspersquaremeter)
#else
        public static HeatFlux FromWattsPerSquareMeter(QuantityValue wattspersquaremeter)
#endif
        {
            double value = (double) wattspersquaremeter;
            return new HeatFlux(value, HeatFluxUnit.WattPerSquareMeter);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="HeatFluxUnit" /> to <see cref="HeatFlux" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>HeatFlux unit value.</returns>
#if WINDOWS_UWP
        // Fix name conflict with parameter "value"
        [return: System.Runtime.InteropServices.WindowsRuntime.ReturnValueName("returnValue")]
        public static HeatFlux From(double value, HeatFluxUnit fromUnit)
#else
        public static HeatFlux From(QuantityValue value, HeatFluxUnit fromUnit)
#endif
        {
            return new HeatFlux((double)value, fromUnit);
        }

        /// <summary>
        ///     Get unit abbreviation string.
        /// </summary>
        /// <param name="unit">Unit to get abbreviation for.</param>
        /// <returns>Unit abbreviation string.</returns>
        [UsedImplicitly]
        public static string GetAbbreviation(HeatFluxUnit unit)
        {
            return GetAbbreviation(unit, null);
        }

        #endregion

        #region Equality / IComparable

        public int CompareTo(object obj)
        {
            if(obj is null) throw new ArgumentNullException(nameof(obj));
            if(!(obj is HeatFlux)) throw new ArgumentException("Expected type HeatFlux.", nameof(obj));

            return CompareTo((HeatFlux)obj);
        }

        // Windows Runtime Component does not allow public methods/ctors with same number of parameters: https://msdn.microsoft.com/en-us/library/br230301.aspx#Overloaded methods
#if WINDOWS_UWP
        internal
#else
        public
#endif
        int CompareTo(HeatFlux other)
        {
            return _value.CompareTo(other.AsBaseNumericType(this.Unit));
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals($quantityName, double, ComparisonType) to provide the max allowed absolute or relative error.")]
        public override bool Equals(object obj)
        {
            if(obj is null || !(obj is HeatFlux))
                return false;

            var objQuantity = (HeatFlux)obj;
            return _value.Equals(objQuantity.AsBaseNumericType(this.Unit));
        }

        /// <summary>
        ///     <para>
        ///     Compare equality to another HeatFlux within the given absolute or relative tolerance.
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
        public bool Equals(HeatFlux other, double tolerance, ComparisonType comparisonType)
        {
            if(tolerance < 0)
                throw new ArgumentOutOfRangeException("tolerance", "Tolerance must be greater than or equal to 0.");

            double thisValue = (double)this.Value;
            double otherValueInThisUnits = other.As(this.Unit);

            return UnitsNet.Comparison.Equals(thisValue, otherValueInThisUnits, tolerance, comparisonType);
        }

        /// <summary>
        ///     Compare equality to another HeatFlux by specifying a max allowed difference.
        ///     Note that it is advised against specifying zero difference, due to the nature
        ///     of floating point operations and using System.Double internally.
        /// </summary>
        /// <param name="other">Other quantity to compare to.</param>
        /// <param name="maxError">Max error allowed.</param>
        /// <returns>True if the difference between the two values is not greater than the specified max.</returns>
        [Obsolete("Please use the Equals(HeatFlux, double, ComparisonType) overload. This method will be removed in a future version.")]
        public bool Equals(HeatFlux other, HeatFlux maxError)
        {
            return Math.Abs(_value - other.AsBaseNumericType(this.Unit)) <= maxError.AsBaseNumericType(this.Unit);
        }

        /// <summary>
        ///     Returns the hash code for this instance.
        /// </summary>
        /// <returns>A hash code for the current HeatFlux.</returns>
        public override int GetHashCode()
        {
            return new { type = typeof(HeatFlux), Value, Unit }.GetHashCode();
        }

        #endregion

        #region Conversion

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(HeatFluxUnit unit)
        {
            if(Unit == unit)
                return Convert.ToDouble(Value);

            var converted = AsBaseNumericType(unit);
            return Convert.ToDouble(converted);
        }

        /// <summary>
        ///     Converts this HeatFlux to another HeatFlux with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A HeatFlux with the specified unit.</returns>
        public HeatFlux ToUnit(HeatFluxUnit unit)
        {
            var convertedValue = AsBaseNumericType(unit);
            return new HeatFlux(convertedValue, unit);
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
                case HeatFluxUnit.BtuPerHourSquareFoot: return _value*3.15459075;
                case HeatFluxUnit.BtuPerMinuteSquareFoot: return _value*1.89275445e2;
                case HeatFluxUnit.BtuPerSecondSquareFoot: return _value*1.13565267e4;
                case HeatFluxUnit.BtuPerSecondSquareInch: return _value*1.63533984e6;
                case HeatFluxUnit.CaloriePerSecondSquareCentimeter: return _value*4.1868e4;
                case HeatFluxUnit.CentiwattPerSquareMeter: return (_value) * 1e-2d;
                case HeatFluxUnit.DeciwattPerSquareMeter: return (_value) * 1e-1d;
                case HeatFluxUnit.KilocaloriePerHourSquareMeter: return _value*1.163;
                case HeatFluxUnit.KilocaloriePerSecondSquareCentimeter: return (_value*4.1868e4) * 1e3d;
                case HeatFluxUnit.KilowattPerSquareMeter: return (_value) * 1e3d;
                case HeatFluxUnit.MicrowattPerSquareMeter: return (_value) * 1e-6d;
                case HeatFluxUnit.MilliwattPerSquareMeter: return (_value) * 1e-3d;
                case HeatFluxUnit.NanowattPerSquareMeter: return (_value) * 1e-9d;
                case HeatFluxUnit.WattPerSquareFoot: return _value*1.07639e1;
                case HeatFluxUnit.WattPerSquareInch: return _value*1.5500031e3;
                case HeatFluxUnit.WattPerSquareMeter: return _value;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double AsBaseNumericType(HeatFluxUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = AsBaseUnit();

            switch(unit)
            {
                case HeatFluxUnit.BtuPerHourSquareFoot: return baseUnitValue/3.15459075;
                case HeatFluxUnit.BtuPerMinuteSquareFoot: return baseUnitValue/1.89275445e2;
                case HeatFluxUnit.BtuPerSecondSquareFoot: return baseUnitValue/1.13565267e4;
                case HeatFluxUnit.BtuPerSecondSquareInch: return baseUnitValue/1.63533984e6;
                case HeatFluxUnit.CaloriePerSecondSquareCentimeter: return baseUnitValue/4.1868e4;
                case HeatFluxUnit.CentiwattPerSquareMeter: return (baseUnitValue) / 1e-2d;
                case HeatFluxUnit.DeciwattPerSquareMeter: return (baseUnitValue) / 1e-1d;
                case HeatFluxUnit.KilocaloriePerHourSquareMeter: return baseUnitValue/1.163;
                case HeatFluxUnit.KilocaloriePerSecondSquareCentimeter: return (baseUnitValue/4.1868e4) / 1e3d;
                case HeatFluxUnit.KilowattPerSquareMeter: return (baseUnitValue) / 1e3d;
                case HeatFluxUnit.MicrowattPerSquareMeter: return (baseUnitValue) / 1e-6d;
                case HeatFluxUnit.MilliwattPerSquareMeter: return (baseUnitValue) / 1e-3d;
                case HeatFluxUnit.NanowattPerSquareMeter: return (baseUnitValue) / 1e-9d;
                case HeatFluxUnit.WattPerSquareFoot: return baseUnitValue/1.07639e1;
                case HeatFluxUnit.WattPerSquareInch: return baseUnitValue/1.5500031e3;
                case HeatFluxUnit.WattPerSquareMeter: return baseUnitValue;
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
        public static HeatFlux Parse(string str)
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
        public static bool TryParse([CanBeNull] string str, out HeatFlux result)
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
        public static HeatFluxUnit ParseUnit(string str)
        {
            return ParseUnit(str, (IFormatProvider)null);
        }

        #endregion

        /// <summary>
        ///     Set the default unit used by ToString(). Default is WattPerSquareMeter
        /// </summary>
        [Obsolete("This is no longer used since we will instead use the quantity's Unit value as default.")]
        public static HeatFluxUnit ToStringDefaultUnit { get; set; } = HeatFluxUnit.WattPerSquareMeter;

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
        public string ToString(HeatFluxUnit unit)
        {
            return ToString(unit, null, 2);
        }

        /// <summary>
        /// Represents the largest possible value of HeatFlux
        /// </summary>
        public static HeatFlux MaxValue => new HeatFlux(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of HeatFlux
        /// </summary>
        public static HeatFlux MinValue => new HeatFlux(double.MinValue, BaseUnit);

        /// <summary>
        ///     The <see cref="QuantityType" /> of this quantity.
        /// </summary>
        public QuantityType Type => HeatFlux.QuantityType;

        /// <summary>
        ///     The <see cref="BaseDimensions" /> of this quantity.
        /// </summary>
        public BaseDimensions Dimensions => HeatFlux.BaseDimensions;
    }
}
