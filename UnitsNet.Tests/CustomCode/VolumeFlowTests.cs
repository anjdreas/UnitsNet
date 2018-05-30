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
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class VolumeFlowTests : VolumeFlowTestsBase
    {
        protected override double CubicMetersPerHourInOneCubicMeterPerSecond => 3600.0;

        protected override double CubicDecimetersPerMinuteInOneCubicMeterPerSecond => 60000.00000;

        protected override double CubicFeetPerHourInOneCubicMeterPerSecond => 1.271328001973604e+5;

        protected override double CubicFeetPerSecondInOneCubicMeterPerSecond => 35.314666721489;

        protected override double MillionUsGallonsPerDayInOneCubicMeterPerSecond => 22.824465227;

        protected override double CubicMetersPerSecondInOneCubicMeterPerSecond => 1;

        protected override double UsGallonsPerMinuteInOneCubicMeterPerSecond => 15850.323141489;
        protected override double LitersPerHourInOneCubicMeterPerSecond => 3600000;

        protected override double LitersPerMinuteInOneCubicMeterPerSecond => 60000.00000;

        protected override double NanolitersPerMinuteInOneCubicMeterPerSecond => 60000000000000.00000;
        protected override double LitersPerSecondInOneCubicMeterPerSecond => 1000;

        protected override double MicrolitersPerMinuteInOneCubicMeterPerSecond => 60000000000.00000;

        protected override double MillilitersPerMinuteInOneCubicMeterPerSecond => 60000000.00000;

        protected override double CentilitersPerMinuteInOneCubicMeterPerSecond => 6000000.00000;

        protected override double DecilitersPerMinuteInOneCubicMeterPerSecond => 600000.00000;

        protected override double KilolitersPerMinuteInOneCubicMeterPerSecond => 60.00000;

        protected override double OilBarrelsPerDayInOneCubicMeterPerSecond => 543439.65056533388306722269588172;

        protected override double CubicFeetPerMinuteInOneCubicMeterPerSecond => 2.11888E3;

        protected override double CubicMetersPerMinuteInOneCubicMeterPerSecond => 6.0E1;

        protected override double CubicYardsPerHourInOneCubicMeterPerSecond => 4.708622232E3;

        protected override double CubicYardsPerMinuteInOneCubicMeterPerSecond => 7.84770372E1;

        protected override double CubicYardsPerSecondInOneCubicMeterPerSecond => 1.30795062;

        protected override double UsGallonsPerHourInOneCubicMeterPerSecond => 9.510193884893328E5;

        protected override double UsGallonsPerSecondInOneCubicMeterPerSecond => 2.64172052358148E2;

        protected override double AcreFeetPerDayInOneCubicMeterPerSecond => 70.0457;

        protected override double AcreFeetPerHourInOneCubicMeterPerSecond => 2.91857;

        protected override double AcreFeetPerMinuteInOneCubicMeterPerSecond => 0.0486429;

        protected override double AcreFeetPerSecondInOneCubicMeterPerSecond => 0.000810714;

        protected override double CentilitersPerDayInOneCubicMeterPerSecond => 8.64e9;

        protected override double CubicMetersPerDayInOneCubicMeterPerSecond => 86400;

        protected override double CubicYardsPerDayInOneCubicMeterPerSecond => 113007;

        protected override double DecilitersPerDayInOneCubicMeterPerSecond => 8.64e8;

        protected override double KilolitersPerDayInOneCubicMeterPerSecond => 8.64e4;

        protected override double LitersPerDayInOneCubicMeterPerSecond => 8.64e7;

        protected override double MegalitersPerDayInOneCubicMeterPerSecond => 86.4;

        protected override double MicrolitersPerDayInOneCubicMeterPerSecond => 8.64e+13;

        protected override double MillilitersPerDayInOneCubicMeterPerSecond => 8.64e+10;

        protected override double NanolitersPerDayInOneCubicMeterPerSecond => 8.64e+16;

        protected override double OilBarrelsPerSecondInOneCubicMeterPerSecond => 6.28981;

        protected override double UkGallonsPerDayInOneCubicMeterPerSecond => 19005304;

        protected override double UkGallonsPerMinuteInOneCubicMeterPerSecond => 13198.2;

        protected override double UkGallonsPerSecondInOneCubicMeterPerSecond => 219.969;

        protected override double UsGallonsPerDayInOneCubicMeterPerSecond => 22824465.227;

        protected override double MegaukGallonsPerSecondInOneCubicMeterPerSecond => 219.969 * 1e-6;

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
