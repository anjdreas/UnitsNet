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
    /// Test of ElectricResistance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricResistanceTestsBase
    {
        protected abstract double GigaohmsInOneOhm { get; }
        protected abstract double KiloohmsInOneOhm { get; }
        protected abstract double MegaohmsInOneOhm { get; }
        protected abstract double MilliohmsInOneOhm { get; }
        protected abstract double OhmsInOneOhm { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double GigaohmsTolerance { get { return 1e-5; } }
        protected virtual double KiloohmsTolerance { get { return 1e-5; } }
        protected virtual double MegaohmsTolerance { get { return 1e-5; } }
        protected virtual double MilliohmsTolerance { get { return 1e-5; } }
        protected virtual double OhmsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricResistance((double)0.0, ElectricResistanceUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricResistance();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricResistanceUnit.Ohm, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricResistance(double.PositiveInfinity, ElectricResistanceUnit.Ohm));
            Assert.Throws<ArgumentException>(() => new ElectricResistance(double.NegativeInfinity, ElectricResistanceUnit.Ohm));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricResistance(double.NaN, ElectricResistanceUnit.Ohm));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricResistance(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void ElectricResistance_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricResistance(1, ElectricResistanceUnit.Ohm);

            QuantityInfo<ElectricResistanceUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricResistance.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricResistance", quantityInfo.Name);
            Assert.Equal(QuantityType.ElectricResistance, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<ElectricResistanceUnit>().Except(new[] {ElectricResistanceUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void OhmToElectricResistanceUnits()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            AssertEx.EqualTolerance(GigaohmsInOneOhm, ohm.Gigaohms, GigaohmsTolerance);
            AssertEx.EqualTolerance(KiloohmsInOneOhm, ohm.Kiloohms, KiloohmsTolerance);
            AssertEx.EqualTolerance(MegaohmsInOneOhm, ohm.Megaohms, MegaohmsTolerance);
            AssertEx.EqualTolerance(MilliohmsInOneOhm, ohm.Milliohms, MilliohmsTolerance);
            AssertEx.EqualTolerance(OhmsInOneOhm, ohm.Ohms, OhmsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricResistance.From(1, ElectricResistanceUnit.Gigaohm);
            AssertEx.EqualTolerance(1, quantity00.Gigaohms, GigaohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Gigaohm, quantity00.Unit);

            var quantity01 = ElectricResistance.From(1, ElectricResistanceUnit.Kiloohm);
            AssertEx.EqualTolerance(1, quantity01.Kiloohms, KiloohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Kiloohm, quantity01.Unit);

            var quantity02 = ElectricResistance.From(1, ElectricResistanceUnit.Megaohm);
            AssertEx.EqualTolerance(1, quantity02.Megaohms, MegaohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Megaohm, quantity02.Unit);

            var quantity03 = ElectricResistance.From(1, ElectricResistanceUnit.Milliohm);
            AssertEx.EqualTolerance(1, quantity03.Milliohms, MilliohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Milliohm, quantity03.Unit);

            var quantity04 = ElectricResistance.From(1, ElectricResistanceUnit.Ohm);
            AssertEx.EqualTolerance(1, quantity04.Ohms, OhmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Ohm, quantity04.Unit);

        }

        [Fact]
        public void FromOhms_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricResistance.FromOhms(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricResistance.FromOhms(double.NegativeInfinity));
        }

        [Fact]
        public void FromOhms_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricResistance.FromOhms(double.NaN));
        }

        [Fact]
        public void As()
        {
            var ohm = ElectricResistance.FromOhms(1);
            AssertEx.EqualTolerance(GigaohmsInOneOhm, ohm.As(ElectricResistanceUnit.Gigaohm), GigaohmsTolerance);
            AssertEx.EqualTolerance(KiloohmsInOneOhm, ohm.As(ElectricResistanceUnit.Kiloohm), KiloohmsTolerance);
            AssertEx.EqualTolerance(MegaohmsInOneOhm, ohm.As(ElectricResistanceUnit.Megaohm), MegaohmsTolerance);
            AssertEx.EqualTolerance(MilliohmsInOneOhm, ohm.As(ElectricResistanceUnit.Milliohm), MilliohmsTolerance);
            AssertEx.EqualTolerance(OhmsInOneOhm, ohm.As(ElectricResistanceUnit.Ohm), OhmsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var ohm = ElectricResistance.FromOhms(1);

            var gigaohmQuantity = ohm.ToUnit(ElectricResistanceUnit.Gigaohm);
            AssertEx.EqualTolerance(GigaohmsInOneOhm, (double)gigaohmQuantity.Value, GigaohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Gigaohm, gigaohmQuantity.Unit);

            var kiloohmQuantity = ohm.ToUnit(ElectricResistanceUnit.Kiloohm);
            AssertEx.EqualTolerance(KiloohmsInOneOhm, (double)kiloohmQuantity.Value, KiloohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Kiloohm, kiloohmQuantity.Unit);

            var megaohmQuantity = ohm.ToUnit(ElectricResistanceUnit.Megaohm);
            AssertEx.EqualTolerance(MegaohmsInOneOhm, (double)megaohmQuantity.Value, MegaohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Megaohm, megaohmQuantity.Unit);

            var milliohmQuantity = ohm.ToUnit(ElectricResistanceUnit.Milliohm);
            AssertEx.EqualTolerance(MilliohmsInOneOhm, (double)milliohmQuantity.Value, MilliohmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Milliohm, milliohmQuantity.Unit);

            var ohmQuantity = ohm.ToUnit(ElectricResistanceUnit.Ohm);
            AssertEx.EqualTolerance(OhmsInOneOhm, (double)ohmQuantity.Value, OhmsTolerance);
            Assert.Equal(ElectricResistanceUnit.Ohm, ohmQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            AssertEx.EqualTolerance(1, ElectricResistance.FromGigaohms(ohm.Gigaohms).Ohms, GigaohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromKiloohms(ohm.Kiloohms).Ohms, KiloohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromMegaohms(ohm.Megaohms).Ohms, MegaohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromMilliohms(ohm.Milliohms).Ohms, MilliohmsTolerance);
            AssertEx.EqualTolerance(1, ElectricResistance.FromOhms(ohm.Ohms).Ohms, OhmsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricResistance v = ElectricResistance.FromOhms(1);
            AssertEx.EqualTolerance(-1, -v.Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, (ElectricResistance.FromOhms(3)-v).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, (ElectricResistance.FromOhms(10)/5).Ohms, OhmsTolerance);
            AssertEx.EqualTolerance(2, ElectricResistance.FromOhms(10)/ElectricResistance.FromOhms(5), OhmsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricResistance oneOhm = ElectricResistance.FromOhms(1);
            ElectricResistance twoOhms = ElectricResistance.FromOhms(2);

            Assert.True(oneOhm < twoOhms);
            Assert.True(oneOhm <= twoOhms);
            Assert.True(twoOhms > oneOhm);
            Assert.True(twoOhms >= oneOhm);

            Assert.False(oneOhm > twoOhms);
            Assert.False(oneOhm >= twoOhms);
            Assert.False(twoOhms < oneOhm);
            Assert.False(twoOhms <= oneOhm);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.Equal(0, ohm.CompareTo(ohm));
            Assert.True(ohm.CompareTo(ElectricResistance.Zero) > 0);
            Assert.True(ElectricResistance.Zero.CompareTo(ohm) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.Throws<ArgumentException>(() => ohm.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.Throws<ArgumentNullException>(() => ohm.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ElectricResistance.FromOhms(1);
            var b = ElectricResistance.FromOhms(2);

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
            var a = ElectricResistance.FromOhms(1);
            var b = ElectricResistance.FromOhms(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = ElectricResistance.FromOhms(1);
            Assert.True(v.Equals(ElectricResistance.FromOhms(1), OhmsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricResistance.Zero, OhmsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.False(ohm.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricResistance ohm = ElectricResistance.FromOhms(1);
            Assert.False(ohm.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricResistanceUnit.Undefined, ElectricResistance.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricResistanceUnit)).Cast<ElectricResistanceUnit>();
            foreach(var unit in units)
            {
                if(unit == ElectricResistanceUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricResistance.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 GΩ", new ElectricResistance(1, ElectricResistanceUnit.Gigaohm).ToString());
                Assert.Equal("1 kΩ", new ElectricResistance(1, ElectricResistanceUnit.Kiloohm).ToString());
                Assert.Equal("1 MΩ", new ElectricResistance(1, ElectricResistanceUnit.Megaohm).ToString());
                Assert.Equal("1 mΩ", new ElectricResistance(1, ElectricResistanceUnit.Milliohm).ToString());
                Assert.Equal("1 Ω", new ElectricResistance(1, ElectricResistanceUnit.Ohm).ToString());
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

            Assert.Equal("1 GΩ", new ElectricResistance(1, ElectricResistanceUnit.Gigaohm).ToString(swedishCulture));
            Assert.Equal("1 kΩ", new ElectricResistance(1, ElectricResistanceUnit.Kiloohm).ToString(swedishCulture));
            Assert.Equal("1 MΩ", new ElectricResistance(1, ElectricResistanceUnit.Megaohm).ToString(swedishCulture));
            Assert.Equal("1 mΩ", new ElectricResistance(1, ElectricResistanceUnit.Milliohm).ToString(swedishCulture));
            Assert.Equal("1 Ω", new ElectricResistance(1, ElectricResistanceUnit.Ohm).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s1"));
                Assert.Equal("0.12 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s2"));
                Assert.Equal("0.123 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s3"));
                Assert.Equal("0.1235 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s4"));
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
            Assert.Equal("0.1 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s1", culture));
            Assert.Equal("0.12 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s2", culture));
            Assert.Equal("0.123 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s3", culture));
            Assert.Equal("0.1235 Ω", new ElectricResistance(0.123456, ElectricResistanceUnit.Ohm).ToString("s4", culture));
        }
    }
}
