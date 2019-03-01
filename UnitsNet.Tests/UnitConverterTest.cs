﻿// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests
{
    public class UnitConverterTest
    {
        [Fact]
        public void CustomConversionWithSameQuantityType()
        {
            ConversionFunction<Length> conversionFunction = (from) => Length.FromInches(18);

            var unitConverter = new UnitConverter();
            unitConverter.SetConversionFunction(LengthUnit.Meter, LengthUnit.Inch, conversionFunction);

            var foundConversionFunction = unitConverter.GetConversionFunction<Length>(LengthUnit.Meter, LengthUnit.Inch);
            var converted = foundConversionFunction(Length.FromMeters(1.0));

            Assert.Equal(Length.FromInches(18), converted);
        }

        [Fact]
        public void CustomConversionWithDifferentQuantityTypes()
        {
            ConversionFunction conversionFunction = (from) => Length.FromInches(18);

            var unitConverter = new UnitConverter();
            unitConverter.SetConversionFunction<Mass, Length>(MassUnit.Grain, LengthUnit.Inch, conversionFunction);

            var foundConversionFunction = unitConverter.GetConversionFunction<Mass, Length>(MassUnit.Grain, LengthUnit.Inch);
            var converted = foundConversionFunction(Mass.FromGrains(100));

            Assert.Equal(Length.FromInches(18), converted);
        }

        [Fact]
        public void TryCustomConversionForOilBarrelsToUsGallons()
        {
            ConversionFunction<Volume> conversionFunction = (from) => Volume.FromUsGallons(from.Value * 42);

            var unitConverter = new UnitConverter();
            unitConverter.SetConversionFunction(VolumeUnit.OilBarrel, VolumeUnit.UsGallon, conversionFunction);

            var foundConversionFunction = unitConverter.GetConversionFunction<Volume>(VolumeUnit.OilBarrel, VolumeUnit.UsGallon);
            var converted = foundConversionFunction(Volume.FromOilBarrels(1));

            Assert.Equal(Volume.FromUsGallons(42), converted);
        }

        [Theory]
        [InlineData(0, 0, "length", "meter", "centimeter")]
        [InlineData(0, 0, "Length", "Meter", "Centimeter")]
        [InlineData(100, 1, "Length", "Meter", "Centimeter")]
        [InlineData(1, 1000, "Mass", "Gram", "Kilogram")]
        [InlineData(1000, 1, "ElectricCurrent", "Kiloampere", "Ampere")]
        public void ConvertByName_ConvertsTheValueToGivenUnit(double expectedValue, double inputValue, string quantityTypeName, string fromUnit, string toUnit)
        {
            Assert.Equal(expectedValue, UnitConverter.ConvertByName(inputValue, quantityTypeName, fromUnit, toUnit));
        }

        [Fact]
        public void ConvertByName_QuantityCaseInsensitive()
        {
            Assert.Equal(0, UnitConverter.ConvertByName(0, "length", "Meter", "Centimeter"));
        }

        [Fact]
        public void ConvertByName_UnitTypeCaseInsensitive()
        {
            Assert.Equal(0, UnitConverter.ConvertByName(0, "Length", "meter", "Centimeter"));
        }

        [Theory]
        [InlineData(1, "UnknownQuantity", "Meter", "Centimeter")]
        public void ConvertByName_ThrowsUnitNotFoundExceptionOnUnknownQuantity(double inputValue, string quantityTypeName, string fromUnit, string toUnit)
        {
            Assert.Throws<UnitNotFoundException>(() => UnitConverter.ConvertByName(inputValue, quantityTypeName, fromUnit, toUnit));
        }

        [Theory]
        [InlineData(1, "Length", "UnknownFromUnit", "Centimeter")]
        [InlineData(1, "Length", "Meter", "UnknownToUnit")]
        public void ConvertByName_ThrowsUnitNotFoundExceptionOnUnknownFromOrToUnit(double inputValue, string quantityTypeName, string fromUnit, string toUnit)
        {
            Assert.Throws<UnitNotFoundException>(() => UnitConverter.ConvertByName(inputValue, quantityTypeName, fromUnit, toUnit));
        }

        [Theory]
        [InlineData(1, "UnknownQuantity", "Meter", "Centimeter")]
        [InlineData(1, "Length", "UnknownFromUnit", "Centimeter")]
        [InlineData(1, "Length", "Meter", "UnknownToUnit")]
        public void TryConvertByName_ReturnsFalseForInvalidInput(double inputValue, string quantityTypeName, string fromUnit, string toUnit)
        {
            Assert.False(UnitConverter.TryConvertByName(inputValue, quantityTypeName, fromUnit, toUnit, out double result));
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(0, 0, "Length", "Meter", "Centimeter")]
        [InlineData(100, 1, "Length", "Meter", "Centimeter")]
        [InlineData(1, 1000, "Mass", "Gram", "Kilogram")]
        [InlineData(1000, 1, "ElectricCurrent", "Kiloampere", "Ampere")]
        public void TryConvertByName_ReturnsTrueOnSuccessAndOutputsResult(double expectedValue, double inputValue, string quantityTypeName, string fromUnit,
            string toUnit)
        {
            Assert.True(UnitConverter.TryConvertByName(inputValue, quantityTypeName, fromUnit, toUnit, out double result), "TryConvertByName() return value.");
            Assert.Equal(expectedValue, result);
        }

        [Theory]
        [InlineData(0, 0, "Length", "m", "cm")]
        [InlineData(100, 1, "Length", "m", "cm")]
        [InlineData(1, 1000, "Mass", "g", "kg")]
        [InlineData(1000, 1, "ElectricCurrent", "kA", "A")]
        public void ConvertByAbbreviation_ConvertsTheValueToGivenUnit(double expectedValue, double inputValue, string quantityTypeName, string fromUnit, string toUnit)
        {
            Assert.Equal(expectedValue, UnitConverter.ConvertByAbbreviation(inputValue, quantityTypeName, fromUnit, toUnit));
        }

        [Theory]
        [InlineData(1, "UnknownQuantity", "m", "cm")]
        public void ConvertByAbbreviation_ThrowsUnitNotFoundExceptionOnUnknownQuantity( double inputValue, string quantityTypeName, string fromUnit, string toUnit)
        {
            Assert.Throws<UnitNotFoundException>(() => UnitConverter.ConvertByAbbreviation(inputValue, quantityTypeName, fromUnit, toUnit));
        }

        [Theory]
        [InlineData(1, "Length", "UnknownFromUnit", "cm")]
        [InlineData(1, "Length", "m", "UnknownToUnit")]
        public void ConvertByAbbreviation_ThrowsUnitNotFoundExceptionOnUnknownFromOrToUnitAbbreviation(double inputValue, string quantityTypeName, string fromUnit, string toUnit)
        {
            Assert.Throws<UnitNotFoundException>(() => UnitConverter.ConvertByAbbreviation(inputValue, quantityTypeName, fromUnit, toUnit));
        }

        [Theory]
        [InlineData(1, "UnknownQuantity", "m", "cm")]
        [InlineData(1, "Length", "UnknownFromUnit", "cm")]
        [InlineData(1, "Length", "m", "UnknownToUnit")]
        public void TryConvertByAbbreviation_ReturnsFalseForInvalidInput(double inputValue, string quantityTypeName, string fromUnit, string toUnit)
        {
            Assert.False(UnitConverter.TryConvertByAbbreviation(inputValue, quantityTypeName, fromUnit, toUnit, out double result));
            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData(0, 0, "Length", "m", "cm")]
        [InlineData(100, 1, "Length", "m", "cm")]
        [InlineData(1, 1000, "Mass", "g", "kg")]
        [InlineData(1000, 1, "ElectricCurrent", "kA", "A")]
        public void TryConvertByAbbreviation_ReturnsTrueOnSuccessAndOutputsResult(double expectedValue, double inputValue, string quantityTypeName, string fromUnit,
            string toUnit)
        {
            Assert.True(UnitConverter.TryConvertByAbbreviation(inputValue, quantityTypeName, fromUnit, toUnit, out double result), "TryConvertByAbbreviation() return value.");
            Assert.Equal(expectedValue, result);
        }
    }
}
