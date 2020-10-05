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
    /// Test of RotationalAcceleration.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RotationalAccelerationTestsBase
    {
        protected abstract double DegreesPerSecondSquaredInOneRadianPerSecondSquared { get; }
        protected abstract double RadiansPerSecondSquaredInOneRadianPerSecondSquared { get; }
        protected abstract double RevolutionsPerMinutePerSecondInOneRadianPerSecondSquared { get; }
        protected abstract double RevolutionsPerSecondSquaredInOneRadianPerSecondSquared { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DegreesPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double RadiansPerSecondSquaredTolerance { get { return 1e-5; } }
        protected virtual double RevolutionsPerMinutePerSecondTolerance { get { return 1e-5; } }
        protected virtual double RevolutionsPerSecondSquaredTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration((double)0.0, RotationalAccelerationUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration(double.PositiveInfinity, RotationalAccelerationUnit.RadianPerSecondSquared));
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration(double.NegativeInfinity, RotationalAccelerationUnit.RadianPerSecondSquared));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration(double.NaN, RotationalAccelerationUnit.RadianPerSecondSquared));
        }

        [Fact]
        public void Ctor_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration(1, UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration(1, UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration(1, UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration(1, UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration(1, UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration(1, UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => new RotationalAcceleration(1, UnitSystem.Astronomical));
        }

        [Fact]
        public void Ctor_WithNullUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new RotationalAcceleration(1, null));
        }

        [Fact]
        public void RadianPerSecondSquaredToRotationalAccelerationUnits()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            AssertEx.EqualTolerance(DegreesPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.DegreesPerSecondSquared, DegreesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(RevolutionsPerMinutePerSecondInOneRadianPerSecondSquared, radianpersecondsquared.RevolutionsPerMinutePerSecond, RevolutionsPerMinutePerSecondTolerance);
            AssertEx.EqualTolerance(RevolutionsPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.RevolutionsPerSecondSquared, RevolutionsPerSecondSquaredTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, RotationalAcceleration.From(1, RotationalAccelerationUnit.DegreePerSecondSquared).DegreesPerSecondSquared, DegreesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, RotationalAcceleration.From(1, RotationalAccelerationUnit.RadianPerSecondSquared).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, RotationalAcceleration.From(1, RotationalAccelerationUnit.RevolutionPerMinutePerSecond).RevolutionsPerMinutePerSecond, RevolutionsPerMinutePerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalAcceleration.From(1, RotationalAccelerationUnit.RevolutionPerSecondSquared).RevolutionsPerSecondSquared, RevolutionsPerSecondSquaredTolerance);
        }

        [Fact]
        public void FromRadiansPerSecondSquared_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalAcceleration.FromRadiansPerSecondSquared(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => RotationalAcceleration.FromRadiansPerSecondSquared(double.NegativeInfinity));
        }

        [Fact]
        public void FromRadiansPerSecondSquared_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalAcceleration.FromRadiansPerSecondSquared(double.NaN));
        }

        [Fact]
        public void As()
        {
            var radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            AssertEx.EqualTolerance(DegreesPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.As(RotationalAccelerationUnit.DegreePerSecondSquared), DegreesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.As(RotationalAccelerationUnit.RadianPerSecondSquared), RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(RevolutionsPerMinutePerSecondInOneRadianPerSecondSquared, radianpersecondsquared.As(RotationalAccelerationUnit.RevolutionPerMinutePerSecond), RevolutionsPerMinutePerSecondTolerance);
            AssertEx.EqualTolerance(RevolutionsPerSecondSquaredInOneRadianPerSecondSquared, radianpersecondsquared.As(RotationalAccelerationUnit.RevolutionPerSecondSquared), RevolutionsPerSecondSquaredTolerance);
        }

        [Fact]
        public void As_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);

            Assert.Throws<ArgumentException>(() => radianpersecondsquared.As(UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.As(UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.As(UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.As(UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.As(UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.As(UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.As(UnitSystem.Astronomical));
        }

        [Fact]
        public void As_WithNullUnitSystem_ThrowsArgumentNullException()
        {
            var radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
 
            Assert.Throws<ArgumentNullException>(() => radianpersecondsquared.As(null));
        }

        [Fact]
        public void ToUnit()
        {
            var radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);

            var degreepersecondsquaredQuantity = radianpersecondsquared.ToUnit(RotationalAccelerationUnit.DegreePerSecondSquared);
            AssertEx.EqualTolerance(DegreesPerSecondSquaredInOneRadianPerSecondSquared, (double)degreepersecondsquaredQuantity.Value, DegreesPerSecondSquaredTolerance);
            Assert.Equal(RotationalAccelerationUnit.DegreePerSecondSquared, degreepersecondsquaredQuantity.Unit);

            var radianpersecondsquaredQuantity = radianpersecondsquared.ToUnit(RotationalAccelerationUnit.RadianPerSecondSquared);
            AssertEx.EqualTolerance(RadiansPerSecondSquaredInOneRadianPerSecondSquared, (double)radianpersecondsquaredQuantity.Value, RadiansPerSecondSquaredTolerance);
            Assert.Equal(RotationalAccelerationUnit.RadianPerSecondSquared, radianpersecondsquaredQuantity.Unit);

            var revolutionperminutepersecondQuantity = radianpersecondsquared.ToUnit(RotationalAccelerationUnit.RevolutionPerMinutePerSecond);
            AssertEx.EqualTolerance(RevolutionsPerMinutePerSecondInOneRadianPerSecondSquared, (double)revolutionperminutepersecondQuantity.Value, RevolutionsPerMinutePerSecondTolerance);
            Assert.Equal(RotationalAccelerationUnit.RevolutionPerMinutePerSecond, revolutionperminutepersecondQuantity.Unit);

            var revolutionpersecondsquaredQuantity = radianpersecondsquared.ToUnit(RotationalAccelerationUnit.RevolutionPerSecondSquared);
            AssertEx.EqualTolerance(RevolutionsPerSecondSquaredInOneRadianPerSecondSquared, (double)revolutionpersecondsquaredQuantity.Value, RevolutionsPerSecondSquaredTolerance);
            Assert.Equal(RotationalAccelerationUnit.RevolutionPerSecondSquared, revolutionpersecondsquaredQuantity.Unit);
        }

        [Fact]
        public void To_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);

            Assert.Throws<ArgumentException>(() => radianpersecondsquared.ToUnit(UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.ToUnit(UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.ToUnit(UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.ToUnit(UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.ToUnit(UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.ToUnit(UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.ToUnit(UnitSystem.Astronomical));
        }

        [Fact]
        public void ToUnit_WithNullUnitSystem_ThrowsNullException()
        {
            var radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
 
            Assert.Throws<ArgumentNullException>(() => radianpersecondsquared.ToUnit(null));
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            AssertEx.EqualTolerance(1, RotationalAcceleration.FromDegreesPerSecondSquared(radianpersecondsquared.DegreesPerSecondSquared).RadiansPerSecondSquared, DegreesPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, RotationalAcceleration.FromRadiansPerSecondSquared(radianpersecondsquared.RadiansPerSecondSquared).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(1, RotationalAcceleration.FromRevolutionsPerMinutePerSecond(radianpersecondsquared.RevolutionsPerMinutePerSecond).RadiansPerSecondSquared, RevolutionsPerMinutePerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalAcceleration.FromRevolutionsPerSecondSquared(radianpersecondsquared.RevolutionsPerSecondSquared).RadiansPerSecondSquared, RevolutionsPerSecondSquaredTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RotationalAcceleration v = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            AssertEx.EqualTolerance(-1, -v.RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (RotationalAcceleration.FromRadiansPerSecondSquared(3)-v).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (v + v).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(10, (v*10).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(10, (10*v).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, (RotationalAcceleration.FromRadiansPerSecondSquared(10)/5).RadiansPerSecondSquared, RadiansPerSecondSquaredTolerance);
            AssertEx.EqualTolerance(2, RotationalAcceleration.FromRadiansPerSecondSquared(10)/RotationalAcceleration.FromRadiansPerSecondSquared(5), RadiansPerSecondSquaredTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RotationalAcceleration oneRadianPerSecondSquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            RotationalAcceleration twoRadiansPerSecondSquared = RotationalAcceleration.FromRadiansPerSecondSquared(2);

            Assert.True(oneRadianPerSecondSquared < twoRadiansPerSecondSquared);
            Assert.True(oneRadianPerSecondSquared <= twoRadiansPerSecondSquared);
            Assert.True(twoRadiansPerSecondSquared > oneRadianPerSecondSquared);
            Assert.True(twoRadiansPerSecondSquared >= oneRadianPerSecondSquared);

            Assert.False(oneRadianPerSecondSquared > twoRadiansPerSecondSquared);
            Assert.False(oneRadianPerSecondSquared >= twoRadiansPerSecondSquared);
            Assert.False(twoRadiansPerSecondSquared < oneRadianPerSecondSquared);
            Assert.False(twoRadiansPerSecondSquared <= oneRadianPerSecondSquared);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.Equal(0, radianpersecondsquared.CompareTo(radianpersecondsquared));
            Assert.True(radianpersecondsquared.CompareTo(RotationalAcceleration.Zero) > 0);
            Assert.True(RotationalAcceleration.Zero.CompareTo(radianpersecondsquared) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.Throws<ArgumentException>(() => radianpersecondsquared.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.Throws<ArgumentNullException>(() => radianpersecondsquared.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            var b = RotationalAcceleration.FromRadiansPerSecondSquared(2);

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
            var a = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            var b = RotationalAcceleration.FromRadiansPerSecondSquared(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.True(v.Equals(RotationalAcceleration.FromRadiansPerSecondSquared(1), RadiansPerSecondSquaredTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(RotationalAcceleration.Zero, RadiansPerSecondSquaredTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.False(radianpersecondsquared.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RotationalAcceleration radianpersecondsquared = RotationalAcceleration.FromRadiansPerSecondSquared(1);
            Assert.False(radianpersecondsquared.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RotationalAccelerationUnit.Undefined, RotationalAcceleration.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(RotationalAccelerationUnit)).Cast<RotationalAccelerationUnit>();
            foreach(var unit in units)
            {
                if(unit == RotationalAccelerationUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(RotationalAcceleration.BaseDimensions is null);
        }
    }
}
