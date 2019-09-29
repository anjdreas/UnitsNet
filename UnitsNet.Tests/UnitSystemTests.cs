﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Linq;
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests
{
    public class UnitSystemTests
    {
        [Fact]
        public void ConstructorImplementedProperly()
        {
            var baseUnits = new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            var unitSystem = new UnitSystem(baseUnits);

            Assert.Equal(unitSystem.BaseUnits, baseUnits);
        }

        [Fact]
        public void ConstructorThrowsArgumentNullExceptionForNullBaseUnits()
        {
            Assert.Throws<ArgumentNullException>(() => new UnitSystem(null));
        }

        [Theory]
        [InlineData(LengthUnit.Undefined, MassUnit.Kilogram, DurationUnit.Second, ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela)]
        [InlineData(LengthUnit.Meter, MassUnit.Undefined, DurationUnit.Second, ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela)]
        [InlineData(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Undefined, ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela)]
        [InlineData(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second, ElectricCurrentUnit.Undefined, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela)]
        [InlineData(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second, ElectricCurrentUnit.Ampere, TemperatureUnit.Undefined, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela)]
        [InlineData(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second, ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Undefined, LuminousIntensityUnit.Candela)]
        [InlineData(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second, ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Undefined)]
        public void ConstructorThrowsArgumentExceptionWithUndefinedUnits(LengthUnit length, MassUnit mass, DurationUnit time, ElectricCurrentUnit current,
            TemperatureUnit temperature, AmountOfSubstanceUnit amount, LuminousIntensityUnit luminousIntensity)
        {
            var baseUnits = new BaseUnits(length, mass, time, current, temperature, amount, luminousIntensity);
            Assert.Throws<ArgumentException>(() => new UnitSystem(baseUnits));
        }

        [Fact]
        public void EqualsObjectIsImplementedCorrectly()
        {
            var unitSystem1 = new UnitSystem(new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela));

            var unitSystem2 = new UnitSystem(new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela));

            var unitSystem3 = new UnitSystem(new BaseUnits(LengthUnit.Foot, MassUnit.Pound, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.DegreeFahrenheit, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela));

            Assert.True(unitSystem1.Equals((object)unitSystem2));
            Assert.False(unitSystem1.Equals((object)unitSystem3));

            Assert.False(unitSystem1.Equals("Some object."));
            Assert.False(unitSystem1.Equals((IFormatProvider)null));
        }

        [Fact]
        public void EqualsUnitSystemIsImplementedCorrectly()
        {
            var unitSystem1 = new UnitSystem(new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela));

            var unitSystem2 = new UnitSystem(new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela));

            var unitSystem3 = new UnitSystem(new BaseUnits(LengthUnit.Foot, MassUnit.Pound, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.DegreeFahrenheit, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela));

            Assert.True(unitSystem1.Equals(unitSystem2));
            Assert.True(unitSystem2.Equals(unitSystem1));

            Assert.False(unitSystem1.Equals(unitSystem3));
            Assert.False(unitSystem3.Equals(unitSystem1));

            Assert.False(unitSystem1.Equals(null));
        }

        [Fact]
        public void EqualityOperatorIsImplementedCorrectly()
        {
            var unitSystem1 = new UnitSystem(new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela));

            var unitSystem2 = new UnitSystem(new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela));

            var unitSystem3 = new UnitSystem(new BaseUnits(LengthUnit.Foot, MassUnit.Pound, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.DegreeFahrenheit, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela));

            Assert.True(unitSystem1 == unitSystem2);
            Assert.True(unitSystem2 == unitSystem1);

            Assert.False(unitSystem1 == unitSystem3);
            Assert.False(unitSystem3 == unitSystem1);

            Assert.False(unitSystem1 == null);
            Assert.False(null == unitSystem1);

            UnitSystem nullUnitSystem1 = null;
            UnitSystem nullUnitSystem2 = null;

            Assert.True(nullUnitSystem1 == nullUnitSystem2);
        }

        [Fact]
        public void InequalityOperatorIsImplementedCorrectly()
        {
            var unitSystem1 = new UnitSystem(new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela));

            var unitSystem2 = new UnitSystem(new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela));

            var unitSystem3 = new UnitSystem(new BaseUnits(LengthUnit.Foot, MassUnit.Pound, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.DegreeFahrenheit, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela));

            Assert.False(unitSystem1 != unitSystem2);
            Assert.False(unitSystem2 != unitSystem1);

            Assert.True(unitSystem1 != unitSystem3);
            Assert.True(unitSystem3 != unitSystem1);

            Assert.True(unitSystem1 != null);
            Assert.True(null != unitSystem1);

            UnitSystem nullUnitSystem1 = null;
            UnitSystem nullUnitSystem2 = null;

            Assert.False(nullUnitSystem1 != nullUnitSystem2);
        }

        [Fact]
        public void SIUnitSystemHasCorrectBaseUnits()
        {
            var siBaseUnits = new BaseUnits(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second,
                ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela);

            Assert.Equal(LengthUnit.Meter, UnitSystem.SI.BaseUnits.Length);
            Assert.Equal(MassUnit.Kilogram, UnitSystem.SI.BaseUnits.Mass);
            Assert.Equal(DurationUnit.Second, UnitSystem.SI.BaseUnits.Time);
            Assert.Equal(ElectricCurrentUnit.Ampere, UnitSystem.SI.BaseUnits.Current);
            Assert.Equal(TemperatureUnit.Kelvin, UnitSystem.SI.BaseUnits.Temperature);
            Assert.Equal(AmountOfSubstanceUnit.Mole, UnitSystem.SI.BaseUnits.Amount);
            Assert.Equal(LuminousIntensityUnit.Candela, UnitSystem.SI.BaseUnits.LuminousIntensity);
        }

        [Fact]
        public void GetDefaultUnitInfo_GivenUndefinedQuantity_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => UnitSystem.SI.GetDefaultUnitInfo(QuantityType.Undefined));
        }

        [Fact]
        public void GetDefaultUnitInfo_GivenQuantityWithNoDefaultUnits_ReturnsNull()
        {
            // we cannot simply rely on something like AmplitudeRatio not having a default base unit definition (as this is expected to change soon)
            var unitSystemWithNoDefaultLengthUnit = UnitSystem.SI.WithDefaultUnit(QuantityType.Length, null); // we can however force the dissociation
            
            Assert.Null(unitSystemWithNoDefaultLengthUnit.GetDefaultUnitInfo(QuantityType.Length));
        }

        [Fact]
        public void WithDefaultUnit_GivenUndefinedQuantityType_ThrowsArgumentException()
        {
            var anyUnitInfo = Length.Info.UnitInfos.First();

            Assert.Throws<ArgumentException>(() => UnitSystem.SI.WithDefaultUnit(QuantityType.Undefined, anyUnitInfo));
        }

        [Fact]
        public void WithDefaultUnit_GivenIncompatibleUnitAndQuantityType_ThrowsArgumentException()
        {
            var nonMassUnit = Length.Info.UnitInfos.First();

            Assert.Throws<ArgumentException>(() => UnitSystem.SI.WithDefaultUnit(QuantityType.Mass, nonMassUnit));
        }

        [Fact]
        public void WithDefaultUnit_GivenNullForBaseUnits_ReturnsUnitSystemWithOldBaseUnits()
        {
            var myDefaultLengthUnit = Length.Info.UnitInfos.First(x => x.Value == LengthUnit.Millimeter);

            var newSI = UnitSystem.SI.WithDefaultUnit(QuantityType.Length, myDefaultLengthUnit, (BaseUnits) null); 

            Assert.Equal(UnitSystem.SI, newSI); // currently comparing using BaseUnits
        }

        [Theory]
        [InlineData(LengthUnit.Undefined, MassUnit.Kilogram, DurationUnit.Second, ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela)]
        [InlineData(LengthUnit.Meter, MassUnit.Undefined, DurationUnit.Second, ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela)]
        [InlineData(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Undefined, ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela)]
        [InlineData(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second, ElectricCurrentUnit.Undefined, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela)]
        [InlineData(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second, ElectricCurrentUnit.Ampere, TemperatureUnit.Undefined, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela)]
        [InlineData(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second, ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Undefined, LuminousIntensityUnit.Candela)]
        [InlineData(LengthUnit.Meter, MassUnit.Kilogram, DurationUnit.Second, ElectricCurrentUnit.Ampere, TemperatureUnit.Kelvin, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Undefined)]
        public void WithDefaultUnit_GivenBaseUnitsNotFullyDefined_ThrowsArgumentException(LengthUnit length, MassUnit mass, DurationUnit time, ElectricCurrentUnit current,
            TemperatureUnit temperature, AmountOfSubstanceUnit amount, LuminousIntensityUnit luminousIntensity)
        {
            var myDefaultLengthUnit = Length.Info.UnitInfos.First(x => x.Value == LengthUnit.Millimeter);

            var baseUnits = new BaseUnits(length, mass, time, current, temperature, amount, luminousIntensity);

            // BaseUnits(obsolete) kept in order to avoid introducing  a breaking change (just yet)
            Assert.Throws<ArgumentException>(()=> UnitSystem.SI.WithDefaultUnit(QuantityType.Length, myDefaultLengthUnit, baseUnits));
        }

    }
}
