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
    /// Test of Duration.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class DurationTestsBase : QuantityTestsBase
    {
        protected abstract double DaysInOneSecond { get; }
        protected abstract double HoursInOneSecond { get; }
        protected abstract double MicrosecondsInOneSecond { get; }
        protected abstract double MillisecondsInOneSecond { get; }
        protected abstract double MinutesInOneSecond { get; }
        protected abstract double Months30InOneSecond { get; }
        protected abstract double NanosecondsInOneSecond { get; }
        protected abstract double SecondsInOneSecond { get; }
        protected abstract double WeeksInOneSecond { get; }
        protected abstract double Years365InOneSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DaysTolerance { get { return 1e-5; } }
        protected virtual double HoursTolerance { get { return 1e-5; } }
        protected virtual double MicrosecondsTolerance { get { return 1e-5; } }
        protected virtual double MillisecondsTolerance { get { return 1e-5; } }
        protected virtual double MinutesTolerance { get { return 1e-5; } }
        protected virtual double Months30Tolerance { get { return 1e-5; } }
        protected virtual double NanosecondsTolerance { get { return 1e-5; } }
        protected virtual double SecondsTolerance { get { return 1e-5; } }
        protected virtual double WeeksTolerance { get { return 1e-5; } }
        protected virtual double Years365Tolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Duration((double)0.0, DurationUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Duration();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(DurationUnit.Second, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Duration(double.PositiveInfinity, DurationUnit.Second));
            Assert.Throws<ArgumentException>(() => new Duration(double.NegativeInfinity, DurationUnit.Second));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Duration(double.NaN, DurationUnit.Second));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Duration(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Duration(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Duration) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Duration_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Duration(1, DurationUnit.Second);

            QuantityInfo<DurationUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Duration.Zero, quantityInfo.Zero);
            Assert.Equal("Duration", quantityInfo.Name);
            Assert.Equal(QuantityType.Duration, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<DurationUnit>().Except(new[] {DurationUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void SecondToDurationUnits()
        {
            Duration second = Duration.FromSeconds(1);
            AssertEx.EqualTolerance(DaysInOneSecond, second.Days, DaysTolerance);
            AssertEx.EqualTolerance(HoursInOneSecond, second.Hours, HoursTolerance);
            AssertEx.EqualTolerance(MicrosecondsInOneSecond, second.Microseconds, MicrosecondsTolerance);
            AssertEx.EqualTolerance(MillisecondsInOneSecond, second.Milliseconds, MillisecondsTolerance);
            AssertEx.EqualTolerance(MinutesInOneSecond, second.Minutes, MinutesTolerance);
            AssertEx.EqualTolerance(Months30InOneSecond, second.Months30, Months30Tolerance);
            AssertEx.EqualTolerance(NanosecondsInOneSecond, second.Nanoseconds, NanosecondsTolerance);
            AssertEx.EqualTolerance(SecondsInOneSecond, second.Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(WeeksInOneSecond, second.Weeks, WeeksTolerance);
            AssertEx.EqualTolerance(Years365InOneSecond, second.Years365, Years365Tolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Duration.From(1, DurationUnit.Day);
            AssertEx.EqualTolerance(1, quantity00.Days, DaysTolerance);
            Assert.Equal(DurationUnit.Day, quantity00.Unit);

            var quantity01 = Duration.From(1, DurationUnit.Hour);
            AssertEx.EqualTolerance(1, quantity01.Hours, HoursTolerance);
            Assert.Equal(DurationUnit.Hour, quantity01.Unit);

            var quantity02 = Duration.From(1, DurationUnit.Microsecond);
            AssertEx.EqualTolerance(1, quantity02.Microseconds, MicrosecondsTolerance);
            Assert.Equal(DurationUnit.Microsecond, quantity02.Unit);

            var quantity03 = Duration.From(1, DurationUnit.Millisecond);
            AssertEx.EqualTolerance(1, quantity03.Milliseconds, MillisecondsTolerance);
            Assert.Equal(DurationUnit.Millisecond, quantity03.Unit);

            var quantity04 = Duration.From(1, DurationUnit.Minute);
            AssertEx.EqualTolerance(1, quantity04.Minutes, MinutesTolerance);
            Assert.Equal(DurationUnit.Minute, quantity04.Unit);

            var quantity05 = Duration.From(1, DurationUnit.Month30);
            AssertEx.EqualTolerance(1, quantity05.Months30, Months30Tolerance);
            Assert.Equal(DurationUnit.Month30, quantity05.Unit);

            var quantity06 = Duration.From(1, DurationUnit.Nanosecond);
            AssertEx.EqualTolerance(1, quantity06.Nanoseconds, NanosecondsTolerance);
            Assert.Equal(DurationUnit.Nanosecond, quantity06.Unit);

            var quantity07 = Duration.From(1, DurationUnit.Second);
            AssertEx.EqualTolerance(1, quantity07.Seconds, SecondsTolerance);
            Assert.Equal(DurationUnit.Second, quantity07.Unit);

            var quantity08 = Duration.From(1, DurationUnit.Week);
            AssertEx.EqualTolerance(1, quantity08.Weeks, WeeksTolerance);
            Assert.Equal(DurationUnit.Week, quantity08.Unit);

            var quantity09 = Duration.From(1, DurationUnit.Year365);
            AssertEx.EqualTolerance(1, quantity09.Years365, Years365Tolerance);
            Assert.Equal(DurationUnit.Year365, quantity09.Unit);

        }

        [Fact]
        public void FromSeconds_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Duration.FromSeconds(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Duration.FromSeconds(double.NegativeInfinity));
        }

        [Fact]
        public void FromSeconds_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Duration.FromSeconds(double.NaN));
        }

        [Fact]
        public void As()
        {
            var second = Duration.FromSeconds(1);
            AssertEx.EqualTolerance(DaysInOneSecond, second.As(DurationUnit.Day), DaysTolerance);
            AssertEx.EqualTolerance(HoursInOneSecond, second.As(DurationUnit.Hour), HoursTolerance);
            AssertEx.EqualTolerance(MicrosecondsInOneSecond, second.As(DurationUnit.Microsecond), MicrosecondsTolerance);
            AssertEx.EqualTolerance(MillisecondsInOneSecond, second.As(DurationUnit.Millisecond), MillisecondsTolerance);
            AssertEx.EqualTolerance(MinutesInOneSecond, second.As(DurationUnit.Minute), MinutesTolerance);
            AssertEx.EqualTolerance(Months30InOneSecond, second.As(DurationUnit.Month30), Months30Tolerance);
            AssertEx.EqualTolerance(NanosecondsInOneSecond, second.As(DurationUnit.Nanosecond), NanosecondsTolerance);
            AssertEx.EqualTolerance(SecondsInOneSecond, second.As(DurationUnit.Second), SecondsTolerance);
            AssertEx.EqualTolerance(WeeksInOneSecond, second.As(DurationUnit.Week), WeeksTolerance);
            AssertEx.EqualTolerance(Years365InOneSecond, second.As(DurationUnit.Year365), Years365Tolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Duration(value: 1, unit: Duration.BaseUnit);
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
            var second = Duration.FromSeconds(1);

            var dayQuantity = second.ToUnit(DurationUnit.Day);
            AssertEx.EqualTolerance(DaysInOneSecond, (double)dayQuantity.Value, DaysTolerance);
            Assert.Equal(DurationUnit.Day, dayQuantity.Unit);

            var hourQuantity = second.ToUnit(DurationUnit.Hour);
            AssertEx.EqualTolerance(HoursInOneSecond, (double)hourQuantity.Value, HoursTolerance);
            Assert.Equal(DurationUnit.Hour, hourQuantity.Unit);

            var microsecondQuantity = second.ToUnit(DurationUnit.Microsecond);
            AssertEx.EqualTolerance(MicrosecondsInOneSecond, (double)microsecondQuantity.Value, MicrosecondsTolerance);
            Assert.Equal(DurationUnit.Microsecond, microsecondQuantity.Unit);

            var millisecondQuantity = second.ToUnit(DurationUnit.Millisecond);
            AssertEx.EqualTolerance(MillisecondsInOneSecond, (double)millisecondQuantity.Value, MillisecondsTolerance);
            Assert.Equal(DurationUnit.Millisecond, millisecondQuantity.Unit);

            var minuteQuantity = second.ToUnit(DurationUnit.Minute);
            AssertEx.EqualTolerance(MinutesInOneSecond, (double)minuteQuantity.Value, MinutesTolerance);
            Assert.Equal(DurationUnit.Minute, minuteQuantity.Unit);

            var month30Quantity = second.ToUnit(DurationUnit.Month30);
            AssertEx.EqualTolerance(Months30InOneSecond, (double)month30Quantity.Value, Months30Tolerance);
            Assert.Equal(DurationUnit.Month30, month30Quantity.Unit);

            var nanosecondQuantity = second.ToUnit(DurationUnit.Nanosecond);
            AssertEx.EqualTolerance(NanosecondsInOneSecond, (double)nanosecondQuantity.Value, NanosecondsTolerance);
            Assert.Equal(DurationUnit.Nanosecond, nanosecondQuantity.Unit);

            var secondQuantity = second.ToUnit(DurationUnit.Second);
            AssertEx.EqualTolerance(SecondsInOneSecond, (double)secondQuantity.Value, SecondsTolerance);
            Assert.Equal(DurationUnit.Second, secondQuantity.Unit);

            var weekQuantity = second.ToUnit(DurationUnit.Week);
            AssertEx.EqualTolerance(WeeksInOneSecond, (double)weekQuantity.Value, WeeksTolerance);
            Assert.Equal(DurationUnit.Week, weekQuantity.Unit);

            var year365Quantity = second.ToUnit(DurationUnit.Year365);
            AssertEx.EqualTolerance(Years365InOneSecond, (double)year365Quantity.Value, Years365Tolerance);
            Assert.Equal(DurationUnit.Year365, year365Quantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = Duration.FromSeconds(1).ToBaseUnit();
            Assert.Equal(Duration.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Duration second = Duration.FromSeconds(1);
            AssertEx.EqualTolerance(1, Duration.FromDays(second.Days).Seconds, DaysTolerance);
            AssertEx.EqualTolerance(1, Duration.FromHours(second.Hours).Seconds, HoursTolerance);
            AssertEx.EqualTolerance(1, Duration.FromMicroseconds(second.Microseconds).Seconds, MicrosecondsTolerance);
            AssertEx.EqualTolerance(1, Duration.FromMilliseconds(second.Milliseconds).Seconds, MillisecondsTolerance);
            AssertEx.EqualTolerance(1, Duration.FromMinutes(second.Minutes).Seconds, MinutesTolerance);
            AssertEx.EqualTolerance(1, Duration.FromMonths30(second.Months30).Seconds, Months30Tolerance);
            AssertEx.EqualTolerance(1, Duration.FromNanoseconds(second.Nanoseconds).Seconds, NanosecondsTolerance);
            AssertEx.EqualTolerance(1, Duration.FromSeconds(second.Seconds).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(1, Duration.FromWeeks(second.Weeks).Seconds, WeeksTolerance);
            AssertEx.EqualTolerance(1, Duration.FromYears365(second.Years365).Seconds, Years365Tolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Duration v = Duration.FromSeconds(1);
            AssertEx.EqualTolerance(-1, -v.Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(2, (Duration.FromSeconds(3)-v).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(2, (Duration.FromSeconds(10)/5).Seconds, SecondsTolerance);
            AssertEx.EqualTolerance(2, Duration.FromSeconds(10)/Duration.FromSeconds(5), SecondsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Duration oneSecond = Duration.FromSeconds(1);
            Duration twoSeconds = Duration.FromSeconds(2);

            Assert.True(oneSecond < twoSeconds);
            Assert.True(oneSecond <= twoSeconds);
            Assert.True(twoSeconds > oneSecond);
            Assert.True(twoSeconds >= oneSecond);

            Assert.False(oneSecond > twoSeconds);
            Assert.False(oneSecond >= twoSeconds);
            Assert.False(twoSeconds < oneSecond);
            Assert.False(twoSeconds <= oneSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Duration second = Duration.FromSeconds(1);
            Assert.Equal(0, second.CompareTo(second));
            Assert.True(second.CompareTo(Duration.Zero) > 0);
            Assert.True(Duration.Zero.CompareTo(second) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Duration second = Duration.FromSeconds(1);
            Assert.Throws<ArgumentException>(() => second.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Duration second = Duration.FromSeconds(1);
            Assert.Throws<ArgumentNullException>(() => second.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Duration.FromSeconds(1);
            var b = Duration.FromSeconds(2);

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
            var a = Duration.FromSeconds(1);
            var b = Duration.FromSeconds(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = Duration.FromSeconds(1);
            object b = Duration.FromSeconds(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Duration.FromSeconds(1);
            Assert.True(v.Equals(Duration.FromSeconds(1), SecondsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Duration.Zero, SecondsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Duration.FromSeconds(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Duration.FromSeconds(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Duration second = Duration.FromSeconds(1);
            Assert.False(second.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Duration second = Duration.FromSeconds(1);
            Assert.False(second.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(DurationUnit.Undefined, Duration.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(DurationUnit)).Cast<DurationUnit>();
            foreach(var unit in units)
            {
                if(unit == DurationUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Duration.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 d", new Duration(1, DurationUnit.Day).ToString());
                Assert.Equal("1 h", new Duration(1, DurationUnit.Hour).ToString());
                Assert.Equal("1 µs", new Duration(1, DurationUnit.Microsecond).ToString());
                Assert.Equal("1 ms", new Duration(1, DurationUnit.Millisecond).ToString());
                Assert.Equal("1 m", new Duration(1, DurationUnit.Minute).ToString());
                Assert.Equal("1 mo", new Duration(1, DurationUnit.Month30).ToString());
                Assert.Equal("1 ns", new Duration(1, DurationUnit.Nanosecond).ToString());
                Assert.Equal("1 s", new Duration(1, DurationUnit.Second).ToString());
                Assert.Equal("1 wk", new Duration(1, DurationUnit.Week).ToString());
                Assert.Equal("1 yr", new Duration(1, DurationUnit.Year365).ToString());
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

            Assert.Equal("1 d", new Duration(1, DurationUnit.Day).ToString(swedishCulture));
            Assert.Equal("1 h", new Duration(1, DurationUnit.Hour).ToString(swedishCulture));
            Assert.Equal("1 µs", new Duration(1, DurationUnit.Microsecond).ToString(swedishCulture));
            Assert.Equal("1 ms", new Duration(1, DurationUnit.Millisecond).ToString(swedishCulture));
            Assert.Equal("1 m", new Duration(1, DurationUnit.Minute).ToString(swedishCulture));
            Assert.Equal("1 mo", new Duration(1, DurationUnit.Month30).ToString(swedishCulture));
            Assert.Equal("1 ns", new Duration(1, DurationUnit.Nanosecond).ToString(swedishCulture));
            Assert.Equal("1 s", new Duration(1, DurationUnit.Second).ToString(swedishCulture));
            Assert.Equal("1 wk", new Duration(1, DurationUnit.Week).ToString(swedishCulture));
            Assert.Equal("1 yr", new Duration(1, DurationUnit.Year365).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 s", new Duration(0.123456, DurationUnit.Second).ToString("s1"));
                Assert.Equal("0.12 s", new Duration(0.123456, DurationUnit.Second).ToString("s2"));
                Assert.Equal("0.123 s", new Duration(0.123456, DurationUnit.Second).ToString("s3"));
                Assert.Equal("0.1235 s", new Duration(0.123456, DurationUnit.Second).ToString("s4"));
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
            Assert.Equal("0.1 s", new Duration(0.123456, DurationUnit.Second).ToString("s1", culture));
            Assert.Equal("0.12 s", new Duration(0.123456, DurationUnit.Second).ToString("s2", culture));
            Assert.Equal("0.123 s", new Duration(0.123456, DurationUnit.Second).ToString("s3", culture));
            Assert.Equal("0.1235 s", new Duration(0.123456, DurationUnit.Second).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Duration.FromSeconds(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Duration)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(DurationUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal(QuantityType.Duration, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal(Duration.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Duration.FromSeconds(1.0);
            Assert.Equal(new {Duration.QuantityType, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Duration.FromSeconds(value);
            Assert.Equal(Duration.FromSeconds(-value), -quantity);
        }
    }
}
