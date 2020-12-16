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
    /// Test of ElectricConductivity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricConductivityTestsBase : QuantityTestsBase
    {
        protected abstract double SiemensPerFootInOneSiemensPerMeter { get; }
        protected abstract double SiemensPerInchInOneSiemensPerMeter { get; }
        protected abstract double SiemensPerMeterInOneSiemensPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double SiemensPerFootTolerance { get { return 1e-5; } }
        protected virtual double SiemensPerInchTolerance { get { return 1e-5; } }
        protected virtual double SiemensPerMeterTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricConductivity((double)0.0, ElectricConductivityUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ElectricConductivity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ElectricConductivityUnit.SiemensPerMeter, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricConductivity(double.PositiveInfinity, ElectricConductivityUnit.SiemensPerMeter));
            Assert.Throws<ArgumentException>(() => new ElectricConductivity(double.NegativeInfinity, ElectricConductivityUnit.SiemensPerMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricConductivity(double.NaN, ElectricConductivityUnit.SiemensPerMeter));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ElectricConductivity(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ElectricConductivity(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ElectricConductivity) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ElectricConductivity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ElectricConductivity(1, ElectricConductivityUnit.SiemensPerMeter);

            QuantityInfo<ElectricConductivityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ElectricConductivity.Zero, quantityInfo.Zero);
            Assert.Equal("ElectricConductivity", quantityInfo.Name);
            Assert.Equal(QuantityType.ElectricConductivity, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<ElectricConductivityUnit>().Except(new[] {ElectricConductivityUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void SiemensPerMeterToElectricConductivityUnits()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            AssertEx.EqualTolerance(SiemensPerFootInOneSiemensPerMeter, siemenspermeter.SiemensPerFoot, SiemensPerFootTolerance);
            AssertEx.EqualTolerance(SiemensPerInchInOneSiemensPerMeter, siemenspermeter.SiemensPerInch, SiemensPerInchTolerance);
            AssertEx.EqualTolerance(SiemensPerMeterInOneSiemensPerMeter, siemenspermeter.SiemensPerMeter, SiemensPerMeterTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ElectricConductivity.From(1, ElectricConductivityUnit.SiemensPerFoot);
            AssertEx.EqualTolerance(1, quantity00.SiemensPerFoot, SiemensPerFootTolerance);
            Assert.Equal(ElectricConductivityUnit.SiemensPerFoot, quantity00.Unit);

            var quantity01 = ElectricConductivity.From(1, ElectricConductivityUnit.SiemensPerInch);
            AssertEx.EqualTolerance(1, quantity01.SiemensPerInch, SiemensPerInchTolerance);
            Assert.Equal(ElectricConductivityUnit.SiemensPerInch, quantity01.Unit);

            var quantity02 = ElectricConductivity.From(1, ElectricConductivityUnit.SiemensPerMeter);
            AssertEx.EqualTolerance(1, quantity02.SiemensPerMeter, SiemensPerMeterTolerance);
            Assert.Equal(ElectricConductivityUnit.SiemensPerMeter, quantity02.Unit);

        }

        [Fact]
        public void FromSiemensPerMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricConductivity.FromSiemensPerMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricConductivity.FromSiemensPerMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromSiemensPerMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricConductivity.FromSiemensPerMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            AssertEx.EqualTolerance(SiemensPerFootInOneSiemensPerMeter, siemenspermeter.As(ElectricConductivityUnit.SiemensPerFoot), SiemensPerFootTolerance);
            AssertEx.EqualTolerance(SiemensPerInchInOneSiemensPerMeter, siemenspermeter.As(ElectricConductivityUnit.SiemensPerInch), SiemensPerInchTolerance);
            AssertEx.EqualTolerance(SiemensPerMeterInOneSiemensPerMeter, siemenspermeter.As(ElectricConductivityUnit.SiemensPerMeter), SiemensPerMeterTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ElectricConductivity(value: 1, unit: ElectricConductivity.BaseUnit);
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
            var siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);

            var siemensperfootQuantity = siemenspermeter.ToUnit(ElectricConductivityUnit.SiemensPerFoot);
            AssertEx.EqualTolerance(SiemensPerFootInOneSiemensPerMeter, (double)siemensperfootQuantity.Value, SiemensPerFootTolerance);
            Assert.Equal(ElectricConductivityUnit.SiemensPerFoot, siemensperfootQuantity.Unit);

            var siemensperinchQuantity = siemenspermeter.ToUnit(ElectricConductivityUnit.SiemensPerInch);
            AssertEx.EqualTolerance(SiemensPerInchInOneSiemensPerMeter, (double)siemensperinchQuantity.Value, SiemensPerInchTolerance);
            Assert.Equal(ElectricConductivityUnit.SiemensPerInch, siemensperinchQuantity.Unit);

            var siemenspermeterQuantity = siemenspermeter.ToUnit(ElectricConductivityUnit.SiemensPerMeter);
            AssertEx.EqualTolerance(SiemensPerMeterInOneSiemensPerMeter, (double)siemenspermeterQuantity.Value, SiemensPerMeterTolerance);
            Assert.Equal(ElectricConductivityUnit.SiemensPerMeter, siemenspermeterQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = ElectricConductivity.FromSiemensPerMeter(1).ToBaseUnit();
            Assert.Equal(ElectricConductivity.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            AssertEx.EqualTolerance(1, ElectricConductivity.FromSiemensPerFoot(siemenspermeter.SiemensPerFoot).SiemensPerMeter, SiemensPerFootTolerance);
            AssertEx.EqualTolerance(1, ElectricConductivity.FromSiemensPerInch(siemenspermeter.SiemensPerInch).SiemensPerMeter, SiemensPerInchTolerance);
            AssertEx.EqualTolerance(1, ElectricConductivity.FromSiemensPerMeter(siemenspermeter.SiemensPerMeter).SiemensPerMeter, SiemensPerMeterTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricConductivity v = ElectricConductivity.FromSiemensPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.SiemensPerMeter, SiemensPerMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricConductivity.FromSiemensPerMeter(3)-v).SiemensPerMeter, SiemensPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).SiemensPerMeter, SiemensPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).SiemensPerMeter, SiemensPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).SiemensPerMeter, SiemensPerMeterTolerance);
            AssertEx.EqualTolerance(2, (ElectricConductivity.FromSiemensPerMeter(10)/5).SiemensPerMeter, SiemensPerMeterTolerance);
            AssertEx.EqualTolerance(2, ElectricConductivity.FromSiemensPerMeter(10)/ElectricConductivity.FromSiemensPerMeter(5), SiemensPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricConductivity oneSiemensPerMeter = ElectricConductivity.FromSiemensPerMeter(1);
            ElectricConductivity twoSiemensPerMeter = ElectricConductivity.FromSiemensPerMeter(2);

            Assert.True(oneSiemensPerMeter < twoSiemensPerMeter);
            Assert.True(oneSiemensPerMeter <= twoSiemensPerMeter);
            Assert.True(twoSiemensPerMeter > oneSiemensPerMeter);
            Assert.True(twoSiemensPerMeter >= oneSiemensPerMeter);

            Assert.False(oneSiemensPerMeter > twoSiemensPerMeter);
            Assert.False(oneSiemensPerMeter >= twoSiemensPerMeter);
            Assert.False(twoSiemensPerMeter < oneSiemensPerMeter);
            Assert.False(twoSiemensPerMeter <= oneSiemensPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            Assert.Equal(0, siemenspermeter.CompareTo(siemenspermeter));
            Assert.True(siemenspermeter.CompareTo(ElectricConductivity.Zero) > 0);
            Assert.True(ElectricConductivity.Zero.CompareTo(siemenspermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            Assert.Throws<ArgumentException>(() => siemenspermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => siemenspermeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ElectricConductivity.FromSiemensPerMeter(1);
            var b = ElectricConductivity.FromSiemensPerMeter(2);

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
            var a = ElectricConductivity.FromSiemensPerMeter(1);
            var b = ElectricConductivity.FromSiemensPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = ElectricConductivity.FromSiemensPerMeter(1);
            object b = ElectricConductivity.FromSiemensPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ElectricConductivity.FromSiemensPerMeter(1);
            Assert.True(v.Equals(ElectricConductivity.FromSiemensPerMeter(1), SiemensPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricConductivity.Zero, SiemensPerMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ElectricConductivity.FromSiemensPerMeter(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ElectricConductivity.FromSiemensPerMeter(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            Assert.False(siemenspermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricConductivity siemenspermeter = ElectricConductivity.FromSiemensPerMeter(1);
            Assert.False(siemenspermeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricConductivityUnit.Undefined, ElectricConductivity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricConductivityUnit)).Cast<ElectricConductivityUnit>();
            foreach(var unit in units)
            {
                if(unit == ElectricConductivityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricConductivity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 S/ft", new ElectricConductivity(1, ElectricConductivityUnit.SiemensPerFoot).ToString());
                Assert.Equal("1 S/in", new ElectricConductivity(1, ElectricConductivityUnit.SiemensPerInch).ToString());
                Assert.Equal("1 S/m", new ElectricConductivity(1, ElectricConductivityUnit.SiemensPerMeter).ToString());
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

            Assert.Equal("1 S/ft", new ElectricConductivity(1, ElectricConductivityUnit.SiemensPerFoot).ToString(swedishCulture));
            Assert.Equal("1 S/in", new ElectricConductivity(1, ElectricConductivityUnit.SiemensPerInch).ToString(swedishCulture));
            Assert.Equal("1 S/m", new ElectricConductivity(1, ElectricConductivityUnit.SiemensPerMeter).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 S/m", new ElectricConductivity(0.123456, ElectricConductivityUnit.SiemensPerMeter).ToString("s1"));
                Assert.Equal("0.12 S/m", new ElectricConductivity(0.123456, ElectricConductivityUnit.SiemensPerMeter).ToString("s2"));
                Assert.Equal("0.123 S/m", new ElectricConductivity(0.123456, ElectricConductivityUnit.SiemensPerMeter).ToString("s3"));
                Assert.Equal("0.1235 S/m", new ElectricConductivity(0.123456, ElectricConductivityUnit.SiemensPerMeter).ToString("s4"));
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
            Assert.Equal("0.1 S/m", new ElectricConductivity(0.123456, ElectricConductivityUnit.SiemensPerMeter).ToString("s1", culture));
            Assert.Equal("0.12 S/m", new ElectricConductivity(0.123456, ElectricConductivityUnit.SiemensPerMeter).ToString("s2", culture));
            Assert.Equal("0.123 S/m", new ElectricConductivity(0.123456, ElectricConductivityUnit.SiemensPerMeter).ToString("s3", culture));
            Assert.Equal("0.1235 S/m", new ElectricConductivity(0.123456, ElectricConductivityUnit.SiemensPerMeter).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ElectricConductivity)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ElectricConductivityUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal(QuantityType.ElectricConductivity, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Equal(ElectricConductivity.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(1.0);
            var roundedBaseValue = Math.Round(quantity.ToBaseUnit().Value, 5);
            Assert.Equal(new {ElectricConductivity.QuantityType, roundedBaseValue}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ElectricConductivity.FromSiemensPerMeter(value);
            Assert.Equal(ElectricConductivity.FromSiemensPerMeter(-value), -quantity);
        }
    }
}
