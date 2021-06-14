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

using System;

namespace UnitsNet.Tests.CustomCode
{
    public class InverseSpeedTests : InverseSpeedTestsBase
    {
        // Override properties in base class here
        protected override double HoursPerFootInOneSecondPerMeter => 11811;

        protected override double HoursPerInchInOneSecondPerMeter => 1.41732e5;

        protected override double HoursPerMeterInOneSecondPerMeter => 3600;

        protected override double HoursPerMileInOneSecondPerMeter => 2.23694;

        protected override double InverseKnotsInOneSecondPerMeter => 0.514444;

        protected override double MinutesPerFootInOneSecondPerMeter => 196.85;

        protected override double MinutesPerInchInOneSecondPerMeter => 2362.2;

        protected override double MinutesPerMeterInOneSecondPerMeter => 60;

        protected override double SecondsPerFootInOneSecondPerMeter => 0.3048;

        protected override double SecondsPerInchInOneSecondPerMeter => 39.37;

        protected override double SecondsPerMetersInOneSecondPerMeter => 1;

        protected override bool SupportsSIUnitSystem => true;
    }
}
