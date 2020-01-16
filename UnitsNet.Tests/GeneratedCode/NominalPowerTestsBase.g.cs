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
    /// Test of NominalPower.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class NominalPowerTestsBase
    {
        protected abstract double DecawattsPeakInOneWattPeak { get; }
        protected abstract double DeciwattsPeakInOneWattPeak { get; }
        protected abstract double FemtowattsPeakInOneWattPeak { get; }
        protected abstract double GigawattsPeakInOneWattPeak { get; }
        protected abstract double KilowattsPeakInOneWattPeak { get; }
        protected abstract double MegawattsPeakInOneWattPeak { get; }
        protected abstract double MicrowattsPeakInOneWattPeak { get; }
        protected abstract double MilliwattsPeakInOneWattPeak { get; }
        protected abstract double NanowattsPeakInOneWattPeak { get; }
        protected abstract double PetawattsPeakInOneWattPeak { get; }
        protected abstract double PicowattsPeakInOneWattPeak { get; }
        protected abstract double TerawattsPeakInOneWattPeak { get; }
        protected abstract double WattsPeakInOneWattPeak { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecawattsPeakTolerance { get { return 1e-5; } }
        protected virtual double DeciwattsPeakTolerance { get { return 1e-5; } }
        protected virtual double FemtowattsPeakTolerance { get { return 1e-5; } }
        protected virtual double GigawattsPeakTolerance { get { return 1e-5; } }
        protected virtual double KilowattsPeakTolerance { get { return 1e-5; } }
        protected virtual double MegawattsPeakTolerance { get { return 1e-5; } }
        protected virtual double MicrowattsPeakTolerance { get { return 1e-5; } }
        protected virtual double MilliwattsPeakTolerance { get { return 1e-5; } }
        protected virtual double NanowattsPeakTolerance { get { return 1e-5; } }
        protected virtual double PetawattsPeakTolerance { get { return 1e-5; } }
        protected virtual double PicowattsPeakTolerance { get { return 1e-5; } }
        protected virtual double TerawattsPeakTolerance { get { return 1e-5; } }
        protected virtual double WattsPeakTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new NominalPower((decimal)0.0, NominalPowerUnit.Undefined));
        }

        [Fact]
        public void WattPeakToNominalPowerUnits()
        {
            NominalPower wattpeak = NominalPower.FromWattsPeak(1);
            AssertEx.EqualTolerance(DecawattsPeakInOneWattPeak, wattpeak.DecawattsPeak, DecawattsPeakTolerance);
            AssertEx.EqualTolerance(DeciwattsPeakInOneWattPeak, wattpeak.DeciwattsPeak, DeciwattsPeakTolerance);
            AssertEx.EqualTolerance(FemtowattsPeakInOneWattPeak, wattpeak.FemtowattsPeak, FemtowattsPeakTolerance);
            AssertEx.EqualTolerance(GigawattsPeakInOneWattPeak, wattpeak.GigawattsPeak, GigawattsPeakTolerance);
            AssertEx.EqualTolerance(KilowattsPeakInOneWattPeak, wattpeak.KilowattsPeak, KilowattsPeakTolerance);
            AssertEx.EqualTolerance(MegawattsPeakInOneWattPeak, wattpeak.MegawattsPeak, MegawattsPeakTolerance);
            AssertEx.EqualTolerance(MicrowattsPeakInOneWattPeak, wattpeak.MicrowattsPeak, MicrowattsPeakTolerance);
            AssertEx.EqualTolerance(MilliwattsPeakInOneWattPeak, wattpeak.MilliwattsPeak, MilliwattsPeakTolerance);
            AssertEx.EqualTolerance(NanowattsPeakInOneWattPeak, wattpeak.NanowattsPeak, NanowattsPeakTolerance);
            AssertEx.EqualTolerance(PetawattsPeakInOneWattPeak, wattpeak.PetawattsPeak, PetawattsPeakTolerance);
            AssertEx.EqualTolerance(PicowattsPeakInOneWattPeak, wattpeak.PicowattsPeak, PicowattsPeakTolerance);
            AssertEx.EqualTolerance(TerawattsPeakInOneWattPeak, wattpeak.TerawattsPeak, TerawattsPeakTolerance);
            AssertEx.EqualTolerance(WattsPeakInOneWattPeak, wattpeak.WattsPeak, WattsPeakTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, NominalPower.From(1, NominalPowerUnit.DecawattPeak).DecawattsPeak, DecawattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.From(1, NominalPowerUnit.DeciwattPeak).DeciwattsPeak, DeciwattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.From(1, NominalPowerUnit.FemtowattPeak).FemtowattsPeak, FemtowattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.From(1, NominalPowerUnit.GigawattPeak).GigawattsPeak, GigawattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.From(1, NominalPowerUnit.KilowattPeak).KilowattsPeak, KilowattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.From(1, NominalPowerUnit.MegawattPeak).MegawattsPeak, MegawattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.From(1, NominalPowerUnit.MicrowattPeak).MicrowattsPeak, MicrowattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.From(1, NominalPowerUnit.MilliwattPeak).MilliwattsPeak, MilliwattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.From(1, NominalPowerUnit.NanowattPeak).NanowattsPeak, NanowattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.From(1, NominalPowerUnit.PetawattPeak).PetawattsPeak, PetawattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.From(1, NominalPowerUnit.PicowattPeak).PicowattsPeak, PicowattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.From(1, NominalPowerUnit.TerawattPeak).TerawattsPeak, TerawattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.From(1, NominalPowerUnit.WattPeak).WattsPeak, WattsPeakTolerance);
        }

        [Fact]
        public void As()
        {
            var wattpeak = NominalPower.FromWattsPeak(1);
            AssertEx.EqualTolerance(DecawattsPeakInOneWattPeak, wattpeak.As(NominalPowerUnit.DecawattPeak), DecawattsPeakTolerance);
            AssertEx.EqualTolerance(DeciwattsPeakInOneWattPeak, wattpeak.As(NominalPowerUnit.DeciwattPeak), DeciwattsPeakTolerance);
            AssertEx.EqualTolerance(FemtowattsPeakInOneWattPeak, wattpeak.As(NominalPowerUnit.FemtowattPeak), FemtowattsPeakTolerance);
            AssertEx.EqualTolerance(GigawattsPeakInOneWattPeak, wattpeak.As(NominalPowerUnit.GigawattPeak), GigawattsPeakTolerance);
            AssertEx.EqualTolerance(KilowattsPeakInOneWattPeak, wattpeak.As(NominalPowerUnit.KilowattPeak), KilowattsPeakTolerance);
            AssertEx.EqualTolerance(MegawattsPeakInOneWattPeak, wattpeak.As(NominalPowerUnit.MegawattPeak), MegawattsPeakTolerance);
            AssertEx.EqualTolerance(MicrowattsPeakInOneWattPeak, wattpeak.As(NominalPowerUnit.MicrowattPeak), MicrowattsPeakTolerance);
            AssertEx.EqualTolerance(MilliwattsPeakInOneWattPeak, wattpeak.As(NominalPowerUnit.MilliwattPeak), MilliwattsPeakTolerance);
            AssertEx.EqualTolerance(NanowattsPeakInOneWattPeak, wattpeak.As(NominalPowerUnit.NanowattPeak), NanowattsPeakTolerance);
            AssertEx.EqualTolerance(PetawattsPeakInOneWattPeak, wattpeak.As(NominalPowerUnit.PetawattPeak), PetawattsPeakTolerance);
            AssertEx.EqualTolerance(PicowattsPeakInOneWattPeak, wattpeak.As(NominalPowerUnit.PicowattPeak), PicowattsPeakTolerance);
            AssertEx.EqualTolerance(TerawattsPeakInOneWattPeak, wattpeak.As(NominalPowerUnit.TerawattPeak), TerawattsPeakTolerance);
            AssertEx.EqualTolerance(WattsPeakInOneWattPeak, wattpeak.As(NominalPowerUnit.WattPeak), WattsPeakTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var wattpeak = NominalPower.FromWattsPeak(1);

            var decawattpeakQuantity = wattpeak.ToUnit(NominalPowerUnit.DecawattPeak);
            AssertEx.EqualTolerance(DecawattsPeakInOneWattPeak, (double)decawattpeakQuantity.Value, DecawattsPeakTolerance);
            Assert.Equal(NominalPowerUnit.DecawattPeak, decawattpeakQuantity.Unit);

            var deciwattpeakQuantity = wattpeak.ToUnit(NominalPowerUnit.DeciwattPeak);
            AssertEx.EqualTolerance(DeciwattsPeakInOneWattPeak, (double)deciwattpeakQuantity.Value, DeciwattsPeakTolerance);
            Assert.Equal(NominalPowerUnit.DeciwattPeak, deciwattpeakQuantity.Unit);

            var femtowattpeakQuantity = wattpeak.ToUnit(NominalPowerUnit.FemtowattPeak);
            AssertEx.EqualTolerance(FemtowattsPeakInOneWattPeak, (double)femtowattpeakQuantity.Value, FemtowattsPeakTolerance);
            Assert.Equal(NominalPowerUnit.FemtowattPeak, femtowattpeakQuantity.Unit);

            var gigawattpeakQuantity = wattpeak.ToUnit(NominalPowerUnit.GigawattPeak);
            AssertEx.EqualTolerance(GigawattsPeakInOneWattPeak, (double)gigawattpeakQuantity.Value, GigawattsPeakTolerance);
            Assert.Equal(NominalPowerUnit.GigawattPeak, gigawattpeakQuantity.Unit);

            var kilowattpeakQuantity = wattpeak.ToUnit(NominalPowerUnit.KilowattPeak);
            AssertEx.EqualTolerance(KilowattsPeakInOneWattPeak, (double)kilowattpeakQuantity.Value, KilowattsPeakTolerance);
            Assert.Equal(NominalPowerUnit.KilowattPeak, kilowattpeakQuantity.Unit);

            var megawattpeakQuantity = wattpeak.ToUnit(NominalPowerUnit.MegawattPeak);
            AssertEx.EqualTolerance(MegawattsPeakInOneWattPeak, (double)megawattpeakQuantity.Value, MegawattsPeakTolerance);
            Assert.Equal(NominalPowerUnit.MegawattPeak, megawattpeakQuantity.Unit);

            var microwattpeakQuantity = wattpeak.ToUnit(NominalPowerUnit.MicrowattPeak);
            AssertEx.EqualTolerance(MicrowattsPeakInOneWattPeak, (double)microwattpeakQuantity.Value, MicrowattsPeakTolerance);
            Assert.Equal(NominalPowerUnit.MicrowattPeak, microwattpeakQuantity.Unit);

            var milliwattpeakQuantity = wattpeak.ToUnit(NominalPowerUnit.MilliwattPeak);
            AssertEx.EqualTolerance(MilliwattsPeakInOneWattPeak, (double)milliwattpeakQuantity.Value, MilliwattsPeakTolerance);
            Assert.Equal(NominalPowerUnit.MilliwattPeak, milliwattpeakQuantity.Unit);

            var nanowattpeakQuantity = wattpeak.ToUnit(NominalPowerUnit.NanowattPeak);
            AssertEx.EqualTolerance(NanowattsPeakInOneWattPeak, (double)nanowattpeakQuantity.Value, NanowattsPeakTolerance);
            Assert.Equal(NominalPowerUnit.NanowattPeak, nanowattpeakQuantity.Unit);

            var petawattpeakQuantity = wattpeak.ToUnit(NominalPowerUnit.PetawattPeak);
            AssertEx.EqualTolerance(PetawattsPeakInOneWattPeak, (double)petawattpeakQuantity.Value, PetawattsPeakTolerance);
            Assert.Equal(NominalPowerUnit.PetawattPeak, petawattpeakQuantity.Unit);

            var picowattpeakQuantity = wattpeak.ToUnit(NominalPowerUnit.PicowattPeak);
            AssertEx.EqualTolerance(PicowattsPeakInOneWattPeak, (double)picowattpeakQuantity.Value, PicowattsPeakTolerance);
            Assert.Equal(NominalPowerUnit.PicowattPeak, picowattpeakQuantity.Unit);

            var terawattpeakQuantity = wattpeak.ToUnit(NominalPowerUnit.TerawattPeak);
            AssertEx.EqualTolerance(TerawattsPeakInOneWattPeak, (double)terawattpeakQuantity.Value, TerawattsPeakTolerance);
            Assert.Equal(NominalPowerUnit.TerawattPeak, terawattpeakQuantity.Unit);

            var wattpeakQuantity = wattpeak.ToUnit(NominalPowerUnit.WattPeak);
            AssertEx.EqualTolerance(WattsPeakInOneWattPeak, (double)wattpeakQuantity.Value, WattsPeakTolerance);
            Assert.Equal(NominalPowerUnit.WattPeak, wattpeakQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            NominalPower wattpeak = NominalPower.FromWattsPeak(1);
            AssertEx.EqualTolerance(1, NominalPower.FromDecawattsPeak(wattpeak.DecawattsPeak).WattsPeak, DecawattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.FromDeciwattsPeak(wattpeak.DeciwattsPeak).WattsPeak, DeciwattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.FromFemtowattsPeak(wattpeak.FemtowattsPeak).WattsPeak, FemtowattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.FromGigawattsPeak(wattpeak.GigawattsPeak).WattsPeak, GigawattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.FromKilowattsPeak(wattpeak.KilowattsPeak).WattsPeak, KilowattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.FromMegawattsPeak(wattpeak.MegawattsPeak).WattsPeak, MegawattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.FromMicrowattsPeak(wattpeak.MicrowattsPeak).WattsPeak, MicrowattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.FromMilliwattsPeak(wattpeak.MilliwattsPeak).WattsPeak, MilliwattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.FromNanowattsPeak(wattpeak.NanowattsPeak).WattsPeak, NanowattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.FromPetawattsPeak(wattpeak.PetawattsPeak).WattsPeak, PetawattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.FromPicowattsPeak(wattpeak.PicowattsPeak).WattsPeak, PicowattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.FromTerawattsPeak(wattpeak.TerawattsPeak).WattsPeak, TerawattsPeakTolerance);
            AssertEx.EqualTolerance(1, NominalPower.FromWattsPeak(wattpeak.WattsPeak).WattsPeak, WattsPeakTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            NominalPower v = NominalPower.FromWattsPeak(1);
            AssertEx.EqualTolerance(-1, -v.WattsPeak, WattsPeakTolerance);
            AssertEx.EqualTolerance(2, (NominalPower.FromWattsPeak(3)-v).WattsPeak, WattsPeakTolerance);
            AssertEx.EqualTolerance(2, (v + v).WattsPeak, WattsPeakTolerance);
            AssertEx.EqualTolerance(10, (v*10).WattsPeak, WattsPeakTolerance);
            AssertEx.EqualTolerance(10, (10*v).WattsPeak, WattsPeakTolerance);
            AssertEx.EqualTolerance(2, (NominalPower.FromWattsPeak(10)/5).WattsPeak, WattsPeakTolerance);
            AssertEx.EqualTolerance(2, NominalPower.FromWattsPeak(10)/NominalPower.FromWattsPeak(5), WattsPeakTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            NominalPower oneWattPeak = NominalPower.FromWattsPeak(1);
            NominalPower twoWattsPeak = NominalPower.FromWattsPeak(2);

            Assert.True(oneWattPeak < twoWattsPeak);
            Assert.True(oneWattPeak <= twoWattsPeak);
            Assert.True(twoWattsPeak > oneWattPeak);
            Assert.True(twoWattsPeak >= oneWattPeak);

            Assert.False(oneWattPeak > twoWattsPeak);
            Assert.False(oneWattPeak >= twoWattsPeak);
            Assert.False(twoWattsPeak < oneWattPeak);
            Assert.False(twoWattsPeak <= oneWattPeak);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            NominalPower wattpeak = NominalPower.FromWattsPeak(1);
            Assert.Equal(0, wattpeak.CompareTo(wattpeak));
            Assert.True(wattpeak.CompareTo(NominalPower.Zero) > 0);
            Assert.True(NominalPower.Zero.CompareTo(wattpeak) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            NominalPower wattpeak = NominalPower.FromWattsPeak(1);
            Assert.Throws<ArgumentException>(() => wattpeak.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            NominalPower wattpeak = NominalPower.FromWattsPeak(1);
            Assert.Throws<ArgumentNullException>(() => wattpeak.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = NominalPower.FromWattsPeak(1);
            var b = NominalPower.FromWattsPeak(2);

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
            var a = NominalPower.FromWattsPeak(1);
            var b = NominalPower.FromWattsPeak(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = NominalPower.FromWattsPeak(1);
            Assert.True(v.Equals(NominalPower.FromWattsPeak(1), WattsPeakTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(NominalPower.Zero, WattsPeakTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            NominalPower wattpeak = NominalPower.FromWattsPeak(1);
            Assert.False(wattpeak.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            NominalPower wattpeak = NominalPower.FromWattsPeak(1);
            Assert.False(wattpeak.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(NominalPowerUnit.Undefined, NominalPower.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(NominalPowerUnit)).Cast<NominalPowerUnit>();
            foreach(var unit in units)
            {
                if(unit == NominalPowerUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(NominalPower.BaseDimensions is null);
        }
    }
}