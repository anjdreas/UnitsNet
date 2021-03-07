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

namespace UnitsNet.NumberExtensions.NumberToStandardVolumeFlow
{
    /// <summary>
    /// A number to StandardVolumeFlow Extensions
    /// </summary>
    public static class NumberToStandardVolumeFlowExtensions
    {
        /// <inheritdoc cref="StandardVolumeFlow.FromStandardCubicCentimetersPerMinute(UnitsNet.QuantityValue)" />
        public static StandardVolumeFlow StandardCubicCentimetersPerMinute<T>(this T value) =>
            StandardVolumeFlow.FromStandardCubicCentimetersPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="StandardVolumeFlow.FromStandardCubicFeetPerHour(UnitsNet.QuantityValue)" />
        public static StandardVolumeFlow StandardCubicFeetPerHour<T>(this T value) =>
            StandardVolumeFlow.FromStandardCubicFeetPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="StandardVolumeFlow.FromStandardCubicFeetPerMinute(UnitsNet.QuantityValue)" />
        public static StandardVolumeFlow StandardCubicFeetPerMinute<T>(this T value) =>
            StandardVolumeFlow.FromStandardCubicFeetPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="StandardVolumeFlow.FromStandardCubicFeetPerSecond(UnitsNet.QuantityValue)" />
        public static StandardVolumeFlow StandardCubicFeetPerSecond<T>(this T value) =>
            StandardVolumeFlow.FromStandardCubicFeetPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="StandardVolumeFlow.FromStandardCubicMetersPerDay(UnitsNet.QuantityValue)" />
        public static StandardVolumeFlow StandardCubicMetersPerDay<T>(this T value) =>
            StandardVolumeFlow.FromStandardCubicMetersPerDay(Convert.ToDouble(value));

        /// <inheritdoc cref="StandardVolumeFlow.FromStandardCubicMetersPerHour(UnitsNet.QuantityValue)" />
        public static StandardVolumeFlow StandardCubicMetersPerHour<T>(this T value) =>
            StandardVolumeFlow.FromStandardCubicMetersPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="StandardVolumeFlow.FromStandardCubicMetersPerMinute(UnitsNet.QuantityValue)" />
        public static StandardVolumeFlow StandardCubicMetersPerMinute<T>(this T value) =>
            StandardVolumeFlow.FromStandardCubicMetersPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="StandardVolumeFlow.FromStandardCubicMetersPerSecond(UnitsNet.QuantityValue)" />
        public static StandardVolumeFlow StandardCubicMetersPerSecond<T>(this T value) =>
            StandardVolumeFlow.FromStandardCubicMetersPerSecond(Convert.ToDouble(value));

        /// <inheritdoc cref="StandardVolumeFlow.FromStandardLitersPerMinute(UnitsNet.QuantityValue)" />
        public static StandardVolumeFlow StandardLitersPerMinute<T>(this T value) =>
            StandardVolumeFlow.FromStandardLitersPerMinute(Convert.ToDouble(value));

    }
}
