//------------------------------------------------------------------------------
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
    /// Test of ThermalConductivity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ThermalConductivityTestsBase : QuantityTestsBase
    {
        protected abstract double BtusPerHourFootFahrenheitInOneWattPerMeterKelvin { get; }
        protected abstract double WattsPerMeterKelvinInOneWattPerMeterKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double BtusPerHourFootFahrenheitTolerance { get { return 1e-5; } }
        protected virtual double WattsPerMeterKelvinTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ThermalConductivity((double)0.0, ThermalConductivityUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ThermalConductivity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ThermalConductivityUnit.WattPerMeterKelvin, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ThermalConductivity(double.PositiveInfinity, ThermalConductivityUnit.WattPerMeterKelvin));
            Assert.Throws<ArgumentException>(() => new ThermalConductivity(double.NegativeInfinity, ThermalConductivityUnit.WattPerMeterKelvin));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ThermalConductivity(double.NaN, ThermalConductivityUnit.WattPerMeterKelvin));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ThermalConductivity(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Assert.Throws<ArgumentException>(() => new ThermalConductivity(1, UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => new ThermalConductivity(1, UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => new ThermalConductivity(1, UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => new ThermalConductivity(1, UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => new ThermalConductivity(1, UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => new ThermalConductivity(1, UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => new ThermalConductivity(1, UnitSystem.Astronomical));
        }

        [Fact]
        public void Ctor_WithNullUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ThermalConductivity(1, null));
        }

        public void ThermalConductivity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ThermalConductivity(1, ThermalConductivityUnit.WattPerMeterKelvin);

            QuantityInfo<ThermalConductivityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ThermalConductivity.Zero, quantityInfo.Zero);
            Assert.Equal("ThermalConductivity", quantityInfo.Name);
            Assert.Equal(QuantityType.ThermalConductivity, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<ThermalConductivityUnit>().Except(new[] {ThermalConductivityUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void WattPerMeterKelvinToThermalConductivityUnits()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            AssertEx.EqualTolerance(BtusPerHourFootFahrenheitInOneWattPerMeterKelvin, wattpermeterkelvin.BtusPerHourFootFahrenheit, BtusPerHourFootFahrenheitTolerance);
            AssertEx.EqualTolerance(WattsPerMeterKelvinInOneWattPerMeterKelvin, wattpermeterkelvin.WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ThermalConductivity.From(1, ThermalConductivityUnit.BtuPerHourFootFahrenheit);
            AssertEx.EqualTolerance(1, quantity00.BtusPerHourFootFahrenheit, BtusPerHourFootFahrenheitTolerance);
            Assert.Equal(ThermalConductivityUnit.BtuPerHourFootFahrenheit, quantity00.Unit);

            var quantity01 = ThermalConductivity.From(1, ThermalConductivityUnit.WattPerMeterKelvin);
            AssertEx.EqualTolerance(1, quantity01.WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            Assert.Equal(ThermalConductivityUnit.WattPerMeterKelvin, quantity01.Unit);

        }

        [Fact]
        public void FromWattsPerMeterKelvin_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ThermalConductivity.FromWattsPerMeterKelvin(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ThermalConductivity.FromWattsPerMeterKelvin(double.NegativeInfinity));
        }

        [Fact]
        public void FromWattsPerMeterKelvin_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ThermalConductivity.FromWattsPerMeterKelvin(double.NaN));
        }

        [Fact]
        public void As()
        {
            var wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            AssertEx.EqualTolerance(BtusPerHourFootFahrenheitInOneWattPerMeterKelvin, wattpermeterkelvin.As(ThermalConductivityUnit.BtuPerHourFootFahrenheit), BtusPerHourFootFahrenheitTolerance);
            AssertEx.EqualTolerance(WattsPerMeterKelvinInOneWattPerMeterKelvin, wattpermeterkelvin.As(ThermalConductivityUnit.WattPerMeterKelvin), WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void As_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);

            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.As(UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.As(UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.As(UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.As(UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.As(UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.As(UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.As(UnitSystem.Astronomical));
        }

        [Fact]
        public void As_WithNullUnitSystem_ThrowsArgumentNullException()
        {
            var wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
 
            Assert.Throws<ArgumentNullException>(() => wattpermeterkelvin.As(null));
        }

        [Fact]
        public void ToUnit()
        {
            var wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);

            var btuperhourfootfahrenheitQuantity = wattpermeterkelvin.ToUnit(ThermalConductivityUnit.BtuPerHourFootFahrenheit);
            AssertEx.EqualTolerance(BtusPerHourFootFahrenheitInOneWattPerMeterKelvin, (double)btuperhourfootfahrenheitQuantity.Value, BtusPerHourFootFahrenheitTolerance);
            Assert.Equal(ThermalConductivityUnit.BtuPerHourFootFahrenheit, btuperhourfootfahrenheitQuantity.Unit);

            var wattpermeterkelvinQuantity = wattpermeterkelvin.ToUnit(ThermalConductivityUnit.WattPerMeterKelvin);
            AssertEx.EqualTolerance(WattsPerMeterKelvinInOneWattPerMeterKelvin, (double)wattpermeterkelvinQuantity.Value, WattsPerMeterKelvinTolerance);
            Assert.Equal(ThermalConductivityUnit.WattPerMeterKelvin, wattpermeterkelvinQuantity.Unit);
        }

        [Fact]
        public void To_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);

            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.ToUnit(UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.ToUnit(UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.ToUnit(UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.ToUnit(UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.ToUnit(UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.ToUnit(UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.ToUnit(UnitSystem.Astronomical));
        }

        [Fact]
        public void ToUnit_WithNullUnitSystem_ThrowsNullException()
        {
            var wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
 
            Assert.Throws<ArgumentNullException>(() => wattpermeterkelvin.ToUnit(null));
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = ThermalConductivity.FromWattsPerMeterKelvin(1).ToBaseUnit();
            Assert.Equal(ThermalConductivity.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            AssertEx.EqualTolerance(1, ThermalConductivity.FromBtusPerHourFootFahrenheit(wattpermeterkelvin.BtusPerHourFootFahrenheit).WattsPerMeterKelvin, BtusPerHourFootFahrenheitTolerance);
            AssertEx.EqualTolerance(1, ThermalConductivity.FromWattsPerMeterKelvin(wattpermeterkelvin.WattsPerMeterKelvin).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ThermalConductivity v = ThermalConductivity.FromWattsPerMeterKelvin(1);
            AssertEx.EqualTolerance(-1, -v.WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, (ThermalConductivity.FromWattsPerMeterKelvin(3)-v).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, (v + v).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(10, (v*10).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(10, (10*v).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, (ThermalConductivity.FromWattsPerMeterKelvin(10)/5).WattsPerMeterKelvin, WattsPerMeterKelvinTolerance);
            AssertEx.EqualTolerance(2, ThermalConductivity.FromWattsPerMeterKelvin(10)/ThermalConductivity.FromWattsPerMeterKelvin(5), WattsPerMeterKelvinTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ThermalConductivity oneWattPerMeterKelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            ThermalConductivity twoWattsPerMeterKelvin = ThermalConductivity.FromWattsPerMeterKelvin(2);

            Assert.True(oneWattPerMeterKelvin < twoWattsPerMeterKelvin);
            Assert.True(oneWattPerMeterKelvin <= twoWattsPerMeterKelvin);
            Assert.True(twoWattsPerMeterKelvin > oneWattPerMeterKelvin);
            Assert.True(twoWattsPerMeterKelvin >= oneWattPerMeterKelvin);

            Assert.False(oneWattPerMeterKelvin > twoWattsPerMeterKelvin);
            Assert.False(oneWattPerMeterKelvin >= twoWattsPerMeterKelvin);
            Assert.False(twoWattsPerMeterKelvin < oneWattPerMeterKelvin);
            Assert.False(twoWattsPerMeterKelvin <= oneWattPerMeterKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            Assert.Equal(0, wattpermeterkelvin.CompareTo(wattpermeterkelvin));
            Assert.True(wattpermeterkelvin.CompareTo(ThermalConductivity.Zero) > 0);
            Assert.True(ThermalConductivity.Zero.CompareTo(wattpermeterkelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            Assert.Throws<ArgumentException>(() => wattpermeterkelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            Assert.Throws<ArgumentNullException>(() => wattpermeterkelvin.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ThermalConductivity.FromWattsPerMeterKelvin(1);
            var b = ThermalConductivity.FromWattsPerMeterKelvin(2);

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = ThermalConductivity.FromWattsPerMeterKelvin(1);
            var b = ThermalConductivity.FromWattsPerMeterKelvin(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = ThermalConductivity.FromWattsPerMeterKelvin(1);
            object b = ThermalConductivity.FromWattsPerMeterKelvin(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ThermalConductivity.FromWattsPerMeterKelvin(1);
            Assert.True(v.Equals(ThermalConductivity.FromWattsPerMeterKelvin(1), WattsPerMeterKelvinTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ThermalConductivity.Zero, WattsPerMeterKelvinTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ThermalConductivity.FromWattsPerMeterKelvin(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ThermalConductivity.FromWattsPerMeterKelvin(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            Assert.False(wattpermeterkelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ThermalConductivity wattpermeterkelvin = ThermalConductivity.FromWattsPerMeterKelvin(1);
            Assert.False(wattpermeterkelvin.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ThermalConductivityUnit.Undefined, ThermalConductivity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ThermalConductivityUnit)).Cast<ThermalConductivityUnit>();
            foreach(var unit in units)
            {
                if(unit == ThermalConductivityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ThermalConductivity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 BTU/h·ft·°F", new ThermalConductivity(1, ThermalConductivityUnit.BtuPerHourFootFahrenheit).ToString());
                Assert.Equal("1 W/m·K", new ThermalConductivity(1, ThermalConductivityUnit.WattPerMeterKelvin).ToString());
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

            Assert.Equal("1 BTU/h·ft·°F", new ThermalConductivity(1, ThermalConductivityUnit.BtuPerHourFootFahrenheit).ToString(swedishCulture));
            Assert.Equal("1 W/m·K", new ThermalConductivity(1, ThermalConductivityUnit.WattPerMeterKelvin).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 W/m·K", new ThermalConductivity(0.123456, ThermalConductivityUnit.WattPerMeterKelvin).ToString("s1"));
                Assert.Equal("0.12 W/m·K", new ThermalConductivity(0.123456, ThermalConductivityUnit.WattPerMeterKelvin).ToString("s2"));
                Assert.Equal("0.123 W/m·K", new ThermalConductivity(0.123456, ThermalConductivityUnit.WattPerMeterKelvin).ToString("s3"));
                Assert.Equal("0.1235 W/m·K", new ThermalConductivity(0.123456, ThermalConductivityUnit.WattPerMeterKelvin).ToString("s4"));
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
            Assert.Equal("0.1 W/m·K", new ThermalConductivity(0.123456, ThermalConductivityUnit.WattPerMeterKelvin).ToString("s1", culture));
            Assert.Equal("0.12 W/m·K", new ThermalConductivity(0.123456, ThermalConductivityUnit.WattPerMeterKelvin).ToString("s2", culture));
            Assert.Equal("0.123 W/m·K", new ThermalConductivity(0.123456, ThermalConductivityUnit.WattPerMeterKelvin).ToString("s3", culture));
            Assert.Equal("0.1235 W/m·K", new ThermalConductivity(0.123456, ThermalConductivityUnit.WattPerMeterKelvin).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ThermalConductivity)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ThermalConductivityUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal(QuantityType.ThermalConductivity, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal(ThermalConductivity.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal(ThermalConductivity.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(1.0);
            Assert.Equal(new {ThermalConductivity.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ThermalConductivity.FromWattsPerMeterKelvin(value);
            Assert.Equal(ThermalConductivity.FromWattsPerMeterKelvin(-value), -quantity);
        }
    }
}
