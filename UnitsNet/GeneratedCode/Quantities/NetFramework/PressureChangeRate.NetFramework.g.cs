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
    ///     Pressure change rate is the ratio of the pressure change to the time during which the change occurred (value of pressure changes per unit time).
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct PressureChangeRate : IComparable, IComparable<PressureChangeRate>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable PressureChangeRate from nullable AtmospheresPerSecond.
        /// </summary>
        public static PressureChangeRate? FromAtmospheresPerSecond(QuantityValue? atmospherespersecond)
        {
            return atmospherespersecond.HasValue ? FromAtmospheresPerSecond(atmospherespersecond.Value) : default(PressureChangeRate?);
        }

        /// <summary>
        ///     Get nullable PressureChangeRate from nullable KilopascalsPerSecond.
        /// </summary>
        public static PressureChangeRate? FromKilopascalsPerSecond(QuantityValue? kilopascalspersecond)
        {
            return kilopascalspersecond.HasValue ? FromKilopascalsPerSecond(kilopascalspersecond.Value) : default(PressureChangeRate?);
        }

        /// <summary>
        ///     Get nullable PressureChangeRate from nullable MegapascalsPerSecond.
        /// </summary>
        public static PressureChangeRate? FromMegapascalsPerSecond(QuantityValue? megapascalspersecond)
        {
            return megapascalspersecond.HasValue ? FromMegapascalsPerSecond(megapascalspersecond.Value) : default(PressureChangeRate?);
        }

        /// <summary>
        ///     Get nullable PressureChangeRate from nullable PascalsPerSecond.
        /// </summary>
        public static PressureChangeRate? FromPascalsPerSecond(QuantityValue? pascalspersecond)
        {
            return pascalspersecond.HasValue ? FromPascalsPerSecond(pascalspersecond.Value) : default(PressureChangeRate?);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="PressureChangeRateUnit" /> to <see cref="PressureChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>PressureChangeRate unit value.</returns>
        public static PressureChangeRate? From(QuantityValue? value, PressureChangeRateUnit fromUnit)
        {
            return value.HasValue ? new PressureChangeRate((double)value.Value, fromUnit) : default(PressureChangeRate?);
        }

        #endregion

        #region Arithmetic Operators

        public static PressureChangeRate operator -(PressureChangeRate right)
        {
            return new PressureChangeRate(-right.Value, right.Unit);
        }

        public static PressureChangeRate operator +(PressureChangeRate left, PressureChangeRate right)
        {
            return new PressureChangeRate(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static PressureChangeRate operator -(PressureChangeRate left, PressureChangeRate right)
        {
            return new PressureChangeRate(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static PressureChangeRate operator *(double left, PressureChangeRate right)
        {
            return new PressureChangeRate(left * right.Value, right.Unit);
        }

        public static PressureChangeRate operator *(PressureChangeRate left, double right)
        {
            return new PressureChangeRate(left.Value * right, left.Unit);
        }

        public static PressureChangeRate operator /(PressureChangeRate left, double right)
        {
            return new PressureChangeRate(left.Value / right, left.Unit);
        }

        public static double operator /(PressureChangeRate left, PressureChangeRate right)
        {
            return left.PascalsPerSecond / right.PascalsPerSecond;
        }

        #endregion

        public static bool operator <=(PressureChangeRate left, PressureChangeRate right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(PressureChangeRate left, PressureChangeRate right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(PressureChangeRate left, PressureChangeRate right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(PressureChangeRate left, PressureChangeRate right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(PressureChangeRate left, PressureChangeRate right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(PressureChangeRate left, PressureChangeRate right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
    }
}
