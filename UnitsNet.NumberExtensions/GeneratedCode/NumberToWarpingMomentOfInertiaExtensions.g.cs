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

namespace UnitsNet.NumberExtensions.NumberToWarpingMomentOfInertia
{
    /// <summary>
    /// A number to WarpingMomentOfInertia Extensions
    /// </summary>
    public static class NumberToWarpingMomentOfInertiaExtensions
    {
        /// <inheritdoc cref="WarpingMomentOfInertia.FromCentimetersToTheSixth(UnitsNet.QuantityValue)" />
        public static WarpingMomentOfInertia CentimetersToTheSixth<T>(this T value) =>
            WarpingMomentOfInertia.FromCentimetersToTheSixth(Convert.ToDouble(value));

        /// <inheritdoc cref="WarpingMomentOfInertia.FromDecimetersToTheSixth(UnitsNet.QuantityValue)" />
        public static WarpingMomentOfInertia DecimetersToTheSixth<T>(this T value) =>
            WarpingMomentOfInertia.FromDecimetersToTheSixth(Convert.ToDouble(value));

        /// <inheritdoc cref="WarpingMomentOfInertia.FromFeetToTheSixth(UnitsNet.QuantityValue)" />
        public static WarpingMomentOfInertia FeetToTheSixth<T>(this T value) =>
            WarpingMomentOfInertia.FromFeetToTheSixth(Convert.ToDouble(value));

        /// <inheritdoc cref="WarpingMomentOfInertia.FromInchesToTheSixth(UnitsNet.QuantityValue)" />
        public static WarpingMomentOfInertia InchesToTheSixth<T>(this T value) =>
            WarpingMomentOfInertia.FromInchesToTheSixth(Convert.ToDouble(value));

        /// <inheritdoc cref="WarpingMomentOfInertia.FromMetersToTheSixth(UnitsNet.QuantityValue)" />
        public static WarpingMomentOfInertia MetersToTheSixth<T>(this T value) =>
            WarpingMomentOfInertia.FromMetersToTheSixth(Convert.ToDouble(value));

        /// <inheritdoc cref="WarpingMomentOfInertia.FromMillimetersToTheSixth(UnitsNet.QuantityValue)" />
        public static WarpingMomentOfInertia MillimetersToTheSixth<T>(this T value) =>
            WarpingMomentOfInertia.FromMillimetersToTheSixth(Convert.ToDouble(value));

    }
}
