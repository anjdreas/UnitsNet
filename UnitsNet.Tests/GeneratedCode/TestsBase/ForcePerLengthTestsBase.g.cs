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
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ForcePerLength.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ForcePerLengthTestsBase
    {
        protected abstract double CentinewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double DecinewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double KilogramsForcePerMeterInOneNewtonPerMeter { get; }
        protected abstract double KilonewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double MeganewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double MicronewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double MillinewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double NanonewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double NewtonsPerMeterInOneNewtonPerMeter { get; }
        protected abstract double PoundsForcePerFootInOneNewtonPerMeter { get; }
        protected abstract double PoundsForcePerInchInOneNewtonPerMeter { get; }
        protected abstract double PoundsForcePerYardInOneNewtonPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentinewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double DecinewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsForcePerMeterTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MicronewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double MillinewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double NanonewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerMeterTolerance { get { return 1e-5; } }
        protected virtual double PoundsForcePerFootTolerance { get { return 1e-5; } }
        protected virtual double PoundsForcePerInchTolerance { get { return 1e-5; } }
        protected virtual double PoundsForcePerYardTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ForcePerLength((double)0.0, ForcePerLengthUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ForcePerLength();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ForcePerLengthUnit.NewtonPerMeter, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ForcePerLength(double.PositiveInfinity, ForcePerLengthUnit.NewtonPerMeter));
            Assert.Throws<ArgumentException>(() => new ForcePerLength(double.NegativeInfinity, ForcePerLengthUnit.NewtonPerMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ForcePerLength(double.NaN, ForcePerLengthUnit.NewtonPerMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ForcePerLength(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void ForcePerLength_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ForcePerLength(1, ForcePerLengthUnit.NewtonPerMeter);

            QuantityInfo<ForcePerLengthUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ForcePerLength.Zero, quantityInfo.Zero);
            Assert.Equal("ForcePerLength", quantityInfo.Name);
            Assert.Equal(QuantityType.ForcePerLength, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<ForcePerLengthUnit>().Except(new[] {ForcePerLengthUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void NewtonPerMeterToForcePerLengthUnits()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            AssertEx.EqualTolerance(CentinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.CentinewtonsPerMeter, CentinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(DecinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.DecinewtonsPerMeter, DecinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerMeterInOneNewtonPerMeter, newtonpermeter.KilogramsForcePerMeter, KilogramsForcePerMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.KilonewtonsPerMeter, KilonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(MeganewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.MeganewtonsPerMeter, MeganewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(MicronewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.MicronewtonsPerMeter, MicronewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(MillinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.MillinewtonsPerMeter, MillinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(NanonewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.NanonewtonsPerMeter, NanonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(PoundsForcePerFootInOneNewtonPerMeter, newtonpermeter.PoundsForcePerFoot, PoundsForcePerFootTolerance);
            AssertEx.EqualTolerance(PoundsForcePerInchInOneNewtonPerMeter, newtonpermeter.PoundsForcePerInch, PoundsForcePerInchTolerance);
            AssertEx.EqualTolerance(PoundsForcePerYardInOneNewtonPerMeter, newtonpermeter.PoundsForcePerYard, PoundsForcePerYardTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ForcePerLength.From(1, ForcePerLengthUnit.CentinewtonPerMeter);
            AssertEx.EqualTolerance(1, quantity00.CentinewtonsPerMeter, CentinewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.CentinewtonPerMeter, quantity00.Unit);

            var quantity01 = ForcePerLength.From(1, ForcePerLengthUnit.DecinewtonPerMeter);
            AssertEx.EqualTolerance(1, quantity01.DecinewtonsPerMeter, DecinewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.DecinewtonPerMeter, quantity01.Unit);

            var quantity02 = ForcePerLength.From(1, ForcePerLengthUnit.KilogramForcePerMeter);
            AssertEx.EqualTolerance(1, quantity02.KilogramsForcePerMeter, KilogramsForcePerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.KilogramForcePerMeter, quantity02.Unit);

            var quantity03 = ForcePerLength.From(1, ForcePerLengthUnit.KilonewtonPerMeter);
            AssertEx.EqualTolerance(1, quantity03.KilonewtonsPerMeter, KilonewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.KilonewtonPerMeter, quantity03.Unit);

            var quantity04 = ForcePerLength.From(1, ForcePerLengthUnit.MeganewtonPerMeter);
            AssertEx.EqualTolerance(1, quantity04.MeganewtonsPerMeter, MeganewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.MeganewtonPerMeter, quantity04.Unit);

            var quantity05 = ForcePerLength.From(1, ForcePerLengthUnit.MicronewtonPerMeter);
            AssertEx.EqualTolerance(1, quantity05.MicronewtonsPerMeter, MicronewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.MicronewtonPerMeter, quantity05.Unit);

            var quantity06 = ForcePerLength.From(1, ForcePerLengthUnit.MillinewtonPerMeter);
            AssertEx.EqualTolerance(1, quantity06.MillinewtonsPerMeter, MillinewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.MillinewtonPerMeter, quantity06.Unit);

            var quantity07 = ForcePerLength.From(1, ForcePerLengthUnit.NanonewtonPerMeter);
            AssertEx.EqualTolerance(1, quantity07.NanonewtonsPerMeter, NanonewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.NanonewtonPerMeter, quantity07.Unit);

            var quantity08 = ForcePerLength.From(1, ForcePerLengthUnit.NewtonPerMeter);
            AssertEx.EqualTolerance(1, quantity08.NewtonsPerMeter, NewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.NewtonPerMeter, quantity08.Unit);

            var quantity09 = ForcePerLength.From(1, ForcePerLengthUnit.PoundForcePerFoot);
            AssertEx.EqualTolerance(1, quantity09.PoundsForcePerFoot, PoundsForcePerFootTolerance);
            Assert.Equal(ForcePerLengthUnit.PoundForcePerFoot, quantity09.Unit);

            var quantity10 = ForcePerLength.From(1, ForcePerLengthUnit.PoundForcePerInch);
            AssertEx.EqualTolerance(1, quantity10.PoundsForcePerInch, PoundsForcePerInchTolerance);
            Assert.Equal(ForcePerLengthUnit.PoundForcePerInch, quantity10.Unit);

            var quantity11 = ForcePerLength.From(1, ForcePerLengthUnit.PoundForcePerYard);
            AssertEx.EqualTolerance(1, quantity11.PoundsForcePerYard, PoundsForcePerYardTolerance);
            Assert.Equal(ForcePerLengthUnit.PoundForcePerYard, quantity11.Unit);

        }

        [Fact]
        public void FromNewtonsPerMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ForcePerLength.FromNewtonsPerMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ForcePerLength.FromNewtonsPerMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromNewtonsPerMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ForcePerLength.FromNewtonsPerMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            AssertEx.EqualTolerance(CentinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.CentinewtonPerMeter), CentinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(DecinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.DecinewtonPerMeter), DecinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.KilogramForcePerMeter), KilogramsForcePerMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.KilonewtonPerMeter), KilonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(MeganewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.MeganewtonPerMeter), MeganewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(MicronewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.MicronewtonPerMeter), MicronewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(MillinewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.MillinewtonPerMeter), MillinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(NanonewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.NanonewtonPerMeter), NanonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerMeterInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.NewtonPerMeter), NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(PoundsForcePerFootInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.PoundForcePerFoot), PoundsForcePerFootTolerance);
            AssertEx.EqualTolerance(PoundsForcePerInchInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.PoundForcePerInch), PoundsForcePerInchTolerance);
            AssertEx.EqualTolerance(PoundsForcePerYardInOneNewtonPerMeter, newtonpermeter.As(ForcePerLengthUnit.PoundForcePerYard), PoundsForcePerYardTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);

            var centinewtonpermeterQuantity = newtonpermeter.ToUnit(ForcePerLengthUnit.CentinewtonPerMeter);
            AssertEx.EqualTolerance(CentinewtonsPerMeterInOneNewtonPerMeter, (double)centinewtonpermeterQuantity.Value, CentinewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.CentinewtonPerMeter, centinewtonpermeterQuantity.Unit);

            var decinewtonpermeterQuantity = newtonpermeter.ToUnit(ForcePerLengthUnit.DecinewtonPerMeter);
            AssertEx.EqualTolerance(DecinewtonsPerMeterInOneNewtonPerMeter, (double)decinewtonpermeterQuantity.Value, DecinewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.DecinewtonPerMeter, decinewtonpermeterQuantity.Unit);

            var kilogramforcepermeterQuantity = newtonpermeter.ToUnit(ForcePerLengthUnit.KilogramForcePerMeter);
            AssertEx.EqualTolerance(KilogramsForcePerMeterInOneNewtonPerMeter, (double)kilogramforcepermeterQuantity.Value, KilogramsForcePerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.KilogramForcePerMeter, kilogramforcepermeterQuantity.Unit);

            var kilonewtonpermeterQuantity = newtonpermeter.ToUnit(ForcePerLengthUnit.KilonewtonPerMeter);
            AssertEx.EqualTolerance(KilonewtonsPerMeterInOneNewtonPerMeter, (double)kilonewtonpermeterQuantity.Value, KilonewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.KilonewtonPerMeter, kilonewtonpermeterQuantity.Unit);

            var meganewtonpermeterQuantity = newtonpermeter.ToUnit(ForcePerLengthUnit.MeganewtonPerMeter);
            AssertEx.EqualTolerance(MeganewtonsPerMeterInOneNewtonPerMeter, (double)meganewtonpermeterQuantity.Value, MeganewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.MeganewtonPerMeter, meganewtonpermeterQuantity.Unit);

            var micronewtonpermeterQuantity = newtonpermeter.ToUnit(ForcePerLengthUnit.MicronewtonPerMeter);
            AssertEx.EqualTolerance(MicronewtonsPerMeterInOneNewtonPerMeter, (double)micronewtonpermeterQuantity.Value, MicronewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.MicronewtonPerMeter, micronewtonpermeterQuantity.Unit);

            var millinewtonpermeterQuantity = newtonpermeter.ToUnit(ForcePerLengthUnit.MillinewtonPerMeter);
            AssertEx.EqualTolerance(MillinewtonsPerMeterInOneNewtonPerMeter, (double)millinewtonpermeterQuantity.Value, MillinewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.MillinewtonPerMeter, millinewtonpermeterQuantity.Unit);

            var nanonewtonpermeterQuantity = newtonpermeter.ToUnit(ForcePerLengthUnit.NanonewtonPerMeter);
            AssertEx.EqualTolerance(NanonewtonsPerMeterInOneNewtonPerMeter, (double)nanonewtonpermeterQuantity.Value, NanonewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.NanonewtonPerMeter, nanonewtonpermeterQuantity.Unit);

            var newtonpermeterQuantity = newtonpermeter.ToUnit(ForcePerLengthUnit.NewtonPerMeter);
            AssertEx.EqualTolerance(NewtonsPerMeterInOneNewtonPerMeter, (double)newtonpermeterQuantity.Value, NewtonsPerMeterTolerance);
            Assert.Equal(ForcePerLengthUnit.NewtonPerMeter, newtonpermeterQuantity.Unit);

            var poundforceperfootQuantity = newtonpermeter.ToUnit(ForcePerLengthUnit.PoundForcePerFoot);
            AssertEx.EqualTolerance(PoundsForcePerFootInOneNewtonPerMeter, (double)poundforceperfootQuantity.Value, PoundsForcePerFootTolerance);
            Assert.Equal(ForcePerLengthUnit.PoundForcePerFoot, poundforceperfootQuantity.Unit);

            var poundforceperinchQuantity = newtonpermeter.ToUnit(ForcePerLengthUnit.PoundForcePerInch);
            AssertEx.EqualTolerance(PoundsForcePerInchInOneNewtonPerMeter, (double)poundforceperinchQuantity.Value, PoundsForcePerInchTolerance);
            Assert.Equal(ForcePerLengthUnit.PoundForcePerInch, poundforceperinchQuantity.Unit);

            var poundforceperyardQuantity = newtonpermeter.ToUnit(ForcePerLengthUnit.PoundForcePerYard);
            AssertEx.EqualTolerance(PoundsForcePerYardInOneNewtonPerMeter, (double)poundforceperyardQuantity.Value, PoundsForcePerYardTolerance);
            Assert.Equal(ForcePerLengthUnit.PoundForcePerYard, poundforceperyardQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            AssertEx.EqualTolerance(1, ForcePerLength.FromCentinewtonsPerMeter(newtonpermeter.CentinewtonsPerMeter).NewtonsPerMeter, CentinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromDecinewtonsPerMeter(newtonpermeter.DecinewtonsPerMeter).NewtonsPerMeter, DecinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromKilogramsForcePerMeter(newtonpermeter.KilogramsForcePerMeter).NewtonsPerMeter, KilogramsForcePerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromKilonewtonsPerMeter(newtonpermeter.KilonewtonsPerMeter).NewtonsPerMeter, KilonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromMeganewtonsPerMeter(newtonpermeter.MeganewtonsPerMeter).NewtonsPerMeter, MeganewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromMicronewtonsPerMeter(newtonpermeter.MicronewtonsPerMeter).NewtonsPerMeter, MicronewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromMillinewtonsPerMeter(newtonpermeter.MillinewtonsPerMeter).NewtonsPerMeter, MillinewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromNanonewtonsPerMeter(newtonpermeter.NanonewtonsPerMeter).NewtonsPerMeter, NanonewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromNewtonsPerMeter(newtonpermeter.NewtonsPerMeter).NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromPoundsForcePerFoot(newtonpermeter.PoundsForcePerFoot).NewtonsPerMeter, PoundsForcePerFootTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromPoundsForcePerInch(newtonpermeter.PoundsForcePerInch).NewtonsPerMeter, PoundsForcePerInchTolerance);
            AssertEx.EqualTolerance(1, ForcePerLength.FromPoundsForcePerYard(newtonpermeter.PoundsForcePerYard).NewtonsPerMeter, PoundsForcePerYardTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ForcePerLength v = ForcePerLength.FromNewtonsPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (ForcePerLength.FromNewtonsPerMeter(3)-v).NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(2, (ForcePerLength.FromNewtonsPerMeter(10)/5).NewtonsPerMeter, NewtonsPerMeterTolerance);
            AssertEx.EqualTolerance(2, ForcePerLength.FromNewtonsPerMeter(10)/ForcePerLength.FromNewtonsPerMeter(5), NewtonsPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ForcePerLength oneNewtonPerMeter = ForcePerLength.FromNewtonsPerMeter(1);
            ForcePerLength twoNewtonsPerMeter = ForcePerLength.FromNewtonsPerMeter(2);

            Assert.True(oneNewtonPerMeter < twoNewtonsPerMeter);
            Assert.True(oneNewtonPerMeter <= twoNewtonsPerMeter);
            Assert.True(twoNewtonsPerMeter > oneNewtonPerMeter);
            Assert.True(twoNewtonsPerMeter >= oneNewtonPerMeter);

            Assert.False(oneNewtonPerMeter > twoNewtonsPerMeter);
            Assert.False(oneNewtonPerMeter >= twoNewtonsPerMeter);
            Assert.False(twoNewtonsPerMeter < oneNewtonPerMeter);
            Assert.False(twoNewtonsPerMeter <= oneNewtonPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.Equal(0, newtonpermeter.CompareTo(newtonpermeter));
            Assert.True(newtonpermeter.CompareTo(ForcePerLength.Zero) > 0);
            Assert.True(ForcePerLength.Zero.CompareTo(newtonpermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.Throws<ArgumentException>(() => newtonpermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => newtonpermeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ForcePerLength.FromNewtonsPerMeter(1);
            var b = ForcePerLength.FromNewtonsPerMeter(2);

 // ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            var a = ForcePerLength.FromNewtonsPerMeter(1);
            var b = ForcePerLength.FromNewtonsPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.True(v.Equals(ForcePerLength.FromNewtonsPerMeter(1), NewtonsPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ForcePerLength.Zero, NewtonsPerMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.False(newtonpermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ForcePerLength newtonpermeter = ForcePerLength.FromNewtonsPerMeter(1);
            Assert.False(newtonpermeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ForcePerLengthUnit.Undefined, ForcePerLength.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ForcePerLengthUnit)).Cast<ForcePerLengthUnit>();
            foreach(var unit in units)
            {
                if(unit == ForcePerLengthUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ForcePerLength.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cN/m", new ForcePerLength(1, ForcePerLengthUnit.CentinewtonPerMeter).ToString());
                Assert.Equal("1 dN/m", new ForcePerLength(1, ForcePerLengthUnit.DecinewtonPerMeter).ToString());
                Assert.Equal("1 kgf/m", new ForcePerLength(1, ForcePerLengthUnit.KilogramForcePerMeter).ToString());
                Assert.Equal("1 kN/m", new ForcePerLength(1, ForcePerLengthUnit.KilonewtonPerMeter).ToString());
                Assert.Equal("1 MN/m", new ForcePerLength(1, ForcePerLengthUnit.MeganewtonPerMeter).ToString());
                Assert.Equal("1 µN/m", new ForcePerLength(1, ForcePerLengthUnit.MicronewtonPerMeter).ToString());
                Assert.Equal("1 mN/m", new ForcePerLength(1, ForcePerLengthUnit.MillinewtonPerMeter).ToString());
                Assert.Equal("1 nN/m", new ForcePerLength(1, ForcePerLengthUnit.NanonewtonPerMeter).ToString());
                Assert.Equal("1 N/m", new ForcePerLength(1, ForcePerLengthUnit.NewtonPerMeter).ToString());
                Assert.Equal("1 lbf/ft", new ForcePerLength(1, ForcePerLengthUnit.PoundForcePerFoot).ToString());
                Assert.Equal("1 lbf/in", new ForcePerLength(1, ForcePerLengthUnit.PoundForcePerInch).ToString());
                Assert.Equal("1 lbf/yd", new ForcePerLength(1, ForcePerLengthUnit.PoundForcePerYard).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 cN/m", new ForcePerLength(1, ForcePerLengthUnit.CentinewtonPerMeter).ToString(swedishCulture));
            Assert.Equal("1 dN/m", new ForcePerLength(1, ForcePerLengthUnit.DecinewtonPerMeter).ToString(swedishCulture));
            Assert.Equal("1 kgf/m", new ForcePerLength(1, ForcePerLengthUnit.KilogramForcePerMeter).ToString(swedishCulture));
            Assert.Equal("1 kN/m", new ForcePerLength(1, ForcePerLengthUnit.KilonewtonPerMeter).ToString(swedishCulture));
            Assert.Equal("1 MN/m", new ForcePerLength(1, ForcePerLengthUnit.MeganewtonPerMeter).ToString(swedishCulture));
            Assert.Equal("1 µN/m", new ForcePerLength(1, ForcePerLengthUnit.MicronewtonPerMeter).ToString(swedishCulture));
            Assert.Equal("1 mN/m", new ForcePerLength(1, ForcePerLengthUnit.MillinewtonPerMeter).ToString(swedishCulture));
            Assert.Equal("1 nN/m", new ForcePerLength(1, ForcePerLengthUnit.NanonewtonPerMeter).ToString(swedishCulture));
            Assert.Equal("1 N/m", new ForcePerLength(1, ForcePerLengthUnit.NewtonPerMeter).ToString(swedishCulture));
            Assert.Equal("1 lbf/ft", new ForcePerLength(1, ForcePerLengthUnit.PoundForcePerFoot).ToString(swedishCulture));
            Assert.Equal("1 lbf/in", new ForcePerLength(1, ForcePerLengthUnit.PoundForcePerInch).ToString(swedishCulture));
            Assert.Equal("1 lbf/yd", new ForcePerLength(1, ForcePerLengthUnit.PoundForcePerYard).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 N/m", new ForcePerLength(0.123456, ForcePerLengthUnit.NewtonPerMeter).ToString("s1"));
                Assert.Equal("0.12 N/m", new ForcePerLength(0.123456, ForcePerLengthUnit.NewtonPerMeter).ToString("s2"));
                Assert.Equal("0.123 N/m", new ForcePerLength(0.123456, ForcePerLengthUnit.NewtonPerMeter).ToString("s3"));
                Assert.Equal("0.1235 N/m", new ForcePerLength(0.123456, ForcePerLengthUnit.NewtonPerMeter).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 N/m", new ForcePerLength(0.123456, ForcePerLengthUnit.NewtonPerMeter).ToString("s1", culture));
            Assert.Equal("0.12 N/m", new ForcePerLength(0.123456, ForcePerLengthUnit.NewtonPerMeter).ToString("s2", culture));
            Assert.Equal("0.123 N/m", new ForcePerLength(0.123456, ForcePerLengthUnit.NewtonPerMeter).ToString("s3", culture));
            Assert.Equal("0.1235 N/m", new ForcePerLength(0.123456, ForcePerLengthUnit.NewtonPerMeter).ToString("s4", culture));
        }
    }
}
