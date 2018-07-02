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
    ///     The joule, symbol J, is a derived unit of energy, work, or amount of heat in the International System of Units. It is equal to the energy transferred (or work done) when applying a force of one newton through a distance of one metre (1 newton metre or N·m), or in passing an electric current of one ampere through a resistance of one ohm for one second. Many other units of energy are included. Please do not confuse this definition of the calorie with the one colloquially used by the food industry, the large calorie, which is equivalent to 1 kcal. Thermochemical definition of the calorie is used. For BTU, the IT definition is used.
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct Energy : IComparable, IComparable<Energy>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable Energy from nullable BritishThermalUnits.
        /// </summary>
        public static Energy? FromBritishThermalUnits(QuantityValue? britishthermalunits)
        {
            return britishthermalunits.HasValue ? FromBritishThermalUnits(britishthermalunits.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable Calories.
        /// </summary>
        public static Energy? FromCalories(QuantityValue? calories)
        {
            return calories.HasValue ? FromCalories(calories.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable DecathermsEc.
        /// </summary>
        public static Energy? FromDecathermsEc(QuantityValue? decathermsec)
        {
            return decathermsec.HasValue ? FromDecathermsEc(decathermsec.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable DecathermsImperial.
        /// </summary>
        public static Energy? FromDecathermsImperial(QuantityValue? decathermsimperial)
        {
            return decathermsimperial.HasValue ? FromDecathermsImperial(decathermsimperial.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable DecathermsUs.
        /// </summary>
        public static Energy? FromDecathermsUs(QuantityValue? decathermsus)
        {
            return decathermsus.HasValue ? FromDecathermsUs(decathermsus.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable ElectronVolts.
        /// </summary>
        public static Energy? FromElectronVolts(QuantityValue? electronvolts)
        {
            return electronvolts.HasValue ? FromElectronVolts(electronvolts.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable Ergs.
        /// </summary>
        public static Energy? FromErgs(QuantityValue? ergs)
        {
            return ergs.HasValue ? FromErgs(ergs.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable FootPounds.
        /// </summary>
        public static Energy? FromFootPounds(QuantityValue? footpounds)
        {
            return footpounds.HasValue ? FromFootPounds(footpounds.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable GigabritishThermalUnits.
        /// </summary>
        public static Energy? FromGigabritishThermalUnits(QuantityValue? gigabritishthermalunits)
        {
            return gigabritishthermalunits.HasValue ? FromGigabritishThermalUnits(gigabritishthermalunits.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable GigawattHours.
        /// </summary>
        public static Energy? FromGigawattHours(QuantityValue? gigawatthours)
        {
            return gigawatthours.HasValue ? FromGigawattHours(gigawatthours.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable Joules.
        /// </summary>
        public static Energy? FromJoules(QuantityValue? joules)
        {
            return joules.HasValue ? FromJoules(joules.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable KilobritishThermalUnits.
        /// </summary>
        public static Energy? FromKilobritishThermalUnits(QuantityValue? kilobritishthermalunits)
        {
            return kilobritishthermalunits.HasValue ? FromKilobritishThermalUnits(kilobritishthermalunits.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable Kilocalories.
        /// </summary>
        public static Energy? FromKilocalories(QuantityValue? kilocalories)
        {
            return kilocalories.HasValue ? FromKilocalories(kilocalories.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable Kilojoules.
        /// </summary>
        public static Energy? FromKilojoules(QuantityValue? kilojoules)
        {
            return kilojoules.HasValue ? FromKilojoules(kilojoules.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable KilowattHours.
        /// </summary>
        public static Energy? FromKilowattHours(QuantityValue? kilowatthours)
        {
            return kilowatthours.HasValue ? FromKilowattHours(kilowatthours.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable MegabritishThermalUnits.
        /// </summary>
        public static Energy? FromMegabritishThermalUnits(QuantityValue? megabritishthermalunits)
        {
            return megabritishthermalunits.HasValue ? FromMegabritishThermalUnits(megabritishthermalunits.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable Megajoules.
        /// </summary>
        public static Energy? FromMegajoules(QuantityValue? megajoules)
        {
            return megajoules.HasValue ? FromMegajoules(megajoules.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable MegawattHours.
        /// </summary>
        public static Energy? FromMegawattHours(QuantityValue? megawatthours)
        {
            return megawatthours.HasValue ? FromMegawattHours(megawatthours.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable ThermsEc.
        /// </summary>
        public static Energy? FromThermsEc(QuantityValue? thermsec)
        {
            return thermsec.HasValue ? FromThermsEc(thermsec.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable ThermsImperial.
        /// </summary>
        public static Energy? FromThermsImperial(QuantityValue? thermsimperial)
        {
            return thermsimperial.HasValue ? FromThermsImperial(thermsimperial.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable ThermsUs.
        /// </summary>
        public static Energy? FromThermsUs(QuantityValue? thermsus)
        {
            return thermsus.HasValue ? FromThermsUs(thermsus.Value) : default(Energy?);
        }

        /// <summary>
        ///     Get nullable Energy from nullable WattHours.
        /// </summary>
        public static Energy? FromWattHours(QuantityValue? watthours)
        {
            return watthours.HasValue ? FromWattHours(watthours.Value) : default(Energy?);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="EnergyUnit" /> to <see cref="Energy" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Energy unit value.</returns>
        public static Energy? From(QuantityValue? value, EnergyUnit fromUnit)
        {
            return value.HasValue ? new Energy((double)value.Value, fromUnit) : default(Energy?);
        }

        #endregion

        #region Arithmetic Operators

        public static Energy operator -(Energy right)
        {
            return new Energy(-right.Value, right.Unit);
        }

        public static Energy operator +(Energy left, Energy right)
        {
            return new Energy(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Energy operator -(Energy left, Energy right)
        {
            return new Energy(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Energy operator *(double left, Energy right)
        {
            return new Energy(left * right.Value, right.Unit);
        }

        public static Energy operator *(Energy left, double right)
        {
            return new Energy(left.Value * right, left.Unit);
        }

        public static Energy operator /(Energy left, double right)
        {
            return new Energy(left.Value / right, left.Unit);
        }

        public static double operator /(Energy left, Energy right)
        {
            return left.Joules / right.Joules;
        }

        #endregion

        public static bool operator <=(Energy left, Energy right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Energy left, Energy right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Energy left, Energy right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Energy left, Energy right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Energy left, Energy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Energy left, Energy right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
    }
}
