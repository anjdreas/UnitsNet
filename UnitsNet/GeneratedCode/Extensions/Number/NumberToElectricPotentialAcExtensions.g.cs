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

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToElectricPotentialAc
{
    public static class NumberToElectricPotentialAcExtensions
    {
        #region KilovoltAc

        /// <inheritdoc cref="ElectricPotentialAc.FromKilovoltsAc(double)"/>
        public static ElectricPotentialAc KilovoltsAc(this int value) => ElectricPotentialAc.FromKilovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromKilovoltsAc(double?)"/>
        public static ElectricPotentialAc? KilovoltsAc(this int? value) => ElectricPotentialAc.FromKilovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromKilovoltsAc(double)"/>
        public static ElectricPotentialAc KilovoltsAc(this long value) => ElectricPotentialAc.FromKilovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromKilovoltsAc(double?)"/>
        public static ElectricPotentialAc? KilovoltsAc(this long? value) => ElectricPotentialAc.FromKilovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromKilovoltsAc(double)"/>
        public static ElectricPotentialAc KilovoltsAc(this double value) => ElectricPotentialAc.FromKilovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromKilovoltsAc(double?)"/>
        public static ElectricPotentialAc? KilovoltsAc(this double? value) => ElectricPotentialAc.FromKilovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromKilovoltsAc(double)"/>
        public static ElectricPotentialAc KilovoltsAc(this float value) => ElectricPotentialAc.FromKilovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromKilovoltsAc(double?)"/>
        public static ElectricPotentialAc? KilovoltsAc(this float? value) => ElectricPotentialAc.FromKilovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromKilovoltsAc(double)"/>
        public static ElectricPotentialAc KilovoltsAc(this decimal value) => ElectricPotentialAc.FromKilovoltsAc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromKilovoltsAc(double?)"/>
        public static ElectricPotentialAc? KilovoltsAc(this decimal? value) => ElectricPotentialAc.FromKilovoltsAc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegavoltAc

        /// <inheritdoc cref="ElectricPotentialAc.FromMegavoltsAc(double)"/>
        public static ElectricPotentialAc MegavoltsAc(this int value) => ElectricPotentialAc.FromMegavoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMegavoltsAc(double?)"/>
        public static ElectricPotentialAc? MegavoltsAc(this int? value) => ElectricPotentialAc.FromMegavoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMegavoltsAc(double)"/>
        public static ElectricPotentialAc MegavoltsAc(this long value) => ElectricPotentialAc.FromMegavoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMegavoltsAc(double?)"/>
        public static ElectricPotentialAc? MegavoltsAc(this long? value) => ElectricPotentialAc.FromMegavoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMegavoltsAc(double)"/>
        public static ElectricPotentialAc MegavoltsAc(this double value) => ElectricPotentialAc.FromMegavoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMegavoltsAc(double?)"/>
        public static ElectricPotentialAc? MegavoltsAc(this double? value) => ElectricPotentialAc.FromMegavoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMegavoltsAc(double)"/>
        public static ElectricPotentialAc MegavoltsAc(this float value) => ElectricPotentialAc.FromMegavoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMegavoltsAc(double?)"/>
        public static ElectricPotentialAc? MegavoltsAc(this float? value) => ElectricPotentialAc.FromMegavoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMegavoltsAc(double)"/>
        public static ElectricPotentialAc MegavoltsAc(this decimal value) => ElectricPotentialAc.FromMegavoltsAc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromMegavoltsAc(double?)"/>
        public static ElectricPotentialAc? MegavoltsAc(this decimal? value) => ElectricPotentialAc.FromMegavoltsAc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MicrovoltAc

        /// <inheritdoc cref="ElectricPotentialAc.FromMicrovoltsAc(double)"/>
        public static ElectricPotentialAc MicrovoltsAc(this int value) => ElectricPotentialAc.FromMicrovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMicrovoltsAc(double?)"/>
        public static ElectricPotentialAc? MicrovoltsAc(this int? value) => ElectricPotentialAc.FromMicrovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMicrovoltsAc(double)"/>
        public static ElectricPotentialAc MicrovoltsAc(this long value) => ElectricPotentialAc.FromMicrovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMicrovoltsAc(double?)"/>
        public static ElectricPotentialAc? MicrovoltsAc(this long? value) => ElectricPotentialAc.FromMicrovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMicrovoltsAc(double)"/>
        public static ElectricPotentialAc MicrovoltsAc(this double value) => ElectricPotentialAc.FromMicrovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMicrovoltsAc(double?)"/>
        public static ElectricPotentialAc? MicrovoltsAc(this double? value) => ElectricPotentialAc.FromMicrovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMicrovoltsAc(double)"/>
        public static ElectricPotentialAc MicrovoltsAc(this float value) => ElectricPotentialAc.FromMicrovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMicrovoltsAc(double?)"/>
        public static ElectricPotentialAc? MicrovoltsAc(this float? value) => ElectricPotentialAc.FromMicrovoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMicrovoltsAc(double)"/>
        public static ElectricPotentialAc MicrovoltsAc(this decimal value) => ElectricPotentialAc.FromMicrovoltsAc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromMicrovoltsAc(double?)"/>
        public static ElectricPotentialAc? MicrovoltsAc(this decimal? value) => ElectricPotentialAc.FromMicrovoltsAc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MillivoltAc

        /// <inheritdoc cref="ElectricPotentialAc.FromMillivoltsAc(double)"/>
        public static ElectricPotentialAc MillivoltsAc(this int value) => ElectricPotentialAc.FromMillivoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMillivoltsAc(double?)"/>
        public static ElectricPotentialAc? MillivoltsAc(this int? value) => ElectricPotentialAc.FromMillivoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMillivoltsAc(double)"/>
        public static ElectricPotentialAc MillivoltsAc(this long value) => ElectricPotentialAc.FromMillivoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMillivoltsAc(double?)"/>
        public static ElectricPotentialAc? MillivoltsAc(this long? value) => ElectricPotentialAc.FromMillivoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMillivoltsAc(double)"/>
        public static ElectricPotentialAc MillivoltsAc(this double value) => ElectricPotentialAc.FromMillivoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMillivoltsAc(double?)"/>
        public static ElectricPotentialAc? MillivoltsAc(this double? value) => ElectricPotentialAc.FromMillivoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMillivoltsAc(double)"/>
        public static ElectricPotentialAc MillivoltsAc(this float value) => ElectricPotentialAc.FromMillivoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMillivoltsAc(double?)"/>
        public static ElectricPotentialAc? MillivoltsAc(this float? value) => ElectricPotentialAc.FromMillivoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromMillivoltsAc(double)"/>
        public static ElectricPotentialAc MillivoltsAc(this decimal value) => ElectricPotentialAc.FromMillivoltsAc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromMillivoltsAc(double?)"/>
        public static ElectricPotentialAc? MillivoltsAc(this decimal? value) => ElectricPotentialAc.FromMillivoltsAc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region VoltAc

        /// <inheritdoc cref="ElectricPotentialAc.FromVoltsAc(double)"/>
        public static ElectricPotentialAc VoltsAc(this int value) => ElectricPotentialAc.FromVoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromVoltsAc(double?)"/>
        public static ElectricPotentialAc? VoltsAc(this int? value) => ElectricPotentialAc.FromVoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromVoltsAc(double)"/>
        public static ElectricPotentialAc VoltsAc(this long value) => ElectricPotentialAc.FromVoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromVoltsAc(double?)"/>
        public static ElectricPotentialAc? VoltsAc(this long? value) => ElectricPotentialAc.FromVoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromVoltsAc(double)"/>
        public static ElectricPotentialAc VoltsAc(this double value) => ElectricPotentialAc.FromVoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromVoltsAc(double?)"/>
        public static ElectricPotentialAc? VoltsAc(this double? value) => ElectricPotentialAc.FromVoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromVoltsAc(double)"/>
        public static ElectricPotentialAc VoltsAc(this float value) => ElectricPotentialAc.FromVoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromVoltsAc(double?)"/>
        public static ElectricPotentialAc? VoltsAc(this float? value) => ElectricPotentialAc.FromVoltsAc(value);

        /// <inheritdoc cref="ElectricPotentialAc.FromVoltsAc(double)"/>
        public static ElectricPotentialAc VoltsAc(this decimal value) => ElectricPotentialAc.FromVoltsAc(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricPotentialAc.FromVoltsAc(double?)"/>
        public static ElectricPotentialAc? VoltsAc(this decimal? value) => ElectricPotentialAc.FromVoltsAc(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
