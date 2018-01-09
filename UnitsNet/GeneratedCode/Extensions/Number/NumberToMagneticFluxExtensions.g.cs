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
namespace UnitsNet.Extensions.NumberToMagneticFlux
{
    public static class NumberToMagneticFluxExtensions
    {
        #region Weber

        /// <inheritdoc cref="MagneticFlux.FromWebers(double)"/>
        public static MagneticFlux Webers(this int value) => MagneticFlux.FromWebers(value);

        /// <inheritdoc cref="MagneticFlux.FromWebers(double?)"/>
        public static MagneticFlux? Webers(this int? value) => MagneticFlux.FromWebers(value);

        /// <inheritdoc cref="MagneticFlux.FromWebers(double)"/>
        public static MagneticFlux Webers(this long value) => MagneticFlux.FromWebers(value);

        /// <inheritdoc cref="MagneticFlux.FromWebers(double?)"/>
        public static MagneticFlux? Webers(this long? value) => MagneticFlux.FromWebers(value);

        /// <inheritdoc cref="MagneticFlux.FromWebers(double)"/>
        public static MagneticFlux Webers(this double value) => MagneticFlux.FromWebers(value);

        /// <inheritdoc cref="MagneticFlux.FromWebers(double?)"/>
        public static MagneticFlux? Webers(this double? value) => MagneticFlux.FromWebers(value);

        /// <inheritdoc cref="MagneticFlux.FromWebers(double)"/>
        public static MagneticFlux Webers(this float value) => MagneticFlux.FromWebers(value);

        /// <inheritdoc cref="MagneticFlux.FromWebers(double?)"/>
        public static MagneticFlux? Webers(this float? value) => MagneticFlux.FromWebers(value);

        /// <inheritdoc cref="MagneticFlux.FromWebers(double)"/>
        public static MagneticFlux Webers(this decimal value) => MagneticFlux.FromWebers(Convert.ToDouble(value));

        /// <inheritdoc cref="MagneticFlux.FromWebers(double?)"/>
        public static MagneticFlux? Webers(this decimal? value) => MagneticFlux.FromWebers(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
