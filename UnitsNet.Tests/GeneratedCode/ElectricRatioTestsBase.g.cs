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
    /// Test of ElectricRatio.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricRatioTestsBase
    {
        protected abstract double MillivoltsPerVoltInOneMillivoltPerVolt { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double MillivoltsPerVoltTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricRatio((double)0.0, ElectricRatioUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricRatio(double.PositiveInfinity, ElectricRatioUnit.MillivoltPerVolt));
            Assert.Throws<ArgumentException>(() => new ElectricRatio(double.NegativeInfinity, ElectricRatioUnit.MillivoltPerVolt));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ElectricRatio(double.NaN, ElectricRatioUnit.MillivoltPerVolt));
        }

        [Fact]
        public void MillivoltPerVoltToElectricRatioUnits()
        {
            ElectricRatio millivoltpervolt = ElectricRatio.FromMillivoltsPerVolt(1);
            AssertEx.EqualTolerance(MillivoltsPerVoltInOneMillivoltPerVolt, millivoltpervolt.MillivoltsPerVolt, MillivoltsPerVoltTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricRatio.From(1, ElectricRatioUnit.MillivoltPerVolt).MillivoltsPerVolt, MillivoltsPerVoltTolerance);
        }

        [Fact]
        public void FromMillivoltsPerVolt_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricRatio.FromMillivoltsPerVolt(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => ElectricRatio.FromMillivoltsPerVolt(double.NegativeInfinity));
        }

        [Fact]
        public void FromMillivoltsPerVolt_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => ElectricRatio.FromMillivoltsPerVolt(double.NaN));
        }

        [Fact]
        public void As()
        {
            var millivoltpervolt = ElectricRatio.FromMillivoltsPerVolt(1);
            AssertEx.EqualTolerance(MillivoltsPerVoltInOneMillivoltPerVolt, millivoltpervolt.As(ElectricRatioUnit.MillivoltPerVolt), MillivoltsPerVoltTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var millivoltpervolt = ElectricRatio.FromMillivoltsPerVolt(1);

            var millivoltpervoltQuantity = millivoltpervolt.ToUnit(ElectricRatioUnit.MillivoltPerVolt);
            AssertEx.EqualTolerance(MillivoltsPerVoltInOneMillivoltPerVolt, (double)millivoltpervoltQuantity.Value, MillivoltsPerVoltTolerance);
            Assert.Equal(ElectricRatioUnit.MillivoltPerVolt, millivoltpervoltQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricRatio millivoltpervolt = ElectricRatio.FromMillivoltsPerVolt(1);
            AssertEx.EqualTolerance(1, ElectricRatio.FromMillivoltsPerVolt(millivoltpervolt.MillivoltsPerVolt).MillivoltsPerVolt, MillivoltsPerVoltTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricRatio v = ElectricRatio.FromMillivoltsPerVolt(1);
            AssertEx.EqualTolerance(-1, -v.MillivoltsPerVolt, MillivoltsPerVoltTolerance);
            AssertEx.EqualTolerance(2, (ElectricRatio.FromMillivoltsPerVolt(3)-v).MillivoltsPerVolt, MillivoltsPerVoltTolerance);
            AssertEx.EqualTolerance(2, (v + v).MillivoltsPerVolt, MillivoltsPerVoltTolerance);
            AssertEx.EqualTolerance(10, (v*10).MillivoltsPerVolt, MillivoltsPerVoltTolerance);
            AssertEx.EqualTolerance(10, (10*v).MillivoltsPerVolt, MillivoltsPerVoltTolerance);
            AssertEx.EqualTolerance(2, (ElectricRatio.FromMillivoltsPerVolt(10)/5).MillivoltsPerVolt, MillivoltsPerVoltTolerance);
            AssertEx.EqualTolerance(2, ElectricRatio.FromMillivoltsPerVolt(10)/ElectricRatio.FromMillivoltsPerVolt(5), MillivoltsPerVoltTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricRatio oneMillivoltPerVolt = ElectricRatio.FromMillivoltsPerVolt(1);
            ElectricRatio twoMillivoltsPerVolt = ElectricRatio.FromMillivoltsPerVolt(2);

            Assert.True(oneMillivoltPerVolt < twoMillivoltsPerVolt);
            Assert.True(oneMillivoltPerVolt <= twoMillivoltsPerVolt);
            Assert.True(twoMillivoltsPerVolt > oneMillivoltPerVolt);
            Assert.True(twoMillivoltsPerVolt >= oneMillivoltPerVolt);

            Assert.False(oneMillivoltPerVolt > twoMillivoltsPerVolt);
            Assert.False(oneMillivoltPerVolt >= twoMillivoltsPerVolt);
            Assert.False(twoMillivoltsPerVolt < oneMillivoltPerVolt);
            Assert.False(twoMillivoltsPerVolt <= oneMillivoltPerVolt);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricRatio millivoltpervolt = ElectricRatio.FromMillivoltsPerVolt(1);
            Assert.Equal(0, millivoltpervolt.CompareTo(millivoltpervolt));
            Assert.True(millivoltpervolt.CompareTo(ElectricRatio.Zero) > 0);
            Assert.True(ElectricRatio.Zero.CompareTo(millivoltpervolt) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricRatio millivoltpervolt = ElectricRatio.FromMillivoltsPerVolt(1);
            Assert.Throws<ArgumentException>(() => millivoltpervolt.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricRatio millivoltpervolt = ElectricRatio.FromMillivoltsPerVolt(1);
            Assert.Throws<ArgumentNullException>(() => millivoltpervolt.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = ElectricRatio.FromMillivoltsPerVolt(1);
            var b = ElectricRatio.FromMillivoltsPerVolt(2);

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
            var a = ElectricRatio.FromMillivoltsPerVolt(1);
            var b = ElectricRatio.FromMillivoltsPerVolt(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = ElectricRatio.FromMillivoltsPerVolt(1);
            Assert.True(v.Equals(ElectricRatio.FromMillivoltsPerVolt(1), MillivoltsPerVoltTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(ElectricRatio.Zero, MillivoltsPerVoltTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricRatio millivoltpervolt = ElectricRatio.FromMillivoltsPerVolt(1);
            Assert.False(millivoltpervolt.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricRatio millivoltpervolt = ElectricRatio.FromMillivoltsPerVolt(1);
            Assert.False(millivoltpervolt.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(ElectricRatioUnit.Undefined, ElectricRatio.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(ElectricRatioUnit)).Cast<ElectricRatioUnit>();
            foreach(var unit in units)
            {
                if(unit == ElectricRatioUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(ElectricRatio.BaseDimensions is null);
        }
    }
}
