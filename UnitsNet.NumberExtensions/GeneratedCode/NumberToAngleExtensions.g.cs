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
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;

#nullable enable

namespace UnitsNet.NumberExtensions.NumberToAngle
{
    /// <summary>
    /// A number to Angle Extensions
    /// </summary>
    public static class NumberToAngleExtensions
    {
        /// <inheritdoc cref="Angle.FromArcminutes(UnitsNet.QuantityValue)" />
        public static Angle Arcminutes<T>(this T value) =>
            Angle.FromArcminutes(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromArcseconds(UnitsNet.QuantityValue)" />
        public static Angle Arcseconds<T>(this T value) =>
            Angle.FromArcseconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromCentiradians(UnitsNet.QuantityValue)" />
        public static Angle Centiradians<T>(this T value) =>
            Angle.FromCentiradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromDeciradians(UnitsNet.QuantityValue)" />
        public static Angle Deciradians<T>(this T value) =>
            Angle.FromDeciradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromDegrees(UnitsNet.QuantityValue)" />
        public static Angle Degrees<T>(this T value) =>
            Angle.FromDegrees(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromGradians(UnitsNet.QuantityValue)" />
        public static Angle Gradians<T>(this T value) =>
            Angle.FromGradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromMicrodegrees(UnitsNet.QuantityValue)" />
        public static Angle Microdegrees<T>(this T value) =>
            Angle.FromMicrodegrees(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromMicroradians(UnitsNet.QuantityValue)" />
        public static Angle Microradians<T>(this T value) =>
            Angle.FromMicroradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromMillidegrees(UnitsNet.QuantityValue)" />
        public static Angle Millidegrees<T>(this T value) =>
            Angle.FromMillidegrees(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromMilliradians(UnitsNet.QuantityValue)" />
        public static Angle Milliradians<T>(this T value) =>
            Angle.FromMilliradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromNanodegrees(UnitsNet.QuantityValue)" />
        public static Angle Nanodegrees<T>(this T value) =>
            Angle.FromNanodegrees(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromNanoradians(UnitsNet.QuantityValue)" />
        public static Angle Nanoradians<T>(this T value) =>
            Angle.FromNanoradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromRadians(UnitsNet.QuantityValue)" />
        public static Angle Radians<T>(this T value) =>
            Angle.FromRadians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromRevolutions(UnitsNet.QuantityValue)" />
        public static Angle Revolutions<T>(this T value) =>
            Angle.FromRevolutions(Convert.ToDouble(value));

    }
}
