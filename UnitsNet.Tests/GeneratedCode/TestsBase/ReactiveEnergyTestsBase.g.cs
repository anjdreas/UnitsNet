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
    /// Test of ReactiveEnergy.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ReactiveEnergyTestsBase : QuantityTestsBase
    {
        protected abstract double KilovoltampereReactiveHoursInOneVoltampereReactiveHour { get; }
        protected abstract double MegavoltampereReactiveHoursInOneVoltampereReactiveHour { get; }
        protected abstract double VoltampereReactiveHoursInOneVoltampereReactiveHour { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilovoltampereReactiveHoursTolerance { get { return 1e-5; } }
        protected virtual double MegavoltampereReactiveHoursTolerance { get { return 1e-5; } }
        protected virtual double VoltampereReactiveHoursTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactiveEnergy((double)0.0, ReactiveEnergyUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new ReactiveEnergy();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(ReactiveEnergyUnit.VoltampereReactiveHour, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactiveEnergy(double.PositiveInfinity, ReactiveEnergyUnit.VoltampereReactiveHour));
            Assert.Throws<ArgumentException>(() => new ReactiveEnergy(double.NegativeInfinity, ReactiveEnergyUnit.VoltampereReactiveHour));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ReactiveEnergy(double.NaN, ReactiveEnergyUnit.VoltampereReactiveHour));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new ReactiveEnergy(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new ReactiveEnergy(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (ReactiveEnergy) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void ReactiveEnergy_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new ReactiveEnergy(1, ReactiveEnergyUnit.VoltampereReactiveHour);

            QuantityInfo<ReactiveEnergyUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(ReactiveEnergy.Zero, quantityInfo.Zero);
            Assert.Equal("ReactiveEnergy", quantityInfo.Name);
            Assert.Equal(QuantityType.ReactiveEnergy, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<ReactiveEnergyUnit>().Except(new[] {ReactiveEnergyUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void VoltampereReactiveHourToReactiveEnergyUnits()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            AssertEx.EqualTolerance(KilovoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.KilovoltampereReactiveHours, KilovoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(MegavoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.MegavoltampereReactiveHours, MegavoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(VoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = ReactiveEnergy.From(1, ReactiveEnergyUnit.KilovoltampereReactiveHour);
            AssertEx.EqualTolerance(1, quantity00.KilovoltampereReactiveHours, KilovoltampereReactiveHoursTolerance);
            Assert.Equal(ReactiveEnergyUnit.KilovoltampereReactiveHour, quantity00.Unit);

            var quantity01 = ReactiveEnergy.From(1, ReactiveEnergyUnit.MegavoltampereReactiveHour);
            AssertEx.EqualTolerance(1, quantity01.MegavoltampereReactiveHours, MegavoltampereReactiveHoursTolerance);
            Assert.Equal(ReactiveEnergyUnit.MegavoltampereReactiveHour, quantity01.Unit);

            var quantity02 = ReactiveEnergy.From(1, ReactiveEnergyUnit.VoltampereReactiveHour);
            AssertEx.EqualTolerance(1, quantity02.VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            Assert.Equal(ReactiveEnergyUnit.VoltampereReactiveHour, quantity02.Unit);

        }

        [Fact]
        public void FromVoltampereReactiveHours_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ReactiveEnergy.FromVoltampereReactiveHours(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ReactiveEnergy.FromVoltampereReactiveHours(double.NegativeInfinity));
        }

        [Fact]
        public void FromVoltampereReactiveHours_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ReactiveEnergy.FromVoltampereReactiveHours(double.NaN));
        }

        [Fact]
        public void As()
        {
            var voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            AssertEx.EqualTolerance(KilovoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.As(ReactiveEnergyUnit.KilovoltampereReactiveHour), KilovoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(MegavoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.As(ReactiveEnergyUnit.MegavoltampereReactiveHour), MegavoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(VoltampereReactiveHoursInOneVoltampereReactiveHour, voltamperereactivehour.As(ReactiveEnergyUnit.VoltampereReactiveHour), VoltampereReactiveHoursTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new ReactiveEnergy(value: 1, unit: ReactiveEnergy.BaseUnit);
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
            var voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);

            var kilovoltamperereactivehourQuantity = voltamperereactivehour.ToUnit(ReactiveEnergyUnit.KilovoltampereReactiveHour);
            AssertEx.EqualTolerance(KilovoltampereReactiveHoursInOneVoltampereReactiveHour, (double)kilovoltamperereactivehourQuantity.Value, KilovoltampereReactiveHoursTolerance);
            Assert.Equal(ReactiveEnergyUnit.KilovoltampereReactiveHour, kilovoltamperereactivehourQuantity.Unit);

            var megavoltamperereactivehourQuantity = voltamperereactivehour.ToUnit(ReactiveEnergyUnit.MegavoltampereReactiveHour);
            AssertEx.EqualTolerance(MegavoltampereReactiveHoursInOneVoltampereReactiveHour, (double)megavoltamperereactivehourQuantity.Value, MegavoltampereReactiveHoursTolerance);
            Assert.Equal(ReactiveEnergyUnit.MegavoltampereReactiveHour, megavoltamperereactivehourQuantity.Unit);

            var voltamperereactivehourQuantity = voltamperereactivehour.ToUnit(ReactiveEnergyUnit.VoltampereReactiveHour);
            AssertEx.EqualTolerance(VoltampereReactiveHoursInOneVoltampereReactiveHour, (double)voltamperereactivehourQuantity.Value, VoltampereReactiveHoursTolerance);
            Assert.Equal(ReactiveEnergyUnit.VoltampereReactiveHour, voltamperereactivehourQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = ReactiveEnergy.FromVoltampereReactiveHours(1).ToBaseUnit();
            Assert.Equal(ReactiveEnergy.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            AssertEx.EqualTolerance(1, ReactiveEnergy.FromKilovoltampereReactiveHours(voltamperereactivehour.KilovoltampereReactiveHours).VoltampereReactiveHours, KilovoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(1, ReactiveEnergy.FromMegavoltampereReactiveHours(voltamperereactivehour.MegavoltampereReactiveHours).VoltampereReactiveHours, MegavoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(1, ReactiveEnergy.FromVoltampereReactiveHours(voltamperereactivehour.VoltampereReactiveHours).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ReactiveEnergy v = ReactiveEnergy.FromVoltampereReactiveHours(1);
            AssertEx.EqualTolerance(-1, -v.VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(2, (ReactiveEnergy.FromVoltampereReactiveHours(3)-v).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(2, (ReactiveEnergy.FromVoltampereReactiveHours(10)/5).VoltampereReactiveHours, VoltampereReactiveHoursTolerance);
            AssertEx.EqualTolerance(2, ReactiveEnergy.FromVoltampereReactiveHours(10)/ReactiveEnergy.FromVoltampereReactiveHours(5), VoltampereReactiveHoursTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ReactiveEnergy oneVoltampereReactiveHour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            ReactiveEnergy twoVoltampereReactiveHours = ReactiveEnergy.FromVoltampereReactiveHours(2);

            Assert.True(oneVoltampereReactiveHour < twoVoltampereReactiveHours);
            Assert.True(oneVoltampereReactiveHour <= twoVoltampereReactiveHours);
            Assert.True(twoVoltampereReactiveHours > oneVoltampereReactiveHour);
            Assert.True(twoVoltampereReactiveHours >= oneVoltampereReactiveHour);

            Assert.False(oneVoltampereReactiveHour > twoVoltampereReactiveHours);
            Assert.False(oneVoltampereReactiveHour >= twoVoltampereReactiveHours);
            Assert.False(twoVoltampereReactiveHours < oneVoltampereReactiveHour);
            Assert.False(twoVoltampereReactiveHours <= oneVoltampereReactiveHour);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.Equal(0, voltamperereactivehour.CompareTo(voltamperereactivehour));
            Assert.True(voltamperereactivehour.CompareTo(ReactiveEnergy.Zero) > 0);
            Assert.True(ReactiveEnergy.Zero.CompareTo(voltamperereactivehour) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.Throws<ArgumentException>(() => voltamperereactivehour.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.Throws<ArgumentNullException>(() => voltamperereactivehour.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ReactiveEnergy.FromVoltampereReactiveHours(1);
            var b = ReactiveEnergy.FromVoltampereReactiveHours(2);

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
            var a = ReactiveEnergy.FromVoltampereReactiveHours(1);
            var b = ReactiveEnergy.FromVoltampereReactiveHours(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = ReactiveEnergy.FromVoltampereReactiveHours(1);
            object b = ReactiveEnergy.FromVoltampereReactiveHours(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = ReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.True(v.Equals(ReactiveEnergy.FromVoltampereReactiveHours(1), VoltampereReactiveHoursTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ReactiveEnergy.Zero, VoltampereReactiveHoursTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = ReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(ReactiveEnergy.FromVoltampereReactiveHours(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.False(voltamperereactivehour.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltampereReactiveHours(1);
            Assert.False(voltamperereactivehour.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ReactiveEnergyUnit.Undefined, ReactiveEnergy.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ReactiveEnergyUnit)).Cast<ReactiveEnergyUnit>();
            foreach(var unit in units)
            {
                if(unit == ReactiveEnergyUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ReactiveEnergy.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 kvarh", new ReactiveEnergy(1, ReactiveEnergyUnit.KilovoltampereReactiveHour).ToString());
                Assert.Equal("1 Mvarh", new ReactiveEnergy(1, ReactiveEnergyUnit.MegavoltampereReactiveHour).ToString());
                Assert.Equal("1 varh", new ReactiveEnergy(1, ReactiveEnergyUnit.VoltampereReactiveHour).ToString());
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

            Assert.Equal("1 kvarh", new ReactiveEnergy(1, ReactiveEnergyUnit.KilovoltampereReactiveHour).ToString(swedishCulture));
            Assert.Equal("1 Mvarh", new ReactiveEnergy(1, ReactiveEnergyUnit.MegavoltampereReactiveHour).ToString(swedishCulture));
            Assert.Equal("1 varh", new ReactiveEnergy(1, ReactiveEnergyUnit.VoltampereReactiveHour).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 varh", new ReactiveEnergy(0.123456, ReactiveEnergyUnit.VoltampereReactiveHour).ToString("s1"));
                Assert.Equal("0.12 varh", new ReactiveEnergy(0.123456, ReactiveEnergyUnit.VoltampereReactiveHour).ToString("s2"));
                Assert.Equal("0.123 varh", new ReactiveEnergy(0.123456, ReactiveEnergyUnit.VoltampereReactiveHour).ToString("s3"));
                Assert.Equal("0.1235 varh", new ReactiveEnergy(0.123456, ReactiveEnergyUnit.VoltampereReactiveHour).ToString("s4"));
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
            Assert.Equal("0.1 varh", new ReactiveEnergy(0.123456, ReactiveEnergyUnit.VoltampereReactiveHour).ToString("s1", culture));
            Assert.Equal("0.12 varh", new ReactiveEnergy(0.123456, ReactiveEnergyUnit.VoltampereReactiveHour).ToString("s2", culture));
            Assert.Equal("0.123 varh", new ReactiveEnergy(0.123456, ReactiveEnergyUnit.VoltampereReactiveHour).ToString("s3", culture));
            Assert.Equal("0.1235 varh", new ReactiveEnergy(0.123456, ReactiveEnergyUnit.VoltampereReactiveHour).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(ReactiveEnergy)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(ReactiveEnergyUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(QuantityType.ReactiveEnergy, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(ReactiveEnergy.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(ReactiveEnergy.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(1.0);
            Assert.Equal(new {ReactiveEnergy.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = ReactiveEnergy.FromVoltampereReactiveHours(value);
            Assert.Equal(ReactiveEnergy.FromVoltampereReactiveHours(-value), -quantity);
        }
    }
}
