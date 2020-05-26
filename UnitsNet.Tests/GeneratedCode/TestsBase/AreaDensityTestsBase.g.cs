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
    /// Test of AreaDensity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AreaDensityTestsBase
    {
        protected abstract double KilogramsPerSquareMeterInOneKilogramPerSquareMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilogramsPerSquareMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AreaDensity((double)0.0, AreaDensityUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new AreaDensity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(AreaDensityUnit.KilogramPerSquareMeter, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AreaDensity(double.PositiveInfinity, AreaDensityUnit.KilogramPerSquareMeter));
            Assert.Throws<ArgumentException>(() => new AreaDensity(double.NegativeInfinity, AreaDensityUnit.KilogramPerSquareMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AreaDensity(double.NaN, AreaDensityUnit.KilogramPerSquareMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new AreaDensity(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void AreaDensity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new AreaDensity(1, AreaDensityUnit.KilogramPerSquareMeter);

            QuantityInfo<AreaDensityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(AreaDensity.Zero, quantityInfo.Zero);
            Assert.Equal("AreaDensity", quantityInfo.Name);
            Assert.Equal(QuantityType.AreaDensity, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<AreaDensityUnit>().Except(new[] {AreaDensityUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void KilogramPerSquareMeterToAreaDensityUnits()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            AssertEx.EqualTolerance(KilogramsPerSquareMeterInOneKilogramPerSquareMeter, kilogrampersquaremeter.KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = AreaDensity.From(1, AreaDensityUnit.KilogramPerSquareMeter);
            AssertEx.EqualTolerance(1, quantity00.KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            Assert.Equal(AreaDensityUnit.KilogramPerSquareMeter, quantity00.Unit);

        }

        [Fact]
        public void FromKilogramsPerSquareMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AreaDensity.FromKilogramsPerSquareMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => AreaDensity.FromKilogramsPerSquareMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromKilogramsPerSquareMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AreaDensity.FromKilogramsPerSquareMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            AssertEx.EqualTolerance(KilogramsPerSquareMeterInOneKilogramPerSquareMeter, kilogrampersquaremeter.As(AreaDensityUnit.KilogramPerSquareMeter), KilogramsPerSquareMeterTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);

            var kilogrampersquaremeterQuantity = kilogrampersquaremeter.ToUnit(AreaDensityUnit.KilogramPerSquareMeter);
            AssertEx.EqualTolerance(KilogramsPerSquareMeterInOneKilogramPerSquareMeter, (double)kilogrampersquaremeterQuantity.Value, KilogramsPerSquareMeterTolerance);
            Assert.Equal(AreaDensityUnit.KilogramPerSquareMeter, kilogrampersquaremeterQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            AssertEx.EqualTolerance(1, AreaDensity.FromKilogramsPerSquareMeter(kilogrampersquaremeter.KilogramsPerSquareMeter).KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            AreaDensity v = AreaDensity.FromKilogramsPerSquareMeter(1);
            AssertEx.EqualTolerance(-1, -v.KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (AreaDensity.FromKilogramsPerSquareMeter(3)-v).KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, (AreaDensity.FromKilogramsPerSquareMeter(10)/5).KilogramsPerSquareMeter, KilogramsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(2, AreaDensity.FromKilogramsPerSquareMeter(10)/AreaDensity.FromKilogramsPerSquareMeter(5), KilogramsPerSquareMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            AreaDensity oneKilogramPerSquareMeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            AreaDensity twoKilogramsPerSquareMeter = AreaDensity.FromKilogramsPerSquareMeter(2);

            Assert.True(oneKilogramPerSquareMeter < twoKilogramsPerSquareMeter);
            Assert.True(oneKilogramPerSquareMeter <= twoKilogramsPerSquareMeter);
            Assert.True(twoKilogramsPerSquareMeter > oneKilogramPerSquareMeter);
            Assert.True(twoKilogramsPerSquareMeter >= oneKilogramPerSquareMeter);

            Assert.False(oneKilogramPerSquareMeter > twoKilogramsPerSquareMeter);
            Assert.False(oneKilogramPerSquareMeter >= twoKilogramsPerSquareMeter);
            Assert.False(twoKilogramsPerSquareMeter < oneKilogramPerSquareMeter);
            Assert.False(twoKilogramsPerSquareMeter <= oneKilogramPerSquareMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            Assert.Equal(0, kilogrampersquaremeter.CompareTo(kilogrampersquaremeter));
            Assert.True(kilogrampersquaremeter.CompareTo(AreaDensity.Zero) > 0);
            Assert.True(AreaDensity.Zero.CompareTo(kilogrampersquaremeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            Assert.Throws<ArgumentException>(() => kilogrampersquaremeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            Assert.Throws<ArgumentNullException>(() => kilogrampersquaremeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = AreaDensity.FromKilogramsPerSquareMeter(1);
            var b = AreaDensity.FromKilogramsPerSquareMeter(2);

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
            var a = AreaDensity.FromKilogramsPerSquareMeter(1);
            var b = AreaDensity.FromKilogramsPerSquareMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = AreaDensity.FromKilogramsPerSquareMeter(1);
            Assert.True(v.Equals(AreaDensity.FromKilogramsPerSquareMeter(1), KilogramsPerSquareMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(AreaDensity.Zero, KilogramsPerSquareMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            Assert.False(kilogrampersquaremeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            AreaDensity kilogrampersquaremeter = AreaDensity.FromKilogramsPerSquareMeter(1);
            Assert.False(kilogrampersquaremeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(AreaDensityUnit.Undefined, AreaDensity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(AreaDensityUnit)).Cast<AreaDensityUnit>();
            foreach(var unit in units)
            {
                if(unit == AreaDensityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(AreaDensity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 kg/m²", new AreaDensity(1, AreaDensityUnit.KilogramPerSquareMeter).ToString());
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

            Assert.Equal("1 kg/m²", new AreaDensity(1, AreaDensityUnit.KilogramPerSquareMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s1"));
                Assert.Equal("0.12 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s2"));
                Assert.Equal("0.123 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s3"));
                Assert.Equal("0.1235 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s4"));
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
            Assert.Equal("0.1 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s1", culture));
            Assert.Equal("0.12 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s2", culture));
            Assert.Equal("0.123 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s3", culture));
            Assert.Equal("0.1235 kg/m²", new AreaDensity(0.123456, AreaDensityUnit.KilogramPerSquareMeter).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = AreaDensity.FromKilogramsPerSquareMeter(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618
    }
}
