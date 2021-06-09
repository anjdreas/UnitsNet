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

using UnitsNet.NumberExtensions.NumberToAmountOfSubstance;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToAmountOfSubstanceExtensionsTests
    {
        [Fact]
        public void NumberToCentimolesTest() =>
            Assert.Equal(AmountOfSubstance.FromCentimoles(2), 2.Centimoles());

        [Fact]
        public void NumberToCentipoundMolesTest() =>
            Assert.Equal(AmountOfSubstance.FromCentipoundMoles(2), 2.CentipoundMoles());

        [Fact]
        public void NumberToDecimolesTest() =>
            Assert.Equal(AmountOfSubstance.FromDecimoles(2), 2.Decimoles());

        [Fact]
        public void NumberToDecipoundMolesTest() =>
            Assert.Equal(AmountOfSubstance.FromDecipoundMoles(2), 2.DecipoundMoles());

        [Fact]
        public void NumberToKilomolesTest() =>
            Assert.Equal(AmountOfSubstance.FromKilomoles(2), 2.Kilomoles());

        [Fact]
        public void NumberToKilopoundMolesTest() =>
            Assert.Equal(AmountOfSubstance.FromKilopoundMoles(2), 2.KilopoundMoles());

        [Fact]
        public void NumberToMegamolesTest() =>
            Assert.Equal(AmountOfSubstance.FromMegamoles(2), 2.Megamoles());

        [Fact]
        public void NumberToMicromolesTest() =>
            Assert.Equal(AmountOfSubstance.FromMicromoles(2), 2.Micromoles());

        [Fact]
        public void NumberToMicropoundMolesTest() =>
            Assert.Equal(AmountOfSubstance.FromMicropoundMoles(2), 2.MicropoundMoles());

        [Fact]
        public void NumberToMillimolesTest() =>
            Assert.Equal(AmountOfSubstance.FromMillimoles(2), 2.Millimoles());

        [Fact]
        public void NumberToMillipoundMolesTest() =>
            Assert.Equal(AmountOfSubstance.FromMillipoundMoles(2), 2.MillipoundMoles());

        [Fact]
        public void NumberToMolesTest() =>
            Assert.Equal(AmountOfSubstance.FromMoles(2), 2.Moles());

        [Fact]
        public void NumberToNanomolesTest() =>
            Assert.Equal(AmountOfSubstance.FromNanomoles(2), 2.Nanomoles());

        [Fact]
        public void NumberToNanopoundMolesTest() =>
            Assert.Equal(AmountOfSubstance.FromNanopoundMoles(2), 2.NanopoundMoles());

        [Fact]
        public void NumberToPoundMolesTest() =>
            Assert.Equal(AmountOfSubstance.FromPoundMoles(2), 2.PoundMoles());

    }
}