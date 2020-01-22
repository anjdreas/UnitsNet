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
                        
namespace UnitsNet.Extensions.NumberToVolumePerLength
{
    /// <summary>
    /// A number to VolumePerLength Extensions
    /// </summary>
    public static class NumberToVolumePerLengthExtensions
    {

        #region CubicMeterPerMeter

        /// <inheritdoc cref="VolumePerLength.FromCubicMetersPerMeter(UnitsNet.QuantityValue)" />
        public static VolumePerLength CubicMetersPerMeter<T>(this T value) =>
             VolumePerLength.FromCubicMetersPerMeter(Convert.ToDouble(value));

        #endregion

        #region CubicYardPerFoot

        /// <inheritdoc cref="VolumePerLength.FromCubicYardsPerFoot(UnitsNet.QuantityValue)" />
        public static VolumePerLength CubicYardsPerFoot<T>(this T value) =>
             VolumePerLength.FromCubicYardsPerFoot(Convert.ToDouble(value));

        #endregion

        #region CubicYardPerUsSurveyFoot

        /// <inheritdoc cref="VolumePerLength.FromCubicYardsPerUsSurveyFoot(UnitsNet.QuantityValue)" />
        public static VolumePerLength CubicYardsPerUsSurveyFoot<T>(this T value) =>
             VolumePerLength.FromCubicYardsPerUsSurveyFoot(Convert.ToDouble(value));

        #endregion

        #region LiterPerMeter

        /// <inheritdoc cref="VolumePerLength.FromLitersPerMeter(UnitsNet.QuantityValue)" />
        public static VolumePerLength LitersPerMeter<T>(this T value) =>
             VolumePerLength.FromLitersPerMeter(Convert.ToDouble(value));

        #endregion

        #region OilBarrelPerFoot

        /// <inheritdoc cref="VolumePerLength.FromOilBarrelsPerFoot(UnitsNet.QuantityValue)" />
        public static VolumePerLength OilBarrelsPerFoot<T>(this T value) =>
             VolumePerLength.FromOilBarrelsPerFoot(Convert.ToDouble(value));

        #endregion

    }
}
