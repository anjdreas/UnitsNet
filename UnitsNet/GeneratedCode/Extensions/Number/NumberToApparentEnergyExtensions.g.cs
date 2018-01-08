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

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToApparentEnergy
{
    public static class NumberToApparentEnergyExtensions
    {
        #region KilovoltampereHour

        /// <inheritdoc cref="ApparentEnergy.FromKilovoltamperesHour(double)"/>
        public static ApparentEnergy KilovoltamperesHour(this int value) => ApparentEnergy.FromKilovoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromKilovoltamperesHour(double?)"/>
        public static ApparentEnergy? KilovoltamperesHour(this int? value) => ApparentEnergy.FromKilovoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromKilovoltamperesHour(double)"/>
        public static ApparentEnergy KilovoltamperesHour(this long value) => ApparentEnergy.FromKilovoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromKilovoltamperesHour(double?)"/>
        public static ApparentEnergy? KilovoltamperesHour(this long? value) => ApparentEnergy.FromKilovoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromKilovoltamperesHour(double)"/>
        public static ApparentEnergy KilovoltamperesHour(this double value) => ApparentEnergy.FromKilovoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromKilovoltamperesHour(double?)"/>
        public static ApparentEnergy? KilovoltamperesHour(this double? value) => ApparentEnergy.FromKilovoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromKilovoltamperesHour(double)"/>
        public static ApparentEnergy KilovoltamperesHour(this float value) => ApparentEnergy.FromKilovoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromKilovoltamperesHour(double?)"/>
        public static ApparentEnergy? KilovoltamperesHour(this float? value) => ApparentEnergy.FromKilovoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromKilovoltamperesHour(double)"/>
        public static ApparentEnergy KilovoltamperesHour(this decimal value) => ApparentEnergy.FromKilovoltamperesHour(Convert.ToDouble(value));

        /// <inheritdoc cref="ApparentEnergy.FromKilovoltamperesHour(double?)"/>
        public static ApparentEnergy? KilovoltamperesHour(this decimal? value) => ApparentEnergy.FromKilovoltamperesHour(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MegavoltampereHour

        /// <inheritdoc cref="ApparentEnergy.FromMegavoltamperesHour(double)"/>
        public static ApparentEnergy MegavoltamperesHour(this int value) => ApparentEnergy.FromMegavoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromMegavoltamperesHour(double?)"/>
        public static ApparentEnergy? MegavoltamperesHour(this int? value) => ApparentEnergy.FromMegavoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromMegavoltamperesHour(double)"/>
        public static ApparentEnergy MegavoltamperesHour(this long value) => ApparentEnergy.FromMegavoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromMegavoltamperesHour(double?)"/>
        public static ApparentEnergy? MegavoltamperesHour(this long? value) => ApparentEnergy.FromMegavoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromMegavoltamperesHour(double)"/>
        public static ApparentEnergy MegavoltamperesHour(this double value) => ApparentEnergy.FromMegavoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromMegavoltamperesHour(double?)"/>
        public static ApparentEnergy? MegavoltamperesHour(this double? value) => ApparentEnergy.FromMegavoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromMegavoltamperesHour(double)"/>
        public static ApparentEnergy MegavoltamperesHour(this float value) => ApparentEnergy.FromMegavoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromMegavoltamperesHour(double?)"/>
        public static ApparentEnergy? MegavoltamperesHour(this float? value) => ApparentEnergy.FromMegavoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromMegavoltamperesHour(double)"/>
        public static ApparentEnergy MegavoltamperesHour(this decimal value) => ApparentEnergy.FromMegavoltamperesHour(Convert.ToDouble(value));

        /// <inheritdoc cref="ApparentEnergy.FromMegavoltamperesHour(double?)"/>
        public static ApparentEnergy? MegavoltamperesHour(this decimal? value) => ApparentEnergy.FromMegavoltamperesHour(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region VoltampereHour

        /// <inheritdoc cref="ApparentEnergy.FromVoltamperesHour(double)"/>
        public static ApparentEnergy VoltamperesHour(this int value) => ApparentEnergy.FromVoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromVoltamperesHour(double?)"/>
        public static ApparentEnergy? VoltamperesHour(this int? value) => ApparentEnergy.FromVoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromVoltamperesHour(double)"/>
        public static ApparentEnergy VoltamperesHour(this long value) => ApparentEnergy.FromVoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromVoltamperesHour(double?)"/>
        public static ApparentEnergy? VoltamperesHour(this long? value) => ApparentEnergy.FromVoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromVoltamperesHour(double)"/>
        public static ApparentEnergy VoltamperesHour(this double value) => ApparentEnergy.FromVoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromVoltamperesHour(double?)"/>
        public static ApparentEnergy? VoltamperesHour(this double? value) => ApparentEnergy.FromVoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromVoltamperesHour(double)"/>
        public static ApparentEnergy VoltamperesHour(this float value) => ApparentEnergy.FromVoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromVoltamperesHour(double?)"/>
        public static ApparentEnergy? VoltamperesHour(this float? value) => ApparentEnergy.FromVoltamperesHour(value);

        /// <inheritdoc cref="ApparentEnergy.FromVoltamperesHour(double)"/>
        public static ApparentEnergy VoltamperesHour(this decimal value) => ApparentEnergy.FromVoltamperesHour(Convert.ToDouble(value));

        /// <inheritdoc cref="ApparentEnergy.FromVoltamperesHour(double?)"/>
        public static ApparentEnergy? VoltamperesHour(this decimal? value) => ApparentEnergy.FromVoltamperesHour(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
