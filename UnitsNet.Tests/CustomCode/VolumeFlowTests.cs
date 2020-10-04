﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated (once) by \generate-code.bat, but will not be
//     regenerated when it already exists. The purpose of creating this file is to make
//     it easier to remember to implement all the unit conversion test cases.
//
//     Whenever a new unit is added to this quantity and \generate-code.bat is run,
//     the base test class will get a new abstract property and cause a compile error
//     in this derived class, reminding the developer to implement the test case
//     for the new unit.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class VolumeFlowTests : VolumeFlowTestsBase
    {
        protected override bool SupportsSIUnitSystem => true;
        protected override double CubicMetersPerHourInOneCubicMeterPerSecond => 3.6e3;

        protected override double CubicDecimetersPerMinuteInOneCubicMeterPerSecond => 6e4;

        protected override double CubicFeetPerHourInOneCubicMeterPerSecond => 1.271328001973604e+5;

        protected override double CubicFeetPerSecondInOneCubicMeterPerSecond => 35.314666721489;

        protected override double MillionUsGallonsPerDayInOneCubicMeterPerSecond => 22.824465227;

        protected override double CubicMetersPerSecondInOneCubicMeterPerSecond => 1;

        protected override double UsGallonsPerMinuteInOneCubicMeterPerSecond => 1.5850323141489e4;
        protected override double LitersPerHourInOneCubicMeterPerSecond => 3.6e6;

        protected override double LitersPerMinuteInOneCubicMeterPerSecond => 6e4;

        protected override double NanolitersPerMinuteInOneCubicMeterPerSecond => 6e13;
        protected override double LitersPerSecondInOneCubicMeterPerSecond => 1000;

        protected override double MicrolitersPerMinuteInOneCubicMeterPerSecond => 6e10;

        protected override double MillilitersPerMinuteInOneCubicMeterPerSecond => 6e7;

        protected override double CentilitersPerMinuteInOneCubicMeterPerSecond => 6e6;

        protected override double DecilitersPerMinuteInOneCubicMeterPerSecond => 6e5;

        protected override double KilolitersPerMinuteInOneCubicMeterPerSecond => 60;

        protected override double OilBarrelsPerDayInOneCubicMeterPerSecond => 5.4343965056533388306722269588172e5;

        protected override double CubicFeetPerMinuteInOneCubicMeterPerSecond => 2.11888E3;

        protected override double CubicMetersPerMinuteInOneCubicMeterPerSecond => 6.0E1;

        protected override double CubicYardsPerHourInOneCubicMeterPerSecond => 4.708622232E3;

        protected override double CubicYardsPerMinuteInOneCubicMeterPerSecond => 7.84770372E1;

        protected override double CubicYardsPerSecondInOneCubicMeterPerSecond => 1.30795062;

        protected override double UsGallonsPerHourInOneCubicMeterPerSecond => 9.510193884893328E5;

        protected override double UsGallonsPerSecondInOneCubicMeterPerSecond => 2.64172052358148E2;

        protected override double AcreFeetPerDayInOneCubicMeterPerSecond => 70.0457;

        protected override double AcreFeetPerHourInOneCubicMeterPerSecond => 2.91857;

        protected override double AcreFeetPerMinuteInOneCubicMeterPerSecond => 0.0486427916;

        protected override double AcreFeetPerSecondInOneCubicMeterPerSecond => 0.000810714;

        protected override double CentilitersPerDayInOneCubicMeterPerSecond => 8.64e9;

        protected override double CubicMetersPerDayInOneCubicMeterPerSecond => 8.64e4;

        protected override double CubicYardsPerDayInOneCubicMeterPerSecond => 1.13007e5;

        protected override double DecilitersPerDayInOneCubicMeterPerSecond => 8.64e8;

        protected override double KilolitersPerDayInOneCubicMeterPerSecond => 8.64e4;

        protected override double LitersPerDayInOneCubicMeterPerSecond => 8.64e7;

        protected override double MegalitersPerDayInOneCubicMeterPerSecond => 86.4;

        protected override double MicrolitersPerDayInOneCubicMeterPerSecond => 8.64e+13;

        protected override double MillilitersPerDayInOneCubicMeterPerSecond => 8.64e+10;

        protected override double NanolitersPerDayInOneCubicMeterPerSecond => 8.64e+16;

        protected override double OilBarrelsPerSecondInOneCubicMeterPerSecond => 6.28981;

        protected override double UkGallonsPerDayInOneCubicMeterPerSecond => 1.9005304e7;

        protected override double UkGallonsPerHourInOneCubicMeterPerSecond => 791888.967;

        protected override double UkGallonsPerMinuteInOneCubicMeterPerSecond => 1.31982e4;

        protected override double UkGallonsPerSecondInOneCubicMeterPerSecond => 219.969;

        protected override double UsGallonsPerDayInOneCubicMeterPerSecond => 2.2824465227e7;

        protected override double MegaukGallonsPerSecondInOneCubicMeterPerSecond => 2.19969e-4;

        protected override double OilBarrelsPerHourInOneCubicMeterPerSecond => 2.26431877E4;

        protected override double OilBarrelsPerMinuteInOneCubicMeterPerSecond => 3.77388865E2;

        protected override double KilousGallonsPerMinuteInOneCubicMeterPerSecond => 1.5850323141489e1;

        protected override double CubicMillimetersPerSecondInOneCubicMeterPerSecond => 1e9;

        [Theory]
        [InlineData(20, 2, 40)]
        [InlineData(20, 62, 1240)]
        public void VolumeFlowTimesTimeSpanEqualsVolume(double cubicMetersPerSecond, double seconds, double expectedCubicMeters)
        {
            Volume volume = VolumeFlow.FromCubicMetersPerSecond(cubicMetersPerSecond) * TimeSpan.FromSeconds(seconds);
            Assert.Equal(Volume.FromCubicMeters(expectedCubicMeters), volume);
        }

        [Fact]
        public void VolumeFlowTimesDurationEqualsVolume()
        {
            Volume volume = VolumeFlow.FromCubicMetersPerSecond(20) * Duration.FromSeconds(2);
            Assert.Equal(Volume.FromCubicMeters(40), volume);
        }

        [Fact]
        public void VolumeFlowDividedByAreaEqualsSpeed()
        {
            Speed speed = VolumeFlow.FromCubicMetersPerSecond(40) / Area.FromSquareMeters(20);
            Assert.Equal(Speed.FromMetersPerSecond(2), speed);
        }

        [Fact]
        public void VolumeFlowDividedBySpeedEqualsArea()
        {
            Area area = VolumeFlow.FromCubicMetersPerSecond(40) / Speed.FromMetersPerSecond(20);
            Assert.Equal(Area.FromSquareMeters(2), area);
        }

        [Fact]
        public void VolumeFlowTimesDensityEqualsMassFlow()
        {
            MassFlow massFlow = VolumeFlow.FromCubicMetersPerSecond(2) * Density.FromKilogramsPerCubicMeter(3);
            Assert.Equal(MassFlow.FromKilogramsPerSecond(6), massFlow);
        }

        [Fact]
        public void DensityTimesVolumeFlowEqualsMassFlow()
        {
            MassFlow massFlow = Density.FromKilogramsPerCubicMeter(3) * VolumeFlow.FromCubicMetersPerSecond(7);
            Assert.Equal(MassFlow.FromKilogramsPerSecond(21), massFlow);
        }
    }
}
