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

// ReSharper disable once CheckNamespace
namespace UnitsNet.UnitSystems
{

    public partial class USC
    {
        /// <summary>
        /// Returns the list of unit mappings for the current unit system
        /// </summary>
        /// <returns>The list of unit system infos</returns>
        public static UnitSystemInfo[] GetDefaultSystemUnits()
        {
            return new UnitSystemInfo[]
            {
                new UnitSystemInfo(null, new UnitInfo[]{
                    Acceleration.Info.UnitInfos[2],
                    Acceleration.Info.UnitInfos[3],
                    }),
                new UnitSystemInfo(AmountOfSubstance.Info.UnitInfos[14], new UnitInfo[]{
                    AmountOfSubstance.Info.UnitInfos[1],
                    AmountOfSubstance.Info.UnitInfos[3],
                    AmountOfSubstance.Info.UnitInfos[5],
                    AmountOfSubstance.Info.UnitInfos[8],
                    AmountOfSubstance.Info.UnitInfos[10],
                    AmountOfSubstance.Info.UnitInfos[13],
                    AmountOfSubstance.Info.UnitInfos[14],
                    }),
                null,
                null,
                null,
                null,
                new UnitSystemInfo(null, new UnitInfo[]{
                    Area.Info.UnitInfos[0],
                    Area.Info.UnitInfos[4],
                    Area.Info.UnitInfos[5],
                    Area.Info.UnitInfos[9],
                    Area.Info.UnitInfos[12],
                    Area.Info.UnitInfos[13],
                    }),
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                new UnitSystemInfo(Duration.Info.UnitInfos[7], new UnitInfo[]{
                    Duration.Info.UnitInfos[0],
                    Duration.Info.UnitInfos[1],
                    Duration.Info.UnitInfos[2],
                    Duration.Info.UnitInfos[3],
                    Duration.Info.UnitInfos[4],
                    Duration.Info.UnitInfos[5],
                    Duration.Info.UnitInfos[6],
                    Duration.Info.UnitInfos[7],
                    Duration.Info.UnitInfos[8],
                    Duration.Info.UnitInfos[9],
                    }),
                null,
                null,
                null,
                null,
                null,
                null,
                new UnitSystemInfo(ElectricCurrent.Info.UnitInfos[0], new UnitInfo[]{
                    ElectricCurrent.Info.UnitInfos[0],
                    ElectricCurrent.Info.UnitInfos[1],
                    ElectricCurrent.Info.UnitInfos[2],
                    ElectricCurrent.Info.UnitInfos[3],
                    ElectricCurrent.Info.UnitInfos[4],
                    ElectricCurrent.Info.UnitInfos[5],
                    ElectricCurrent.Info.UnitInfos[6],
                    ElectricCurrent.Info.UnitInfos[7],
                    }),
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                new UnitSystemInfo(null, new UnitInfo[]{
                    Energy.Info.UnitInfos[4],
                    Energy.Info.UnitInfos[7],
                    Energy.Info.UnitInfos[33],
                    }),
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                new UnitSystemInfo(Length.Info.UnitInfos[32], new UnitInfo[]{
                    Length.Info.UnitInfos[7],
                    Length.Info.UnitInfos[10],
                    Length.Info.UnitInfos[18],
                    Length.Info.UnitInfos[21],
                    Length.Info.UnitInfos[31],
                    Length.Info.UnitInfos[32],
                    }),
                null,
                null,
                null,
                null,
                null,
                new UnitSystemInfo(LuminousIntensity.Info.UnitInfos[0], new UnitInfo[]{
                    LuminousIntensity.Info.UnitInfos[0],
                    }),
                null,
                null,
                null,
                new UnitSystemInfo(Mass.Info.UnitInfos[18], new UnitInfo[]{
                    Mass.Info.UnitInfos[4],
                    Mass.Info.UnitInfos[8],
                    Mass.Info.UnitInfos[12],
                    Mass.Info.UnitInfos[17],
                    Mass.Info.UnitInfos[18],
                    Mass.Info.UnitInfos[19],
                    Mass.Info.UnitInfos[20],
                    }),
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                new UnitSystemInfo(Temperature.Info.UnitInfos[2], new UnitInfo[]{
                    Temperature.Info.UnitInfos[0],
                    Temperature.Info.UnitInfos[2],
                    Temperature.Info.UnitInfos[4],
                    Temperature.Info.UnitInfos[7],
                    }),
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                null,
                new UnitSystemInfo(null, new UnitInfo[]{
                    Volume.Info.UnitInfos[6],
                    Volume.Info.UnitInfos[8],
                    Volume.Info.UnitInfos[12],
                    Volume.Info.UnitInfos[14],
                    Volume.Info.UnitInfos[15],
                    Volume.Info.UnitInfos[17],
                    Volume.Info.UnitInfos[18],
                    Volume.Info.UnitInfos[21],
                    Volume.Info.UnitInfos[26],
                    Volume.Info.UnitInfos[30],
                    Volume.Info.UnitInfos[32],
                    Volume.Info.UnitInfos[35],
                    Volume.Info.UnitInfos[42],
                    Volume.Info.UnitInfos[43],
                    Volume.Info.UnitInfos[44],
                    Volume.Info.UnitInfos[45],
                    Volume.Info.UnitInfos[46],
                    Volume.Info.UnitInfos[47],
                    Volume.Info.UnitInfos[48],
                    Volume.Info.UnitInfos[49],
                    Volume.Info.UnitInfos[50],
                    }),
                null,
                null,
                null,
                null,
            };
        }
    }
}

