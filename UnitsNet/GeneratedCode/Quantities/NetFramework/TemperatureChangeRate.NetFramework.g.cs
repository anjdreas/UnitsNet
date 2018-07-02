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
    ///     Temperature change rate is the ratio of the temperature change to the time during which the change occurred (value of temperature changes per unit time).
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct TemperatureChangeRate : IComparable, IComparable<TemperatureChangeRate>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable TemperatureChangeRate from nullable CentidegreesCelsiusPerSecond.
        /// </summary>
        public static TemperatureChangeRate? FromCentidegreesCelsiusPerSecond(QuantityValue? centidegreescelsiuspersecond)
        {
            return centidegreescelsiuspersecond.HasValue ? FromCentidegreesCelsiusPerSecond(centidegreescelsiuspersecond.Value) : default(TemperatureChangeRate?);
        }

        /// <summary>
        ///     Get nullable TemperatureChangeRate from nullable DecadegreesCelsiusPerSecond.
        /// </summary>
        public static TemperatureChangeRate? FromDecadegreesCelsiusPerSecond(QuantityValue? decadegreescelsiuspersecond)
        {
            return decadegreescelsiuspersecond.HasValue ? FromDecadegreesCelsiusPerSecond(decadegreescelsiuspersecond.Value) : default(TemperatureChangeRate?);
        }

        /// <summary>
        ///     Get nullable TemperatureChangeRate from nullable DecidegreesCelsiusPerSecond.
        /// </summary>
        public static TemperatureChangeRate? FromDecidegreesCelsiusPerSecond(QuantityValue? decidegreescelsiuspersecond)
        {
            return decidegreescelsiuspersecond.HasValue ? FromDecidegreesCelsiusPerSecond(decidegreescelsiuspersecond.Value) : default(TemperatureChangeRate?);
        }

        /// <summary>
        ///     Get nullable TemperatureChangeRate from nullable DegreesCelsiusPerMinute.
        /// </summary>
        public static TemperatureChangeRate? FromDegreesCelsiusPerMinute(QuantityValue? degreescelsiusperminute)
        {
            return degreescelsiusperminute.HasValue ? FromDegreesCelsiusPerMinute(degreescelsiusperminute.Value) : default(TemperatureChangeRate?);
        }

        /// <summary>
        ///     Get nullable TemperatureChangeRate from nullable DegreesCelsiusPerSecond.
        /// </summary>
        public static TemperatureChangeRate? FromDegreesCelsiusPerSecond(QuantityValue? degreescelsiuspersecond)
        {
            return degreescelsiuspersecond.HasValue ? FromDegreesCelsiusPerSecond(degreescelsiuspersecond.Value) : default(TemperatureChangeRate?);
        }

        /// <summary>
        ///     Get nullable TemperatureChangeRate from nullable HectodegreesCelsiusPerSecond.
        /// </summary>
        public static TemperatureChangeRate? FromHectodegreesCelsiusPerSecond(QuantityValue? hectodegreescelsiuspersecond)
        {
            return hectodegreescelsiuspersecond.HasValue ? FromHectodegreesCelsiusPerSecond(hectodegreescelsiuspersecond.Value) : default(TemperatureChangeRate?);
        }

        /// <summary>
        ///     Get nullable TemperatureChangeRate from nullable KilodegreesCelsiusPerSecond.
        /// </summary>
        public static TemperatureChangeRate? FromKilodegreesCelsiusPerSecond(QuantityValue? kilodegreescelsiuspersecond)
        {
            return kilodegreescelsiuspersecond.HasValue ? FromKilodegreesCelsiusPerSecond(kilodegreescelsiuspersecond.Value) : default(TemperatureChangeRate?);
        }

        /// <summary>
        ///     Get nullable TemperatureChangeRate from nullable MicrodegreesCelsiusPerSecond.
        /// </summary>
        public static TemperatureChangeRate? FromMicrodegreesCelsiusPerSecond(QuantityValue? microdegreescelsiuspersecond)
        {
            return microdegreescelsiuspersecond.HasValue ? FromMicrodegreesCelsiusPerSecond(microdegreescelsiuspersecond.Value) : default(TemperatureChangeRate?);
        }

        /// <summary>
        ///     Get nullable TemperatureChangeRate from nullable MillidegreesCelsiusPerSecond.
        /// </summary>
        public static TemperatureChangeRate? FromMillidegreesCelsiusPerSecond(QuantityValue? millidegreescelsiuspersecond)
        {
            return millidegreescelsiuspersecond.HasValue ? FromMillidegreesCelsiusPerSecond(millidegreescelsiuspersecond.Value) : default(TemperatureChangeRate?);
        }

        /// <summary>
        ///     Get nullable TemperatureChangeRate from nullable NanodegreesCelsiusPerSecond.
        /// </summary>
        public static TemperatureChangeRate? FromNanodegreesCelsiusPerSecond(QuantityValue? nanodegreescelsiuspersecond)
        {
            return nanodegreescelsiuspersecond.HasValue ? FromNanodegreesCelsiusPerSecond(nanodegreescelsiuspersecond.Value) : default(TemperatureChangeRate?);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="TemperatureChangeRateUnit" /> to <see cref="TemperatureChangeRate" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>TemperatureChangeRate unit value.</returns>
        public static TemperatureChangeRate? From(QuantityValue? value, TemperatureChangeRateUnit fromUnit)
        {
            return value.HasValue ? new TemperatureChangeRate((double)value.Value, fromUnit) : default(TemperatureChangeRate?);
        }

        #endregion

        #region Arithmetic Operators

        public static TemperatureChangeRate operator -(TemperatureChangeRate right)
        {
            return new TemperatureChangeRate(-right.Value, right.Unit);
        }

        public static TemperatureChangeRate operator +(TemperatureChangeRate left, TemperatureChangeRate right)
        {
            return new TemperatureChangeRate(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static TemperatureChangeRate operator -(TemperatureChangeRate left, TemperatureChangeRate right)
        {
            return new TemperatureChangeRate(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static TemperatureChangeRate operator *(double left, TemperatureChangeRate right)
        {
            return new TemperatureChangeRate(left * right.Value, right.Unit);
        }

        public static TemperatureChangeRate operator *(TemperatureChangeRate left, double right)
        {
            return new TemperatureChangeRate(left.Value * right, left.Unit);
        }

        public static TemperatureChangeRate operator /(TemperatureChangeRate left, double right)
        {
            return new TemperatureChangeRate(left.Value / right, left.Unit);
        }

        public static double operator /(TemperatureChangeRate left, TemperatureChangeRate right)
        {
            return left.DegreesCelsiusPerSecond / right.DegreesCelsiusPerSecond;
        }

        #endregion

        public static bool operator <=(TemperatureChangeRate left, TemperatureChangeRate right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(TemperatureChangeRate left, TemperatureChangeRate right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(TemperatureChangeRate left, TemperatureChangeRate right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(TemperatureChangeRate left, TemperatureChangeRate right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(TemperatureChangeRate left, TemperatureChangeRate right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(TemperatureChangeRate left, TemperatureChangeRate right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
    }
}
