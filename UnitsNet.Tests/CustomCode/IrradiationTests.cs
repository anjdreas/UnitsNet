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

namespace UnitsNet.Tests.CustomCode
{
    public class IrradiationTests : IrradiationTestsBase
    {
        protected override bool SupportsSIUnitSystem => true;
        protected override double JoulesPerSquareMeterInOneJoulePerSquareMeter => 1;

        protected override double KilojoulesPerSquareMeterInOneJoulePerSquareMeter => 1E-3;

        protected override double JoulesPerSquareCentimeterInOneJoulePerSquareMeter => 1E-4;

        protected override double JoulesPerSquareMillimeterInOneJoulePerSquareMeter => 1E-6;

        protected override double MillijoulesPerSquareCentimeterInOneJoulePerSquareMeter => 1e-1;

        protected override double WattHoursPerSquareMeterInOneJoulePerSquareMeter => 2.777777777777778e-4;

        protected override double KilowattHoursPerSquareMeterInOneJoulePerSquareMeter => 2.777777777777778e-7;
    }
}
