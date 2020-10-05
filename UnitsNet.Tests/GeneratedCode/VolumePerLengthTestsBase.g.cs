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
using System.Linq;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of VolumePerLength.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class VolumePerLengthTestsBase
    {
        protected abstract double CubicMetersPerMeterInOneCubicMeterPerMeter { get; }
        protected abstract double LitersPerMeterInOneCubicMeterPerMeter { get; }
        protected abstract double OilBarrelsPerFootInOneCubicMeterPerMeter { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CubicMetersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double LitersPerMeterTolerance { get { return 1e-5; } }
        protected virtual double OilBarrelsPerFootTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VolumePerLength((double)0.0, VolumePerLengthUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VolumePerLength(double.PositiveInfinity, VolumePerLengthUnit.CubicMeterPerMeter));
            Assert.Throws<ArgumentException>(() => new VolumePerLength(double.NegativeInfinity, VolumePerLengthUnit.CubicMeterPerMeter));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new VolumePerLength(double.NaN, VolumePerLengthUnit.CubicMeterPerMeter));
        }

        [Fact]
        public void Ctor_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Assert.Throws<ArgumentException>(() => new VolumePerLength(1, UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => new VolumePerLength(1, UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => new VolumePerLength(1, UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => new VolumePerLength(1, UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => new VolumePerLength(1, UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => new VolumePerLength(1, UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => new VolumePerLength(1, UnitSystem.Astronomical));
        }

        [Fact]
        public void Ctor_WithNullUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new VolumePerLength(1, null));
        }

        [Fact]
        public void CubicMeterPerMeterToVolumePerLengthUnits()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            AssertEx.EqualTolerance(CubicMetersPerMeterInOneCubicMeterPerMeter, cubicmeterpermeter.CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(LitersPerMeterInOneCubicMeterPerMeter, cubicmeterpermeter.LitersPerMeter, LitersPerMeterTolerance);
            AssertEx.EqualTolerance(OilBarrelsPerFootInOneCubicMeterPerMeter, cubicmeterpermeter.OilBarrelsPerFoot, OilBarrelsPerFootTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, VolumePerLength.From(1, VolumePerLengthUnit.CubicMeterPerMeter).CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, VolumePerLength.From(1, VolumePerLengthUnit.LiterPerMeter).LitersPerMeter, LitersPerMeterTolerance);
            AssertEx.EqualTolerance(1, VolumePerLength.From(1, VolumePerLengthUnit.OilBarrelPerFoot).OilBarrelsPerFoot, OilBarrelsPerFootTolerance);
        }

        [Fact]
        public void FromCubicMetersPerMeter_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => VolumePerLength.FromCubicMetersPerMeter(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => VolumePerLength.FromCubicMetersPerMeter(double.NegativeInfinity));
        }

        [Fact]
        public void FromCubicMetersPerMeter_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => VolumePerLength.FromCubicMetersPerMeter(double.NaN));
        }

        [Fact]
        public void As()
        {
            var cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            AssertEx.EqualTolerance(CubicMetersPerMeterInOneCubicMeterPerMeter, cubicmeterpermeter.As(VolumePerLengthUnit.CubicMeterPerMeter), CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(LitersPerMeterInOneCubicMeterPerMeter, cubicmeterpermeter.As(VolumePerLengthUnit.LiterPerMeter), LitersPerMeterTolerance);
            AssertEx.EqualTolerance(OilBarrelsPerFootInOneCubicMeterPerMeter, cubicmeterpermeter.As(VolumePerLengthUnit.OilBarrelPerFoot), OilBarrelsPerFootTolerance);
        }

        [Fact]
        public void As_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);

            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.As(UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.As(UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.As(UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.As(UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.As(UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.As(UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.As(UnitSystem.Astronomical));
        }

        [Fact]
        public void As_WithNullUnitSystem_ThrowsArgumentNullException()
        {
            var cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
 
            Assert.Throws<ArgumentNullException>(() => cubicmeterpermeter.As(null));
        }

        [Fact]
        public void ToUnit()
        {
            var cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);

            var cubicmeterpermeterQuantity = cubicmeterpermeter.ToUnit(VolumePerLengthUnit.CubicMeterPerMeter);
            AssertEx.EqualTolerance(CubicMetersPerMeterInOneCubicMeterPerMeter, (double)cubicmeterpermeterQuantity.Value, CubicMetersPerMeterTolerance);
            Assert.Equal(VolumePerLengthUnit.CubicMeterPerMeter, cubicmeterpermeterQuantity.Unit);

            var literpermeterQuantity = cubicmeterpermeter.ToUnit(VolumePerLengthUnit.LiterPerMeter);
            AssertEx.EqualTolerance(LitersPerMeterInOneCubicMeterPerMeter, (double)literpermeterQuantity.Value, LitersPerMeterTolerance);
            Assert.Equal(VolumePerLengthUnit.LiterPerMeter, literpermeterQuantity.Unit);

            var oilbarrelperfootQuantity = cubicmeterpermeter.ToUnit(VolumePerLengthUnit.OilBarrelPerFoot);
            AssertEx.EqualTolerance(OilBarrelsPerFootInOneCubicMeterPerMeter, (double)oilbarrelperfootQuantity.Value, OilBarrelsPerFootTolerance);
            Assert.Equal(VolumePerLengthUnit.OilBarrelPerFoot, oilbarrelperfootQuantity.Unit);
        }

        [Fact]
        public void To_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);

            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.ToUnit(UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.ToUnit(UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.ToUnit(UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.ToUnit(UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.ToUnit(UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.ToUnit(UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.ToUnit(UnitSystem.Astronomical));
        }

        [Fact]
        public void ToUnit_WithNullUnitSystem_ThrowsNullException()
        {
            var cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
 
            Assert.Throws<ArgumentNullException>(() => cubicmeterpermeter.ToUnit(null));
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            AssertEx.EqualTolerance(1, VolumePerLength.FromCubicMetersPerMeter(cubicmeterpermeter.CubicMetersPerMeter).CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(1, VolumePerLength.FromLitersPerMeter(cubicmeterpermeter.LitersPerMeter).CubicMetersPerMeter, LitersPerMeterTolerance);
            AssertEx.EqualTolerance(1, VolumePerLength.FromOilBarrelsPerFoot(cubicmeterpermeter.OilBarrelsPerFoot).CubicMetersPerMeter, OilBarrelsPerFootTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            VolumePerLength v = VolumePerLength.FromCubicMetersPerMeter(1);
            AssertEx.EqualTolerance(-1, -v.CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(2, (VolumePerLength.FromCubicMetersPerMeter(3)-v).CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(2, (v + v).CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(10, (v*10).CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(10, (10*v).CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(2, (VolumePerLength.FromCubicMetersPerMeter(10)/5).CubicMetersPerMeter, CubicMetersPerMeterTolerance);
            AssertEx.EqualTolerance(2, VolumePerLength.FromCubicMetersPerMeter(10)/VolumePerLength.FromCubicMetersPerMeter(5), CubicMetersPerMeterTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            VolumePerLength oneCubicMeterPerMeter = VolumePerLength.FromCubicMetersPerMeter(1);
            VolumePerLength twoCubicMetersPerMeter = VolumePerLength.FromCubicMetersPerMeter(2);

            Assert.True(oneCubicMeterPerMeter < twoCubicMetersPerMeter);
            Assert.True(oneCubicMeterPerMeter <= twoCubicMetersPerMeter);
            Assert.True(twoCubicMetersPerMeter > oneCubicMeterPerMeter);
            Assert.True(twoCubicMetersPerMeter >= oneCubicMeterPerMeter);

            Assert.False(oneCubicMeterPerMeter > twoCubicMetersPerMeter);
            Assert.False(oneCubicMeterPerMeter >= twoCubicMetersPerMeter);
            Assert.False(twoCubicMetersPerMeter < oneCubicMeterPerMeter);
            Assert.False(twoCubicMetersPerMeter <= oneCubicMeterPerMeter);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            Assert.Equal(0, cubicmeterpermeter.CompareTo(cubicmeterpermeter));
            Assert.True(cubicmeterpermeter.CompareTo(VolumePerLength.Zero) > 0);
            Assert.True(VolumePerLength.Zero.CompareTo(cubicmeterpermeter) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            Assert.Throws<ArgumentException>(() => cubicmeterpermeter.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            Assert.Throws<ArgumentNullException>(() => cubicmeterpermeter.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = VolumePerLength.FromCubicMetersPerMeter(1);
            var b = VolumePerLength.FromCubicMetersPerMeter(2);

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
            var a = VolumePerLength.FromCubicMetersPerMeter(1);
            var b = VolumePerLength.FromCubicMetersPerMeter(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = VolumePerLength.FromCubicMetersPerMeter(1);
            Assert.True(v.Equals(VolumePerLength.FromCubicMetersPerMeter(1), CubicMetersPerMeterTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(VolumePerLength.Zero, CubicMetersPerMeterTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            Assert.False(cubicmeterpermeter.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            VolumePerLength cubicmeterpermeter = VolumePerLength.FromCubicMetersPerMeter(1);
            Assert.False(cubicmeterpermeter.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(VolumePerLengthUnit.Undefined, VolumePerLength.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(VolumePerLengthUnit)).Cast<VolumePerLengthUnit>();
            foreach(var unit in units)
            {
                if(unit == VolumePerLengthUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(VolumePerLength.BaseDimensions is null);
        }
    }
}
