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

using UnitsNet.NumberExtensions.NumberToRotationalSpeed;
using Xunit;

namespace UnitsNet.Tests
{    
    public class NumberToRotationalSpeedExtensionsTests
    {
        [Fact]
        public void NumberToCentiradiansPerSecondTest() =>
            Assert.Equal(RotationalSpeed.FromCentiradiansPerSecond(2), 2.CentiradiansPerSecond());

        [Fact]
        public void NumberToDeciradiansPerSecondTest() =>
            Assert.Equal(RotationalSpeed.FromDeciradiansPerSecond(2), 2.DeciradiansPerSecond());

        [Fact]
        public void NumberToDegreesPerMinuteTest() =>
            Assert.Equal(RotationalSpeed.FromDegreesPerMinute(2), 2.DegreesPerMinute());

        [Fact]
        public void NumberToDegreesPerSecondTest() =>
            Assert.Equal(RotationalSpeed.FromDegreesPerSecond(2), 2.DegreesPerSecond());

        [Fact]
        public void NumberToMicrodegreesPerSecondTest() =>
            Assert.Equal(RotationalSpeed.FromMicrodegreesPerSecond(2), 2.MicrodegreesPerSecond());

        [Fact]
        public void NumberToMicroradiansPerSecondTest() =>
            Assert.Equal(RotationalSpeed.FromMicroradiansPerSecond(2), 2.MicroradiansPerSecond());

        [Fact]
        public void NumberToMillidegreesPerSecondTest() =>
            Assert.Equal(RotationalSpeed.FromMillidegreesPerSecond(2), 2.MillidegreesPerSecond());

        [Fact]
        public void NumberToMilliradiansPerSecondTest() =>
            Assert.Equal(RotationalSpeed.FromMilliradiansPerSecond(2), 2.MilliradiansPerSecond());

        [Fact]
        public void NumberToNanodegreesPerSecondTest() =>
            Assert.Equal(RotationalSpeed.FromNanodegreesPerSecond(2), 2.NanodegreesPerSecond());

        [Fact]
        public void NumberToNanoradiansPerSecondTest() =>
            Assert.Equal(RotationalSpeed.FromNanoradiansPerSecond(2), 2.NanoradiansPerSecond());

        [Fact]
        public void NumberToRadiansPerSecondTest() =>
            Assert.Equal(RotationalSpeed.FromRadiansPerSecond(2), 2.RadiansPerSecond());

        [Fact]
        public void NumberToRevolutionsPerMinuteTest() =>
            Assert.Equal(RotationalSpeed.FromRevolutionsPerMinute(2), 2.RevolutionsPerMinute());

        [Fact]
        public void NumberToRevolutionsPerSecondTest() =>
            Assert.Equal(RotationalSpeed.FromRevolutionsPerSecond(2), 2.RevolutionsPerSecond());

    }
}
