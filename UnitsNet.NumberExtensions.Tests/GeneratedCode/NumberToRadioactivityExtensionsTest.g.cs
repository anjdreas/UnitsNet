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

using UnitsNet.NumberExtensions.NumberToRadioactivity;
using Xunit;

namespace UnitsNet.Tests
{
    public class NumberToRadioactivityExtensionsTests
    {
        [Fact]
        public void NumberToBecquerelsTest() =>
            Assert.Equal(Radioactivity.FromBecquerels(2), 2.Becquerels());

        [Fact]
        public void NumberToCuriesTest() =>
            Assert.Equal(Radioactivity.FromCuries(2), 2.Curies());

        [Fact]
        public void NumberToGigabecquerelsTest() =>
            Assert.Equal(Radioactivity.FromGigabecquerels(2), 2.Gigabecquerels());

        [Fact]
        public void NumberToKilobecquerelsTest() =>
            Assert.Equal(Radioactivity.FromKilobecquerels(2), 2.Kilobecquerels());

        [Fact]
        public void NumberToMegabecquerelsTest() =>
            Assert.Equal(Radioactivity.FromMegabecquerels(2), 2.Megabecquerels());

        [Fact]
        public void NumberToMicrocuriesTest() =>
            Assert.Equal(Radioactivity.FromMicrocuries(2), 2.Microcuries());

        [Fact]
        public void NumberToMillicuriesTest() =>
            Assert.Equal(Radioactivity.FromMillicuries(2), 2.Millicuries());

        [Fact]
        public void NumberToTerabecquerelsTest() =>
            Assert.Equal(Radioactivity.FromTerabecquerels(2), 2.Terabecquerels());

    }
}
