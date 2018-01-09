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
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
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

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToPower
{
    public static class NumberToPowerExtensions
    {
        #region BoilerHorsepower

        /// <inheritdoc cref="Power.FromBoilerHorsepower(double)"/>
        public static Power BoilerHorsepower(this int value) => Power.FromBoilerHorsepower(value);

        /// <inheritdoc cref="Power.FromBoilerHorsepower(double?)"/>
        public static Power? BoilerHorsepower(this int? value) => Power.FromBoilerHorsepower(value);

        /// <inheritdoc cref="Power.FromBoilerHorsepower(double)"/>
        public static Power BoilerHorsepower(this long value) => Power.FromBoilerHorsepower(value);

        /// <inheritdoc cref="Power.FromBoilerHorsepower(double?)"/>
        public static Power? BoilerHorsepower(this long? value) => Power.FromBoilerHorsepower(value);

        /// <inheritdoc cref="Power.FromBoilerHorsepower(double)"/>
        public static Power BoilerHorsepower(this double value) => Power.FromBoilerHorsepower(value);

        /// <inheritdoc cref="Power.FromBoilerHorsepower(double?)"/>
        public static Power? BoilerHorsepower(this double? value) => Power.FromBoilerHorsepower(value);

        /// <inheritdoc cref="Power.FromBoilerHorsepower(double)"/>
        public static Power BoilerHorsepower(this float value) => Power.FromBoilerHorsepower(value);

        /// <inheritdoc cref="Power.FromBoilerHorsepower(double?)"/>
        public static Power? BoilerHorsepower(this float? value) => Power.FromBoilerHorsepower(value);

        /// <inheritdoc cref="Power.FromBoilerHorsepower(double)"/>
        public static Power BoilerHorsepower(this decimal value) => Power.FromBoilerHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromBoilerHorsepower(double?)"/>
        public static Power? BoilerHorsepower(this decimal? value) => Power.FromBoilerHorsepower(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region BritishThermalUnitPerHour

        /// <inheritdoc cref="Power.FromBritishThermalUnitsPerHour(double)"/>
        public static Power BritishThermalUnitsPerHour(this int value) => Power.FromBritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromBritishThermalUnitsPerHour(double?)"/>
        public static Power? BritishThermalUnitsPerHour(this int? value) => Power.FromBritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromBritishThermalUnitsPerHour(double)"/>
        public static Power BritishThermalUnitsPerHour(this long value) => Power.FromBritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromBritishThermalUnitsPerHour(double?)"/>
        public static Power? BritishThermalUnitsPerHour(this long? value) => Power.FromBritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromBritishThermalUnitsPerHour(double)"/>
        public static Power BritishThermalUnitsPerHour(this double value) => Power.FromBritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromBritishThermalUnitsPerHour(double?)"/>
        public static Power? BritishThermalUnitsPerHour(this double? value) => Power.FromBritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromBritishThermalUnitsPerHour(double)"/>
        public static Power BritishThermalUnitsPerHour(this float value) => Power.FromBritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromBritishThermalUnitsPerHour(double?)"/>
        public static Power? BritishThermalUnitsPerHour(this float? value) => Power.FromBritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromBritishThermalUnitsPerHour(double)"/>
        public static Power BritishThermalUnitsPerHour(this decimal value) => Power.FromBritishThermalUnitsPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromBritishThermalUnitsPerHour(double?)"/>
        public static Power? BritishThermalUnitsPerHour(this decimal? value) => Power.FromBritishThermalUnitsPerHour(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Decawatt

        /// <inheritdoc cref="Power.FromDecawatts(double)"/>
        public static Power Decawatts(this int value) => Power.FromDecawatts(value);

        /// <inheritdoc cref="Power.FromDecawatts(double?)"/>
        public static Power? Decawatts(this int? value) => Power.FromDecawatts(value);

        /// <inheritdoc cref="Power.FromDecawatts(double)"/>
        public static Power Decawatts(this long value) => Power.FromDecawatts(value);

        /// <inheritdoc cref="Power.FromDecawatts(double?)"/>
        public static Power? Decawatts(this long? value) => Power.FromDecawatts(value);

        /// <inheritdoc cref="Power.FromDecawatts(double)"/>
        public static Power Decawatts(this double value) => Power.FromDecawatts(value);

        /// <inheritdoc cref="Power.FromDecawatts(double?)"/>
        public static Power? Decawatts(this double? value) => Power.FromDecawatts(value);

        /// <inheritdoc cref="Power.FromDecawatts(double)"/>
        public static Power Decawatts(this float value) => Power.FromDecawatts(value);

        /// <inheritdoc cref="Power.FromDecawatts(double?)"/>
        public static Power? Decawatts(this float? value) => Power.FromDecawatts(value);

        /// <inheritdoc cref="Power.FromDecawatts(double)"/>
        public static Power Decawatts(this decimal value) => Power.FromDecawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromDecawatts(double?)"/>
        public static Power? Decawatts(this decimal? value) => Power.FromDecawatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Deciwatt

        /// <inheritdoc cref="Power.FromDeciwatts(double)"/>
        public static Power Deciwatts(this int value) => Power.FromDeciwatts(value);

        /// <inheritdoc cref="Power.FromDeciwatts(double?)"/>
        public static Power? Deciwatts(this int? value) => Power.FromDeciwatts(value);

        /// <inheritdoc cref="Power.FromDeciwatts(double)"/>
        public static Power Deciwatts(this long value) => Power.FromDeciwatts(value);

        /// <inheritdoc cref="Power.FromDeciwatts(double?)"/>
        public static Power? Deciwatts(this long? value) => Power.FromDeciwatts(value);

        /// <inheritdoc cref="Power.FromDeciwatts(double)"/>
        public static Power Deciwatts(this double value) => Power.FromDeciwatts(value);

        /// <inheritdoc cref="Power.FromDeciwatts(double?)"/>
        public static Power? Deciwatts(this double? value) => Power.FromDeciwatts(value);

        /// <inheritdoc cref="Power.FromDeciwatts(double)"/>
        public static Power Deciwatts(this float value) => Power.FromDeciwatts(value);

        /// <inheritdoc cref="Power.FromDeciwatts(double?)"/>
        public static Power? Deciwatts(this float? value) => Power.FromDeciwatts(value);

        /// <inheritdoc cref="Power.FromDeciwatts(double)"/>
        public static Power Deciwatts(this decimal value) => Power.FromDeciwatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromDeciwatts(double?)"/>
        public static Power? Deciwatts(this decimal? value) => Power.FromDeciwatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region ElectricalHorsepower

        /// <inheritdoc cref="Power.FromElectricalHorsepower(double)"/>
        public static Power ElectricalHorsepower(this int value) => Power.FromElectricalHorsepower(value);

        /// <inheritdoc cref="Power.FromElectricalHorsepower(double?)"/>
        public static Power? ElectricalHorsepower(this int? value) => Power.FromElectricalHorsepower(value);

        /// <inheritdoc cref="Power.FromElectricalHorsepower(double)"/>
        public static Power ElectricalHorsepower(this long value) => Power.FromElectricalHorsepower(value);

        /// <inheritdoc cref="Power.FromElectricalHorsepower(double?)"/>
        public static Power? ElectricalHorsepower(this long? value) => Power.FromElectricalHorsepower(value);

        /// <inheritdoc cref="Power.FromElectricalHorsepower(double)"/>
        public static Power ElectricalHorsepower(this double value) => Power.FromElectricalHorsepower(value);

        /// <inheritdoc cref="Power.FromElectricalHorsepower(double?)"/>
        public static Power? ElectricalHorsepower(this double? value) => Power.FromElectricalHorsepower(value);

        /// <inheritdoc cref="Power.FromElectricalHorsepower(double)"/>
        public static Power ElectricalHorsepower(this float value) => Power.FromElectricalHorsepower(value);

        /// <inheritdoc cref="Power.FromElectricalHorsepower(double?)"/>
        public static Power? ElectricalHorsepower(this float? value) => Power.FromElectricalHorsepower(value);

        /// <inheritdoc cref="Power.FromElectricalHorsepower(double)"/>
        public static Power ElectricalHorsepower(this decimal value) => Power.FromElectricalHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromElectricalHorsepower(double?)"/>
        public static Power? ElectricalHorsepower(this decimal? value) => Power.FromElectricalHorsepower(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Femtowatt

        /// <inheritdoc cref="Power.FromFemtowatts(double)"/>
        public static Power Femtowatts(this int value) => Power.FromFemtowatts(value);

        /// <inheritdoc cref="Power.FromFemtowatts(double?)"/>
        public static Power? Femtowatts(this int? value) => Power.FromFemtowatts(value);

        /// <inheritdoc cref="Power.FromFemtowatts(double)"/>
        public static Power Femtowatts(this long value) => Power.FromFemtowatts(value);

        /// <inheritdoc cref="Power.FromFemtowatts(double?)"/>
        public static Power? Femtowatts(this long? value) => Power.FromFemtowatts(value);

        /// <inheritdoc cref="Power.FromFemtowatts(double)"/>
        public static Power Femtowatts(this double value) => Power.FromFemtowatts(value);

        /// <inheritdoc cref="Power.FromFemtowatts(double?)"/>
        public static Power? Femtowatts(this double? value) => Power.FromFemtowatts(value);

        /// <inheritdoc cref="Power.FromFemtowatts(double)"/>
        public static Power Femtowatts(this float value) => Power.FromFemtowatts(value);

        /// <inheritdoc cref="Power.FromFemtowatts(double?)"/>
        public static Power? Femtowatts(this float? value) => Power.FromFemtowatts(value);

        /// <inheritdoc cref="Power.FromFemtowatts(double)"/>
        public static Power Femtowatts(this decimal value) => Power.FromFemtowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromFemtowatts(double?)"/>
        public static Power? Femtowatts(this decimal? value) => Power.FromFemtowatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Gigawatt

        /// <inheritdoc cref="Power.FromGigawatts(double)"/>
        public static Power Gigawatts(this int value) => Power.FromGigawatts(value);

        /// <inheritdoc cref="Power.FromGigawatts(double?)"/>
        public static Power? Gigawatts(this int? value) => Power.FromGigawatts(value);

        /// <inheritdoc cref="Power.FromGigawatts(double)"/>
        public static Power Gigawatts(this long value) => Power.FromGigawatts(value);

        /// <inheritdoc cref="Power.FromGigawatts(double?)"/>
        public static Power? Gigawatts(this long? value) => Power.FromGigawatts(value);

        /// <inheritdoc cref="Power.FromGigawatts(double)"/>
        public static Power Gigawatts(this double value) => Power.FromGigawatts(value);

        /// <inheritdoc cref="Power.FromGigawatts(double?)"/>
        public static Power? Gigawatts(this double? value) => Power.FromGigawatts(value);

        /// <inheritdoc cref="Power.FromGigawatts(double)"/>
        public static Power Gigawatts(this float value) => Power.FromGigawatts(value);

        /// <inheritdoc cref="Power.FromGigawatts(double?)"/>
        public static Power? Gigawatts(this float? value) => Power.FromGigawatts(value);

        /// <inheritdoc cref="Power.FromGigawatts(double)"/>
        public static Power Gigawatts(this decimal value) => Power.FromGigawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromGigawatts(double?)"/>
        public static Power? Gigawatts(this decimal? value) => Power.FromGigawatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region HydraulicHorsepower

        /// <inheritdoc cref="Power.FromHydraulicHorsepower(double)"/>
        public static Power HydraulicHorsepower(this int value) => Power.FromHydraulicHorsepower(value);

        /// <inheritdoc cref="Power.FromHydraulicHorsepower(double?)"/>
        public static Power? HydraulicHorsepower(this int? value) => Power.FromHydraulicHorsepower(value);

        /// <inheritdoc cref="Power.FromHydraulicHorsepower(double)"/>
        public static Power HydraulicHorsepower(this long value) => Power.FromHydraulicHorsepower(value);

        /// <inheritdoc cref="Power.FromHydraulicHorsepower(double?)"/>
        public static Power? HydraulicHorsepower(this long? value) => Power.FromHydraulicHorsepower(value);

        /// <inheritdoc cref="Power.FromHydraulicHorsepower(double)"/>
        public static Power HydraulicHorsepower(this double value) => Power.FromHydraulicHorsepower(value);

        /// <inheritdoc cref="Power.FromHydraulicHorsepower(double?)"/>
        public static Power? HydraulicHorsepower(this double? value) => Power.FromHydraulicHorsepower(value);

        /// <inheritdoc cref="Power.FromHydraulicHorsepower(double)"/>
        public static Power HydraulicHorsepower(this float value) => Power.FromHydraulicHorsepower(value);

        /// <inheritdoc cref="Power.FromHydraulicHorsepower(double?)"/>
        public static Power? HydraulicHorsepower(this float? value) => Power.FromHydraulicHorsepower(value);

        /// <inheritdoc cref="Power.FromHydraulicHorsepower(double)"/>
        public static Power HydraulicHorsepower(this decimal value) => Power.FromHydraulicHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromHydraulicHorsepower(double?)"/>
        public static Power? HydraulicHorsepower(this decimal? value) => Power.FromHydraulicHorsepower(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region KilobritishThermalUnitPerHour

        /// <inheritdoc cref="Power.FromKilobritishThermalUnitsPerHour(double)"/>
        public static Power KilobritishThermalUnitsPerHour(this int value) => Power.FromKilobritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromKilobritishThermalUnitsPerHour(double?)"/>
        public static Power? KilobritishThermalUnitsPerHour(this int? value) => Power.FromKilobritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromKilobritishThermalUnitsPerHour(double)"/>
        public static Power KilobritishThermalUnitsPerHour(this long value) => Power.FromKilobritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromKilobritishThermalUnitsPerHour(double?)"/>
        public static Power? KilobritishThermalUnitsPerHour(this long? value) => Power.FromKilobritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromKilobritishThermalUnitsPerHour(double)"/>
        public static Power KilobritishThermalUnitsPerHour(this double value) => Power.FromKilobritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromKilobritishThermalUnitsPerHour(double?)"/>
        public static Power? KilobritishThermalUnitsPerHour(this double? value) => Power.FromKilobritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromKilobritishThermalUnitsPerHour(double)"/>
        public static Power KilobritishThermalUnitsPerHour(this float value) => Power.FromKilobritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromKilobritishThermalUnitsPerHour(double?)"/>
        public static Power? KilobritishThermalUnitsPerHour(this float? value) => Power.FromKilobritishThermalUnitsPerHour(value);

        /// <inheritdoc cref="Power.FromKilobritishThermalUnitsPerHour(double)"/>
        public static Power KilobritishThermalUnitsPerHour(this decimal value) => Power.FromKilobritishThermalUnitsPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromKilobritishThermalUnitsPerHour(double?)"/>
        public static Power? KilobritishThermalUnitsPerHour(this decimal? value) => Power.FromKilobritishThermalUnitsPerHour(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilowatt

        /// <inheritdoc cref="Power.FromKilowatts(double)"/>
        public static Power Kilowatts(this int value) => Power.FromKilowatts(value);

        /// <inheritdoc cref="Power.FromKilowatts(double?)"/>
        public static Power? Kilowatts(this int? value) => Power.FromKilowatts(value);

        /// <inheritdoc cref="Power.FromKilowatts(double)"/>
        public static Power Kilowatts(this long value) => Power.FromKilowatts(value);

        /// <inheritdoc cref="Power.FromKilowatts(double?)"/>
        public static Power? Kilowatts(this long? value) => Power.FromKilowatts(value);

        /// <inheritdoc cref="Power.FromKilowatts(double)"/>
        public static Power Kilowatts(this double value) => Power.FromKilowatts(value);

        /// <inheritdoc cref="Power.FromKilowatts(double?)"/>
        public static Power? Kilowatts(this double? value) => Power.FromKilowatts(value);

        /// <inheritdoc cref="Power.FromKilowatts(double)"/>
        public static Power Kilowatts(this float value) => Power.FromKilowatts(value);

        /// <inheritdoc cref="Power.FromKilowatts(double?)"/>
        public static Power? Kilowatts(this float? value) => Power.FromKilowatts(value);

        /// <inheritdoc cref="Power.FromKilowatts(double)"/>
        public static Power Kilowatts(this decimal value) => Power.FromKilowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromKilowatts(double?)"/>
        public static Power? Kilowatts(this decimal? value) => Power.FromKilowatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MechanicalHorsepower

        /// <inheritdoc cref="Power.FromMechanicalHorsepower(double)"/>
        public static Power MechanicalHorsepower(this int value) => Power.FromMechanicalHorsepower(value);

        /// <inheritdoc cref="Power.FromMechanicalHorsepower(double?)"/>
        public static Power? MechanicalHorsepower(this int? value) => Power.FromMechanicalHorsepower(value);

        /// <inheritdoc cref="Power.FromMechanicalHorsepower(double)"/>
        public static Power MechanicalHorsepower(this long value) => Power.FromMechanicalHorsepower(value);

        /// <inheritdoc cref="Power.FromMechanicalHorsepower(double?)"/>
        public static Power? MechanicalHorsepower(this long? value) => Power.FromMechanicalHorsepower(value);

        /// <inheritdoc cref="Power.FromMechanicalHorsepower(double)"/>
        public static Power MechanicalHorsepower(this double value) => Power.FromMechanicalHorsepower(value);

        /// <inheritdoc cref="Power.FromMechanicalHorsepower(double?)"/>
        public static Power? MechanicalHorsepower(this double? value) => Power.FromMechanicalHorsepower(value);

        /// <inheritdoc cref="Power.FromMechanicalHorsepower(double)"/>
        public static Power MechanicalHorsepower(this float value) => Power.FromMechanicalHorsepower(value);

        /// <inheritdoc cref="Power.FromMechanicalHorsepower(double?)"/>
        public static Power? MechanicalHorsepower(this float? value) => Power.FromMechanicalHorsepower(value);

        /// <inheritdoc cref="Power.FromMechanicalHorsepower(double)"/>
        public static Power MechanicalHorsepower(this decimal value) => Power.FromMechanicalHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMechanicalHorsepower(double?)"/>
        public static Power? MechanicalHorsepower(this decimal? value) => Power.FromMechanicalHorsepower(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megawatt

        /// <inheritdoc cref="Power.FromMegawatts(double)"/>
        public static Power Megawatts(this int value) => Power.FromMegawatts(value);

        /// <inheritdoc cref="Power.FromMegawatts(double?)"/>
        public static Power? Megawatts(this int? value) => Power.FromMegawatts(value);

        /// <inheritdoc cref="Power.FromMegawatts(double)"/>
        public static Power Megawatts(this long value) => Power.FromMegawatts(value);

        /// <inheritdoc cref="Power.FromMegawatts(double?)"/>
        public static Power? Megawatts(this long? value) => Power.FromMegawatts(value);

        /// <inheritdoc cref="Power.FromMegawatts(double)"/>
        public static Power Megawatts(this double value) => Power.FromMegawatts(value);

        /// <inheritdoc cref="Power.FromMegawatts(double?)"/>
        public static Power? Megawatts(this double? value) => Power.FromMegawatts(value);

        /// <inheritdoc cref="Power.FromMegawatts(double)"/>
        public static Power Megawatts(this float value) => Power.FromMegawatts(value);

        /// <inheritdoc cref="Power.FromMegawatts(double?)"/>
        public static Power? Megawatts(this float? value) => Power.FromMegawatts(value);

        /// <inheritdoc cref="Power.FromMegawatts(double)"/>
        public static Power Megawatts(this decimal value) => Power.FromMegawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMegawatts(double?)"/>
        public static Power? Megawatts(this decimal? value) => Power.FromMegawatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region MetricHorsepower

        /// <inheritdoc cref="Power.FromMetricHorsepower(double)"/>
        public static Power MetricHorsepower(this int value) => Power.FromMetricHorsepower(value);

        /// <inheritdoc cref="Power.FromMetricHorsepower(double?)"/>
        public static Power? MetricHorsepower(this int? value) => Power.FromMetricHorsepower(value);

        /// <inheritdoc cref="Power.FromMetricHorsepower(double)"/>
        public static Power MetricHorsepower(this long value) => Power.FromMetricHorsepower(value);

        /// <inheritdoc cref="Power.FromMetricHorsepower(double?)"/>
        public static Power? MetricHorsepower(this long? value) => Power.FromMetricHorsepower(value);

        /// <inheritdoc cref="Power.FromMetricHorsepower(double)"/>
        public static Power MetricHorsepower(this double value) => Power.FromMetricHorsepower(value);

        /// <inheritdoc cref="Power.FromMetricHorsepower(double?)"/>
        public static Power? MetricHorsepower(this double? value) => Power.FromMetricHorsepower(value);

        /// <inheritdoc cref="Power.FromMetricHorsepower(double)"/>
        public static Power MetricHorsepower(this float value) => Power.FromMetricHorsepower(value);

        /// <inheritdoc cref="Power.FromMetricHorsepower(double?)"/>
        public static Power? MetricHorsepower(this float? value) => Power.FromMetricHorsepower(value);

        /// <inheritdoc cref="Power.FromMetricHorsepower(double)"/>
        public static Power MetricHorsepower(this decimal value) => Power.FromMetricHorsepower(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMetricHorsepower(double?)"/>
        public static Power? MetricHorsepower(this decimal? value) => Power.FromMetricHorsepower(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Microwatt

        /// <inheritdoc cref="Power.FromMicrowatts(double)"/>
        public static Power Microwatts(this int value) => Power.FromMicrowatts(value);

        /// <inheritdoc cref="Power.FromMicrowatts(double?)"/>
        public static Power? Microwatts(this int? value) => Power.FromMicrowatts(value);

        /// <inheritdoc cref="Power.FromMicrowatts(double)"/>
        public static Power Microwatts(this long value) => Power.FromMicrowatts(value);

        /// <inheritdoc cref="Power.FromMicrowatts(double?)"/>
        public static Power? Microwatts(this long? value) => Power.FromMicrowatts(value);

        /// <inheritdoc cref="Power.FromMicrowatts(double)"/>
        public static Power Microwatts(this double value) => Power.FromMicrowatts(value);

        /// <inheritdoc cref="Power.FromMicrowatts(double?)"/>
        public static Power? Microwatts(this double? value) => Power.FromMicrowatts(value);

        /// <inheritdoc cref="Power.FromMicrowatts(double)"/>
        public static Power Microwatts(this float value) => Power.FromMicrowatts(value);

        /// <inheritdoc cref="Power.FromMicrowatts(double?)"/>
        public static Power? Microwatts(this float? value) => Power.FromMicrowatts(value);

        /// <inheritdoc cref="Power.FromMicrowatts(double)"/>
        public static Power Microwatts(this decimal value) => Power.FromMicrowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMicrowatts(double?)"/>
        public static Power? Microwatts(this decimal? value) => Power.FromMicrowatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Milliwatt

        /// <inheritdoc cref="Power.FromMilliwatts(double)"/>
        public static Power Milliwatts(this int value) => Power.FromMilliwatts(value);

        /// <inheritdoc cref="Power.FromMilliwatts(double?)"/>
        public static Power? Milliwatts(this int? value) => Power.FromMilliwatts(value);

        /// <inheritdoc cref="Power.FromMilliwatts(double)"/>
        public static Power Milliwatts(this long value) => Power.FromMilliwatts(value);

        /// <inheritdoc cref="Power.FromMilliwatts(double?)"/>
        public static Power? Milliwatts(this long? value) => Power.FromMilliwatts(value);

        /// <inheritdoc cref="Power.FromMilliwatts(double)"/>
        public static Power Milliwatts(this double value) => Power.FromMilliwatts(value);

        /// <inheritdoc cref="Power.FromMilliwatts(double?)"/>
        public static Power? Milliwatts(this double? value) => Power.FromMilliwatts(value);

        /// <inheritdoc cref="Power.FromMilliwatts(double)"/>
        public static Power Milliwatts(this float value) => Power.FromMilliwatts(value);

        /// <inheritdoc cref="Power.FromMilliwatts(double?)"/>
        public static Power? Milliwatts(this float? value) => Power.FromMilliwatts(value);

        /// <inheritdoc cref="Power.FromMilliwatts(double)"/>
        public static Power Milliwatts(this decimal value) => Power.FromMilliwatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromMilliwatts(double?)"/>
        public static Power? Milliwatts(this decimal? value) => Power.FromMilliwatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Nanowatt

        /// <inheritdoc cref="Power.FromNanowatts(double)"/>
        public static Power Nanowatts(this int value) => Power.FromNanowatts(value);

        /// <inheritdoc cref="Power.FromNanowatts(double?)"/>
        public static Power? Nanowatts(this int? value) => Power.FromNanowatts(value);

        /// <inheritdoc cref="Power.FromNanowatts(double)"/>
        public static Power Nanowatts(this long value) => Power.FromNanowatts(value);

        /// <inheritdoc cref="Power.FromNanowatts(double?)"/>
        public static Power? Nanowatts(this long? value) => Power.FromNanowatts(value);

        /// <inheritdoc cref="Power.FromNanowatts(double)"/>
        public static Power Nanowatts(this double value) => Power.FromNanowatts(value);

        /// <inheritdoc cref="Power.FromNanowatts(double?)"/>
        public static Power? Nanowatts(this double? value) => Power.FromNanowatts(value);

        /// <inheritdoc cref="Power.FromNanowatts(double)"/>
        public static Power Nanowatts(this float value) => Power.FromNanowatts(value);

        /// <inheritdoc cref="Power.FromNanowatts(double?)"/>
        public static Power? Nanowatts(this float? value) => Power.FromNanowatts(value);

        /// <inheritdoc cref="Power.FromNanowatts(double)"/>
        public static Power Nanowatts(this decimal value) => Power.FromNanowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromNanowatts(double?)"/>
        public static Power? Nanowatts(this decimal? value) => Power.FromNanowatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Petawatt

        /// <inheritdoc cref="Power.FromPetawatts(double)"/>
        public static Power Petawatts(this int value) => Power.FromPetawatts(value);

        /// <inheritdoc cref="Power.FromPetawatts(double?)"/>
        public static Power? Petawatts(this int? value) => Power.FromPetawatts(value);

        /// <inheritdoc cref="Power.FromPetawatts(double)"/>
        public static Power Petawatts(this long value) => Power.FromPetawatts(value);

        /// <inheritdoc cref="Power.FromPetawatts(double?)"/>
        public static Power? Petawatts(this long? value) => Power.FromPetawatts(value);

        /// <inheritdoc cref="Power.FromPetawatts(double)"/>
        public static Power Petawatts(this double value) => Power.FromPetawatts(value);

        /// <inheritdoc cref="Power.FromPetawatts(double?)"/>
        public static Power? Petawatts(this double? value) => Power.FromPetawatts(value);

        /// <inheritdoc cref="Power.FromPetawatts(double)"/>
        public static Power Petawatts(this float value) => Power.FromPetawatts(value);

        /// <inheritdoc cref="Power.FromPetawatts(double?)"/>
        public static Power? Petawatts(this float? value) => Power.FromPetawatts(value);

        /// <inheritdoc cref="Power.FromPetawatts(double)"/>
        public static Power Petawatts(this decimal value) => Power.FromPetawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromPetawatts(double?)"/>
        public static Power? Petawatts(this decimal? value) => Power.FromPetawatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Picowatt

        /// <inheritdoc cref="Power.FromPicowatts(double)"/>
        public static Power Picowatts(this int value) => Power.FromPicowatts(value);

        /// <inheritdoc cref="Power.FromPicowatts(double?)"/>
        public static Power? Picowatts(this int? value) => Power.FromPicowatts(value);

        /// <inheritdoc cref="Power.FromPicowatts(double)"/>
        public static Power Picowatts(this long value) => Power.FromPicowatts(value);

        /// <inheritdoc cref="Power.FromPicowatts(double?)"/>
        public static Power? Picowatts(this long? value) => Power.FromPicowatts(value);

        /// <inheritdoc cref="Power.FromPicowatts(double)"/>
        public static Power Picowatts(this double value) => Power.FromPicowatts(value);

        /// <inheritdoc cref="Power.FromPicowatts(double?)"/>
        public static Power? Picowatts(this double? value) => Power.FromPicowatts(value);

        /// <inheritdoc cref="Power.FromPicowatts(double)"/>
        public static Power Picowatts(this float value) => Power.FromPicowatts(value);

        /// <inheritdoc cref="Power.FromPicowatts(double?)"/>
        public static Power? Picowatts(this float? value) => Power.FromPicowatts(value);

        /// <inheritdoc cref="Power.FromPicowatts(double)"/>
        public static Power Picowatts(this decimal value) => Power.FromPicowatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromPicowatts(double?)"/>
        public static Power? Picowatts(this decimal? value) => Power.FromPicowatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Terawatt

        /// <inheritdoc cref="Power.FromTerawatts(double)"/>
        public static Power Terawatts(this int value) => Power.FromTerawatts(value);

        /// <inheritdoc cref="Power.FromTerawatts(double?)"/>
        public static Power? Terawatts(this int? value) => Power.FromTerawatts(value);

        /// <inheritdoc cref="Power.FromTerawatts(double)"/>
        public static Power Terawatts(this long value) => Power.FromTerawatts(value);

        /// <inheritdoc cref="Power.FromTerawatts(double?)"/>
        public static Power? Terawatts(this long? value) => Power.FromTerawatts(value);

        /// <inheritdoc cref="Power.FromTerawatts(double)"/>
        public static Power Terawatts(this double value) => Power.FromTerawatts(value);

        /// <inheritdoc cref="Power.FromTerawatts(double?)"/>
        public static Power? Terawatts(this double? value) => Power.FromTerawatts(value);

        /// <inheritdoc cref="Power.FromTerawatts(double)"/>
        public static Power Terawatts(this float value) => Power.FromTerawatts(value);

        /// <inheritdoc cref="Power.FromTerawatts(double?)"/>
        public static Power? Terawatts(this float? value) => Power.FromTerawatts(value);

        /// <inheritdoc cref="Power.FromTerawatts(double)"/>
        public static Power Terawatts(this decimal value) => Power.FromTerawatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromTerawatts(double?)"/>
        public static Power? Terawatts(this decimal? value) => Power.FromTerawatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Watt

        /// <inheritdoc cref="Power.FromWatts(double)"/>
        public static Power Watts(this int value) => Power.FromWatts(value);

        /// <inheritdoc cref="Power.FromWatts(double?)"/>
        public static Power? Watts(this int? value) => Power.FromWatts(value);

        /// <inheritdoc cref="Power.FromWatts(double)"/>
        public static Power Watts(this long value) => Power.FromWatts(value);

        /// <inheritdoc cref="Power.FromWatts(double?)"/>
        public static Power? Watts(this long? value) => Power.FromWatts(value);

        /// <inheritdoc cref="Power.FromWatts(double)"/>
        public static Power Watts(this double value) => Power.FromWatts(value);

        /// <inheritdoc cref="Power.FromWatts(double?)"/>
        public static Power? Watts(this double? value) => Power.FromWatts(value);

        /// <inheritdoc cref="Power.FromWatts(double)"/>
        public static Power Watts(this float value) => Power.FromWatts(value);

        /// <inheritdoc cref="Power.FromWatts(double?)"/>
        public static Power? Watts(this float? value) => Power.FromWatts(value);

        /// <inheritdoc cref="Power.FromWatts(double)"/>
        public static Power Watts(this decimal value) => Power.FromWatts(Convert.ToDouble(value));

        /// <inheritdoc cref="Power.FromWatts(double?)"/>
        public static Power? Watts(this decimal? value) => Power.FromWatts(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
