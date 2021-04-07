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

namespace UnitsNet.NumberExtensions.NumberToForce
{
    /// <summary>
    /// A number to Force Extensions
    /// </summary>
    public static class NumberToForceExtensions
    {
        /// <inheritdoc cref="Force.FromDecanewtons(UnitsNet.QuantityValue)" />
        public static Force Decanewtons<T>(this T value) =>
            Force.FromDecanewtons(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromDyne(UnitsNet.QuantityValue)" />
        public static Force Dyne<T>(this T value) =>
            Force.FromDyne(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromKilogramsForce(UnitsNet.QuantityValue)" />
        public static Force KilogramsForce<T>(this T value) =>
            Force.FromKilogramsForce(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromKilonewtons(UnitsNet.QuantityValue)" />
        public static Force Kilonewtons<T>(this T value) =>
            Force.FromKilonewtons(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromKiloPonds(UnitsNet.QuantityValue)" />
        public static Force KiloPonds<T>(this T value) =>
            Force.FromKiloPonds(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromKilopoundsForce(UnitsNet.QuantityValue)" />
        public static Force KilopoundsForce<T>(this T value) =>
            Force.FromKilopoundsForce(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromMeganewtons(UnitsNet.QuantityValue)" />
        public static Force Meganewtons<T>(this T value) =>
            Force.FromMeganewtons(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromMicronewtons(UnitsNet.QuantityValue)" />
        public static Force Micronewtons<T>(this T value) =>
            Force.FromMicronewtons(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromMillinewtons(UnitsNet.QuantityValue)" />
        public static Force Millinewtons<T>(this T value) =>
            Force.FromMillinewtons(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromNewtons(UnitsNet.QuantityValue)" />
        public static Force Newtons<T>(this T value) =>
            Force.FromNewtons(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromOunceForce(UnitsNet.QuantityValue)" />
        public static Force OunceForce<T>(this T value) =>
            Force.FromOunceForce(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromPoundals(UnitsNet.QuantityValue)" />
        public static Force Poundals<T>(this T value) =>
            Force.FromPoundals(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromPoundsForce(UnitsNet.QuantityValue)" />
        public static Force PoundsForce<T>(this T value) =>
            Force.FromPoundsForce(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromShortTonsForce(UnitsNet.QuantityValue)" />
        public static Force ShortTonsForce<T>(this T value) =>
            Force.FromShortTonsForce(Convert.ToDouble(value));

        /// <inheritdoc cref="Force.FromTonnesForce(UnitsNet.QuantityValue)" />
        public static Force TonnesForce<T>(this T value) =>
            Force.FromTonnesForce(Convert.ToDouble(value));

    }
}
