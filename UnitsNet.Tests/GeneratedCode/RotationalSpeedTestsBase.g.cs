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
    /// Test of RotationalSpeed.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class RotationalSpeedTestsBase
    {
        protected abstract double CentiradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double DeciradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double DegreesPerMinuteInOneRadianPerSecond { get; }
        protected abstract double DegreesPerSecondInOneRadianPerSecond { get; }
        protected abstract double MicrodegreesPerSecondInOneRadianPerSecond { get; }
        protected abstract double MicroradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double MillidegreesPerSecondInOneRadianPerSecond { get; }
        protected abstract double MilliradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double NanodegreesPerSecondInOneRadianPerSecond { get; }
        protected abstract double NanoradiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double RadiansPerSecondInOneRadianPerSecond { get; }
        protected abstract double RevolutionsPerMinuteInOneRadianPerSecond { get; }
        protected abstract double RevolutionsPerSecondInOneRadianPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentiradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DeciradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double DegreesPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double DegreesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicrodegreesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MicroradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MillidegreesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double MilliradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NanodegreesPerSecondTolerance { get { return 1e-5; } }
        protected virtual double NanoradiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double RadiansPerSecondTolerance { get { return 1e-5; } }
        protected virtual double RevolutionsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double RevolutionsPerSecondTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalSpeed((double)0.0, RotationalSpeedUnit.Undefined));
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalSpeed(double.PositiveInfinity, RotationalSpeedUnit.RadianPerSecond));
            Assert.Throws<ArgumentException>(() => new RotationalSpeed(double.NegativeInfinity, RotationalSpeedUnit.RadianPerSecond));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new RotationalSpeed(double.NaN, RotationalSpeedUnit.RadianPerSecond));
        }

        [Fact]
        public void Ctor_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Assert.Throws<ArgumentException>(() => new RotationalSpeed(1, UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => new RotationalSpeed(1, UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => new RotationalSpeed(1, UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => new RotationalSpeed(1, UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => new RotationalSpeed(1, UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => new RotationalSpeed(1, UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => new RotationalSpeed(1, UnitSystem.Astronomical));
        }

        [Fact]
        public void Ctor_WithNullUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new RotationalSpeed(1, null));
        }

        [Fact]
        public void RadianPerSecondToRotationalSpeedUnits()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            AssertEx.EqualTolerance(CentiradiansPerSecondInOneRadianPerSecond, radianpersecond.CentiradiansPerSecond, CentiradiansPerSecondTolerance);
            AssertEx.EqualTolerance(DeciradiansPerSecondInOneRadianPerSecond, radianpersecond.DeciradiansPerSecond, DeciradiansPerSecondTolerance);
            AssertEx.EqualTolerance(DegreesPerMinuteInOneRadianPerSecond, radianpersecond.DegreesPerMinute, DegreesPerMinuteTolerance);
            AssertEx.EqualTolerance(DegreesPerSecondInOneRadianPerSecond, radianpersecond.DegreesPerSecond, DegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MicrodegreesPerSecondInOneRadianPerSecond, radianpersecond.MicrodegreesPerSecond, MicrodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MicroradiansPerSecondInOneRadianPerSecond, radianpersecond.MicroradiansPerSecond, MicroradiansPerSecondTolerance);
            AssertEx.EqualTolerance(MillidegreesPerSecondInOneRadianPerSecond, radianpersecond.MillidegreesPerSecond, MillidegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MilliradiansPerSecondInOneRadianPerSecond, radianpersecond.MilliradiansPerSecond, MilliradiansPerSecondTolerance);
            AssertEx.EqualTolerance(NanodegreesPerSecondInOneRadianPerSecond, radianpersecond.NanodegreesPerSecond, NanodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(NanoradiansPerSecondInOneRadianPerSecond, radianpersecond.NanoradiansPerSecond, NanoradiansPerSecondTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondInOneRadianPerSecond, radianpersecond.RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(RevolutionsPerMinuteInOneRadianPerSecond, radianpersecond.RevolutionsPerMinute, RevolutionsPerMinuteTolerance);
            AssertEx.EqualTolerance(RevolutionsPerSecondInOneRadianPerSecond, radianpersecond.RevolutionsPerSecond, RevolutionsPerSecondTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.CentiradianPerSecond).CentiradiansPerSecond, CentiradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.DeciradianPerSecond).DeciradiansPerSecond, DeciradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.DegreePerMinute).DegreesPerMinute, DegreesPerMinuteTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.DegreePerSecond).DegreesPerSecond, DegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.MicrodegreePerSecond).MicrodegreesPerSecond, MicrodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.MicroradianPerSecond).MicroradiansPerSecond, MicroradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.MillidegreePerSecond).MillidegreesPerSecond, MillidegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.MilliradianPerSecond).MilliradiansPerSecond, MilliradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.NanodegreePerSecond).NanodegreesPerSecond, NanodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.NanoradianPerSecond).NanoradiansPerSecond, NanoradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.RadianPerSecond).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.RevolutionPerMinute).RevolutionsPerMinute, RevolutionsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.From(1, RotationalSpeedUnit.RevolutionPerSecond).RevolutionsPerSecond, RevolutionsPerSecondTolerance);
        }

        [Fact]
        public void FromRadiansPerSecond_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalSpeed.FromRadiansPerSecond(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => RotationalSpeed.FromRadiansPerSecond(double.NegativeInfinity));
        }

        [Fact]
        public void FromRadiansPerSecond_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => RotationalSpeed.FromRadiansPerSecond(double.NaN));
        }

        [Fact]
        public void As()
        {
            var radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            AssertEx.EqualTolerance(CentiradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.CentiradianPerSecond), CentiradiansPerSecondTolerance);
            AssertEx.EqualTolerance(DeciradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.DeciradianPerSecond), DeciradiansPerSecondTolerance);
            AssertEx.EqualTolerance(DegreesPerMinuteInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.DegreePerMinute), DegreesPerMinuteTolerance);
            AssertEx.EqualTolerance(DegreesPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.DegreePerSecond), DegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MicrodegreesPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.MicrodegreePerSecond), MicrodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MicroradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.MicroradianPerSecond), MicroradiansPerSecondTolerance);
            AssertEx.EqualTolerance(MillidegreesPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.MillidegreePerSecond), MillidegreesPerSecondTolerance);
            AssertEx.EqualTolerance(MilliradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.MilliradianPerSecond), MilliradiansPerSecondTolerance);
            AssertEx.EqualTolerance(NanodegreesPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.NanodegreePerSecond), NanodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(NanoradiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.NanoradianPerSecond), NanoradiansPerSecondTolerance);
            AssertEx.EqualTolerance(RadiansPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.RadianPerSecond), RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(RevolutionsPerMinuteInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.RevolutionPerMinute), RevolutionsPerMinuteTolerance);
            AssertEx.EqualTolerance(RevolutionsPerSecondInOneRadianPerSecond, radianpersecond.As(RotationalSpeedUnit.RevolutionPerSecond), RevolutionsPerSecondTolerance);
        }

        [Fact]
        public void As_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);

            Assert.Throws<ArgumentException>(() => radianpersecond.As(UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => radianpersecond.As(UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => radianpersecond.As(UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => radianpersecond.As(UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => radianpersecond.As(UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => radianpersecond.As(UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => radianpersecond.As(UnitSystem.Astronomical));
        }

        [Fact]
        public void As_WithNullUnitSystem_ThrowsArgumentNullException()
        {
            var radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
 
            Assert.Throws<ArgumentNullException>(() => radianpersecond.As(null));
        }

        [Fact]
        public void ToUnit()
        {
            var radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);

            var centiradianpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.CentiradianPerSecond);
            AssertEx.EqualTolerance(CentiradiansPerSecondInOneRadianPerSecond, (double)centiradianpersecondQuantity.Value, CentiradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.CentiradianPerSecond, centiradianpersecondQuantity.Unit);

            var deciradianpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.DeciradianPerSecond);
            AssertEx.EqualTolerance(DeciradiansPerSecondInOneRadianPerSecond, (double)deciradianpersecondQuantity.Value, DeciradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.DeciradianPerSecond, deciradianpersecondQuantity.Unit);

            var degreeperminuteQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.DegreePerMinute);
            AssertEx.EqualTolerance(DegreesPerMinuteInOneRadianPerSecond, (double)degreeperminuteQuantity.Value, DegreesPerMinuteTolerance);
            Assert.Equal(RotationalSpeedUnit.DegreePerMinute, degreeperminuteQuantity.Unit);

            var degreepersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.DegreePerSecond);
            AssertEx.EqualTolerance(DegreesPerSecondInOneRadianPerSecond, (double)degreepersecondQuantity.Value, DegreesPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.DegreePerSecond, degreepersecondQuantity.Unit);

            var microdegreepersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.MicrodegreePerSecond);
            AssertEx.EqualTolerance(MicrodegreesPerSecondInOneRadianPerSecond, (double)microdegreepersecondQuantity.Value, MicrodegreesPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.MicrodegreePerSecond, microdegreepersecondQuantity.Unit);

            var microradianpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.MicroradianPerSecond);
            AssertEx.EqualTolerance(MicroradiansPerSecondInOneRadianPerSecond, (double)microradianpersecondQuantity.Value, MicroradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.MicroradianPerSecond, microradianpersecondQuantity.Unit);

            var millidegreepersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.MillidegreePerSecond);
            AssertEx.EqualTolerance(MillidegreesPerSecondInOneRadianPerSecond, (double)millidegreepersecondQuantity.Value, MillidegreesPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.MillidegreePerSecond, millidegreepersecondQuantity.Unit);

            var milliradianpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.MilliradianPerSecond);
            AssertEx.EqualTolerance(MilliradiansPerSecondInOneRadianPerSecond, (double)milliradianpersecondQuantity.Value, MilliradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.MilliradianPerSecond, milliradianpersecondQuantity.Unit);

            var nanodegreepersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.NanodegreePerSecond);
            AssertEx.EqualTolerance(NanodegreesPerSecondInOneRadianPerSecond, (double)nanodegreepersecondQuantity.Value, NanodegreesPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.NanodegreePerSecond, nanodegreepersecondQuantity.Unit);

            var nanoradianpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.NanoradianPerSecond);
            AssertEx.EqualTolerance(NanoradiansPerSecondInOneRadianPerSecond, (double)nanoradianpersecondQuantity.Value, NanoradiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.NanoradianPerSecond, nanoradianpersecondQuantity.Unit);

            var radianpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.RadianPerSecond);
            AssertEx.EqualTolerance(RadiansPerSecondInOneRadianPerSecond, (double)radianpersecondQuantity.Value, RadiansPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.RadianPerSecond, radianpersecondQuantity.Unit);

            var revolutionperminuteQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.RevolutionPerMinute);
            AssertEx.EqualTolerance(RevolutionsPerMinuteInOneRadianPerSecond, (double)revolutionperminuteQuantity.Value, RevolutionsPerMinuteTolerance);
            Assert.Equal(RotationalSpeedUnit.RevolutionPerMinute, revolutionperminuteQuantity.Unit);

            var revolutionpersecondQuantity = radianpersecond.ToUnit(RotationalSpeedUnit.RevolutionPerSecond);
            AssertEx.EqualTolerance(RevolutionsPerSecondInOneRadianPerSecond, (double)revolutionpersecondQuantity.Value, RevolutionsPerSecondTolerance);
            Assert.Equal(RotationalSpeedUnit.RevolutionPerSecond, revolutionpersecondQuantity.Unit);
        }

        [Fact]
        public void To_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);

            Assert.Throws<ArgumentException>(() => radianpersecond.ToUnit(UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => radianpersecond.ToUnit(UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => radianpersecond.ToUnit(UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => radianpersecond.ToUnit(UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => radianpersecond.ToUnit(UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => radianpersecond.ToUnit(UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => radianpersecond.ToUnit(UnitSystem.Astronomical));
        }

        [Fact]
        public void ToUnit_WithNullUnitSystem_ThrowsNullException()
        {
            var radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
 
            Assert.Throws<ArgumentNullException>(() => radianpersecond.ToUnit(null));
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromCentiradiansPerSecond(radianpersecond.CentiradiansPerSecond).RadiansPerSecond, CentiradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromDeciradiansPerSecond(radianpersecond.DeciradiansPerSecond).RadiansPerSecond, DeciradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromDegreesPerMinute(radianpersecond.DegreesPerMinute).RadiansPerSecond, DegreesPerMinuteTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromDegreesPerSecond(radianpersecond.DegreesPerSecond).RadiansPerSecond, DegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromMicrodegreesPerSecond(radianpersecond.MicrodegreesPerSecond).RadiansPerSecond, MicrodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromMicroradiansPerSecond(radianpersecond.MicroradiansPerSecond).RadiansPerSecond, MicroradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromMillidegreesPerSecond(radianpersecond.MillidegreesPerSecond).RadiansPerSecond, MillidegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromMilliradiansPerSecond(radianpersecond.MilliradiansPerSecond).RadiansPerSecond, MilliradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromNanodegreesPerSecond(radianpersecond.NanodegreesPerSecond).RadiansPerSecond, NanodegreesPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromNanoradiansPerSecond(radianpersecond.NanoradiansPerSecond).RadiansPerSecond, NanoradiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromRadiansPerSecond(radianpersecond.RadiansPerSecond).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromRevolutionsPerMinute(radianpersecond.RevolutionsPerMinute).RadiansPerSecond, RevolutionsPerMinuteTolerance);
            AssertEx.EqualTolerance(1, RotationalSpeed.FromRevolutionsPerSecond(radianpersecond.RevolutionsPerSecond).RadiansPerSecond, RevolutionsPerSecondTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            RotationalSpeed v = RotationalSpeed.FromRadiansPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RotationalSpeed.FromRadiansPerSecond(3)-v).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(2, (RotationalSpeed.FromRadiansPerSecond(10)/5).RadiansPerSecond, RadiansPerSecondTolerance);
            AssertEx.EqualTolerance(2, RotationalSpeed.FromRadiansPerSecond(10)/RotationalSpeed.FromRadiansPerSecond(5), RadiansPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            RotationalSpeed oneRadianPerSecond = RotationalSpeed.FromRadiansPerSecond(1);
            RotationalSpeed twoRadiansPerSecond = RotationalSpeed.FromRadiansPerSecond(2);

            Assert.True(oneRadianPerSecond < twoRadiansPerSecond);
            Assert.True(oneRadianPerSecond <= twoRadiansPerSecond);
            Assert.True(twoRadiansPerSecond > oneRadianPerSecond);
            Assert.True(twoRadiansPerSecond >= oneRadianPerSecond);

            Assert.False(oneRadianPerSecond > twoRadiansPerSecond);
            Assert.False(oneRadianPerSecond >= twoRadiansPerSecond);
            Assert.False(twoRadiansPerSecond < oneRadianPerSecond);
            Assert.False(twoRadiansPerSecond <= oneRadianPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.Equal(0, radianpersecond.CompareTo(radianpersecond));
            Assert.True(radianpersecond.CompareTo(RotationalSpeed.Zero) > 0);
            Assert.True(RotationalSpeed.Zero.CompareTo(radianpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.Throws<ArgumentException>(() => radianpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => radianpersecond.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = RotationalSpeed.FromRadiansPerSecond(1);
            var b = RotationalSpeed.FromRadiansPerSecond(2);

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
            var a = RotationalSpeed.FromRadiansPerSecond(1);
            var b = RotationalSpeed.FromRadiansPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.True(v.Equals(RotationalSpeed.FromRadiansPerSecond(1), RadiansPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(RotationalSpeed.Zero, RadiansPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.False(radianpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            RotationalSpeed radianpersecond = RotationalSpeed.FromRadiansPerSecond(1);
            Assert.False(radianpersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(RotationalSpeedUnit.Undefined, RotationalSpeed.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(RotationalSpeedUnit)).Cast<RotationalSpeedUnit>();
            foreach(var unit in units)
            {
                if(unit == RotationalSpeedUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(RotationalSpeed.BaseDimensions is null);
        }
    }
}
