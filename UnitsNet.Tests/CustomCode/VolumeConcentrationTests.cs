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
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class VolumeConcentrationTests : VolumeConcentrationTestsBase
    {
        protected override bool SupportsSIUnitSystem => true;

        #region Unit Conversion Coefficients
        protected override double LitersPerMililiterInOneDecimalFraction => 1E-3;
        protected override double DecilitersPerMililiterInOneDecimalFraction => 1E-2;
        protected override double CentilitersPerMililiterInOneDecimalFraction => 1E-1;
        protected override double MillilitersPerMililiterInOneDecimalFraction => 1;
        protected override double MicrolitersPerMililiterInOneDecimalFraction => 1E3;
        protected override double NanolitersPerMililiterInOneDecimalFraction => 1E6;
        protected override double PicolitersPerMililiterInOneDecimalFraction => 1E9;

        protected override double LitersPerLiterInOneDecimalFraction => 1;
        protected override double DecilitersPerLiterInOneDecimalFraction => 10;
        protected override double CentilitersPerLiterInOneDecimalFraction => 1E2;
        protected override double MillilitersPerLiterInOneDecimalFraction => 1E3;
        protected override double MicrolitersPerLiterInOneDecimalFraction => 1E6;
        protected override double NanolitersPerLiterInOneDecimalFraction => 1E9;
        protected override double PicolitersPerLiterInOneDecimalFraction => 1E12;

        protected override double PartsPerThousandInOneDecimalFraction => 1e3;
        protected override double PartsPerMillionInOneDecimalFraction => 1e6;
        protected override double PartsPerBillionInOneDecimalFraction => 1e9;
        protected override double PartsPerTrillionInOneDecimalFraction => 1e12;

        protected override double DecimalFractionsInOneDecimalFraction => 1;
        protected override double PercentInOneDecimalFraction => 100;
        #endregion

        [Theory]
        [InlineData(50, VolumeConcentrationUnit.Percent,
                    10, DensityUnit.GramPerCubicMeter,
                    5, MassConcentrationUnit.GramPerCubicMeter)]    // synthetic data
        [InlineData(29.19419518377693, VolumeConcentrationUnit.MillilitersPerLiter,
                    KnownQuantities.DensityOfEthanolInKgPerCubicMeter, DensityUnit.KilogramPerCubicMeter,
                    23.03422, MassConcentrationUnit.GramPerLiter)]  // 29.19419518377693 = VolumeConcentration_0_5M_Ethanol
        public void MassConcentrationFromVolumeConcentrationAndComponentDensity(
            double volumeConcValue, VolumeConcentrationUnit volumeConcUnit,
            double componentDensityValue, DensityUnit componentDensityUnit,
            double expectedMassConcValue, MassConcentrationUnit expectedMassConcUnit,
            double tolerence = 1e-5)
        {
            var volumeConcentration = new VolumeConcentration(volumeConcValue, volumeConcUnit);
            var componentDensity = new Density(componentDensityValue, componentDensityUnit);

            MassConcentration massConcentration = volumeConcentration.ToMassConcentration(componentDensity); // volumeConcentration * density

            AssertEx.EqualTolerance(expectedMassConcValue, massConcentration.As(expectedMassConcUnit), tolerence);
        }

        [Theory]
        [InlineData(29.19419518377693, VolumeConcentrationUnit.MillilitersPerLiter,
                    KnownQuantities.DensityOfEthanolInKgPerCubicMeter, DensityUnit.KilogramPerCubicMeter,
                    KnownQuantities.MolarMassOfEthanolInGramsPerMole, MolarMassUnit.GramPerMole,
                    0.5, MolarityUnit.MolesPerLiter)]   // 29.19419518377693 = VolumeConcentration_0_5M_Ethanol
        public void MolarityFromVolumeConcentrationAndComponentDensityAndMolarMass(
            double volumeConcValue, VolumeConcentrationUnit volumeConcUnit,
            double componentDensityValue, DensityUnit componetDensityUnit,
            double componentMolarMassValue, MolarMassUnit componentMolarMassUnit,
            double expectedMolarityValue, MolarityUnit expectedMolarityUnit, double tolerence = 1e-5)
        {
            var volumeConcentration = new VolumeConcentration(volumeConcValue, volumeConcUnit);
            var componentDensity = new Density(componentDensityValue, componetDensityUnit);
            var componentMolarMass = new MolarMass(componentMolarMassValue, componentMolarMassUnit);

            Molarity molarity = volumeConcentration.ToMolarity(componentDensity, componentMolarMass); // volumeConcentration * density / molarMass

            AssertEx.EqualTolerance(expectedMolarityValue, molarity.As(expectedMolarityUnit), tolerence);
        }

    }
}
