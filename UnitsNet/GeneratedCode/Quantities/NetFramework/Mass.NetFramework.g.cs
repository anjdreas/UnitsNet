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
    ///     In physics, mass (from Greek μᾶζα "barley cake, lump [of dough]") is a property of a physical system or body, giving rise to the phenomena of the body's resistance to being accelerated by a force and the strength of its mutual gravitational attraction with other bodies. Instruments such as mass balances or scales use those phenomena to measure mass. The SI unit of mass is the kilogram (kg).
    /// </summary>
    // ReSharper disable once PartialTypeWithSinglePart

    public partial struct Mass : IComparable, IComparable<Mass>
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        #region Nullable From Methods

        /// <summary>
        ///     Get nullable Mass from nullable Centigrams.
        /// </summary>
        public static Mass? FromCentigrams(QuantityValue? centigrams)
        {
            return centigrams.HasValue ? FromCentigrams(centigrams.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Decagrams.
        /// </summary>
        public static Mass? FromDecagrams(QuantityValue? decagrams)
        {
            return decagrams.HasValue ? FromDecagrams(decagrams.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Decigrams.
        /// </summary>
        public static Mass? FromDecigrams(QuantityValue? decigrams)
        {
            return decigrams.HasValue ? FromDecigrams(decigrams.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Grams.
        /// </summary>
        public static Mass? FromGrams(QuantityValue? grams)
        {
            return grams.HasValue ? FromGrams(grams.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Hectograms.
        /// </summary>
        public static Mass? FromHectograms(QuantityValue? hectograms)
        {
            return hectograms.HasValue ? FromHectograms(hectograms.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Kilograms.
        /// </summary>
        public static Mass? FromKilograms(QuantityValue? kilograms)
        {
            return kilograms.HasValue ? FromKilograms(kilograms.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Kilopounds.
        /// </summary>
        public static Mass? FromKilopounds(QuantityValue? kilopounds)
        {
            return kilopounds.HasValue ? FromKilopounds(kilopounds.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Kilotonnes.
        /// </summary>
        public static Mass? FromKilotonnes(QuantityValue? kilotonnes)
        {
            return kilotonnes.HasValue ? FromKilotonnes(kilotonnes.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable LongHundredweight.
        /// </summary>
        public static Mass? FromLongHundredweight(QuantityValue? longhundredweight)
        {
            return longhundredweight.HasValue ? FromLongHundredweight(longhundredweight.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable LongTons.
        /// </summary>
        public static Mass? FromLongTons(QuantityValue? longtons)
        {
            return longtons.HasValue ? FromLongTons(longtons.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Megapounds.
        /// </summary>
        public static Mass? FromMegapounds(QuantityValue? megapounds)
        {
            return megapounds.HasValue ? FromMegapounds(megapounds.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Megatonnes.
        /// </summary>
        public static Mass? FromMegatonnes(QuantityValue? megatonnes)
        {
            return megatonnes.HasValue ? FromMegatonnes(megatonnes.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Micrograms.
        /// </summary>
        public static Mass? FromMicrograms(QuantityValue? micrograms)
        {
            return micrograms.HasValue ? FromMicrograms(micrograms.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Milligrams.
        /// </summary>
        public static Mass? FromMilligrams(QuantityValue? milligrams)
        {
            return milligrams.HasValue ? FromMilligrams(milligrams.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Nanograms.
        /// </summary>
        public static Mass? FromNanograms(QuantityValue? nanograms)
        {
            return nanograms.HasValue ? FromNanograms(nanograms.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Ounces.
        /// </summary>
        public static Mass? FromOunces(QuantityValue? ounces)
        {
            return ounces.HasValue ? FromOunces(ounces.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Pounds.
        /// </summary>
        public static Mass? FromPounds(QuantityValue? pounds)
        {
            return pounds.HasValue ? FromPounds(pounds.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable ShortHundredweight.
        /// </summary>
        public static Mass? FromShortHundredweight(QuantityValue? shorthundredweight)
        {
            return shorthundredweight.HasValue ? FromShortHundredweight(shorthundredweight.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable ShortTons.
        /// </summary>
        public static Mass? FromShortTons(QuantityValue? shorttons)
        {
            return shorttons.HasValue ? FromShortTons(shorttons.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Stone.
        /// </summary>
        public static Mass? FromStone(QuantityValue? stone)
        {
            return stone.HasValue ? FromStone(stone.Value) : default(Mass?);
        }

        /// <summary>
        ///     Get nullable Mass from nullable Tonnes.
        /// </summary>
        public static Mass? FromTonnes(QuantityValue? tonnes)
        {
            return tonnes.HasValue ? FromTonnes(tonnes.Value) : default(Mass?);
        }


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MassUnit" /> to <see cref="Mass" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Mass unit value.</returns>
        public static Mass? From(QuantityValue? value, MassUnit fromUnit)
        {
            return value.HasValue ? new Mass((double)value.Value, fromUnit) : default(Mass?);
        }

        #endregion

        #region Arithmetic Operators

        public static Mass operator -(Mass right)
        {
            return new Mass(-right.Value, right.Unit);
        }

        public static Mass operator +(Mass left, Mass right)
        {
            return new Mass(left.Value + right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Mass operator -(Mass left, Mass right)
        {
            return new Mass(left.Value - right.AsBaseNumericType(left.Unit), left.Unit);
        }

        public static Mass operator *(double left, Mass right)
        {
            return new Mass(left * right.Value, right.Unit);
        }

        public static Mass operator *(Mass left, double right)
        {
            return new Mass(left.Value * right, left.Unit);
        }

        public static Mass operator /(Mass left, double right)
        {
            return new Mass(left.Value / right, left.Unit);
        }

        public static double operator /(Mass left, Mass right)
        {
            return left.Kilograms / right.Kilograms;
        }

        #endregion

        public static bool operator <=(Mass left, Mass right)
        {
            return left.Value <= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >=(Mass left, Mass right)
        {
            return left.Value >= right.AsBaseNumericType(left.Unit);
        }

        public static bool operator <(Mass left, Mass right)
        {
            return left.Value < right.AsBaseNumericType(left.Unit);
        }

        public static bool operator >(Mass left, Mass right)
        {
            return left.Value > right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator ==(Mass left, Mass right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value == right.AsBaseNumericType(left.Unit);
        }

        [Obsolete("It is not safe to compare equality due to using System.Double as the internal representation. It is very easy to get slightly different values due to floating point operations. Instead use Equals(other, maxError) to provide the max allowed error.")]
        public static bool operator !=(Mass left, Mass right)
        {
            // ReSharper disable once CompareOfFloatsByEqualityOperator
            return left.Value != right.AsBaseNumericType(left.Unit);
        }
    }
}
