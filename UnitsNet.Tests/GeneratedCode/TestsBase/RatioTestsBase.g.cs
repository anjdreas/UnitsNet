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
    /// Test of Ratio.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RatioTestsBase
    {
        protected abstract double DecimalFractionsInOneDecimalFraction { get; }
        protected abstract double PartsPerBillionInOneDecimalFraction { get; }
        protected abstract double PartsPerMillionInOneDecimalFraction { get; }
        protected abstract double PartsPerThousandInOneDecimalFraction { get; }
        protected abstract double PartsPerTrillionInOneDecimalFraction { get; }
        protected abstract double PercentInOneDecimalFraction { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecimalFractionsTolerance { get { return 1e-5; } }
        protected virtual double PartsPerBillionTolerance { get { return 1e-5; } }
        protected virtual double PartsPerMillionTolerance { get { return 1e-5; } }
        protected virtual double PartsPerThousandTolerance { get { return 1e-5; } }
        protected virtual double PartsPerTrillionTolerance { get { return 1e-5; } }
        protected virtual double PercentTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Ratio((double)0.0, RatioUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Ratio();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(RatioUnit.DecimalFraction, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Ratio(double.PositiveInfinity, RatioUnit.DecimalFraction));
            Assert.Throws<ArgumentException>(() => new Ratio(double.NegativeInfinity, RatioUnit.DecimalFraction));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Ratio(double.NaN, RatioUnit.DecimalFraction));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Ratio(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void Ratio_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Ratio(1, RatioUnit.DecimalFraction);

            QuantityInfo<RatioUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Ratio.Zero, quantityInfo.Zero);
            Assert.Equal("Ratio", quantityInfo.Name);
            Assert.Equal(QuantityType.Ratio, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<RatioUnit>().Except(new[] {RatioUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void DecimalFractionToRatioUnits()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            AssertEx.EqualTolerance(DecimalFractionsInOneDecimalFraction, decimalfraction.DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(PartsPerBillionInOneDecimalFraction, decimalfraction.PartsPerBillion, PartsPerBillionTolerance);
            AssertEx.EqualTolerance(PartsPerMillionInOneDecimalFraction, decimalfraction.PartsPerMillion, PartsPerMillionTolerance);
            AssertEx.EqualTolerance(PartsPerThousandInOneDecimalFraction, decimalfraction.PartsPerThousand, PartsPerThousandTolerance);
            AssertEx.EqualTolerance(PartsPerTrillionInOneDecimalFraction, decimalfraction.PartsPerTrillion, PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(PercentInOneDecimalFraction, decimalfraction.Percent, PercentTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Ratio.From(1, RatioUnit.DecimalFraction);
            AssertEx.EqualTolerance(1, quantity00.DecimalFractions, DecimalFractionsTolerance);
            Assert.Equal(RatioUnit.DecimalFraction, quantity00.Unit);

            var quantity01 = Ratio.From(1, RatioUnit.PartPerBillion);
            AssertEx.EqualTolerance(1, quantity01.PartsPerBillion, PartsPerBillionTolerance);
            Assert.Equal(RatioUnit.PartPerBillion, quantity01.Unit);

            var quantity02 = Ratio.From(1, RatioUnit.PartPerMillion);
            AssertEx.EqualTolerance(1, quantity02.PartsPerMillion, PartsPerMillionTolerance);
            Assert.Equal(RatioUnit.PartPerMillion, quantity02.Unit);

            var quantity03 = Ratio.From(1, RatioUnit.PartPerThousand);
            AssertEx.EqualTolerance(1, quantity03.PartsPerThousand, PartsPerThousandTolerance);
            Assert.Equal(RatioUnit.PartPerThousand, quantity03.Unit);

            var quantity04 = Ratio.From(1, RatioUnit.PartPerTrillion);
            AssertEx.EqualTolerance(1, quantity04.PartsPerTrillion, PartsPerTrillionTolerance);
            Assert.Equal(RatioUnit.PartPerTrillion, quantity04.Unit);

            var quantity05 = Ratio.From(1, RatioUnit.Percent);
            AssertEx.EqualTolerance(1, quantity05.Percent, PercentTolerance);
            Assert.Equal(RatioUnit.Percent, quantity05.Unit);

        }

        [Fact]
        public void FromDecimalFractions_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Ratio.FromDecimalFractions(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Ratio.FromDecimalFractions(double.NegativeInfinity));
        }

        [Fact]
        public void FromDecimalFractions_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Ratio.FromDecimalFractions(double.NaN));
        }

        [Fact]
        public void As()
        {
            var decimalfraction = Ratio.FromDecimalFractions(1);
            AssertEx.EqualTolerance(DecimalFractionsInOneDecimalFraction, decimalfraction.As(RatioUnit.DecimalFraction), DecimalFractionsTolerance);
            AssertEx.EqualTolerance(PartsPerBillionInOneDecimalFraction, decimalfraction.As(RatioUnit.PartPerBillion), PartsPerBillionTolerance);
            AssertEx.EqualTolerance(PartsPerMillionInOneDecimalFraction, decimalfraction.As(RatioUnit.PartPerMillion), PartsPerMillionTolerance);
            AssertEx.EqualTolerance(PartsPerThousandInOneDecimalFraction, decimalfraction.As(RatioUnit.PartPerThousand), PartsPerThousandTolerance);
            AssertEx.EqualTolerance(PartsPerTrillionInOneDecimalFraction, decimalfraction.As(RatioUnit.PartPerTrillion), PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(PercentInOneDecimalFraction, decimalfraction.As(RatioUnit.Percent), PercentTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var decimalfraction = Ratio.FromDecimalFractions(1);

            var decimalfractionQuantity = decimalfraction.ToUnit(RatioUnit.DecimalFraction);
            AssertEx.EqualTolerance(DecimalFractionsInOneDecimalFraction, (double)decimalfractionQuantity.Value, DecimalFractionsTolerance);
            Assert.Equal(RatioUnit.DecimalFraction, decimalfractionQuantity.Unit);

            var partperbillionQuantity = decimalfraction.ToUnit(RatioUnit.PartPerBillion);
            AssertEx.EqualTolerance(PartsPerBillionInOneDecimalFraction, (double)partperbillionQuantity.Value, PartsPerBillionTolerance);
            Assert.Equal(RatioUnit.PartPerBillion, partperbillionQuantity.Unit);

            var partpermillionQuantity = decimalfraction.ToUnit(RatioUnit.PartPerMillion);
            AssertEx.EqualTolerance(PartsPerMillionInOneDecimalFraction, (double)partpermillionQuantity.Value, PartsPerMillionTolerance);
            Assert.Equal(RatioUnit.PartPerMillion, partpermillionQuantity.Unit);

            var partperthousandQuantity = decimalfraction.ToUnit(RatioUnit.PartPerThousand);
            AssertEx.EqualTolerance(PartsPerThousandInOneDecimalFraction, (double)partperthousandQuantity.Value, PartsPerThousandTolerance);
            Assert.Equal(RatioUnit.PartPerThousand, partperthousandQuantity.Unit);

            var partpertrillionQuantity = decimalfraction.ToUnit(RatioUnit.PartPerTrillion);
            AssertEx.EqualTolerance(PartsPerTrillionInOneDecimalFraction, (double)partpertrillionQuantity.Value, PartsPerTrillionTolerance);
            Assert.Equal(RatioUnit.PartPerTrillion, partpertrillionQuantity.Unit);

            var percentQuantity = decimalfraction.ToUnit(RatioUnit.Percent);
            AssertEx.EqualTolerance(PercentInOneDecimalFraction, (double)percentQuantity.Value, PercentTolerance);
            Assert.Equal(RatioUnit.Percent, percentQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            AssertEx.EqualTolerance(1, Ratio.FromDecimalFractions(decimalfraction.DecimalFractions).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPartsPerBillion(decimalfraction.PartsPerBillion).DecimalFractions, PartsPerBillionTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPartsPerMillion(decimalfraction.PartsPerMillion).DecimalFractions, PartsPerMillionTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPartsPerThousand(decimalfraction.PartsPerThousand).DecimalFractions, PartsPerThousandTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPartsPerTrillion(decimalfraction.PartsPerTrillion).DecimalFractions, PartsPerTrillionTolerance);
            AssertEx.EqualTolerance(1, Ratio.FromPercent(decimalfraction.Percent).DecimalFractions, PercentTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Ratio v = Ratio.FromDecimalFractions(1);
            AssertEx.EqualTolerance(-1, -v.DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, (Ratio.FromDecimalFractions(3)-v).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, (v + v).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(10, (v*10).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(10, (10*v).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, (Ratio.FromDecimalFractions(10)/5).DecimalFractions, DecimalFractionsTolerance);
            AssertEx.EqualTolerance(2, Ratio.FromDecimalFractions(10)/Ratio.FromDecimalFractions(5), DecimalFractionsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Ratio oneDecimalFraction = Ratio.FromDecimalFractions(1);
            Ratio twoDecimalFractions = Ratio.FromDecimalFractions(2);

            Assert.True(oneDecimalFraction < twoDecimalFractions);
            Assert.True(oneDecimalFraction <= twoDecimalFractions);
            Assert.True(twoDecimalFractions > oneDecimalFraction);
            Assert.True(twoDecimalFractions >= oneDecimalFraction);

            Assert.False(oneDecimalFraction > twoDecimalFractions);
            Assert.False(oneDecimalFraction >= twoDecimalFractions);
            Assert.False(twoDecimalFractions < oneDecimalFraction);
            Assert.False(twoDecimalFractions <= oneDecimalFraction);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.Equal(0, decimalfraction.CompareTo(decimalfraction));
            Assert.True(decimalfraction.CompareTo(Ratio.Zero) > 0);
            Assert.True(Ratio.Zero.CompareTo(decimalfraction) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.Throws<ArgumentException>(() => decimalfraction.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.Throws<ArgumentNullException>(() => decimalfraction.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Ratio.FromDecimalFractions(1);
            var b = Ratio.FromDecimalFractions(2);

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
            var a = Ratio.FromDecimalFractions(1);
            var b = Ratio.FromDecimalFractions(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = Ratio.FromDecimalFractions(1);
            Assert.True(v.Equals(Ratio.FromDecimalFractions(1), DecimalFractionsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Ratio.Zero, DecimalFractionsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.False(decimalfraction.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Ratio decimalfraction = Ratio.FromDecimalFractions(1);
            Assert.False(decimalfraction.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RatioUnit.Undefined, Ratio.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(RatioUnit)).Cast<RatioUnit>();
            foreach(var unit in units)
            {
                if(unit == RatioUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Ratio.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 ", new Ratio(1, RatioUnit.DecimalFraction).ToString());
                Assert.Equal("1 ppb", new Ratio(1, RatioUnit.PartPerBillion).ToString());
                Assert.Equal("1 ppm", new Ratio(1, RatioUnit.PartPerMillion).ToString());
                Assert.Equal("1 ‰", new Ratio(1, RatioUnit.PartPerThousand).ToString());
                Assert.Equal("1 ppt", new Ratio(1, RatioUnit.PartPerTrillion).ToString());
                Assert.Equal("1 %", new Ratio(1, RatioUnit.Percent).ToString());
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

            Assert.Equal("1 ", new Ratio(1, RatioUnit.DecimalFraction).ToString(swedishCulture));
            Assert.Equal("1 ppb", new Ratio(1, RatioUnit.PartPerBillion).ToString(swedishCulture));
            Assert.Equal("1 ppm", new Ratio(1, RatioUnit.PartPerMillion).ToString(swedishCulture));
            Assert.Equal("1 ‰", new Ratio(1, RatioUnit.PartPerThousand).ToString(swedishCulture));
            Assert.Equal("1 ppt", new Ratio(1, RatioUnit.PartPerTrillion).ToString(swedishCulture));
            Assert.Equal("1 %", new Ratio(1, RatioUnit.Percent).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 ", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s1"));
                Assert.Equal("0.12 ", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s2"));
                Assert.Equal("0.123 ", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s3"));
                Assert.Equal("0.1235 ", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s4"));
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
            Assert.Equal("0.1 ", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s1", culture));
            Assert.Equal("0.12 ", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s2", culture));
            Assert.Equal("0.123 ", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s3", culture));
            Assert.Equal("0.1235 ", new Ratio(0.123456, RatioUnit.DecimalFraction).ToString("s4", culture));
        }
    }
}
