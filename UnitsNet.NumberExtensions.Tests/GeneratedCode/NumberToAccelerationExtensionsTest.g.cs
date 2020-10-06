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

using UnitsNet.NumberExtensions.NumberToAcceleration;
using Xunit;

namespace UnitsNet.Tests
{    
    public class NumberToAccelerationExtensionsTests
    {
        [Fact]
        public void NumberToCentimetersPerSecondSquaredTest() =>
            Assert.Equal(Acceleration.FromCentimetersPerSecondSquared(2), 2.CentimetersPerSecondSquared());

        [Fact]
        public void NumberToDecimetersPerSecondSquaredTest() =>
            Assert.Equal(Acceleration.FromDecimetersPerSecondSquared(2), 2.DecimetersPerSecondSquared());

        [Fact]
        public void NumberToFeetPerSecondSquaredTest() =>
            Assert.Equal(Acceleration.FromFeetPerSecondSquared(2), 2.FeetPerSecondSquared());

        [Fact]
        public void NumberToInchesPerSecondSquaredTest() =>
            Assert.Equal(Acceleration.FromInchesPerSecondSquared(2), 2.InchesPerSecondSquared());

        [Fact]
        public void NumberToKilometersPerSecondSquaredTest() =>
            Assert.Equal(Acceleration.FromKilometersPerSecondSquared(2), 2.KilometersPerSecondSquared());

        [Fact]
        public void NumberToKnotsPerHourTest() =>
            Assert.Equal(Acceleration.FromKnotsPerHour(2), 2.KnotsPerHour());

        [Fact]
        public void NumberToKnotsPerMinuteTest() =>
            Assert.Equal(Acceleration.FromKnotsPerMinute(2), 2.KnotsPerMinute());

        [Fact]
        public void NumberToKnotsPerSecondTest() =>
            Assert.Equal(Acceleration.FromKnotsPerSecond(2), 2.KnotsPerSecond());

        [Fact]
        public void NumberToMetersPerSecondSquaredTest() =>
            Assert.Equal(Acceleration.FromMetersPerSecondSquared(2), 2.MetersPerSecondSquared());

        [Fact]
        public void NumberToMicrometersPerSecondSquaredTest() =>
            Assert.Equal(Acceleration.FromMicrometersPerSecondSquared(2), 2.MicrometersPerSecondSquared());

        [Fact]
        public void NumberToMillimetersPerSecondSquaredTest() =>
            Assert.Equal(Acceleration.FromMillimetersPerSecondSquared(2), 2.MillimetersPerSecondSquared());

        [Fact]
        public void NumberToMillistandardGravityTest() =>
            Assert.Equal(Acceleration.FromMillistandardGravity(2), 2.MillistandardGravity());

        [Fact]
        public void NumberToNanometersPerSecondSquaredTest() =>
            Assert.Equal(Acceleration.FromNanometersPerSecondSquared(2), 2.NanometersPerSecondSquared());

        [Fact]
        public void NumberToStandardGravityTest() =>
            Assert.Equal(Acceleration.FromStandardGravity(2), 2.StandardGravity());

    }
}
