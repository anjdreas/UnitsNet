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
    /// Test of Temperature.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class TemperatureTestsBase : QuantityTestsBase
    {
        protected abstract double DegreesCelsiusInOneKelvin { get; }
        protected abstract double DegreesDelisleInOneKelvin { get; }
        protected abstract double DegreesFahrenheitInOneKelvin { get; }
        protected abstract double DegreesNewtonInOneKelvin { get; }
        protected abstract double DegreesRankineInOneKelvin { get; }
        protected abstract double DegreesReaumurInOneKelvin { get; }
        protected abstract double DegreesRoemerInOneKelvin { get; }
        protected abstract double KelvinsInOneKelvin { get; }
        protected abstract double MillidegreesCelsiusInOneKelvin { get; }
        protected abstract double SolarTemperaturesInOneKelvin { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DegreesCelsiusTolerance { get { return 1e-5; } }
        protected virtual double DegreesDelisleTolerance { get { return 1e-5; } }
        protected virtual double DegreesFahrenheitTolerance { get { return 1e-5; } }
        protected virtual double DegreesNewtonTolerance { get { return 1e-5; } }
        protected virtual double DegreesRankineTolerance { get { return 1e-5; } }
        protected virtual double DegreesReaumurTolerance { get { return 1e-5; } }
        protected virtual double DegreesRoemerTolerance { get { return 1e-5; } }
        protected virtual double KelvinsTolerance { get { return 1e-5; } }
        protected virtual double MillidegreesCelsiusTolerance { get { return 1e-5; } }
        protected virtual double SolarTemperaturesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Temperature((double)0.0, TemperatureUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Temperature();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(TemperatureUnit.Kelvin, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Temperature(double.PositiveInfinity, TemperatureUnit.Kelvin));
            Assert.Throws<ArgumentException>(() => new Temperature(double.NegativeInfinity, TemperatureUnit.Kelvin));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Temperature(double.NaN, TemperatureUnit.Kelvin));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Temperature(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new Temperature(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (Temperature) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void Temperature_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Temperature(1, TemperatureUnit.Kelvin);

            QuantityInfo<TemperatureUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Temperature.Zero, quantityInfo.Zero);
            Assert.Equal("Temperature", quantityInfo.Name);
#pragma warning disable 612,618
            Assert.Equal(QuantityType.Temperature, quantityInfo.QuantityType);
#pragma warning restore 612,618

            var units = EnumUtils.GetEnumValues<TemperatureUnit>().Except(new[] {TemperatureUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void KelvinToTemperatureUnits()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            AssertEx.EqualTolerance(DegreesCelsiusInOneKelvin, kelvin.DegreesCelsius, DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(DegreesDelisleInOneKelvin, kelvin.DegreesDelisle, DegreesDelisleTolerance);
            AssertEx.EqualTolerance(DegreesFahrenheitInOneKelvin, kelvin.DegreesFahrenheit, DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(DegreesNewtonInOneKelvin, kelvin.DegreesNewton, DegreesNewtonTolerance);
            AssertEx.EqualTolerance(DegreesRankineInOneKelvin, kelvin.DegreesRankine, DegreesRankineTolerance);
            AssertEx.EqualTolerance(DegreesReaumurInOneKelvin, kelvin.DegreesReaumur, DegreesReaumurTolerance);
            AssertEx.EqualTolerance(DegreesRoemerInOneKelvin, kelvin.DegreesRoemer, DegreesRoemerTolerance);
            AssertEx.EqualTolerance(KelvinsInOneKelvin, kelvin.Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(MillidegreesCelsiusInOneKelvin, kelvin.MillidegreesCelsius, MillidegreesCelsiusTolerance);
            AssertEx.EqualTolerance(SolarTemperaturesInOneKelvin, kelvin.SolarTemperatures, SolarTemperaturesTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Temperature.From(1, TemperatureUnit.DegreeCelsius);
            AssertEx.EqualTolerance(1, quantity00.DegreesCelsius, DegreesCelsiusTolerance);
            Assert.Equal(TemperatureUnit.DegreeCelsius, quantity00.Unit);

            var quantity01 = Temperature.From(1, TemperatureUnit.DegreeDelisle);
            AssertEx.EqualTolerance(1, quantity01.DegreesDelisle, DegreesDelisleTolerance);
            Assert.Equal(TemperatureUnit.DegreeDelisle, quantity01.Unit);

            var quantity02 = Temperature.From(1, TemperatureUnit.DegreeFahrenheit);
            AssertEx.EqualTolerance(1, quantity02.DegreesFahrenheit, DegreesFahrenheitTolerance);
            Assert.Equal(TemperatureUnit.DegreeFahrenheit, quantity02.Unit);

            var quantity03 = Temperature.From(1, TemperatureUnit.DegreeNewton);
            AssertEx.EqualTolerance(1, quantity03.DegreesNewton, DegreesNewtonTolerance);
            Assert.Equal(TemperatureUnit.DegreeNewton, quantity03.Unit);

            var quantity04 = Temperature.From(1, TemperatureUnit.DegreeRankine);
            AssertEx.EqualTolerance(1, quantity04.DegreesRankine, DegreesRankineTolerance);
            Assert.Equal(TemperatureUnit.DegreeRankine, quantity04.Unit);

            var quantity05 = Temperature.From(1, TemperatureUnit.DegreeReaumur);
            AssertEx.EqualTolerance(1, quantity05.DegreesReaumur, DegreesReaumurTolerance);
            Assert.Equal(TemperatureUnit.DegreeReaumur, quantity05.Unit);

            var quantity06 = Temperature.From(1, TemperatureUnit.DegreeRoemer);
            AssertEx.EqualTolerance(1, quantity06.DegreesRoemer, DegreesRoemerTolerance);
            Assert.Equal(TemperatureUnit.DegreeRoemer, quantity06.Unit);

            var quantity07 = Temperature.From(1, TemperatureUnit.Kelvin);
            AssertEx.EqualTolerance(1, quantity07.Kelvins, KelvinsTolerance);
            Assert.Equal(TemperatureUnit.Kelvin, quantity07.Unit);

            var quantity08 = Temperature.From(1, TemperatureUnit.MillidegreeCelsius);
            AssertEx.EqualTolerance(1, quantity08.MillidegreesCelsius, MillidegreesCelsiusTolerance);
            Assert.Equal(TemperatureUnit.MillidegreeCelsius, quantity08.Unit);

            var quantity09 = Temperature.From(1, TemperatureUnit.SolarTemperature);
            AssertEx.EqualTolerance(1, quantity09.SolarTemperatures, SolarTemperaturesTolerance);
            Assert.Equal(TemperatureUnit.SolarTemperature, quantity09.Unit);

        }

        [Fact]
        public void FromKelvins_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Temperature.FromKelvins(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Temperature.FromKelvins(double.NegativeInfinity));
        }

        [Fact]
        public void FromKelvins_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Temperature.FromKelvins(double.NaN));
        }

        [Fact]
        public void As()
        {
            var kelvin = Temperature.FromKelvins(1);
            AssertEx.EqualTolerance(DegreesCelsiusInOneKelvin, kelvin.As(TemperatureUnit.DegreeCelsius), DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(DegreesDelisleInOneKelvin, kelvin.As(TemperatureUnit.DegreeDelisle), DegreesDelisleTolerance);
            AssertEx.EqualTolerance(DegreesFahrenheitInOneKelvin, kelvin.As(TemperatureUnit.DegreeFahrenheit), DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(DegreesNewtonInOneKelvin, kelvin.As(TemperatureUnit.DegreeNewton), DegreesNewtonTolerance);
            AssertEx.EqualTolerance(DegreesRankineInOneKelvin, kelvin.As(TemperatureUnit.DegreeRankine), DegreesRankineTolerance);
            AssertEx.EqualTolerance(DegreesReaumurInOneKelvin, kelvin.As(TemperatureUnit.DegreeReaumur), DegreesReaumurTolerance);
            AssertEx.EqualTolerance(DegreesRoemerInOneKelvin, kelvin.As(TemperatureUnit.DegreeRoemer), DegreesRoemerTolerance);
            AssertEx.EqualTolerance(KelvinsInOneKelvin, kelvin.As(TemperatureUnit.Kelvin), KelvinsTolerance);
            AssertEx.EqualTolerance(MillidegreesCelsiusInOneKelvin, kelvin.As(TemperatureUnit.MillidegreeCelsius), MillidegreesCelsiusTolerance);
            AssertEx.EqualTolerance(SolarTemperaturesInOneKelvin, kelvin.As(TemperatureUnit.SolarTemperature), SolarTemperaturesTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new Temperature(value: 1, unit: Temperature.BaseUnit);
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
            var kelvin = Temperature.FromKelvins(1);

            var degreecelsiusQuantity = kelvin.ToUnit(TemperatureUnit.DegreeCelsius);
            AssertEx.EqualTolerance(DegreesCelsiusInOneKelvin, (double)degreecelsiusQuantity.Value, DegreesCelsiusTolerance);
            Assert.Equal(TemperatureUnit.DegreeCelsius, degreecelsiusQuantity.Unit);

            var degreedelisleQuantity = kelvin.ToUnit(TemperatureUnit.DegreeDelisle);
            AssertEx.EqualTolerance(DegreesDelisleInOneKelvin, (double)degreedelisleQuantity.Value, DegreesDelisleTolerance);
            Assert.Equal(TemperatureUnit.DegreeDelisle, degreedelisleQuantity.Unit);

            var degreefahrenheitQuantity = kelvin.ToUnit(TemperatureUnit.DegreeFahrenheit);
            AssertEx.EqualTolerance(DegreesFahrenheitInOneKelvin, (double)degreefahrenheitQuantity.Value, DegreesFahrenheitTolerance);
            Assert.Equal(TemperatureUnit.DegreeFahrenheit, degreefahrenheitQuantity.Unit);

            var degreenewtonQuantity = kelvin.ToUnit(TemperatureUnit.DegreeNewton);
            AssertEx.EqualTolerance(DegreesNewtonInOneKelvin, (double)degreenewtonQuantity.Value, DegreesNewtonTolerance);
            Assert.Equal(TemperatureUnit.DegreeNewton, degreenewtonQuantity.Unit);

            var degreerankineQuantity = kelvin.ToUnit(TemperatureUnit.DegreeRankine);
            AssertEx.EqualTolerance(DegreesRankineInOneKelvin, (double)degreerankineQuantity.Value, DegreesRankineTolerance);
            Assert.Equal(TemperatureUnit.DegreeRankine, degreerankineQuantity.Unit);

            var degreereaumurQuantity = kelvin.ToUnit(TemperatureUnit.DegreeReaumur);
            AssertEx.EqualTolerance(DegreesReaumurInOneKelvin, (double)degreereaumurQuantity.Value, DegreesReaumurTolerance);
            Assert.Equal(TemperatureUnit.DegreeReaumur, degreereaumurQuantity.Unit);

            var degreeroemerQuantity = kelvin.ToUnit(TemperatureUnit.DegreeRoemer);
            AssertEx.EqualTolerance(DegreesRoemerInOneKelvin, (double)degreeroemerQuantity.Value, DegreesRoemerTolerance);
            Assert.Equal(TemperatureUnit.DegreeRoemer, degreeroemerQuantity.Unit);

            var kelvinQuantity = kelvin.ToUnit(TemperatureUnit.Kelvin);
            AssertEx.EqualTolerance(KelvinsInOneKelvin, (double)kelvinQuantity.Value, KelvinsTolerance);
            Assert.Equal(TemperatureUnit.Kelvin, kelvinQuantity.Unit);

            var millidegreecelsiusQuantity = kelvin.ToUnit(TemperatureUnit.MillidegreeCelsius);
            AssertEx.EqualTolerance(MillidegreesCelsiusInOneKelvin, (double)millidegreecelsiusQuantity.Value, MillidegreesCelsiusTolerance);
            Assert.Equal(TemperatureUnit.MillidegreeCelsius, millidegreecelsiusQuantity.Unit);

            var solartemperatureQuantity = kelvin.ToUnit(TemperatureUnit.SolarTemperature);
            AssertEx.EqualTolerance(SolarTemperaturesInOneKelvin, (double)solartemperatureQuantity.Value, SolarTemperaturesTolerance);
            Assert.Equal(TemperatureUnit.SolarTemperature, solartemperatureQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = Temperature.FromKelvins(1).ToBaseUnit();
            Assert.Equal(Temperature.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesCelsius(kelvin.DegreesCelsius).Kelvins, DegreesCelsiusTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesDelisle(kelvin.DegreesDelisle).Kelvins, DegreesDelisleTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesFahrenheit(kelvin.DegreesFahrenheit).Kelvins, DegreesFahrenheitTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesNewton(kelvin.DegreesNewton).Kelvins, DegreesNewtonTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesRankine(kelvin.DegreesRankine).Kelvins, DegreesRankineTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesReaumur(kelvin.DegreesReaumur).Kelvins, DegreesReaumurTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromDegreesRoemer(kelvin.DegreesRoemer).Kelvins, DegreesRoemerTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromKelvins(kelvin.Kelvins).Kelvins, KelvinsTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromMillidegreesCelsius(kelvin.MillidegreesCelsius).Kelvins, MillidegreesCelsiusTolerance);
            AssertEx.EqualTolerance(1, Temperature.FromSolarTemperatures(kelvin.SolarTemperatures).Kelvins, SolarTemperaturesTolerance);
        }


        [Fact]
        public void ComparisonOperators()
        {
            Temperature oneKelvin = Temperature.FromKelvins(1);
            Temperature twoKelvins = Temperature.FromKelvins(2);

            Assert.True(oneKelvin < twoKelvins);
            Assert.True(oneKelvin <= twoKelvins);
            Assert.True(twoKelvins > oneKelvin);
            Assert.True(twoKelvins >= oneKelvin);

            Assert.False(oneKelvin > twoKelvins);
            Assert.False(oneKelvin >= twoKelvins);
            Assert.False(twoKelvins < oneKelvin);
            Assert.False(twoKelvins <= oneKelvin);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            Assert.Equal(0, kelvin.CompareTo(kelvin));
            Assert.True(kelvin.CompareTo(Temperature.Zero) > 0);
            Assert.True(Temperature.Zero.CompareTo(kelvin) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            Assert.Throws<ArgumentException>(() => kelvin.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            Assert.Throws<ArgumentNullException>(() => kelvin.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Temperature.FromKelvins(1);
            var b = Temperature.FromKelvins(2);

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
            var a = Temperature.FromKelvins(1);
            var b = Temperature.FromKelvins(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = Temperature.FromKelvins(1);
            object b = Temperature.FromKelvins(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Temperature.FromKelvins(1);
            Assert.True(v.Equals(Temperature.FromKelvins(1), KelvinsTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Temperature.Zero, KelvinsTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Temperature.FromKelvins(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Temperature.FromKelvins(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            Assert.False(kelvin.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Temperature kelvin = Temperature.FromKelvins(1);
            Assert.False(kelvin.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(TemperatureUnit.Undefined, Temperature.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(TemperatureUnit)).Cast<TemperatureUnit>();
            foreach(var unit in units)
            {
                if(unit == TemperatureUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Temperature.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 °C", new Temperature(1, TemperatureUnit.DegreeCelsius).ToString());
                Assert.Equal("1 °De", new Temperature(1, TemperatureUnit.DegreeDelisle).ToString());
                Assert.Equal("1 °F", new Temperature(1, TemperatureUnit.DegreeFahrenheit).ToString());
                Assert.Equal("1 °N", new Temperature(1, TemperatureUnit.DegreeNewton).ToString());
                Assert.Equal("1 °R", new Temperature(1, TemperatureUnit.DegreeRankine).ToString());
                Assert.Equal("1 °Ré", new Temperature(1, TemperatureUnit.DegreeReaumur).ToString());
                Assert.Equal("1 °Rø", new Temperature(1, TemperatureUnit.DegreeRoemer).ToString());
                Assert.Equal("1 K", new Temperature(1, TemperatureUnit.Kelvin).ToString());
                Assert.Equal("1 m°C", new Temperature(1, TemperatureUnit.MillidegreeCelsius).ToString());
                Assert.Equal("1 T⊙", new Temperature(1, TemperatureUnit.SolarTemperature).ToString());
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

            Assert.Equal("1 °C", new Temperature(1, TemperatureUnit.DegreeCelsius).ToString(swedishCulture));
            Assert.Equal("1 °De", new Temperature(1, TemperatureUnit.DegreeDelisle).ToString(swedishCulture));
            Assert.Equal("1 °F", new Temperature(1, TemperatureUnit.DegreeFahrenheit).ToString(swedishCulture));
            Assert.Equal("1 °N", new Temperature(1, TemperatureUnit.DegreeNewton).ToString(swedishCulture));
            Assert.Equal("1 °R", new Temperature(1, TemperatureUnit.DegreeRankine).ToString(swedishCulture));
            Assert.Equal("1 °Ré", new Temperature(1, TemperatureUnit.DegreeReaumur).ToString(swedishCulture));
            Assert.Equal("1 °Rø", new Temperature(1, TemperatureUnit.DegreeRoemer).ToString(swedishCulture));
            Assert.Equal("1 K", new Temperature(1, TemperatureUnit.Kelvin).ToString(swedishCulture));
            Assert.Equal("1 m°C", new Temperature(1, TemperatureUnit.MillidegreeCelsius).ToString(swedishCulture));
            Assert.Equal("1 T⊙", new Temperature(1, TemperatureUnit.SolarTemperature).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 K", new Temperature(0.123456, TemperatureUnit.Kelvin).ToString("s1"));
                Assert.Equal("0.12 K", new Temperature(0.123456, TemperatureUnit.Kelvin).ToString("s2"));
                Assert.Equal("0.123 K", new Temperature(0.123456, TemperatureUnit.Kelvin).ToString("s3"));
                Assert.Equal("0.1235 K", new Temperature(0.123456, TemperatureUnit.Kelvin).ToString("s4"));
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
            Assert.Equal("0.1 K", new Temperature(0.123456, TemperatureUnit.Kelvin).ToString("s1", culture));
            Assert.Equal("0.12 K", new Temperature(0.123456, TemperatureUnit.Kelvin).ToString("s2", culture));
            Assert.Equal("0.123 K", new Temperature(0.123456, TemperatureUnit.Kelvin).ToString("s3", culture));
            Assert.Equal("0.1235 K", new Temperature(0.123456, TemperatureUnit.Kelvin).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Temperature.FromKelvins(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Temperature)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(TemperatureUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal(QuantityType.Temperature, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal(Temperature.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal(Temperature.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Temperature.FromKelvins(1.0);
            Assert.Equal(new {Temperature.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

    }
}
