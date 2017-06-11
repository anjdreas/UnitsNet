﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/anjdreas/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\UnitClasses\MyUnit.extra.cs files to add code to generated unit classes.
//     Add Extensions\MyUnitExtensions.cs to decorate unit classes with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or unit classes.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2007 Andreas Gullberg Larsen (anjdreas@gmail.com).
// https://github.com/anjdreas/UnitsNet
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
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Density.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class DensityTestsBase
    {
        protected abstract double CentigramsPerDeciLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double CentigramsPerLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double CentigramsPerMilliliterInOneKilogramPerCubicMeter { get; }
        protected abstract double DecigramsPerDeciLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double DecigramsPerLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double DecigramsPerMilliliterInOneKilogramPerCubicMeter { get; }
        protected abstract double GramsPerCubicCentimeterInOneKilogramPerCubicMeter { get; }
        protected abstract double GramsPerCubicMeterInOneKilogramPerCubicMeter { get; }
        protected abstract double GramsPerCubicMillimeterInOneKilogramPerCubicMeter { get; }
        protected abstract double GramsPerDeciLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double GramsPerLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double GramsPerMilliliterInOneKilogramPerCubicMeter { get; }
        protected abstract double KilogramsPerCubicCentimeterInOneKilogramPerCubicMeter { get; }
        protected abstract double KilogramsPerCubicMeterInOneKilogramPerCubicMeter { get; }
        protected abstract double KilogramsPerCubicMillimeterInOneKilogramPerCubicMeter { get; }
        protected abstract double KilopoundsPerCubicFootInOneKilogramPerCubicMeter { get; }
        protected abstract double KilopoundsPerCubicInchInOneKilogramPerCubicMeter { get; }
        protected abstract double MicrogramsPerDeciLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double MicrogramsPerLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double MicrogramsPerMilliliterInOneKilogramPerCubicMeter { get; }
        protected abstract double MilligramsPerDeciLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double MilligramsPerLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double MilligramsPerMilliliterInOneKilogramPerCubicMeter { get; }
        protected abstract double NanogramsPerDeciLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double NanogramsPerLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double NanogramsPerMilliliterInOneKilogramPerCubicMeter { get; }
        protected abstract double PicogramsPerDeciLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double PicogramsPerLiterInOneKilogramPerCubicMeter { get; }
        protected abstract double PicogramsPerMilliliterInOneKilogramPerCubicMeter { get; }
        protected abstract double PoundsPerCubicFootInOneKilogramPerCubicMeter { get; }
        protected abstract double PoundsPerCubicInchInOneKilogramPerCubicMeter { get; }
        protected abstract double SlugsPerCubicFootInOneKilogramPerCubicMeter { get; }
        protected abstract double TonnesPerCubicCentimeterInOneKilogramPerCubicMeter { get; }
        protected abstract double TonnesPerCubicMeterInOneKilogramPerCubicMeter { get; }
        protected abstract double TonnesPerCubicMillimeterInOneKilogramPerCubicMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentigramsPerDeciLiterTolerance { get { return 1e-5; } }
        protected virtual double CentigramsPerLiterTolerance { get { return 1e-5; } }
        protected virtual double CentigramsPerMilliliterTolerance { get { return 1e-5; } }
        protected virtual double DecigramsPerDeciLiterTolerance { get { return 1e-5; } }
        protected virtual double DecigramsPerLiterTolerance { get { return 1e-5; } }
        protected virtual double DecigramsPerMilliliterTolerance { get { return 1e-5; } }
        protected virtual double GramsPerCubicCentimeterTolerance { get { return 1e-5; } }
        protected virtual double GramsPerCubicMeterTolerance { get { return 1e-5; } }
        protected virtual double GramsPerCubicMillimeterTolerance { get { return 1e-5; } }
        protected virtual double GramsPerDeciLiterTolerance { get { return 1e-5; } }
        protected virtual double GramsPerLiterTolerance { get { return 1e-5; } }
        protected virtual double GramsPerMilliliterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerCubicCentimeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerCubicMeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsPerCubicMillimeterTolerance { get { return 1e-5; } }
        protected virtual double KilopoundsPerCubicFootTolerance { get { return 1e-5; } }
        protected virtual double KilopoundsPerCubicInchTolerance { get { return 1e-5; } }
        protected virtual double MicrogramsPerDeciLiterTolerance { get { return 1e-5; } }
        protected virtual double MicrogramsPerLiterTolerance { get { return 1e-5; } }
        protected virtual double MicrogramsPerMilliliterTolerance { get { return 1e-5; } }
        protected virtual double MilligramsPerDeciLiterTolerance { get { return 1e-5; } }
        protected virtual double MilligramsPerLiterTolerance { get { return 1e-5; } }
        protected virtual double MilligramsPerMilliliterTolerance { get { return 1e-5; } }
        protected virtual double NanogramsPerDeciLiterTolerance { get { return 1e-5; } }
        protected virtual double NanogramsPerLiterTolerance { get { return 1e-5; } }
        protected virtual double NanogramsPerMilliliterTolerance { get { return 1e-5; } }
        protected virtual double PicogramsPerDeciLiterTolerance { get { return 1e-5; } }
        protected virtual double PicogramsPerLiterTolerance { get { return 1e-5; } }
        protected virtual double PicogramsPerMilliliterTolerance { get { return 1e-5; } }
        protected virtual double PoundsPerCubicFootTolerance { get { return 1e-5; } }
        protected virtual double PoundsPerCubicInchTolerance { get { return 1e-5; } }
        protected virtual double SlugsPerCubicFootTolerance { get { return 1e-5; } }
        protected virtual double TonnesPerCubicCentimeterTolerance { get { return 1e-5; } }
        protected virtual double TonnesPerCubicMeterTolerance { get { return 1e-5; } }
        protected virtual double TonnesPerCubicMillimeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void KilogramPerCubicMeterToDensityUnits()
        {
            Density kilogrampercubicmeter = Density.FromKilogramsPerCubicMeter(1);
            AssertEx.EqualTolerance(CentigramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.CentigramsPerDeciLiter, CentigramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(CentigramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.CentigramsPerLiter, CentigramsPerLiterTolerance);
            AssertEx.EqualTolerance(CentigramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.CentigramsPerMilliliter, CentigramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(DecigramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.DecigramsPerDeciLiter, DecigramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(DecigramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.DecigramsPerLiter, DecigramsPerLiterTolerance);
            AssertEx.EqualTolerance(DecigramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.DecigramsPerMilliliter, DecigramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(GramsPerCubicCentimeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.GramsPerCubicCentimeter, GramsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(GramsPerCubicMeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.GramsPerCubicMeter, GramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(GramsPerCubicMillimeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.GramsPerCubicMillimeter, GramsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(GramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.GramsPerDeciLiter, GramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(GramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.GramsPerLiter, GramsPerLiterTolerance);
            AssertEx.EqualTolerance(GramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.GramsPerMilliliter, GramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(KilogramsPerCubicCentimeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.KilogramsPerCubicCentimeter, KilogramsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerCubicMeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.KilogramsPerCubicMeter, KilogramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerCubicMillimeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.KilogramsPerCubicMillimeter, KilogramsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(KilopoundsPerCubicFootInOneKilogramPerCubicMeter, kilogrampercubicmeter.KilopoundsPerCubicFoot, KilopoundsPerCubicFootTolerance);
            AssertEx.EqualTolerance(KilopoundsPerCubicInchInOneKilogramPerCubicMeter, kilogrampercubicmeter.KilopoundsPerCubicInch, KilopoundsPerCubicInchTolerance);
            AssertEx.EqualTolerance(MicrogramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.MicrogramsPerDeciLiter, MicrogramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(MicrogramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.MicrogramsPerLiter, MicrogramsPerLiterTolerance);
            AssertEx.EqualTolerance(MicrogramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.MicrogramsPerMilliliter, MicrogramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(MilligramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.MilligramsPerDeciLiter, MilligramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(MilligramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.MilligramsPerLiter, MilligramsPerLiterTolerance);
            AssertEx.EqualTolerance(MilligramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.MilligramsPerMilliliter, MilligramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(NanogramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.NanogramsPerDeciLiter, NanogramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(NanogramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.NanogramsPerLiter, NanogramsPerLiterTolerance);
            AssertEx.EqualTolerance(NanogramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.NanogramsPerMilliliter, NanogramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(PicogramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.PicogramsPerDeciLiter, PicogramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(PicogramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.PicogramsPerLiter, PicogramsPerLiterTolerance);
            AssertEx.EqualTolerance(PicogramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.PicogramsPerMilliliter, PicogramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(PoundsPerCubicFootInOneKilogramPerCubicMeter, kilogrampercubicmeter.PoundsPerCubicFoot, PoundsPerCubicFootTolerance);
            AssertEx.EqualTolerance(PoundsPerCubicInchInOneKilogramPerCubicMeter, kilogrampercubicmeter.PoundsPerCubicInch, PoundsPerCubicInchTolerance);
            AssertEx.EqualTolerance(SlugsPerCubicFootInOneKilogramPerCubicMeter, kilogrampercubicmeter.SlugsPerCubicFoot, SlugsPerCubicFootTolerance);
            AssertEx.EqualTolerance(TonnesPerCubicCentimeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.TonnesPerCubicCentimeter, TonnesPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(TonnesPerCubicMeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.TonnesPerCubicMeter, TonnesPerCubicMeterTolerance);
            AssertEx.EqualTolerance(TonnesPerCubicMillimeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.TonnesPerCubicMillimeter, TonnesPerCubicMillimeterTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.CentigramPerDeciliter).CentigramsPerDeciLiter, CentigramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.CentigramPerLiter).CentigramsPerLiter, CentigramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.CentigramPerMilliliter).CentigramsPerMilliliter, CentigramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.DecigramPerDeciliter).DecigramsPerDeciLiter, DecigramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.DecigramPerLiter).DecigramsPerLiter, DecigramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.DecigramPerMilliliter).DecigramsPerMilliliter, DecigramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.GramPerCubicCentimeter).GramsPerCubicCentimeter, GramsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.GramPerCubicMeter).GramsPerCubicMeter, GramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.GramPerCubicMillimeter).GramsPerCubicMillimeter, GramsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.GramPerDeciliter).GramsPerDeciLiter, GramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.GramPerLiter).GramsPerLiter, GramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.GramPerMilliliter).GramsPerMilliliter, GramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.KilogramPerCubicCentimeter).KilogramsPerCubicCentimeter, KilogramsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.KilogramPerCubicMeter).KilogramsPerCubicMeter, KilogramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.KilogramPerCubicMillimeter).KilogramsPerCubicMillimeter, KilogramsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.KilopoundPerCubicFoot).KilopoundsPerCubicFoot, KilopoundsPerCubicFootTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.KilopoundPerCubicInch).KilopoundsPerCubicInch, KilopoundsPerCubicInchTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.MicrogramPerDeciliter).MicrogramsPerDeciLiter, MicrogramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.MicrogramPerLiter).MicrogramsPerLiter, MicrogramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.MicrogramPerMilliliter).MicrogramsPerMilliliter, MicrogramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.MilligramPerDeciliter).MilligramsPerDeciLiter, MilligramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.MilligramPerLiter).MilligramsPerLiter, MilligramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.MilligramPerMilliliter).MilligramsPerMilliliter, MilligramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.NanogramPerDeciliter).NanogramsPerDeciLiter, NanogramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.NanogramPerLiter).NanogramsPerLiter, NanogramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.NanogramPerMilliliter).NanogramsPerMilliliter, NanogramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.PicogramPerDeciliter).PicogramsPerDeciLiter, PicogramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.PicogramPerLiter).PicogramsPerLiter, PicogramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.PicogramPerMilliliter).PicogramsPerMilliliter, PicogramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.PoundPerCubicFoot).PoundsPerCubicFoot, PoundsPerCubicFootTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.PoundPerCubicInch).PoundsPerCubicInch, PoundsPerCubicInchTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.SlugPerCubicFoot).SlugsPerCubicFoot, SlugsPerCubicFootTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.TonnePerCubicCentimeter).TonnesPerCubicCentimeter, TonnesPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.TonnePerCubicMeter).TonnesPerCubicMeter, TonnesPerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, Density.From(1, DensityUnit.TonnePerCubicMillimeter).TonnesPerCubicMillimeter, TonnesPerCubicMillimeterTolerance);
        }

        [Fact]
        public void As()
        {
            var kilogrampercubicmeter = Density.FromKilogramsPerCubicMeter(1);
            AssertEx.EqualTolerance(CentigramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.CentigramPerDeciliter), CentigramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(CentigramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.CentigramPerLiter), CentigramsPerLiterTolerance);
            AssertEx.EqualTolerance(CentigramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.CentigramPerMilliliter), CentigramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(DecigramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.DecigramPerDeciliter), DecigramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(DecigramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.DecigramPerLiter), DecigramsPerLiterTolerance);
            AssertEx.EqualTolerance(DecigramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.DecigramPerMilliliter), DecigramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(GramsPerCubicCentimeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.GramPerCubicCentimeter), GramsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(GramsPerCubicMeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.GramPerCubicMeter), GramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(GramsPerCubicMillimeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.GramPerCubicMillimeter), GramsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(GramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.GramPerDeciliter), GramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(GramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.GramPerLiter), GramsPerLiterTolerance);
            AssertEx.EqualTolerance(GramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.GramPerMilliliter), GramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(KilogramsPerCubicCentimeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.KilogramPerCubicCentimeter), KilogramsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerCubicMeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.KilogramPerCubicMeter), KilogramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(KilogramsPerCubicMillimeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.KilogramPerCubicMillimeter), KilogramsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(KilopoundsPerCubicFootInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.KilopoundPerCubicFoot), KilopoundsPerCubicFootTolerance);
            AssertEx.EqualTolerance(KilopoundsPerCubicInchInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.KilopoundPerCubicInch), KilopoundsPerCubicInchTolerance);
            AssertEx.EqualTolerance(MicrogramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.MicrogramPerDeciliter), MicrogramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(MicrogramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.MicrogramPerLiter), MicrogramsPerLiterTolerance);
            AssertEx.EqualTolerance(MicrogramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.MicrogramPerMilliliter), MicrogramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(MilligramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.MilligramPerDeciliter), MilligramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(MilligramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.MilligramPerLiter), MilligramsPerLiterTolerance);
            AssertEx.EqualTolerance(MilligramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.MilligramPerMilliliter), MilligramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(NanogramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.NanogramPerDeciliter), NanogramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(NanogramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.NanogramPerLiter), NanogramsPerLiterTolerance);
            AssertEx.EqualTolerance(NanogramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.NanogramPerMilliliter), NanogramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(PicogramsPerDeciLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.PicogramPerDeciliter), PicogramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(PicogramsPerLiterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.PicogramPerLiter), PicogramsPerLiterTolerance);
            AssertEx.EqualTolerance(PicogramsPerMilliliterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.PicogramPerMilliliter), PicogramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(PoundsPerCubicFootInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.PoundPerCubicFoot), PoundsPerCubicFootTolerance);
            AssertEx.EqualTolerance(PoundsPerCubicInchInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.PoundPerCubicInch), PoundsPerCubicInchTolerance);
            AssertEx.EqualTolerance(SlugsPerCubicFootInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.SlugPerCubicFoot), SlugsPerCubicFootTolerance);
            AssertEx.EqualTolerance(TonnesPerCubicCentimeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.TonnePerCubicCentimeter), TonnesPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(TonnesPerCubicMeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.TonnePerCubicMeter), TonnesPerCubicMeterTolerance);
            AssertEx.EqualTolerance(TonnesPerCubicMillimeterInOneKilogramPerCubicMeter, kilogrampercubicmeter.As(DensityUnit.TonnePerCubicMillimeter), TonnesPerCubicMillimeterTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Density kilogrampercubicmeter = Density.FromKilogramsPerCubicMeter(1);
            AssertEx.EqualTolerance(1, Density.FromCentigramsPerDeciLiter(kilogrampercubicmeter.CentigramsPerDeciLiter).KilogramsPerCubicMeter, CentigramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromCentigramsPerLiter(kilogrampercubicmeter.CentigramsPerLiter).KilogramsPerCubicMeter, CentigramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromCentigramsPerMilliliter(kilogrampercubicmeter.CentigramsPerMilliliter).KilogramsPerCubicMeter, CentigramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.FromDecigramsPerDeciLiter(kilogrampercubicmeter.DecigramsPerDeciLiter).KilogramsPerCubicMeter, DecigramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromDecigramsPerLiter(kilogrampercubicmeter.DecigramsPerLiter).KilogramsPerCubicMeter, DecigramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromDecigramsPerMilliliter(kilogrampercubicmeter.DecigramsPerMilliliter).KilogramsPerCubicMeter, DecigramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.FromGramsPerCubicCentimeter(kilogrampercubicmeter.GramsPerCubicCentimeter).KilogramsPerCubicMeter, GramsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, Density.FromGramsPerCubicMeter(kilogrampercubicmeter.GramsPerCubicMeter).KilogramsPerCubicMeter, GramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, Density.FromGramsPerCubicMillimeter(kilogrampercubicmeter.GramsPerCubicMillimeter).KilogramsPerCubicMeter, GramsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(1, Density.FromGramsPerDeciLiter(kilogrampercubicmeter.GramsPerDeciLiter).KilogramsPerCubicMeter, GramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromGramsPerLiter(kilogrampercubicmeter.GramsPerLiter).KilogramsPerCubicMeter, GramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromGramsPerMilliliter(kilogrampercubicmeter.GramsPerMilliliter).KilogramsPerCubicMeter, GramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.FromKilogramsPerCubicCentimeter(kilogrampercubicmeter.KilogramsPerCubicCentimeter).KilogramsPerCubicMeter, KilogramsPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, Density.FromKilogramsPerCubicMeter(kilogrampercubicmeter.KilogramsPerCubicMeter).KilogramsPerCubicMeter, KilogramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, Density.FromKilogramsPerCubicMillimeter(kilogrampercubicmeter.KilogramsPerCubicMillimeter).KilogramsPerCubicMeter, KilogramsPerCubicMillimeterTolerance);
            AssertEx.EqualTolerance(1, Density.FromKilopoundsPerCubicFoot(kilogrampercubicmeter.KilopoundsPerCubicFoot).KilogramsPerCubicMeter, KilopoundsPerCubicFootTolerance);
            AssertEx.EqualTolerance(1, Density.FromKilopoundsPerCubicInch(kilogrampercubicmeter.KilopoundsPerCubicInch).KilogramsPerCubicMeter, KilopoundsPerCubicInchTolerance);
            AssertEx.EqualTolerance(1, Density.FromMicrogramsPerDeciLiter(kilogrampercubicmeter.MicrogramsPerDeciLiter).KilogramsPerCubicMeter, MicrogramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromMicrogramsPerLiter(kilogrampercubicmeter.MicrogramsPerLiter).KilogramsPerCubicMeter, MicrogramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromMicrogramsPerMilliliter(kilogrampercubicmeter.MicrogramsPerMilliliter).KilogramsPerCubicMeter, MicrogramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.FromMilligramsPerDeciLiter(kilogrampercubicmeter.MilligramsPerDeciLiter).KilogramsPerCubicMeter, MilligramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromMilligramsPerLiter(kilogrampercubicmeter.MilligramsPerLiter).KilogramsPerCubicMeter, MilligramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromMilligramsPerMilliliter(kilogrampercubicmeter.MilligramsPerMilliliter).KilogramsPerCubicMeter, MilligramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.FromNanogramsPerDeciLiter(kilogrampercubicmeter.NanogramsPerDeciLiter).KilogramsPerCubicMeter, NanogramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromNanogramsPerLiter(kilogrampercubicmeter.NanogramsPerLiter).KilogramsPerCubicMeter, NanogramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromNanogramsPerMilliliter(kilogrampercubicmeter.NanogramsPerMilliliter).KilogramsPerCubicMeter, NanogramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.FromPicogramsPerDeciLiter(kilogrampercubicmeter.PicogramsPerDeciLiter).KilogramsPerCubicMeter, PicogramsPerDeciLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromPicogramsPerLiter(kilogrampercubicmeter.PicogramsPerLiter).KilogramsPerCubicMeter, PicogramsPerLiterTolerance);
            AssertEx.EqualTolerance(1, Density.FromPicogramsPerMilliliter(kilogrampercubicmeter.PicogramsPerMilliliter).KilogramsPerCubicMeter, PicogramsPerMilliliterTolerance);
            AssertEx.EqualTolerance(1, Density.FromPoundsPerCubicFoot(kilogrampercubicmeter.PoundsPerCubicFoot).KilogramsPerCubicMeter, PoundsPerCubicFootTolerance);
            AssertEx.EqualTolerance(1, Density.FromPoundsPerCubicInch(kilogrampercubicmeter.PoundsPerCubicInch).KilogramsPerCubicMeter, PoundsPerCubicInchTolerance);
            AssertEx.EqualTolerance(1, Density.FromSlugsPerCubicFoot(kilogrampercubicmeter.SlugsPerCubicFoot).KilogramsPerCubicMeter, SlugsPerCubicFootTolerance);
            AssertEx.EqualTolerance(1, Density.FromTonnesPerCubicCentimeter(kilogrampercubicmeter.TonnesPerCubicCentimeter).KilogramsPerCubicMeter, TonnesPerCubicCentimeterTolerance);
            AssertEx.EqualTolerance(1, Density.FromTonnesPerCubicMeter(kilogrampercubicmeter.TonnesPerCubicMeter).KilogramsPerCubicMeter, TonnesPerCubicMeterTolerance);
            AssertEx.EqualTolerance(1, Density.FromTonnesPerCubicMillimeter(kilogrampercubicmeter.TonnesPerCubicMillimeter).KilogramsPerCubicMeter, TonnesPerCubicMillimeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Density v = Density.FromKilogramsPerCubicMeter(1);
            AssertEx.EqualTolerance(-1, -v.KilogramsPerCubicMeter, KilogramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (Density.FromKilogramsPerCubicMeter(3)-v).KilogramsPerCubicMeter, KilogramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).KilogramsPerCubicMeter, KilogramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).KilogramsPerCubicMeter, KilogramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).KilogramsPerCubicMeter, KilogramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, (Density.FromKilogramsPerCubicMeter(10)/5).KilogramsPerCubicMeter, KilogramsPerCubicMeterTolerance);
            AssertEx.EqualTolerance(2, Density.FromKilogramsPerCubicMeter(10)/Density.FromKilogramsPerCubicMeter(5), KilogramsPerCubicMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Density oneKilogramPerCubicMeter = Density.FromKilogramsPerCubicMeter(1);
            Density twoKilogramsPerCubicMeter = Density.FromKilogramsPerCubicMeter(2);

            Assert.True(oneKilogramPerCubicMeter < twoKilogramsPerCubicMeter);
            Assert.True(oneKilogramPerCubicMeter <= twoKilogramsPerCubicMeter);
            Assert.True(twoKilogramsPerCubicMeter > oneKilogramPerCubicMeter);
            Assert.True(twoKilogramsPerCubicMeter >= oneKilogramPerCubicMeter);

            Assert.False(oneKilogramPerCubicMeter > twoKilogramsPerCubicMeter);
            Assert.False(oneKilogramPerCubicMeter >= twoKilogramsPerCubicMeter);
            Assert.False(twoKilogramsPerCubicMeter < oneKilogramPerCubicMeter);
            Assert.False(twoKilogramsPerCubicMeter <= oneKilogramPerCubicMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Density kilogrampercubicmeter = Density.FromKilogramsPerCubicMeter(1);
            Assert.Equal(0, kilogrampercubicmeter.CompareTo(kilogrampercubicmeter));
            Assert.True(kilogrampercubicmeter.CompareTo(Density.Zero) > 0);
            Assert.True(Density.Zero.CompareTo(kilogrampercubicmeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Density kilogrampercubicmeter = Density.FromKilogramsPerCubicMeter(1);
            Assert.Throws<ArgumentException>(() => kilogrampercubicmeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Density kilogrampercubicmeter = Density.FromKilogramsPerCubicMeter(1);
            Assert.Throws<ArgumentNullException>(() => kilogrampercubicmeter.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Density a = Density.FromKilogramsPerCubicMeter(1);
            Density b = Density.FromKilogramsPerCubicMeter(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            Density v = Density.FromKilogramsPerCubicMeter(1);
            Assert.True(v.Equals(Density.FromKilogramsPerCubicMeter(1)));
            Assert.False(v.Equals(Density.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Density kilogrampercubicmeter = Density.FromKilogramsPerCubicMeter(1);
            Assert.False(kilogrampercubicmeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Density kilogrampercubicmeter = Density.FromKilogramsPerCubicMeter(1);
            Assert.False(kilogrampercubicmeter.Equals(null));
        }
    }
}
