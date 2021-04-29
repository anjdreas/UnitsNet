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
    /// Test of Angle.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AngleTestsBase : QuantityTestsBase
    {
        protected abstract double ArcminutesInOneDegree { get; }
        protected abstract double ArcsecondsInOneDegree { get; }
        protected abstract double CentiradiansInOneDegree { get; }
        protected abstract double DeciradiansInOneDegree { get; }
        protected abstract double DegreesInOneDegree { get; }
        protected abstract double GradiansInOneDegree { get; }
        protected abstract double MicrodegreesInOneDegree { get; }
        protected abstract double MicroradiansInOneDegree { get; }
        protected abstract double MillidegreesInOneDegree { get; }
        protected abstract double MilliradiansInOneDegree { get; }
        protected abstract double NanodegreesInOneDegree { get; }
        protected abstract double NanoradiansInOneDegree { get; }
        protected abstract double RadiansInOneDegree { get; }
        protected abstract double RevolutionsInOneDegree { get; }
        protected abstract double TiltInOneDegree { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double ArcminutesTolerance { get { return 1e-5; } }
        protected virtual double ArcsecondsTolerance { get { return 1e-5; } }
        protected virtual double CentiradiansTolerance { get { return 1e-5; } }
        protected virtual double DeciradiansTolerance { get { return 1e-5; } }
        protected virtual double DegreesTolerance { get { return 1e-5; } }
        protected virtual double GradiansTolerance { get { return 1e-5; } }
        protected virtual double MicrodegreesTolerance { get { return 1e-5; } }
        protected virtual double MicroradiansTolerance { get { return 1e-5; } }
        protected virtual double MillidegreesTolerance { get { return 1e-5; } }
        protected virtual double MilliradiansTolerance { get { return 1e-5; } }
        protected virtual double NanodegreesTolerance { get { return 1e-5; } }
        protected virtual double NanoradiansTolerance { get { return 1e-5; } }
        protected virtual double RadiansTolerance { get { return 1e-5; } }
        protected virtual double RevolutionsTolerance { get { return 1e-5; } }
        protected virtual double TiltTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Angle((double)0.0, AngleUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new Angle();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(AngleUnit.Degree, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Angle(double.PositiveInfinity, AngleUnit.Degree));
            Assert.Throws<ArgumentException>(() => new Angle(double.NegativeInfinity, AngleUnit.Degree));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new Angle(double.NaN, AngleUnit.Degree));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Angle(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Assert.Throws<ArgumentException>(() => new Angle(1, UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => new Angle(1, UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => new Angle(1, UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => new Angle(1, UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => new Angle(1, UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => new Angle(1, UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => new Angle(1, UnitSystem.Astronomical));
        }

        [Fact]
        public void Ctor_WithNullUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Angle(1, null));
        }

        public void Angle_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new Angle(1, AngleUnit.Degree);

            QuantityInfo<AngleUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(Angle.Zero, quantityInfo.Zero);
            Assert.Equal("Angle", quantityInfo.Name);
            Assert.Equal(QuantityType.Angle, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<AngleUnit>().Except(new[] {AngleUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void DegreeToAngleUnits()
        {
            Angle degree = Angle.FromDegrees(1);
            AssertEx.EqualTolerance(ArcminutesInOneDegree, degree.Arcminutes, ArcminutesTolerance);
            AssertEx.EqualTolerance(ArcsecondsInOneDegree, degree.Arcseconds, ArcsecondsTolerance);
            AssertEx.EqualTolerance(CentiradiansInOneDegree, degree.Centiradians, CentiradiansTolerance);
            AssertEx.EqualTolerance(DeciradiansInOneDegree, degree.Deciradians, DeciradiansTolerance);
            AssertEx.EqualTolerance(DegreesInOneDegree, degree.Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(GradiansInOneDegree, degree.Gradians, GradiansTolerance);
            AssertEx.EqualTolerance(MicrodegreesInOneDegree, degree.Microdegrees, MicrodegreesTolerance);
            AssertEx.EqualTolerance(MicroradiansInOneDegree, degree.Microradians, MicroradiansTolerance);
            AssertEx.EqualTolerance(MillidegreesInOneDegree, degree.Millidegrees, MillidegreesTolerance);
            AssertEx.EqualTolerance(MilliradiansInOneDegree, degree.Milliradians, MilliradiansTolerance);
            AssertEx.EqualTolerance(NanodegreesInOneDegree, degree.Nanodegrees, NanodegreesTolerance);
            AssertEx.EqualTolerance(NanoradiansInOneDegree, degree.Nanoradians, NanoradiansTolerance);
            AssertEx.EqualTolerance(RadiansInOneDegree, degree.Radians, RadiansTolerance);
            AssertEx.EqualTolerance(RevolutionsInOneDegree, degree.Revolutions, RevolutionsTolerance);
            AssertEx.EqualTolerance(TiltInOneDegree, degree.Tilt, TiltTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = Angle.From(1, AngleUnit.Arcminute);
            AssertEx.EqualTolerance(1, quantity00.Arcminutes, ArcminutesTolerance);
            Assert.Equal(AngleUnit.Arcminute, quantity00.Unit);

            var quantity01 = Angle.From(1, AngleUnit.Arcsecond);
            AssertEx.EqualTolerance(1, quantity01.Arcseconds, ArcsecondsTolerance);
            Assert.Equal(AngleUnit.Arcsecond, quantity01.Unit);

            var quantity02 = Angle.From(1, AngleUnit.Centiradian);
            AssertEx.EqualTolerance(1, quantity02.Centiradians, CentiradiansTolerance);
            Assert.Equal(AngleUnit.Centiradian, quantity02.Unit);

            var quantity03 = Angle.From(1, AngleUnit.Deciradian);
            AssertEx.EqualTolerance(1, quantity03.Deciradians, DeciradiansTolerance);
            Assert.Equal(AngleUnit.Deciradian, quantity03.Unit);

            var quantity04 = Angle.From(1, AngleUnit.Degree);
            AssertEx.EqualTolerance(1, quantity04.Degrees, DegreesTolerance);
            Assert.Equal(AngleUnit.Degree, quantity04.Unit);

            var quantity05 = Angle.From(1, AngleUnit.Gradian);
            AssertEx.EqualTolerance(1, quantity05.Gradians, GradiansTolerance);
            Assert.Equal(AngleUnit.Gradian, quantity05.Unit);

            var quantity06 = Angle.From(1, AngleUnit.Microdegree);
            AssertEx.EqualTolerance(1, quantity06.Microdegrees, MicrodegreesTolerance);
            Assert.Equal(AngleUnit.Microdegree, quantity06.Unit);

            var quantity07 = Angle.From(1, AngleUnit.Microradian);
            AssertEx.EqualTolerance(1, quantity07.Microradians, MicroradiansTolerance);
            Assert.Equal(AngleUnit.Microradian, quantity07.Unit);

            var quantity08 = Angle.From(1, AngleUnit.Millidegree);
            AssertEx.EqualTolerance(1, quantity08.Millidegrees, MillidegreesTolerance);
            Assert.Equal(AngleUnit.Millidegree, quantity08.Unit);

            var quantity09 = Angle.From(1, AngleUnit.Milliradian);
            AssertEx.EqualTolerance(1, quantity09.Milliradians, MilliradiansTolerance);
            Assert.Equal(AngleUnit.Milliradian, quantity09.Unit);

            var quantity10 = Angle.From(1, AngleUnit.Nanodegree);
            AssertEx.EqualTolerance(1, quantity10.Nanodegrees, NanodegreesTolerance);
            Assert.Equal(AngleUnit.Nanodegree, quantity10.Unit);

            var quantity11 = Angle.From(1, AngleUnit.Nanoradian);
            AssertEx.EqualTolerance(1, quantity11.Nanoradians, NanoradiansTolerance);
            Assert.Equal(AngleUnit.Nanoradian, quantity11.Unit);

            var quantity12 = Angle.From(1, AngleUnit.Radian);
            AssertEx.EqualTolerance(1, quantity12.Radians, RadiansTolerance);
            Assert.Equal(AngleUnit.Radian, quantity12.Unit);

            var quantity13 = Angle.From(1, AngleUnit.Revolution);
            AssertEx.EqualTolerance(1, quantity13.Revolutions, RevolutionsTolerance);
            Assert.Equal(AngleUnit.Revolution, quantity13.Unit);

            var quantity14 = Angle.From(1, AngleUnit.Tilt);
            AssertEx.EqualTolerance(1, quantity14.Tilt, TiltTolerance);
            Assert.Equal(AngleUnit.Tilt, quantity14.Unit);

        }

        [Fact]
        public void FromDegrees_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Angle.FromDegrees(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => Angle.FromDegrees(double.NegativeInfinity));
        }

        [Fact]
        public void FromDegrees_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => Angle.FromDegrees(double.NaN));
        }

        [Fact]
        public void As()
        {
            var degree = Angle.FromDegrees(1);
            AssertEx.EqualTolerance(ArcminutesInOneDegree, degree.As(AngleUnit.Arcminute), ArcminutesTolerance);
            AssertEx.EqualTolerance(ArcsecondsInOneDegree, degree.As(AngleUnit.Arcsecond), ArcsecondsTolerance);
            AssertEx.EqualTolerance(CentiradiansInOneDegree, degree.As(AngleUnit.Centiradian), CentiradiansTolerance);
            AssertEx.EqualTolerance(DeciradiansInOneDegree, degree.As(AngleUnit.Deciradian), DeciradiansTolerance);
            AssertEx.EqualTolerance(DegreesInOneDegree, degree.As(AngleUnit.Degree), DegreesTolerance);
            AssertEx.EqualTolerance(GradiansInOneDegree, degree.As(AngleUnit.Gradian), GradiansTolerance);
            AssertEx.EqualTolerance(MicrodegreesInOneDegree, degree.As(AngleUnit.Microdegree), MicrodegreesTolerance);
            AssertEx.EqualTolerance(MicroradiansInOneDegree, degree.As(AngleUnit.Microradian), MicroradiansTolerance);
            AssertEx.EqualTolerance(MillidegreesInOneDegree, degree.As(AngleUnit.Millidegree), MillidegreesTolerance);
            AssertEx.EqualTolerance(MilliradiansInOneDegree, degree.As(AngleUnit.Milliradian), MilliradiansTolerance);
            AssertEx.EqualTolerance(NanodegreesInOneDegree, degree.As(AngleUnit.Nanodegree), NanodegreesTolerance);
            AssertEx.EqualTolerance(NanoradiansInOneDegree, degree.As(AngleUnit.Nanoradian), NanoradiansTolerance);
            AssertEx.EqualTolerance(RadiansInOneDegree, degree.As(AngleUnit.Radian), RadiansTolerance);
            AssertEx.EqualTolerance(RevolutionsInOneDegree, degree.As(AngleUnit.Revolution), RevolutionsTolerance);
            AssertEx.EqualTolerance(TiltInOneDegree, degree.As(AngleUnit.Tilt), TiltTolerance);
        }

        [Fact]
        public void As_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var degree = Angle.FromDegrees(1);

            Assert.Throws<ArgumentException>(() => degree.As(UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => degree.As(UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => degree.As(UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => degree.As(UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => degree.As(UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => degree.As(UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => degree.As(UnitSystem.Astronomical));
        }

        [Fact]
        public void As_WithNullUnitSystem_ThrowsArgumentNullException()
        {
            var degree = Angle.FromDegrees(1);
 
            Assert.Throws<ArgumentNullException>(() => degree.As(null));
        }

        [Fact]
        public void ToUnit()
        {
            var degree = Angle.FromDegrees(1);

            var arcminuteQuantity = degree.ToUnit(AngleUnit.Arcminute);
            AssertEx.EqualTolerance(ArcminutesInOneDegree, (double)arcminuteQuantity.Value, ArcminutesTolerance);
            Assert.Equal(AngleUnit.Arcminute, arcminuteQuantity.Unit);

            var arcsecondQuantity = degree.ToUnit(AngleUnit.Arcsecond);
            AssertEx.EqualTolerance(ArcsecondsInOneDegree, (double)arcsecondQuantity.Value, ArcsecondsTolerance);
            Assert.Equal(AngleUnit.Arcsecond, arcsecondQuantity.Unit);

            var centiradianQuantity = degree.ToUnit(AngleUnit.Centiradian);
            AssertEx.EqualTolerance(CentiradiansInOneDegree, (double)centiradianQuantity.Value, CentiradiansTolerance);
            Assert.Equal(AngleUnit.Centiradian, centiradianQuantity.Unit);

            var deciradianQuantity = degree.ToUnit(AngleUnit.Deciradian);
            AssertEx.EqualTolerance(DeciradiansInOneDegree, (double)deciradianQuantity.Value, DeciradiansTolerance);
            Assert.Equal(AngleUnit.Deciradian, deciradianQuantity.Unit);

            var degreeQuantity = degree.ToUnit(AngleUnit.Degree);
            AssertEx.EqualTolerance(DegreesInOneDegree, (double)degreeQuantity.Value, DegreesTolerance);
            Assert.Equal(AngleUnit.Degree, degreeQuantity.Unit);

            var gradianQuantity = degree.ToUnit(AngleUnit.Gradian);
            AssertEx.EqualTolerance(GradiansInOneDegree, (double)gradianQuantity.Value, GradiansTolerance);
            Assert.Equal(AngleUnit.Gradian, gradianQuantity.Unit);

            var microdegreeQuantity = degree.ToUnit(AngleUnit.Microdegree);
            AssertEx.EqualTolerance(MicrodegreesInOneDegree, (double)microdegreeQuantity.Value, MicrodegreesTolerance);
            Assert.Equal(AngleUnit.Microdegree, microdegreeQuantity.Unit);

            var microradianQuantity = degree.ToUnit(AngleUnit.Microradian);
            AssertEx.EqualTolerance(MicroradiansInOneDegree, (double)microradianQuantity.Value, MicroradiansTolerance);
            Assert.Equal(AngleUnit.Microradian, microradianQuantity.Unit);

            var millidegreeQuantity = degree.ToUnit(AngleUnit.Millidegree);
            AssertEx.EqualTolerance(MillidegreesInOneDegree, (double)millidegreeQuantity.Value, MillidegreesTolerance);
            Assert.Equal(AngleUnit.Millidegree, millidegreeQuantity.Unit);

            var milliradianQuantity = degree.ToUnit(AngleUnit.Milliradian);
            AssertEx.EqualTolerance(MilliradiansInOneDegree, (double)milliradianQuantity.Value, MilliradiansTolerance);
            Assert.Equal(AngleUnit.Milliradian, milliradianQuantity.Unit);

            var nanodegreeQuantity = degree.ToUnit(AngleUnit.Nanodegree);
            AssertEx.EqualTolerance(NanodegreesInOneDegree, (double)nanodegreeQuantity.Value, NanodegreesTolerance);
            Assert.Equal(AngleUnit.Nanodegree, nanodegreeQuantity.Unit);

            var nanoradianQuantity = degree.ToUnit(AngleUnit.Nanoradian);
            AssertEx.EqualTolerance(NanoradiansInOneDegree, (double)nanoradianQuantity.Value, NanoradiansTolerance);
            Assert.Equal(AngleUnit.Nanoradian, nanoradianQuantity.Unit);

            var radianQuantity = degree.ToUnit(AngleUnit.Radian);
            AssertEx.EqualTolerance(RadiansInOneDegree, (double)radianQuantity.Value, RadiansTolerance);
            Assert.Equal(AngleUnit.Radian, radianQuantity.Unit);

            var revolutionQuantity = degree.ToUnit(AngleUnit.Revolution);
            AssertEx.EqualTolerance(RevolutionsInOneDegree, (double)revolutionQuantity.Value, RevolutionsTolerance);
            Assert.Equal(AngleUnit.Revolution, revolutionQuantity.Unit);

            var tiltQuantity = degree.ToUnit(AngleUnit.Tilt);
            AssertEx.EqualTolerance(TiltInOneDegree, (double)tiltQuantity.Value, TiltTolerance);
            Assert.Equal(AngleUnit.Tilt, tiltQuantity.Unit);
        }

        [Fact]
        public void To_UnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var degree = Angle.FromDegrees(1);

            Assert.Throws<ArgumentException>(() => degree.ToUnit(UnitSystem.SI));
            Assert.Throws<ArgumentException>(() => degree.ToUnit(UnitSystem.CGS));
            Assert.Throws<ArgumentException>(() => degree.ToUnit(UnitSystem.BI));
            Assert.Throws<ArgumentException>(() => degree.ToUnit(UnitSystem.EE));
            Assert.Throws<ArgumentException>(() => degree.ToUnit(UnitSystem.USC));
            Assert.Throws<ArgumentException>(() => degree.ToUnit(UnitSystem.FPS));
            Assert.Throws<ArgumentException>(() => degree.ToUnit(UnitSystem.Astronomical));
        }

        [Fact]
        public void ToUnit_WithNullUnitSystem_ThrowsNullException()
        {
            var degree = Angle.FromDegrees(1);
 
            Assert.Throws<ArgumentNullException>(() => degree.ToUnit(null));
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = Angle.FromDegrees(1).ToBaseUnit();
            Assert.Equal(Angle.BaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Angle degree = Angle.FromDegrees(1);
            AssertEx.EqualTolerance(1, Angle.FromArcminutes(degree.Arcminutes).Degrees, ArcminutesTolerance);
            AssertEx.EqualTolerance(1, Angle.FromArcseconds(degree.Arcseconds).Degrees, ArcsecondsTolerance);
            AssertEx.EqualTolerance(1, Angle.FromCentiradians(degree.Centiradians).Degrees, CentiradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.FromDeciradians(degree.Deciradians).Degrees, DeciradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.FromDegrees(degree.Degrees).Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(1, Angle.FromGradians(degree.Gradians).Degrees, GradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.FromMicrodegrees(degree.Microdegrees).Degrees, MicrodegreesTolerance);
            AssertEx.EqualTolerance(1, Angle.FromMicroradians(degree.Microradians).Degrees, MicroradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.FromMillidegrees(degree.Millidegrees).Degrees, MillidegreesTolerance);
            AssertEx.EqualTolerance(1, Angle.FromMilliradians(degree.Milliradians).Degrees, MilliradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.FromNanodegrees(degree.Nanodegrees).Degrees, NanodegreesTolerance);
            AssertEx.EqualTolerance(1, Angle.FromNanoradians(degree.Nanoradians).Degrees, NanoradiansTolerance);
            AssertEx.EqualTolerance(1, Angle.FromRadians(degree.Radians).Degrees, RadiansTolerance);
            AssertEx.EqualTolerance(1, Angle.FromRevolutions(degree.Revolutions).Degrees, RevolutionsTolerance);
            AssertEx.EqualTolerance(1, Angle.FromTilt(degree.Tilt).Degrees, TiltTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Angle v = Angle.FromDegrees(1);
            AssertEx.EqualTolerance(-1, -v.Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(2, (Angle.FromDegrees(3)-v).Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(2, (v + v).Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(10, (v*10).Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(10, (10*v).Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(2, (Angle.FromDegrees(10)/5).Degrees, DegreesTolerance);
            AssertEx.EqualTolerance(2, Angle.FromDegrees(10)/Angle.FromDegrees(5), DegreesTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Angle oneDegree = Angle.FromDegrees(1);
            Angle twoDegrees = Angle.FromDegrees(2);

            Assert.True(oneDegree < twoDegrees);
            Assert.True(oneDegree <= twoDegrees);
            Assert.True(twoDegrees > oneDegree);
            Assert.True(twoDegrees >= oneDegree);

            Assert.False(oneDegree > twoDegrees);
            Assert.False(oneDegree >= twoDegrees);
            Assert.False(twoDegrees < oneDegree);
            Assert.False(twoDegrees <= oneDegree);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.Equal(0, degree.CompareTo(degree));
            Assert.True(degree.CompareTo(Angle.Zero) > 0);
            Assert.True(Angle.Zero.CompareTo(degree) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.Throws<ArgumentException>(() => degree.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.Throws<ArgumentNullException>(() => degree.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = Angle.FromDegrees(1);
            var b = Angle.FromDegrees(2);

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
            var a = Angle.FromDegrees(1);
            var b = Angle.FromDegrees(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = Angle.FromDegrees(1);
            object b = Angle.FromDegrees(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = Angle.FromDegrees(1);
            Assert.True(v.Equals(Angle.FromDegrees(1), DegreesTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(Angle.Zero, DegreesTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = Angle.FromDegrees(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(Angle.FromDegrees(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.False(degree.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Angle degree = Angle.FromDegrees(1);
            Assert.False(degree.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(AngleUnit.Undefined, Angle.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(AngleUnit)).Cast<AngleUnit>();
            foreach(var unit in units)
            {
                if(unit == AngleUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(Angle.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 '", new Angle(1, AngleUnit.Arcminute).ToString());
                Assert.Equal("1 ″", new Angle(1, AngleUnit.Arcsecond).ToString());
                Assert.Equal("1 crad", new Angle(1, AngleUnit.Centiradian).ToString());
                Assert.Equal("1 drad", new Angle(1, AngleUnit.Deciradian).ToString());
                Assert.Equal("1 °", new Angle(1, AngleUnit.Degree).ToString());
                Assert.Equal("1 g", new Angle(1, AngleUnit.Gradian).ToString());
                Assert.Equal("1 µ°", new Angle(1, AngleUnit.Microdegree).ToString());
                Assert.Equal("1 µrad", new Angle(1, AngleUnit.Microradian).ToString());
                Assert.Equal("1 m°", new Angle(1, AngleUnit.Millidegree).ToString());
                Assert.Equal("1 mrad", new Angle(1, AngleUnit.Milliradian).ToString());
                Assert.Equal("1 n°", new Angle(1, AngleUnit.Nanodegree).ToString());
                Assert.Equal("1 nrad", new Angle(1, AngleUnit.Nanoradian).ToString());
                Assert.Equal("1 rad", new Angle(1, AngleUnit.Radian).ToString());
                Assert.Equal("1 r", new Angle(1, AngleUnit.Revolution).ToString());
                Assert.Equal("1 sin(θ)", new Angle(1, AngleUnit.Tilt).ToString());
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

            Assert.Equal("1 '", new Angle(1, AngleUnit.Arcminute).ToString(swedishCulture));
            Assert.Equal("1 ″", new Angle(1, AngleUnit.Arcsecond).ToString(swedishCulture));
            Assert.Equal("1 crad", new Angle(1, AngleUnit.Centiradian).ToString(swedishCulture));
            Assert.Equal("1 drad", new Angle(1, AngleUnit.Deciradian).ToString(swedishCulture));
            Assert.Equal("1 °", new Angle(1, AngleUnit.Degree).ToString(swedishCulture));
            Assert.Equal("1 g", new Angle(1, AngleUnit.Gradian).ToString(swedishCulture));
            Assert.Equal("1 µ°", new Angle(1, AngleUnit.Microdegree).ToString(swedishCulture));
            Assert.Equal("1 µrad", new Angle(1, AngleUnit.Microradian).ToString(swedishCulture));
            Assert.Equal("1 m°", new Angle(1, AngleUnit.Millidegree).ToString(swedishCulture));
            Assert.Equal("1 mrad", new Angle(1, AngleUnit.Milliradian).ToString(swedishCulture));
            Assert.Equal("1 n°", new Angle(1, AngleUnit.Nanodegree).ToString(swedishCulture));
            Assert.Equal("1 nrad", new Angle(1, AngleUnit.Nanoradian).ToString(swedishCulture));
            Assert.Equal("1 rad", new Angle(1, AngleUnit.Radian).ToString(swedishCulture));
            Assert.Equal("1 r", new Angle(1, AngleUnit.Revolution).ToString(swedishCulture));
            Assert.Equal("1 sin(θ)", new Angle(1, AngleUnit.Tilt).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 °", new Angle(0.123456, AngleUnit.Degree).ToString("s1"));
                Assert.Equal("0.12 °", new Angle(0.123456, AngleUnit.Degree).ToString("s2"));
                Assert.Equal("0.123 °", new Angle(0.123456, AngleUnit.Degree).ToString("s3"));
                Assert.Equal("0.1235 °", new Angle(0.123456, AngleUnit.Degree).ToString("s4"));
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
            Assert.Equal("0.1 °", new Angle(0.123456, AngleUnit.Degree).ToString("s1", culture));
            Assert.Equal("0.12 °", new Angle(0.123456, AngleUnit.Degree).ToString("s2", culture));
            Assert.Equal("0.123 °", new Angle(0.123456, AngleUnit.Degree).ToString("s3", culture));
            Assert.Equal("0.1235 °", new Angle(0.123456, AngleUnit.Degree).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = Angle.FromDegrees(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(Angle)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(AngleUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal(QuantityType.Angle, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal(Angle.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal(Angle.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = Angle.FromDegrees(1.0);
            Assert.Equal(new {Angle.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = Angle.FromDegrees(value);
            Assert.Equal(Angle.FromDegrees(-value), -quantity);
        }
    }
}
