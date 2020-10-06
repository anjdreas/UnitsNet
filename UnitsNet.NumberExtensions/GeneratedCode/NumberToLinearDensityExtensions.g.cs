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

namespace UnitsNet.NumberExtensions.NumberToLinearDensity
{
    /// <summary>
    /// A number to LinearDensity Extensions
    /// </summary>
    public static class NumberToLinearDensityExtensions
    {
        /// <inheritdoc cref="LinearDensity.FromGramsPerCentimeter(UnitsNet.QuantityValue)" />
        public static LinearDensity GramsPerCentimeter<T>(this T value) =>
            LinearDensity.FromGramsPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromGramsPerMeter(UnitsNet.QuantityValue)" />
        public static LinearDensity GramsPerMeter<T>(this T value) =>
            LinearDensity.FromGramsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromGramsPerMillimeter(UnitsNet.QuantityValue)" />
        public static LinearDensity GramsPerMillimeter<T>(this T value) =>
            LinearDensity.FromGramsPerMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromKilogramsPerCentimeter(UnitsNet.QuantityValue)" />
        public static LinearDensity KilogramsPerCentimeter<T>(this T value) =>
            LinearDensity.FromKilogramsPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromKilogramsPerMeter(UnitsNet.QuantityValue)" />
        public static LinearDensity KilogramsPerMeter<T>(this T value) =>
            LinearDensity.FromKilogramsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromKilogramsPerMillimeter(UnitsNet.QuantityValue)" />
        public static LinearDensity KilogramsPerMillimeter<T>(this T value) =>
            LinearDensity.FromKilogramsPerMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMicrogramsPerCentimeter(UnitsNet.QuantityValue)" />
        public static LinearDensity MicrogramsPerCentimeter<T>(this T value) =>
            LinearDensity.FromMicrogramsPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMicrogramsPerMeter(UnitsNet.QuantityValue)" />
        public static LinearDensity MicrogramsPerMeter<T>(this T value) =>
            LinearDensity.FromMicrogramsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMicrogramsPerMillimeter(UnitsNet.QuantityValue)" />
        public static LinearDensity MicrogramsPerMillimeter<T>(this T value) =>
            LinearDensity.FromMicrogramsPerMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMilligramsPerCentimeter(UnitsNet.QuantityValue)" />
        public static LinearDensity MilligramsPerCentimeter<T>(this T value) =>
            LinearDensity.FromMilligramsPerCentimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMilligramsPerMeter(UnitsNet.QuantityValue)" />
        public static LinearDensity MilligramsPerMeter<T>(this T value) =>
            LinearDensity.FromMilligramsPerMeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromMilligramsPerMillimeter(UnitsNet.QuantityValue)" />
        public static LinearDensity MilligramsPerMillimeter<T>(this T value) =>
            LinearDensity.FromMilligramsPerMillimeter(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromPoundsPerFoot(UnitsNet.QuantityValue)" />
        public static LinearDensity PoundsPerFoot<T>(this T value) =>
            LinearDensity.FromPoundsPerFoot(Convert.ToDouble(value));

        /// <inheritdoc cref="LinearDensity.FromPoundsPerInch(UnitsNet.QuantityValue)" />
        public static LinearDensity PoundsPerInch<T>(this T value) =>
            LinearDensity.FromPoundsPerInch(Convert.ToDouble(value));

    }
}
