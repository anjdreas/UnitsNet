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
    /// Test of TemperatureChangeRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class TemperatureChangeRateTestsBase
    {
        protected abstract double CentidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double DecadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double DecidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double DegreesCelsiusPerMinuteInOneDegreeCelsiusPerSecond { get; }
        protected abstract double DegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double HectodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double KilodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double MicrodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double MillidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }
        protected abstract double NanodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentidegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DecadegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DecidegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DegreesCelsiusPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double DegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double HectodegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double KilodegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicrodegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MillidegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NanodegreesCelsiusPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureChangeRate((double)0.0, TemperatureChangeRateUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new TemperatureChangeRate();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(TemperatureChangeRateUnit.DegreeCelsiusPerSecond, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureChangeRate(double.PositiveInfinity, TemperatureChangeRateUnit.DegreeCelsiusPerSecond));
            Assert.Throws<ArgumentException>(() => new TemperatureChangeRate(double.NegativeInfinity, TemperatureChangeRateUnit.DegreeCelsiusPerSecond));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new TemperatureChangeRate(double.NaN, TemperatureChangeRateUnit.DegreeCelsiusPerSecond));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new TemperatureChangeRate(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void TemperatureChangeRate_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new TemperatureChangeRate(1, TemperatureChangeRateUnit.DegreeCelsiusPerSecond);

            QuantityInfo<TemperatureChangeRateUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(TemperatureChangeRate.Zero, quantityInfo.Zero);
            Assert.Equal("TemperatureChangeRate", quantityInfo.Name);
            Assert.Equal(QuantityType.TemperatureChangeRate, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<TemperatureChangeRateUnit>().Except(new[] {TemperatureChangeRateUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void DegreeCelsiusPerSecondToTemperatureChangeRateUnits()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            AssertEx.EqualTolerance(CentidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.CentidegreesCelsiusPerSecond, CentidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(DecadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.DecadegreesCelsiusPerSecond, DecadegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(DecidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.DecidegreesCelsiusPerSecond, DecidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(DegreesCelsiusPerMinuteInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.DegreesCelsiusPerMinute, DegreesCelsiusPerMinuteTolerance);
            AssertEx.EqualTolerance(DegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(HectodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.HectodegreesCelsiusPerSecond, HectodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(KilodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.KilodegreesCelsiusPerSecond, KilodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(MicrodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.MicrodegreesCelsiusPerSecond, MicrodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(MillidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.MillidegreesCelsiusPerSecond, MillidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(NanodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.NanodegreesCelsiusPerSecond, NanodegreesCelsiusPerSecondTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = TemperatureChangeRate.From(1, TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(1, quantity00.CentidegreesCelsiusPerSecond, CentidegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond, quantity00.Unit);

            var quantity01 = TemperatureChangeRate.From(1, TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(1, quantity01.DecadegreesCelsiusPerSecond, DecadegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond, quantity01.Unit);

            var quantity02 = TemperatureChangeRate.From(1, TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(1, quantity02.DecidegreesCelsiusPerSecond, DecidegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond, quantity02.Unit);

            var quantity03 = TemperatureChangeRate.From(1, TemperatureChangeRateUnit.DegreeCelsiusPerMinute);
            AssertEx.EqualTolerance(1, quantity03.DegreesCelsiusPerMinute, DegreesCelsiusPerMinuteTolerance);
            Assert.Equal(TemperatureChangeRateUnit.DegreeCelsiusPerMinute, quantity03.Unit);

            var quantity04 = TemperatureChangeRate.From(1, TemperatureChangeRateUnit.DegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(1, quantity04.DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.DegreeCelsiusPerSecond, quantity04.Unit);

            var quantity05 = TemperatureChangeRate.From(1, TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(1, quantity05.HectodegreesCelsiusPerSecond, HectodegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond, quantity05.Unit);

            var quantity06 = TemperatureChangeRate.From(1, TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(1, quantity06.KilodegreesCelsiusPerSecond, KilodegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond, quantity06.Unit);

            var quantity07 = TemperatureChangeRate.From(1, TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(1, quantity07.MicrodegreesCelsiusPerSecond, MicrodegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond, quantity07.Unit);

            var quantity08 = TemperatureChangeRate.From(1, TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(1, quantity08.MillidegreesCelsiusPerSecond, MillidegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond, quantity08.Unit);

            var quantity09 = TemperatureChangeRate.From(1, TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(1, quantity09.NanodegreesCelsiusPerSecond, NanodegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond, quantity09.Unit);

        }

        [Fact]
        public void FromDegreesCelsiusPerSecond_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TemperatureChangeRate.FromDegreesCelsiusPerSecond(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => TemperatureChangeRate.FromDegreesCelsiusPerSecond(double.NegativeInfinity));
        }

        [Fact]
        public void FromDegreesCelsiusPerSecond_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => TemperatureChangeRate.FromDegreesCelsiusPerSecond(double.NaN));
        }

        [Fact]
        public void As()
        {
            var degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            AssertEx.EqualTolerance(CentidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond), CentidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(DecadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond), DecadegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(DecidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond), DecidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(DegreesCelsiusPerMinuteInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.DegreeCelsiusPerMinute), DegreesCelsiusPerMinuteTolerance);
            AssertEx.EqualTolerance(DegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.DegreeCelsiusPerSecond), DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(HectodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond), HectodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(KilodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond), KilodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(MicrodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond), MicrodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(MillidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond), MillidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(NanodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, degreecelsiuspersecond.As(TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond), NanodegreesCelsiusPerSecondTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);

            var centidegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(CentidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)centidegreecelsiuspersecondQuantity.Value, CentidegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond, centidegreecelsiuspersecondQuantity.Unit);

            var decadegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(DecadegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)decadegreecelsiuspersecondQuantity.Value, DecadegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond, decadegreecelsiuspersecondQuantity.Unit);

            var decidegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(DecidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)decidegreecelsiuspersecondQuantity.Value, DecidegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond, decidegreecelsiuspersecondQuantity.Unit);

            var degreecelsiusperminuteQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.DegreeCelsiusPerMinute);
            AssertEx.EqualTolerance(DegreesCelsiusPerMinuteInOneDegreeCelsiusPerSecond, (double)degreecelsiusperminuteQuantity.Value, DegreesCelsiusPerMinuteTolerance);
            Assert.Equal(TemperatureChangeRateUnit.DegreeCelsiusPerMinute, degreecelsiusperminuteQuantity.Unit);

            var degreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.DegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(DegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)degreecelsiuspersecondQuantity.Value, DegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.DegreeCelsiusPerSecond, degreecelsiuspersecondQuantity.Unit);

            var hectodegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(HectodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)hectodegreecelsiuspersecondQuantity.Value, HectodegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond, hectodegreecelsiuspersecondQuantity.Unit);

            var kilodegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(KilodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)kilodegreecelsiuspersecondQuantity.Value, KilodegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond, kilodegreecelsiuspersecondQuantity.Unit);

            var microdegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(MicrodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)microdegreecelsiuspersecondQuantity.Value, MicrodegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond, microdegreecelsiuspersecondQuantity.Unit);

            var millidegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(MillidegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)millidegreecelsiuspersecondQuantity.Value, MillidegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond, millidegreecelsiuspersecondQuantity.Unit);

            var nanodegreecelsiuspersecondQuantity = degreecelsiuspersecond.ToUnit(TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond);
            AssertEx.EqualTolerance(NanodegreesCelsiusPerSecondInOneDegreeCelsiusPerSecond, (double)nanodegreecelsiuspersecondQuantity.Value, NanodegreesCelsiusPerSecondTolerance);
            Assert.Equal(TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond, nanodegreecelsiuspersecondQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromCentidegreesCelsiusPerSecond(degreecelsiuspersecond.CentidegreesCelsiusPerSecond).DegreesCelsiusPerSecond, CentidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromDecadegreesCelsiusPerSecond(degreecelsiuspersecond.DecadegreesCelsiusPerSecond).DegreesCelsiusPerSecond, DecadegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromDecidegreesCelsiusPerSecond(degreecelsiuspersecond.DecidegreesCelsiusPerSecond).DegreesCelsiusPerSecond, DecidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromDegreesCelsiusPerMinute(degreecelsiuspersecond.DegreesCelsiusPerMinute).DegreesCelsiusPerSecond, DegreesCelsiusPerMinuteTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromDegreesCelsiusPerSecond(degreecelsiuspersecond.DegreesCelsiusPerSecond).DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromHectodegreesCelsiusPerSecond(degreecelsiuspersecond.HectodegreesCelsiusPerSecond).DegreesCelsiusPerSecond, HectodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromKilodegreesCelsiusPerSecond(degreecelsiuspersecond.KilodegreesCelsiusPerSecond).DegreesCelsiusPerSecond, KilodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromMicrodegreesCelsiusPerSecond(degreecelsiuspersecond.MicrodegreesCelsiusPerSecond).DegreesCelsiusPerSecond, MicrodegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromMillidegreesCelsiusPerSecond(degreecelsiuspersecond.MillidegreesCelsiusPerSecond).DegreesCelsiusPerSecond, MillidegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(1, TemperatureChangeRate.FromNanodegreesCelsiusPerSecond(degreecelsiuspersecond.NanodegreesCelsiusPerSecond).DegreesCelsiusPerSecond, NanodegreesCelsiusPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            TemperatureChangeRate v = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(2, (TemperatureChangeRate.FromDegreesCelsiusPerSecond(3)-v).DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(2, (TemperatureChangeRate.FromDegreesCelsiusPerSecond(10)/5).DegreesCelsiusPerSecond, DegreesCelsiusPerSecondTolerance);
            AssertEx.EqualTolerance(2, TemperatureChangeRate.FromDegreesCelsiusPerSecond(10)/TemperatureChangeRate.FromDegreesCelsiusPerSecond(5), DegreesCelsiusPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            TemperatureChangeRate oneDegreeCelsiusPerSecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            TemperatureChangeRate twoDegreesCelsiusPerSecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(2);

            Assert.True(oneDegreeCelsiusPerSecond < twoDegreesCelsiusPerSecond);
            Assert.True(oneDegreeCelsiusPerSecond <= twoDegreesCelsiusPerSecond);
            Assert.True(twoDegreesCelsiusPerSecond > oneDegreeCelsiusPerSecond);
            Assert.True(twoDegreesCelsiusPerSecond >= oneDegreeCelsiusPerSecond);

            Assert.False(oneDegreeCelsiusPerSecond > twoDegreesCelsiusPerSecond);
            Assert.False(oneDegreeCelsiusPerSecond >= twoDegreesCelsiusPerSecond);
            Assert.False(twoDegreesCelsiusPerSecond < oneDegreeCelsiusPerSecond);
            Assert.False(twoDegreesCelsiusPerSecond <= oneDegreeCelsiusPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            Assert.Equal(0, degreecelsiuspersecond.CompareTo(degreecelsiuspersecond));
            Assert.True(degreecelsiuspersecond.CompareTo(TemperatureChangeRate.Zero) > 0);
            Assert.True(TemperatureChangeRate.Zero.CompareTo(degreecelsiuspersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            Assert.Throws<ArgumentException>(() => degreecelsiuspersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => degreecelsiuspersecond.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            var b = TemperatureChangeRate.FromDegreesCelsiusPerSecond(2);

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
        public void Equals_SameType_IsImplemented()
        {
            var a = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            var b = TemperatureChangeRate.FromDegreesCelsiusPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            object b = TemperatureChangeRate.FromDegreesCelsiusPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            Assert.True(v.Equals(TemperatureChangeRate.FromDegreesCelsiusPerSecond(1), DegreesCelsiusPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(TemperatureChangeRate.Zero, DegreesCelsiusPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(TemperatureChangeRate.FromDegreesCelsiusPerSecond(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            Assert.False(degreecelsiuspersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            TemperatureChangeRate degreecelsiuspersecond = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1);
            Assert.False(degreecelsiuspersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(TemperatureChangeRateUnit.Undefined, TemperatureChangeRate.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(TemperatureChangeRateUnit)).Cast<TemperatureChangeRateUnit>();
            foreach(var unit in units)
            {
                if(unit == TemperatureChangeRateUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(TemperatureChangeRate.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 c°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond).ToString());
                Assert.Equal("1 da°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond).ToString());
                Assert.Equal("1 d°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond).ToString());
                Assert.Equal("1 °C/min", new TemperatureChangeRate(1, TemperatureChangeRateUnit.DegreeCelsiusPerMinute).ToString());
                Assert.Equal("1 °C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.DegreeCelsiusPerSecond).ToString());
                Assert.Equal("1 h°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond).ToString());
                Assert.Equal("1 k°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond).ToString());
                Assert.Equal("1 µ°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond).ToString());
                Assert.Equal("1 m°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond).ToString());
                Assert.Equal("1 n°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond).ToString());
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

            Assert.Equal("1 c°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.CentidegreeCelsiusPerSecond).ToString(swedishCulture));
            Assert.Equal("1 da°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.DecadegreeCelsiusPerSecond).ToString(swedishCulture));
            Assert.Equal("1 d°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.DecidegreeCelsiusPerSecond).ToString(swedishCulture));
            Assert.Equal("1 °C/min", new TemperatureChangeRate(1, TemperatureChangeRateUnit.DegreeCelsiusPerMinute).ToString(swedishCulture));
            Assert.Equal("1 °C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.DegreeCelsiusPerSecond).ToString(swedishCulture));
            Assert.Equal("1 h°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.HectodegreeCelsiusPerSecond).ToString(swedishCulture));
            Assert.Equal("1 k°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.KilodegreeCelsiusPerSecond).ToString(swedishCulture));
            Assert.Equal("1 µ°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.MicrodegreeCelsiusPerSecond).ToString(swedishCulture));
            Assert.Equal("1 m°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.MillidegreeCelsiusPerSecond).ToString(swedishCulture));
            Assert.Equal("1 n°C/s", new TemperatureChangeRate(1, TemperatureChangeRateUnit.NanodegreeCelsiusPerSecond).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 °C/s", new TemperatureChangeRate(0.123456, TemperatureChangeRateUnit.DegreeCelsiusPerSecond).ToString("s1"));
                Assert.Equal("0.12 °C/s", new TemperatureChangeRate(0.123456, TemperatureChangeRateUnit.DegreeCelsiusPerSecond).ToString("s2"));
                Assert.Equal("0.123 °C/s", new TemperatureChangeRate(0.123456, TemperatureChangeRateUnit.DegreeCelsiusPerSecond).ToString("s3"));
                Assert.Equal("0.1235 °C/s", new TemperatureChangeRate(0.123456, TemperatureChangeRateUnit.DegreeCelsiusPerSecond).ToString("s4"));
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
            Assert.Equal("0.1 °C/s", new TemperatureChangeRate(0.123456, TemperatureChangeRateUnit.DegreeCelsiusPerSecond).ToString("s1", culture));
            Assert.Equal("0.12 °C/s", new TemperatureChangeRate(0.123456, TemperatureChangeRateUnit.DegreeCelsiusPerSecond).ToString("s2", culture));
            Assert.Equal("0.123 °C/s", new TemperatureChangeRate(0.123456, TemperatureChangeRateUnit.DegreeCelsiusPerSecond).ToString("s3", culture));
            Assert.Equal("0.1235 °C/s", new TemperatureChangeRate(0.123456, TemperatureChangeRateUnit.DegreeCelsiusPerSecond).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(TemperatureChangeRate)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(TemperatureChangeRateUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal(QuantityType.TemperatureChangeRate, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal(TemperatureChangeRate.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(1.0);
            Assert.Equal(TemperatureChangeRate.QuantityType.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = TemperatureChangeRate.FromDegreesCelsiusPerSecond(value);
            Assert.Equal(TemperatureChangeRate.FromDegreesCelsiusPerSecond(-value), -quantity);
        }

    }
}
