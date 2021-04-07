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

using UnitsNet.NumberExtensions.NumberToFuelEfficiency;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToFuelEfficiencyExtensionsTests
    {
        [Fact]
        public void NumberToKilometersPerLitersTest() =>
            Assert.Equal(FuelEfficiency.FromKilometersPerLiters(2), 2.KilometersPerLiters());

        [Fact]
        public void NumberToLitersPer100KilometersTest() =>
            Assert.Equal(FuelEfficiency.FromLitersPer100Kilometers(2), 2.LitersPer100Kilometers());

        [Fact]
        public void NumberToMilesPerUkGallonTest() =>
            Assert.Equal(FuelEfficiency.FromMilesPerUkGallon(2), 2.MilesPerUkGallon());

        [Fact]
        public void NumberToMilesPerUsGallonTest() =>
            Assert.Equal(FuelEfficiency.FromMilesPerUsGallon(2), 2.MilesPerUsGallon());

    }
}
