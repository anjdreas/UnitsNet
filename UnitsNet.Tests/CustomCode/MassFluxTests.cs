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

using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class MassFluxTests : MassFluxTestsBase
    {
        protected override bool SupportsSIUnitSystem => true;
        protected override double GramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter => 1E3;
        protected override double GramsPerSecondPerSquareCentimeterInOneKilogramPerSecondPerSquareMeter => 1E-1;
        protected override double GramsPerSecondPerSquareMillimeterInOneKilogramPerSecondPerSquareMeter => 1E-3;

        protected override double GramsPerHourPerSquareMeterInOneKilogramPerSecondPerSquareMeter => 3.6E6;
        protected override double GramsPerHourPerSquareCentimeterInOneKilogramPerSecondPerSquareMeter => 3.6E2;
        protected override double GramsPerHourPerSquareMillimeterInOneKilogramPerSecondPerSquareMeter => 3.6E0;

        protected override double KilogramsPerSecondPerSquareMeterInOneKilogramPerSecondPerSquareMeter => 1;
        protected override double KilogramsPerSecondPerSquareCentimeterInOneKilogramPerSecondPerSquareMeter => 1E-4;
        protected override double KilogramsPerSecondPerSquareMillimeterInOneKilogramPerSecondPerSquareMeter => 1E-6;

        protected override double KilogramsPerHourPerSquareMeterInOneKilogramPerSecondPerSquareMeter => 3.6E3;
        protected override double KilogramsPerHourPerSquareCentimeterInOneKilogramPerSecondPerSquareMeter => 3.6E-1;
        protected override double KilogramsPerHourPerSquareMillimeterInOneKilogramPerSecondPerSquareMeter => 3.6E-3;


        [Fact]
        public void MassFluxDividedBySpeedEqualsDensity()
        {
            Density density = MassFlux.FromKilogramsPerSecondPerSquareMeter(20) / Speed.FromMetersPerSecond(2);
            Assert.Equal(density, Density.FromKilogramsPerCubicMeter(10));
        }

        [Fact]
        public void MassFluxDividedByDensityEqualsSpeed()
        {
            Speed speed = MassFlux.FromKilogramsPerSecondPerSquareMeter(20) / Density.FromKilogramsPerCubicMeter(2);
            Assert.Equal(speed, Speed.FromMetersPerSecond(10));
        }

        [Fact]
        public void MassFluxTimesAreaEqualsMassFlow()
        {
            MassFlow massFlow = MassFlux.FromKilogramsPerSecondPerSquareMeter(20) * Area.FromSquareMeters(2);
            Assert.Equal(massFlow, MassFlow.FromKilogramsPerSecond(40));
        }
    }
}
