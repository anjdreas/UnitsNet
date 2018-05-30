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
namespace UnitsNet.Extensions.NumberToElectricAdmittance
{
    public static class NumberToElectricAdmittanceExtensions
    {
        #region Microsiemens

        /// <inheritdoc cref="ElectricAdmittance.FromMicrosiemens(double)"/>
        public static ElectricAdmittance Microsiemens(this int value) => ElectricAdmittance.FromMicrosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMicrosiemens(double?)"/>
        public static ElectricAdmittance? Microsiemens(this int? value) => ElectricAdmittance.FromMicrosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMicrosiemens(double)"/>
        public static ElectricAdmittance Microsiemens(this long value) => ElectricAdmittance.FromMicrosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMicrosiemens(double?)"/>
        public static ElectricAdmittance? Microsiemens(this long? value) => ElectricAdmittance.FromMicrosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMicrosiemens(double)"/>
        public static ElectricAdmittance Microsiemens(this double value) => ElectricAdmittance.FromMicrosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMicrosiemens(double?)"/>
        public static ElectricAdmittance? Microsiemens(this double? value) => ElectricAdmittance.FromMicrosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMicrosiemens(double)"/>
        public static ElectricAdmittance Microsiemens(this float value) => ElectricAdmittance.FromMicrosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMicrosiemens(double?)"/>
        public static ElectricAdmittance? Microsiemens(this float? value) => ElectricAdmittance.FromMicrosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMicrosiemens(double)"/>
        public static ElectricAdmittance Microsiemens(this decimal value) => ElectricAdmittance.FromMicrosiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromMicrosiemens(double?)"/>
        public static ElectricAdmittance? Microsiemens(this decimal? value) => ElectricAdmittance.FromMicrosiemens(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Millisiemens

        /// <inheritdoc cref="ElectricAdmittance.FromMillisiemens(double)"/>
        public static ElectricAdmittance Millisiemens(this int value) => ElectricAdmittance.FromMillisiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMillisiemens(double?)"/>
        public static ElectricAdmittance? Millisiemens(this int? value) => ElectricAdmittance.FromMillisiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMillisiemens(double)"/>
        public static ElectricAdmittance Millisiemens(this long value) => ElectricAdmittance.FromMillisiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMillisiemens(double?)"/>
        public static ElectricAdmittance? Millisiemens(this long? value) => ElectricAdmittance.FromMillisiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMillisiemens(double)"/>
        public static ElectricAdmittance Millisiemens(this double value) => ElectricAdmittance.FromMillisiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMillisiemens(double?)"/>
        public static ElectricAdmittance? Millisiemens(this double? value) => ElectricAdmittance.FromMillisiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMillisiemens(double)"/>
        public static ElectricAdmittance Millisiemens(this float value) => ElectricAdmittance.FromMillisiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMillisiemens(double?)"/>
        public static ElectricAdmittance? Millisiemens(this float? value) => ElectricAdmittance.FromMillisiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromMillisiemens(double)"/>
        public static ElectricAdmittance Millisiemens(this decimal value) => ElectricAdmittance.FromMillisiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromMillisiemens(double?)"/>
        public static ElectricAdmittance? Millisiemens(this decimal? value) => ElectricAdmittance.FromMillisiemens(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Nanosiemens

        /// <inheritdoc cref="ElectricAdmittance.FromNanosiemens(double)"/>
        public static ElectricAdmittance Nanosiemens(this int value) => ElectricAdmittance.FromNanosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromNanosiemens(double?)"/>
        public static ElectricAdmittance? Nanosiemens(this int? value) => ElectricAdmittance.FromNanosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromNanosiemens(double)"/>
        public static ElectricAdmittance Nanosiemens(this long value) => ElectricAdmittance.FromNanosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromNanosiemens(double?)"/>
        public static ElectricAdmittance? Nanosiemens(this long? value) => ElectricAdmittance.FromNanosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromNanosiemens(double)"/>
        public static ElectricAdmittance Nanosiemens(this double value) => ElectricAdmittance.FromNanosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromNanosiemens(double?)"/>
        public static ElectricAdmittance? Nanosiemens(this double? value) => ElectricAdmittance.FromNanosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromNanosiemens(double)"/>
        public static ElectricAdmittance Nanosiemens(this float value) => ElectricAdmittance.FromNanosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromNanosiemens(double?)"/>
        public static ElectricAdmittance? Nanosiemens(this float? value) => ElectricAdmittance.FromNanosiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromNanosiemens(double)"/>
        public static ElectricAdmittance Nanosiemens(this decimal value) => ElectricAdmittance.FromNanosiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromNanosiemens(double?)"/>
        public static ElectricAdmittance? Nanosiemens(this decimal? value) => ElectricAdmittance.FromNanosiemens(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Siemens

        /// <inheritdoc cref="ElectricAdmittance.FromSiemens(double)"/>
        public static ElectricAdmittance Siemens(this int value) => ElectricAdmittance.FromSiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromSiemens(double?)"/>
        public static ElectricAdmittance? Siemens(this int? value) => ElectricAdmittance.FromSiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromSiemens(double)"/>
        public static ElectricAdmittance Siemens(this long value) => ElectricAdmittance.FromSiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromSiemens(double?)"/>
        public static ElectricAdmittance? Siemens(this long? value) => ElectricAdmittance.FromSiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromSiemens(double)"/>
        public static ElectricAdmittance Siemens(this double value) => ElectricAdmittance.FromSiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromSiemens(double?)"/>
        public static ElectricAdmittance? Siemens(this double? value) => ElectricAdmittance.FromSiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromSiemens(double)"/>
        public static ElectricAdmittance Siemens(this float value) => ElectricAdmittance.FromSiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromSiemens(double?)"/>
        public static ElectricAdmittance? Siemens(this float? value) => ElectricAdmittance.FromSiemens(value);

        /// <inheritdoc cref="ElectricAdmittance.FromSiemens(double)"/>
        public static ElectricAdmittance Siemens(this decimal value) => ElectricAdmittance.FromSiemens(Convert.ToDouble(value));

        /// <inheritdoc cref="ElectricAdmittance.FromSiemens(double?)"/>
        public static ElectricAdmittance? Siemens(this decimal? value) => ElectricAdmittance.FromSiemens(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
