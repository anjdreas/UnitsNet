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
    /// Test of PowerRatio.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class PowerRatioTestsBase
    {
        protected abstract double DecibelMilliwattsInOneDecibelWatt { get; }
        protected abstract double DecibelWattsInOneDecibelWatt { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecibelMilliwattsTolerance { get { return 1e-5; } }
        protected virtual double DecibelWattsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new PowerRatio((double)0.0, PowerRatioUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new PowerRatio();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(PowerRatioUnit.DecibelWatt, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new PowerRatio(double.PositiveInfinity, PowerRatioUnit.DecibelWatt));
            Assert.Throws<ArgumentException>(() => new PowerRatio(double.NegativeInfinity, PowerRatioUnit.DecibelWatt));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new PowerRatio(double.NaN, PowerRatioUnit.DecibelWatt));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new PowerRatio(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void PowerRatio_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new PowerRatio(1, PowerRatioUnit.DecibelWatt);

            QuantityInfo<PowerRatioUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(PowerRatio.Zero, quantityInfo.Zero);
            Assert.Equal("PowerRatio", quantityInfo.Name);
            Assert.Equal(QuantityType.PowerRatio, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<PowerRatioUnit>().Except(new[] {PowerRatioUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void DecibelWattToPowerRatioUnits()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            AssertEx.EqualTolerance(DecibelMilliwattsInOneDecibelWatt, decibelwatt.DecibelMilliwatts, DecibelMilliwattsTolerance);
            AssertEx.EqualTolerance(DecibelWattsInOneDecibelWatt, decibelwatt.DecibelWatts, DecibelWattsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = PowerRatio.From(1, PowerRatioUnit.DecibelMilliwatt);
            AssertEx.EqualTolerance(1, quantity00.DecibelMilliwatts, DecibelMilliwattsTolerance);
            Assert.Equal(PowerRatioUnit.DecibelMilliwatt, quantity00.Unit);

            var quantity01 = PowerRatio.From(1, PowerRatioUnit.DecibelWatt);
            AssertEx.EqualTolerance(1, quantity01.DecibelWatts, DecibelWattsTolerance);
            Assert.Equal(PowerRatioUnit.DecibelWatt, quantity01.Unit);

        }

        [Fact]
        public void FromDecibelWatts_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => PowerRatio.FromDecibelWatts(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => PowerRatio.FromDecibelWatts(double.NegativeInfinity));
        }

        [Fact]
        public void FromDecibelWatts_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => PowerRatio.FromDecibelWatts(double.NaN));
        }

        [Fact]
        public void As()
        {
            var decibelwatt = PowerRatio.FromDecibelWatts(1);
            AssertEx.EqualTolerance(DecibelMilliwattsInOneDecibelWatt, decibelwatt.As(PowerRatioUnit.DecibelMilliwatt), DecibelMilliwattsTolerance);
            AssertEx.EqualTolerance(DecibelWattsInOneDecibelWatt, decibelwatt.As(PowerRatioUnit.DecibelWatt), DecibelWattsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var decibelwatt = PowerRatio.FromDecibelWatts(1);

            var decibelmilliwattQuantity = decibelwatt.ToUnit(PowerRatioUnit.DecibelMilliwatt);
            AssertEx.EqualTolerance(DecibelMilliwattsInOneDecibelWatt, (double)decibelmilliwattQuantity.Value, DecibelMilliwattsTolerance);
            Assert.Equal(PowerRatioUnit.DecibelMilliwatt, decibelmilliwattQuantity.Unit);

            var decibelwattQuantity = decibelwatt.ToUnit(PowerRatioUnit.DecibelWatt);
            AssertEx.EqualTolerance(DecibelWattsInOneDecibelWatt, (double)decibelwattQuantity.Value, DecibelWattsTolerance);
            Assert.Equal(PowerRatioUnit.DecibelWatt, decibelwattQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            AssertEx.EqualTolerance(1, PowerRatio.FromDecibelMilliwatts(decibelwatt.DecibelMilliwatts).DecibelWatts, DecibelMilliwattsTolerance);
            AssertEx.EqualTolerance(1, PowerRatio.FromDecibelWatts(decibelwatt.DecibelWatts).DecibelWatts, DecibelWattsTolerance);
        }

        [Fact]
        public void LogarithmicArithmeticOperators()
        {
            PowerRatio v = PowerRatio.FromDecibelWatts(40);
            AssertEx.EqualTolerance(-40, -v.DecibelWatts, DecibelWattsTolerance);
            AssertLogarithmicAddition();
            AssertLogarithmicSubtraction();
            AssertEx.EqualTolerance(50, (v*10).DecibelWatts, DecibelWattsTolerance);
            AssertEx.EqualTolerance(50, (10*v).DecibelWatts, DecibelWattsTolerance);
            AssertEx.EqualTolerance(35, (v/5).DecibelWatts, DecibelWattsTolerance);
            AssertEx.EqualTolerance(35, v/PowerRatio.FromDecibelWatts(5), DecibelWattsTolerance);
        }

        protected abstract void AssertLogarithmicAddition();

        protected abstract void AssertLogarithmicSubtraction();

        [Fact]
        public void ComparisonOperators()
        {
            PowerRatio oneDecibelWatt = PowerRatio.FromDecibelWatts(1);
            PowerRatio twoDecibelWatts = PowerRatio.FromDecibelWatts(2);

            Assert.True(oneDecibelWatt < twoDecibelWatts);
            Assert.True(oneDecibelWatt <= twoDecibelWatts);
            Assert.True(twoDecibelWatts > oneDecibelWatt);
            Assert.True(twoDecibelWatts >= oneDecibelWatt);

            Assert.False(oneDecibelWatt > twoDecibelWatts);
            Assert.False(oneDecibelWatt >= twoDecibelWatts);
            Assert.False(twoDecibelWatts < oneDecibelWatt);
            Assert.False(twoDecibelWatts <= oneDecibelWatt);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            Assert.Equal(0, decibelwatt.CompareTo(decibelwatt));
            Assert.True(decibelwatt.CompareTo(PowerRatio.Zero) > 0);
            Assert.True(PowerRatio.Zero.CompareTo(decibelwatt) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            Assert.Throws<ArgumentException>(() => decibelwatt.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            Assert.Throws<ArgumentNullException>(() => decibelwatt.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = PowerRatio.FromDecibelWatts(1);
            var b = PowerRatio.FromDecibelWatts(2);

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
            var a = PowerRatio.FromDecibelWatts(1);
            var b = PowerRatio.FromDecibelWatts(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = PowerRatio.FromDecibelWatts(1);
            Assert.True(v.Equals(PowerRatio.FromDecibelWatts(1), DecibelWattsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(PowerRatio.Zero, DecibelWattsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            Assert.False(decibelwatt.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            PowerRatio decibelwatt = PowerRatio.FromDecibelWatts(1);
            Assert.False(decibelwatt.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(PowerRatioUnit.Undefined, PowerRatio.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(PowerRatioUnit)).Cast<PowerRatioUnit>();
            foreach(var unit in units)
            {
                if(unit == PowerRatioUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(PowerRatio.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 dBmW", new PowerRatio(1, PowerRatioUnit.DecibelMilliwatt).ToString());
                Assert.Equal("1 dBW", new PowerRatio(1, PowerRatioUnit.DecibelWatt).ToString());
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

            Assert.Equal("1 dBmW", new PowerRatio(1, PowerRatioUnit.DecibelMilliwatt).ToString(swedishCulture));
            Assert.Equal("1 dBW", new PowerRatio(1, PowerRatioUnit.DecibelWatt).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s1"));
                Assert.Equal("0.12 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s2"));
                Assert.Equal("0.123 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s3"));
                Assert.Equal("0.1235 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s4"));
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
            Assert.Equal("0.1 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s1", culture));
            Assert.Equal("0.12 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s2", culture));
            Assert.Equal("0.123 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s3", culture));
            Assert.Equal("0.1235 dBW", new PowerRatio(0.123456, PowerRatioUnit.DecibelWatt).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = PowerRatio.FromDecibelWatts(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618
    }
}
