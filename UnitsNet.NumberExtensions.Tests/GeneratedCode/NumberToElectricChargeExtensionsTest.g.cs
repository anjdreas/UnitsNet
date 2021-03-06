//------------------------------------------------------------------------------
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

using UnitsNet.NumberExtensions.NumberToElectricCharge;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToElectricChargeExtensionsTests
    {
        [Fact]
        public void NumberToAmpereHoursTest() =>
            Assert.Equal(ElectricCharge.FromAmpereHours(2), 2.AmpereHours());

        [Fact]
        public void NumberToCoulombsTest() =>
            Assert.Equal(ElectricCharge.FromCoulombs(2), 2.Coulombs());

        [Fact]
        public void NumberToKiloampereHoursTest() =>
            Assert.Equal(ElectricCharge.FromKiloampereHours(2), 2.KiloampereHours());

        [Fact]
        public void NumberToMegaampereHoursTest() =>
            Assert.Equal(ElectricCharge.FromMegaampereHours(2), 2.MegaampereHours());

        [Fact]
        public void NumberToMilliampereHoursTest() =>
            Assert.Equal(ElectricCharge.FromMilliampereHours(2), 2.MilliampereHours());

    }
}
