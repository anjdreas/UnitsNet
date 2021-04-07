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
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of PressureChangeRate.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class PressureChangeRateTestsBase : QuantityTestsBase
    {
        protected abstract double AtmospheresPerSecondInOnePascalPerSecond { get; }
        protected abstract double KilopascalsPerMinuteInOnePascalPerSecond { get; }
        protected abstract double KilopascalsPerSecondInOnePascalPerSecond { get; }
        protected abstract double MegapascalsPerMinuteInOnePascalPerSecond { get; }
        protected abstract double MegapascalsPerSecondInOnePascalPerSecond { get; }
        protected abstract double PascalsPerMinuteInOnePascalPerSecond { get; }
        protected abstract double PascalsPerSecondInOnePascalPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AtmospheresPerSecondTolerance { get { return 1e-5; } }
        protected virtual double KilopascalsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double KilopascalsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MegapascalsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double MegapascalsPerSecondTolerance { get { return 1e-5; } }
        protected virtual double PascalsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double PascalsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new PressureChangeRate((double)0.0, PressureChangeRateUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new PressureChangeRate();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(PressureChangeRateUnit.PascalPerSecond, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new PressureChangeRate(double.PositiveInfinity, PressureChangeRateUnit.PascalPerSecond));
            Assert.Throws<ArgumentException>(() => new PressureChangeRate(double.NegativeInfinity, PressureChangeRateUnit.PascalPerSecond));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new PressureChangeRate(double.NaN, PressureChangeRateUnit.PascalPerSecond));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PressureChangeRate(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new PressureChangeRate(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (PressureChangeRate) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void PressureChangeRate_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new PressureChangeRate(1, PressureChangeRateUnit.PascalPerSecond);

            QuantityInfo<PressureChangeRateUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(PressureChangeRate.Zero, quantityInfo.Zero);
            Assert.Equal("PressureChangeRate", quantityInfo.Name);
            Assert.Equal(QuantityType.PressureChangeRate, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<PressureChangeRateUnit>().Except(new[] {PressureChangeRateUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void PascalPerSecondToPressureChangeRateUnits()
        {
            PressureChangeRate pascalpersecond = PressureChangeRate.FromPascalsPerSecond(1);
            AssertEx.EqualTolerance(AtmospheresPerSecondInOnePascalPerSecond, pascalpersecond.AtmospheresPerSecond, AtmospheresPerSecondTolerance);
            AssertEx.EqualTolerance(KilopascalsPerMinuteInOnePascalPerSecond, pascalpersecond.KilopascalsPerMinute, KilopascalsPerMinuteTolerance);
            AssertEx.EqualTolerance(KilopascalsPerSecondInOnePascalPerSecond, pascalpersecond.KilopascalsPerSecond, KilopascalsPerSecondTolerance);
            AssertEx.EqualTolerance(MegapascalsPerMinuteInOnePascalPerSecond, pascalpersecond.MegapascalsPerMinute, MegapascalsPerMinuteTolerance);
            AssertEx.EqualTolerance(MegapascalsPerSecondInOnePascalPerSecond, pascalpersecond.MegapascalsPerSecond, MegapascalsPerSecondTolerance);
            AssertEx.EqualTolerance(PascalsPerMinuteInOnePascalPerSecond, pascalpersecond.PascalsPerMinute, PascalsPerMinuteTolerance);
            AssertEx.EqualTolerance(PascalsPerSecondInOnePascalPerSecond, pascalpersecond.PascalsPerSecond, PascalsPerSecondTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = PressureChangeRate.From(1, PressureChangeRateUnit.AtmospherePerSecond);
            AssertEx.EqualTolerance(1, quantity00.AtmospheresPerSecond, AtmospheresPerSecondTolerance);
            Assert.Equal(PressureChangeRateUnit.AtmospherePerSecond, quantity00.Unit);

            var quantity01 = PressureChangeRate.From(1, PressureChangeRateUnit.KilopascalPerMinute);
            AssertEx.EqualTolerance(1, quantity01.KilopascalsPerMinute, KilopascalsPerMinuteTolerance);
            Assert.Equal(PressureChangeRateUnit.KilopascalPerMinute, quantity01.Unit);

            var quantity02 = PressureChangeRate.From(1, PressureChangeRateUnit.KilopascalPerSecond);
            AssertEx.EqualTolerance(1, quantity02.KilopascalsPerSecond, KilopascalsPerSecondTolerance);
            Assert.Equal(PressureChangeRateUnit.KilopascalPerSecond, quantity02.Unit);

            var quantity03 = PressureChangeRate.From(1, PressureChangeRateUnit.MegapascalPerMinute);
            AssertEx.EqualTolerance(1, quantity03.MegapascalsPerMinute, MegapascalsPerMinuteTolerance);
            Assert.Equal(PressureChangeRateUnit.MegapascalPerMinute, quantity03.Unit);

            var quantity04 = PressureChangeRate.From(1, PressureChangeRateUnit.MegapascalPerSecond);
            AssertEx.EqualTolerance(1, quantity04.MegapascalsPerSecond, MegapascalsPerSecondTolerance);
            Assert.Equal(PressureChangeRateUnit.MegapascalPerSecond, quantity04.Unit);

            var quantity05 = PressureChangeRate.From(1, PressureChangeRateUnit.PascalPerMinute);
            AssertEx.EqualTolerance(1, quantity05.PascalsPerMinute, PascalsPerMinuteTolerance);
            Assert.Equal(PressureChangeRateUnit.PascalPerMinute, quantity05.Unit);

            var quantity06 = PressureChangeRate.From(1, PressureChangeRateUnit.PascalPerSecond);
            AssertEx.EqualTolerance(1, quantity06.PascalsPerSecond, PascalsPerSecondTolerance);
            Assert.Equal(PressureChangeRateUnit.PascalPerSecond, quantity06.Unit);

        }

        [Fact]
        public void FromPascalsPerSecond_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => PressureChangeRate.FromPascalsPerSecond(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => PressureChangeRate.FromPascalsPerSecond(double.NegativeInfinity));
        }

        [Fact]
        public void FromPascalsPerSecond_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => PressureChangeRate.FromPascalsPerSecond(double.NaN));
        }

        [Fact]
        public void As()
        {
            var pascalpersecond = PressureChangeRate.FromPascalsPerSecond(1);
            AssertEx.EqualTolerance(AtmospheresPerSecondInOnePascalPerSecond, pascalpersecond.As(PressureChangeRateUnit.AtmospherePerSecond), AtmospheresPerSecondTolerance);
            AssertEx.EqualTolerance(KilopascalsPerMinuteInOnePascalPerSecond, pascalpersecond.As(PressureChangeRateUnit.KilopascalPerMinute), KilopascalsPerMinuteTolerance);
            AssertEx.EqualTolerance(KilopascalsPerSecondInOnePascalPerSecond, pascalpersecond.As(PressureChangeRateUnit.KilopascalPerSecond), KilopascalsPerSecondTolerance);
            AssertEx.EqualTolerance(MegapascalsPerMinuteInOnePascalPerSecond, pascalpersecond.As(PressureChangeRateUnit.MegapascalPerMinute), MegapascalsPerMinuteTolerance);
            AssertEx.EqualTolerance(MegapascalsPerSecondInOnePascalPerSecond, pascalpersecond.As(PressureChangeRateUnit.MegapascalPerSecond), MegapascalsPerSecondTolerance);
            AssertEx.EqualTolerance(PascalsPerMinuteInOnePascalPerSecond, pascalpersecond.As(PressureChangeRateUnit.PascalPerMinute), PascalsPerMinuteTolerance);
            AssertEx.EqualTolerance(PascalsPerSecondInOnePascalPerSecond, pascalpersecond.As(PressureChangeRateUnit.PascalPerSecond), PascalsPerSecondTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new PressureChangeRate(value: 1, unit: PressureChangeRate.BaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void ToUnit()
        {
            var pascalpersecond = PressureChangeRate.FromPascalsPerSecond(1);

            var atmospherepersecondQuantity = pascalpersecond.ToUnit(PressureChangeRateUnit.AtmospherePerSecond);
            AssertEx.EqualTolerance(AtmospheresPerSecondInOnePascalPerSecond, (double)atmospherepersecondQuantity.Value, AtmospheresPerSecondTolerance);
            Assert.Equal(PressureChangeRateUnit.AtmospherePerSecond, atmospherepersecondQuantity.Unit);

            var kilopascalperminuteQuantity = pascalpersecond.ToUnit(PressureChangeRateUnit.KilopascalPerMinute);
            AssertEx.EqualTolerance(KilopascalsPerMinuteInOnePascalPerSecond, (double)kilopascalperminuteQuantity.Value, KilopascalsPerMinuteTolerance);
            Assert.Equal(PressureChangeRateUnit.KilopascalPerMinute, kilopascalperminuteQuantity.Unit);

            var kilopascalpersecondQuantity = pascalpersecond.ToUnit(PressureChangeRateUnit.KilopascalPerSecond);
            AssertEx.EqualTolerance(KilopascalsPerSecondInOnePascalPerSecond, (double)kilopascalpersecondQuantity.Value, KilopascalsPerSecondTolerance);
            Assert.Equal(PressureChangeRateUnit.KilopascalPerSecond, kilopascalpersecondQuantity.Unit);

            var megapascalperminuteQuantity = pascalpersecond.ToUnit(PressureChangeRateUnit.MegapascalPerMinute);
            AssertEx.EqualTolerance(MegapascalsPerMinuteInOnePascalPerSecond, (double)megapascalperminuteQuantity.Value, MegapascalsPerMinuteTolerance);
            Assert.Equal(PressureChangeRateUnit.MegapascalPerMinute, megapascalperminuteQuantity.Unit);

            var megapascalpersecondQuantity = pascalpersecond.ToUnit(PressureChangeRateUnit.MegapascalPerSecond);
            AssertEx.EqualTolerance(MegapascalsPerSecondInOnePascalPerSecond, (double)megapascalpersecondQuantity.Value, MegapascalsPerSecondTolerance);
            Assert.Equal(PressureChangeRateUnit.MegapascalPerSecond, megapascalpersecondQuantity.Unit);

            var pascalperminuteQuantity = pascalpersecond.ToUnit(PressureChangeRateUnit.PascalPerMinute);
            AssertEx.EqualTolerance(PascalsPerMinuteInOnePascalPerSecond, (double)pascalperminuteQuantity.Value, PascalsPerMinuteTolerance);
            Assert.Equal(PressureChangeRateUnit.PascalPerMinute, pascalperminuteQuantity.Unit);

            var pascalpersecondQuantity = pascalpersecond.ToUnit(PressureChangeRateUnit.PascalPerSecond);
            AssertEx.EqualTolerance(PascalsPerSecondInOnePascalPerSecond, (double)pascalpersecondQuantity.Value, PascalsPerSecondTolerance);
            Assert.Equal(PressureChangeRateUnit.PascalPerSecond, pascalpersecondQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = PressureChangeRate.FromPascalsPerSecond(1).ToBaseUnit();
            Assert.Equal(PressureChangeRate.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            PressureChangeRate pascalpersecond = PressureChangeRate.FromPascalsPerSecond(1);
            AssertEx.EqualTolerance(1, PressureChangeRate.FromAtmospheresPerSecond(pascalpersecond.AtmospheresPerSecond).PascalsPerSecond, AtmospheresPerSecondTolerance);
            AssertEx.EqualTolerance(1, PressureChangeRate.FromKilopascalsPerMinute(pascalpersecond.KilopascalsPerMinute).PascalsPerSecond, KilopascalsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, PressureChangeRate.FromKilopascalsPerSecond(pascalpersecond.KilopascalsPerSecond).PascalsPerSecond, KilopascalsPerSecondTolerance);
            AssertEx.EqualTolerance(1, PressureChangeRate.FromMegapascalsPerMinute(pascalpersecond.MegapascalsPerMinute).PascalsPerSecond, MegapascalsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, PressureChangeRate.FromMegapascalsPerSecond(pascalpersecond.MegapascalsPerSecond).PascalsPerSecond, MegapascalsPerSecondTolerance);
            AssertEx.EqualTolerance(1, PressureChangeRate.FromPascalsPerMinute(pascalpersecond.PascalsPerMinute).PascalsPerSecond, PascalsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, PressureChangeRate.FromPascalsPerSecond(pascalpersecond.PascalsPerSecond).PascalsPerSecond, PascalsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            PressureChangeRate v = PressureChangeRate.FromPascalsPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.PascalsPerSecond, PascalsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (PressureChangeRate.FromPascalsPerSecond(3)-v).PascalsPerSecond, PascalsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).PascalsPerSecond, PascalsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).PascalsPerSecond, PascalsPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).PascalsPerSecond, PascalsPerSecondTolerance);
            AssertEx.EqualTolerance(2, (PressureChangeRate.FromPascalsPerSecond(10)/5).PascalsPerSecond, PascalsPerSecondTolerance);
            AssertEx.EqualTolerance(2, PressureChangeRate.FromPascalsPerSecond(10)/PressureChangeRate.FromPascalsPerSecond(5), PascalsPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            PressureChangeRate onePascalPerSecond = PressureChangeRate.FromPascalsPerSecond(1);
            PressureChangeRate twoPascalsPerSecond = PressureChangeRate.FromPascalsPerSecond(2);

            Assert.True(onePascalPerSecond < twoPascalsPerSecond);
            Assert.True(onePascalPerSecond <= twoPascalsPerSecond);
            Assert.True(twoPascalsPerSecond > onePascalPerSecond);
            Assert.True(twoPascalsPerSecond >= onePascalPerSecond);

            Assert.False(onePascalPerSecond > twoPascalsPerSecond);
            Assert.False(onePascalPerSecond >= twoPascalsPerSecond);
            Assert.False(twoPascalsPerSecond < onePascalPerSecond);
            Assert.False(twoPascalsPerSecond <= onePascalPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            PressureChangeRate pascalpersecond = PressureChangeRate.FromPascalsPerSecond(1);
            Assert.Equal(0, pascalpersecond.CompareTo(pascalpersecond));
            Assert.True(pascalpersecond.CompareTo(PressureChangeRate.Zero) > 0);
            Assert.True(PressureChangeRate.Zero.CompareTo(pascalpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            PressureChangeRate pascalpersecond = PressureChangeRate.FromPascalsPerSecond(1);
            Assert.Throws<ArgumentException>(() => pascalpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            PressureChangeRate pascalpersecond = PressureChangeRate.FromPascalsPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => pascalpersecond.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = PressureChangeRate.FromPascalsPerSecond(1);
            var b = PressureChangeRate.FromPascalsPerSecond(2);

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
            var a = PressureChangeRate.FromPascalsPerSecond(1);
            var b = PressureChangeRate.FromPascalsPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = PressureChangeRate.FromPascalsPerSecond(1);
            object b = PressureChangeRate.FromPascalsPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = PressureChangeRate.FromPascalsPerSecond(1);
            Assert.True(v.Equals(PressureChangeRate.FromPascalsPerSecond(1), PascalsPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(PressureChangeRate.Zero, PascalsPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = PressureChangeRate.FromPascalsPerSecond(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(PressureChangeRate.FromPascalsPerSecond(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            PressureChangeRate pascalpersecond = PressureChangeRate.FromPascalsPerSecond(1);
            Assert.False(pascalpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            PressureChangeRate pascalpersecond = PressureChangeRate.FromPascalsPerSecond(1);
            Assert.False(pascalpersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(PressureChangeRateUnit.Undefined, PressureChangeRate.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(PressureChangeRateUnit)).Cast<PressureChangeRateUnit>();
            foreach(var unit in units)
            {
                if(unit == PressureChangeRateUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(PressureChangeRate.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 atm/s", new PressureChangeRate(1, PressureChangeRateUnit.AtmospherePerSecond).ToString());
                Assert.Equal("1 kPa/min", new PressureChangeRate(1, PressureChangeRateUnit.KilopascalPerMinute).ToString());
                Assert.Equal("1 kPa/s", new PressureChangeRate(1, PressureChangeRateUnit.KilopascalPerSecond).ToString());
                Assert.Equal("1 MPa/min", new PressureChangeRate(1, PressureChangeRateUnit.MegapascalPerMinute).ToString());
                Assert.Equal("1 MPa/s", new PressureChangeRate(1, PressureChangeRateUnit.MegapascalPerSecond).ToString());
                Assert.Equal("1 Pa/min", new PressureChangeRate(1, PressureChangeRateUnit.PascalPerMinute).ToString());
                Assert.Equal("1 Pa/s", new PressureChangeRate(1, PressureChangeRateUnit.PascalPerSecond).ToString());
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

            Assert.Equal("1 atm/s", new PressureChangeRate(1, PressureChangeRateUnit.AtmospherePerSecond).ToString(swedishCulture));
            Assert.Equal("1 kPa/min", new PressureChangeRate(1, PressureChangeRateUnit.KilopascalPerMinute).ToString(swedishCulture));
            Assert.Equal("1 kPa/s", new PressureChangeRate(1, PressureChangeRateUnit.KilopascalPerSecond).ToString(swedishCulture));
            Assert.Equal("1 MPa/min", new PressureChangeRate(1, PressureChangeRateUnit.MegapascalPerMinute).ToString(swedishCulture));
            Assert.Equal("1 MPa/s", new PressureChangeRate(1, PressureChangeRateUnit.MegapascalPerSecond).ToString(swedishCulture));
            Assert.Equal("1 Pa/min", new PressureChangeRate(1, PressureChangeRateUnit.PascalPerMinute).ToString(swedishCulture));
            Assert.Equal("1 Pa/s", new PressureChangeRate(1, PressureChangeRateUnit.PascalPerSecond).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 Pa/s", new PressureChangeRate(0.123456, PressureChangeRateUnit.PascalPerSecond).ToString("s1"));
                Assert.Equal("0.12 Pa/s", new PressureChangeRate(0.123456, PressureChangeRateUnit.PascalPerSecond).ToString("s2"));
                Assert.Equal("0.123 Pa/s", new PressureChangeRate(0.123456, PressureChangeRateUnit.PascalPerSecond).ToString("s3"));
                Assert.Equal("0.1235 Pa/s", new PressureChangeRate(0.123456, PressureChangeRateUnit.PascalPerSecond).ToString("s4"));
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
            Assert.Equal("0.1 Pa/s", new PressureChangeRate(0.123456, PressureChangeRateUnit.PascalPerSecond).ToString("s1", culture));
            Assert.Equal("0.12 Pa/s", new PressureChangeRate(0.123456, PressureChangeRateUnit.PascalPerSecond).ToString("s2", culture));
            Assert.Equal("0.123 Pa/s", new PressureChangeRate(0.123456, PressureChangeRateUnit.PascalPerSecond).ToString("s3", culture));
            Assert.Equal("0.1235 Pa/s", new PressureChangeRate(0.123456, PressureChangeRateUnit.PascalPerSecond).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(PressureChangeRate)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(PressureChangeRateUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal(QuantityType.PressureChangeRate, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal(PressureChangeRate.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal(PressureChangeRate.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(1.0);
            Assert.Equal(new {PressureChangeRate.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = PressureChangeRate.FromPascalsPerSecond(value);
            Assert.Equal(PressureChangeRate.FromPascalsPerSecond(-value), -quantity);
        }
    }
}
