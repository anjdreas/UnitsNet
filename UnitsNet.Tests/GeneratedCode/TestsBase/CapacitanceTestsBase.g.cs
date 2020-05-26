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
    /// Test of Capacitance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class CapacitanceTestsBase
    {
        protected abstract double FaradsInOneFarad { get; }
        protected abstract double KilofaradsInOneFarad { get; }
        protected abstract double MegafaradsInOneFarad { get; }
        protected abstract double MicrofaradsInOneFarad { get; }
        protected abstract double MillifaradsInOneFarad { get; }
        protected abstract double NanofaradsInOneFarad { get; }
        protected abstract double PicofaradsInOneFarad { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double FaradsTolerance { get { return 1e-5; } }
        protected virtual double KilofaradsTolerance { get { return 1e-5; } }
        protected virtual double MegafaradsTolerance { get { return 1e-5; } }
        protected virtual double MicrofaradsTolerance { get { return 1e-5; } }
        protected virtual double MillifaradsTolerance { get { return 1e-5; } }
        protected virtual double NanofaradsTolerance { get { return 1e-5; } }
        protected virtual double PicofaradsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Capacitance((double)0.0, CapacitanceUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Capacitance();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(CapacitanceUnit.Farad, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Capacitance(double.PositiveInfinity, CapacitanceUnit.Farad));
            Assert.Throws<ArgumentException>(() => new Capacitance(double.NegativeInfinity, CapacitanceUnit.Farad));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Capacitance(double.NaN, CapacitanceUnit.Farad));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Capacitance(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void Capacitance_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Capacitance(1, CapacitanceUnit.Farad);

            QuantityInfo<CapacitanceUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Capacitance.Zero, quantityInfo.Zero);
            Assert.Equal("Capacitance", quantityInfo.Name);
            Assert.Equal(QuantityType.Capacitance, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<CapacitanceUnit>().Except(new[] {CapacitanceUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void FaradToCapacitanceUnits()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            AssertEx.EqualTolerance(FaradsInOneFarad, farad.Farads, FaradsTolerance);
            AssertEx.EqualTolerance(KilofaradsInOneFarad, farad.Kilofarads, KilofaradsTolerance);
            AssertEx.EqualTolerance(MegafaradsInOneFarad, farad.Megafarads, MegafaradsTolerance);
            AssertEx.EqualTolerance(MicrofaradsInOneFarad, farad.Microfarads, MicrofaradsTolerance);
            AssertEx.EqualTolerance(MillifaradsInOneFarad, farad.Millifarads, MillifaradsTolerance);
            AssertEx.EqualTolerance(NanofaradsInOneFarad, farad.Nanofarads, NanofaradsTolerance);
            AssertEx.EqualTolerance(PicofaradsInOneFarad, farad.Picofarads, PicofaradsTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Capacitance.From(1, CapacitanceUnit.Farad);
            AssertEx.EqualTolerance(1, quantity00.Farads, FaradsTolerance);
            Assert.Equal(CapacitanceUnit.Farad, quantity00.Unit);

            var quantity01 = Capacitance.From(1, CapacitanceUnit.Kilofarad);
            AssertEx.EqualTolerance(1, quantity01.Kilofarads, KilofaradsTolerance);
            Assert.Equal(CapacitanceUnit.Kilofarad, quantity01.Unit);

            var quantity02 = Capacitance.From(1, CapacitanceUnit.Megafarad);
            AssertEx.EqualTolerance(1, quantity02.Megafarads, MegafaradsTolerance);
            Assert.Equal(CapacitanceUnit.Megafarad, quantity02.Unit);

            var quantity03 = Capacitance.From(1, CapacitanceUnit.Microfarad);
            AssertEx.EqualTolerance(1, quantity03.Microfarads, MicrofaradsTolerance);
            Assert.Equal(CapacitanceUnit.Microfarad, quantity03.Unit);

            var quantity04 = Capacitance.From(1, CapacitanceUnit.Millifarad);
            AssertEx.EqualTolerance(1, quantity04.Millifarads, MillifaradsTolerance);
            Assert.Equal(CapacitanceUnit.Millifarad, quantity04.Unit);

            var quantity05 = Capacitance.From(1, CapacitanceUnit.Nanofarad);
            AssertEx.EqualTolerance(1, quantity05.Nanofarads, NanofaradsTolerance);
            Assert.Equal(CapacitanceUnit.Nanofarad, quantity05.Unit);

            var quantity06 = Capacitance.From(1, CapacitanceUnit.Picofarad);
            AssertEx.EqualTolerance(1, quantity06.Picofarads, PicofaradsTolerance);
            Assert.Equal(CapacitanceUnit.Picofarad, quantity06.Unit);

        }

        [Fact]
        public void FromFarads_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Capacitance.FromFarads(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Capacitance.FromFarads(double.NegativeInfinity));
        }

        [Fact]
        public void FromFarads_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Capacitance.FromFarads(double.NaN));
        }

        [Fact]
        public void As()
        {
            var farad = Capacitance.FromFarads(1);
            AssertEx.EqualTolerance(FaradsInOneFarad, farad.As(CapacitanceUnit.Farad), FaradsTolerance);
            AssertEx.EqualTolerance(KilofaradsInOneFarad, farad.As(CapacitanceUnit.Kilofarad), KilofaradsTolerance);
            AssertEx.EqualTolerance(MegafaradsInOneFarad, farad.As(CapacitanceUnit.Megafarad), MegafaradsTolerance);
            AssertEx.EqualTolerance(MicrofaradsInOneFarad, farad.As(CapacitanceUnit.Microfarad), MicrofaradsTolerance);
            AssertEx.EqualTolerance(MillifaradsInOneFarad, farad.As(CapacitanceUnit.Millifarad), MillifaradsTolerance);
            AssertEx.EqualTolerance(NanofaradsInOneFarad, farad.As(CapacitanceUnit.Nanofarad), NanofaradsTolerance);
            AssertEx.EqualTolerance(PicofaradsInOneFarad, farad.As(CapacitanceUnit.Picofarad), PicofaradsTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var farad = Capacitance.FromFarads(1);

            var faradQuantity = farad.ToUnit(CapacitanceUnit.Farad);
            AssertEx.EqualTolerance(FaradsInOneFarad, (double)faradQuantity.Value, FaradsTolerance);
            Assert.Equal(CapacitanceUnit.Farad, faradQuantity.Unit);

            var kilofaradQuantity = farad.ToUnit(CapacitanceUnit.Kilofarad);
            AssertEx.EqualTolerance(KilofaradsInOneFarad, (double)kilofaradQuantity.Value, KilofaradsTolerance);
            Assert.Equal(CapacitanceUnit.Kilofarad, kilofaradQuantity.Unit);

            var megafaradQuantity = farad.ToUnit(CapacitanceUnit.Megafarad);
            AssertEx.EqualTolerance(MegafaradsInOneFarad, (double)megafaradQuantity.Value, MegafaradsTolerance);
            Assert.Equal(CapacitanceUnit.Megafarad, megafaradQuantity.Unit);

            var microfaradQuantity = farad.ToUnit(CapacitanceUnit.Microfarad);
            AssertEx.EqualTolerance(MicrofaradsInOneFarad, (double)microfaradQuantity.Value, MicrofaradsTolerance);
            Assert.Equal(CapacitanceUnit.Microfarad, microfaradQuantity.Unit);

            var millifaradQuantity = farad.ToUnit(CapacitanceUnit.Millifarad);
            AssertEx.EqualTolerance(MillifaradsInOneFarad, (double)millifaradQuantity.Value, MillifaradsTolerance);
            Assert.Equal(CapacitanceUnit.Millifarad, millifaradQuantity.Unit);

            var nanofaradQuantity = farad.ToUnit(CapacitanceUnit.Nanofarad);
            AssertEx.EqualTolerance(NanofaradsInOneFarad, (double)nanofaradQuantity.Value, NanofaradsTolerance);
            Assert.Equal(CapacitanceUnit.Nanofarad, nanofaradQuantity.Unit);

            var picofaradQuantity = farad.ToUnit(CapacitanceUnit.Picofarad);
            AssertEx.EqualTolerance(PicofaradsInOneFarad, (double)picofaradQuantity.Value, PicofaradsTolerance);
            Assert.Equal(CapacitanceUnit.Picofarad, picofaradQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            AssertEx.EqualTolerance(1, Capacitance.FromFarads(farad.Farads).Farads, FaradsTolerance);
            AssertEx.EqualTolerance(1, Capacitance.FromKilofarads(farad.Kilofarads).Farads, KilofaradsTolerance);
            AssertEx.EqualTolerance(1, Capacitance.FromMegafarads(farad.Megafarads).Farads, MegafaradsTolerance);
            AssertEx.EqualTolerance(1, Capacitance.FromMicrofarads(farad.Microfarads).Farads, MicrofaradsTolerance);
            AssertEx.EqualTolerance(1, Capacitance.FromMillifarads(farad.Millifarads).Farads, MillifaradsTolerance);
            AssertEx.EqualTolerance(1, Capacitance.FromNanofarads(farad.Nanofarads).Farads, NanofaradsTolerance);
            AssertEx.EqualTolerance(1, Capacitance.FromPicofarads(farad.Picofarads).Farads, PicofaradsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Capacitance v = Capacitance.FromFarads(1);
            AssertEx.EqualTolerance(-1, -v.Farads, FaradsTolerance);
            AssertEx.EqualTolerance(2, (Capacitance.FromFarads(3)-v).Farads, FaradsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Farads, FaradsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Farads, FaradsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Farads, FaradsTolerance);
            AssertEx.EqualTolerance(2, (Capacitance.FromFarads(10)/5).Farads, FaradsTolerance);
            AssertEx.EqualTolerance(2, Capacitance.FromFarads(10)/Capacitance.FromFarads(5), FaradsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Capacitance oneFarad = Capacitance.FromFarads(1);
            Capacitance twoFarads = Capacitance.FromFarads(2);

            Assert.True(oneFarad < twoFarads);
            Assert.True(oneFarad <= twoFarads);
            Assert.True(twoFarads > oneFarad);
            Assert.True(twoFarads >= oneFarad);

            Assert.False(oneFarad > twoFarads);
            Assert.False(oneFarad >= twoFarads);
            Assert.False(twoFarads < oneFarad);
            Assert.False(twoFarads <= oneFarad);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            Assert.Equal(0, farad.CompareTo(farad));
            Assert.True(farad.CompareTo(Capacitance.Zero) > 0);
            Assert.True(Capacitance.Zero.CompareTo(farad) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            Assert.Throws<ArgumentException>(() => farad.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            Assert.Throws<ArgumentNullException>(() => farad.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Capacitance.FromFarads(1);
            var b = Capacitance.FromFarads(2);

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
            var a = Capacitance.FromFarads(1);
            var b = Capacitance.FromFarads(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = Capacitance.FromFarads(1);
            Assert.True(v.Equals(Capacitance.FromFarads(1), FaradsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Capacitance.Zero, FaradsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            Assert.False(farad.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Capacitance farad = Capacitance.FromFarads(1);
            Assert.False(farad.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(CapacitanceUnit.Undefined, Capacitance.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(CapacitanceUnit)).Cast<CapacitanceUnit>();
            foreach(var unit in units)
            {
                if(unit == CapacitanceUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Capacitance.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 F", new Capacitance(1, CapacitanceUnit.Farad).ToString());
                Assert.Equal("1 kF", new Capacitance(1, CapacitanceUnit.Kilofarad).ToString());
                Assert.Equal("1 MF", new Capacitance(1, CapacitanceUnit.Megafarad).ToString());
                Assert.Equal("1 µF", new Capacitance(1, CapacitanceUnit.Microfarad).ToString());
                Assert.Equal("1 mF", new Capacitance(1, CapacitanceUnit.Millifarad).ToString());
                Assert.Equal("1 nF", new Capacitance(1, CapacitanceUnit.Nanofarad).ToString());
                Assert.Equal("1 pF", new Capacitance(1, CapacitanceUnit.Picofarad).ToString());
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

            Assert.Equal("1 F", new Capacitance(1, CapacitanceUnit.Farad).ToString(swedishCulture));
            Assert.Equal("1 kF", new Capacitance(1, CapacitanceUnit.Kilofarad).ToString(swedishCulture));
            Assert.Equal("1 MF", new Capacitance(1, CapacitanceUnit.Megafarad).ToString(swedishCulture));
            Assert.Equal("1 µF", new Capacitance(1, CapacitanceUnit.Microfarad).ToString(swedishCulture));
            Assert.Equal("1 mF", new Capacitance(1, CapacitanceUnit.Millifarad).ToString(swedishCulture));
            Assert.Equal("1 nF", new Capacitance(1, CapacitanceUnit.Nanofarad).ToString(swedishCulture));
            Assert.Equal("1 pF", new Capacitance(1, CapacitanceUnit.Picofarad).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s1"));
                Assert.Equal("0.12 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s2"));
                Assert.Equal("0.123 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s3"));
                Assert.Equal("0.1235 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s4"));
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
            Assert.Equal("0.1 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s1", culture));
            Assert.Equal("0.12 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s2", culture));
            Assert.Equal("0.123 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s3", culture));
            Assert.Equal("0.1235 F", new Capacitance(0.123456, CapacitanceUnit.Farad).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = Capacitance.FromFarads(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618
    }
}
