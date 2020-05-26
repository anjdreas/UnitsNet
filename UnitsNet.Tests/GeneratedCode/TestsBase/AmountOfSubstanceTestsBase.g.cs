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
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of AmountOfSubstance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class AmountOfSubstanceTestsBase
    {
        protected abstract double CentimolesInOneMole { get; }
        protected abstract double CentipoundMolesInOneMole { get; }
        protected abstract double DecimolesInOneMole { get; }
        protected abstract double DecipoundMolesInOneMole { get; }
        protected abstract double KilomolesInOneMole { get; }
        protected abstract double KilopoundMolesInOneMole { get; }
        protected abstract double MegamolesInOneMole { get; }
        protected abstract double MicromolesInOneMole { get; }
        protected abstract double MicropoundMolesInOneMole { get; }
        protected abstract double MillimolesInOneMole { get; }
        protected abstract double MillipoundMolesInOneMole { get; }
        protected abstract double MolesInOneMole { get; }
        protected abstract double NanomolesInOneMole { get; }
        protected abstract double NanopoundMolesInOneMole { get; }
        protected abstract double PoundMolesInOneMole { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentimolesTolerance { get { return 1e-5; } }
        protected virtual double CentipoundMolesTolerance { get { return 1e-5; } }
        protected virtual double DecimolesTolerance { get { return 1e-5; } }
        protected virtual double DecipoundMolesTolerance { get { return 1e-5; } }
        protected virtual double KilomolesTolerance { get { return 1e-5; } }
        protected virtual double KilopoundMolesTolerance { get { return 1e-5; } }
        protected virtual double MegamolesTolerance { get { return 1e-5; } }
        protected virtual double MicromolesTolerance { get { return 1e-5; } }
        protected virtual double MicropoundMolesTolerance { get { return 1e-5; } }
        protected virtual double MillimolesTolerance { get { return 1e-5; } }
        protected virtual double MillipoundMolesTolerance { get { return 1e-5; } }
        protected virtual double MolesTolerance { get { return 1e-5; } }
        protected virtual double NanomolesTolerance { get { return 1e-5; } }
        protected virtual double NanopoundMolesTolerance { get { return 1e-5; } }
        protected virtual double PoundMolesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AmountOfSubstance((double)0.0, AmountOfSubstanceUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new AmountOfSubstance();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(AmountOfSubstanceUnit.Mole, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AmountOfSubstance(double.PositiveInfinity, AmountOfSubstanceUnit.Mole));
            Assert.Throws<ArgumentException>(() => new AmountOfSubstance(double.NegativeInfinity, AmountOfSubstanceUnit.Mole));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new AmountOfSubstance(double.NaN, AmountOfSubstanceUnit.Mole));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new AmountOfSubstance(value: 1.0, unitSystem: null));
        }

        [Fact]
        public void AmountOfSubstance_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new AmountOfSubstance(1, AmountOfSubstanceUnit.Mole);

            QuantityInfo<AmountOfSubstanceUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(AmountOfSubstance.Zero, quantityInfo.Zero);
            Assert.Equal("AmountOfSubstance", quantityInfo.Name);
            Assert.Equal(QuantityType.AmountOfSubstance, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<AmountOfSubstanceUnit>().Except(new[] {AmountOfSubstanceUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
#pragma warning disable 618
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
#pragma warning restore 618
        }

        [Fact]
        public void MoleToAmountOfSubstanceUnits()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            AssertEx.EqualTolerance(CentimolesInOneMole, mole.Centimoles, CentimolesTolerance);
            AssertEx.EqualTolerance(CentipoundMolesInOneMole, mole.CentipoundMoles, CentipoundMolesTolerance);
            AssertEx.EqualTolerance(DecimolesInOneMole, mole.Decimoles, DecimolesTolerance);
            AssertEx.EqualTolerance(DecipoundMolesInOneMole, mole.DecipoundMoles, DecipoundMolesTolerance);
            AssertEx.EqualTolerance(KilomolesInOneMole, mole.Kilomoles, KilomolesTolerance);
            AssertEx.EqualTolerance(KilopoundMolesInOneMole, mole.KilopoundMoles, KilopoundMolesTolerance);
            AssertEx.EqualTolerance(MegamolesInOneMole, mole.Megamoles, MegamolesTolerance);
            AssertEx.EqualTolerance(MicromolesInOneMole, mole.Micromoles, MicromolesTolerance);
            AssertEx.EqualTolerance(MicropoundMolesInOneMole, mole.MicropoundMoles, MicropoundMolesTolerance);
            AssertEx.EqualTolerance(MillimolesInOneMole, mole.Millimoles, MillimolesTolerance);
            AssertEx.EqualTolerance(MillipoundMolesInOneMole, mole.MillipoundMoles, MillipoundMolesTolerance);
            AssertEx.EqualTolerance(MolesInOneMole, mole.Moles, MolesTolerance);
            AssertEx.EqualTolerance(NanomolesInOneMole, mole.Nanomoles, NanomolesTolerance);
            AssertEx.EqualTolerance(NanopoundMolesInOneMole, mole.NanopoundMoles, NanopoundMolesTolerance);
            AssertEx.EqualTolerance(PoundMolesInOneMole, mole.PoundMoles, PoundMolesTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Centimole);
            AssertEx.EqualTolerance(1, quantity00.Centimoles, CentimolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Centimole, quantity00.Unit);

            var quantity01 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.CentipoundMole);
            AssertEx.EqualTolerance(1, quantity01.CentipoundMoles, CentipoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.CentipoundMole, quantity01.Unit);

            var quantity02 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Decimole);
            AssertEx.EqualTolerance(1, quantity02.Decimoles, DecimolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Decimole, quantity02.Unit);

            var quantity03 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.DecipoundMole);
            AssertEx.EqualTolerance(1, quantity03.DecipoundMoles, DecipoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.DecipoundMole, quantity03.Unit);

            var quantity04 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Kilomole);
            AssertEx.EqualTolerance(1, quantity04.Kilomoles, KilomolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Kilomole, quantity04.Unit);

            var quantity05 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.KilopoundMole);
            AssertEx.EqualTolerance(1, quantity05.KilopoundMoles, KilopoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.KilopoundMole, quantity05.Unit);

            var quantity06 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Megamole);
            AssertEx.EqualTolerance(1, quantity06.Megamoles, MegamolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Megamole, quantity06.Unit);

            var quantity07 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Micromole);
            AssertEx.EqualTolerance(1, quantity07.Micromoles, MicromolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Micromole, quantity07.Unit);

            var quantity08 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.MicropoundMole);
            AssertEx.EqualTolerance(1, quantity08.MicropoundMoles, MicropoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.MicropoundMole, quantity08.Unit);

            var quantity09 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Millimole);
            AssertEx.EqualTolerance(1, quantity09.Millimoles, MillimolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Millimole, quantity09.Unit);

            var quantity10 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.MillipoundMole);
            AssertEx.EqualTolerance(1, quantity10.MillipoundMoles, MillipoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.MillipoundMole, quantity10.Unit);

            var quantity11 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Mole);
            AssertEx.EqualTolerance(1, quantity11.Moles, MolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Mole, quantity11.Unit);

            var quantity12 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.Nanomole);
            AssertEx.EqualTolerance(1, quantity12.Nanomoles, NanomolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Nanomole, quantity12.Unit);

            var quantity13 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.NanopoundMole);
            AssertEx.EqualTolerance(1, quantity13.NanopoundMoles, NanopoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.NanopoundMole, quantity13.Unit);

            var quantity14 = AmountOfSubstance.From(1, AmountOfSubstanceUnit.PoundMole);
            AssertEx.EqualTolerance(1, quantity14.PoundMoles, PoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.PoundMole, quantity14.Unit);

        }

        [Fact]
        public void FromMoles_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AmountOfSubstance.FromMoles(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => AmountOfSubstance.FromMoles(double.NegativeInfinity));
        }

        [Fact]
        public void FromMoles_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => AmountOfSubstance.FromMoles(double.NaN));
        }

        [Fact]
        public void As()
        {
            var mole = AmountOfSubstance.FromMoles(1);
            AssertEx.EqualTolerance(CentimolesInOneMole, mole.As(AmountOfSubstanceUnit.Centimole), CentimolesTolerance);
            AssertEx.EqualTolerance(CentipoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.CentipoundMole), CentipoundMolesTolerance);
            AssertEx.EqualTolerance(DecimolesInOneMole, mole.As(AmountOfSubstanceUnit.Decimole), DecimolesTolerance);
            AssertEx.EqualTolerance(DecipoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.DecipoundMole), DecipoundMolesTolerance);
            AssertEx.EqualTolerance(KilomolesInOneMole, mole.As(AmountOfSubstanceUnit.Kilomole), KilomolesTolerance);
            AssertEx.EqualTolerance(KilopoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.KilopoundMole), KilopoundMolesTolerance);
            AssertEx.EqualTolerance(MegamolesInOneMole, mole.As(AmountOfSubstanceUnit.Megamole), MegamolesTolerance);
            AssertEx.EqualTolerance(MicromolesInOneMole, mole.As(AmountOfSubstanceUnit.Micromole), MicromolesTolerance);
            AssertEx.EqualTolerance(MicropoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.MicropoundMole), MicropoundMolesTolerance);
            AssertEx.EqualTolerance(MillimolesInOneMole, mole.As(AmountOfSubstanceUnit.Millimole), MillimolesTolerance);
            AssertEx.EqualTolerance(MillipoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.MillipoundMole), MillipoundMolesTolerance);
            AssertEx.EqualTolerance(MolesInOneMole, mole.As(AmountOfSubstanceUnit.Mole), MolesTolerance);
            AssertEx.EqualTolerance(NanomolesInOneMole, mole.As(AmountOfSubstanceUnit.Nanomole), NanomolesTolerance);
            AssertEx.EqualTolerance(NanopoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.NanopoundMole), NanopoundMolesTolerance);
            AssertEx.EqualTolerance(PoundMolesInOneMole, mole.As(AmountOfSubstanceUnit.PoundMole), PoundMolesTolerance);
        }

        [Fact]
        public void ToUnit()
        {
            var mole = AmountOfSubstance.FromMoles(1);

            var centimoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Centimole);
            AssertEx.EqualTolerance(CentimolesInOneMole, (double)centimoleQuantity.Value, CentimolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Centimole, centimoleQuantity.Unit);

            var centipoundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.CentipoundMole);
            AssertEx.EqualTolerance(CentipoundMolesInOneMole, (double)centipoundmoleQuantity.Value, CentipoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.CentipoundMole, centipoundmoleQuantity.Unit);

            var decimoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Decimole);
            AssertEx.EqualTolerance(DecimolesInOneMole, (double)decimoleQuantity.Value, DecimolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Decimole, decimoleQuantity.Unit);

            var decipoundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.DecipoundMole);
            AssertEx.EqualTolerance(DecipoundMolesInOneMole, (double)decipoundmoleQuantity.Value, DecipoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.DecipoundMole, decipoundmoleQuantity.Unit);

            var kilomoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Kilomole);
            AssertEx.EqualTolerance(KilomolesInOneMole, (double)kilomoleQuantity.Value, KilomolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Kilomole, kilomoleQuantity.Unit);

            var kilopoundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.KilopoundMole);
            AssertEx.EqualTolerance(KilopoundMolesInOneMole, (double)kilopoundmoleQuantity.Value, KilopoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.KilopoundMole, kilopoundmoleQuantity.Unit);

            var megamoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Megamole);
            AssertEx.EqualTolerance(MegamolesInOneMole, (double)megamoleQuantity.Value, MegamolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Megamole, megamoleQuantity.Unit);

            var micromoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Micromole);
            AssertEx.EqualTolerance(MicromolesInOneMole, (double)micromoleQuantity.Value, MicromolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Micromole, micromoleQuantity.Unit);

            var micropoundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.MicropoundMole);
            AssertEx.EqualTolerance(MicropoundMolesInOneMole, (double)micropoundmoleQuantity.Value, MicropoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.MicropoundMole, micropoundmoleQuantity.Unit);

            var millimoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Millimole);
            AssertEx.EqualTolerance(MillimolesInOneMole, (double)millimoleQuantity.Value, MillimolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Millimole, millimoleQuantity.Unit);

            var millipoundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.MillipoundMole);
            AssertEx.EqualTolerance(MillipoundMolesInOneMole, (double)millipoundmoleQuantity.Value, MillipoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.MillipoundMole, millipoundmoleQuantity.Unit);

            var moleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Mole);
            AssertEx.EqualTolerance(MolesInOneMole, (double)moleQuantity.Value, MolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Mole, moleQuantity.Unit);

            var nanomoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.Nanomole);
            AssertEx.EqualTolerance(NanomolesInOneMole, (double)nanomoleQuantity.Value, NanomolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.Nanomole, nanomoleQuantity.Unit);

            var nanopoundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.NanopoundMole);
            AssertEx.EqualTolerance(NanopoundMolesInOneMole, (double)nanopoundmoleQuantity.Value, NanopoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.NanopoundMole, nanopoundmoleQuantity.Unit);

            var poundmoleQuantity = mole.ToUnit(AmountOfSubstanceUnit.PoundMole);
            AssertEx.EqualTolerance(PoundMolesInOneMole, (double)poundmoleQuantity.Value, PoundMolesTolerance);
            Assert.Equal(AmountOfSubstanceUnit.PoundMole, poundmoleQuantity.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromCentimoles(mole.Centimoles).Moles, CentimolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromCentipoundMoles(mole.CentipoundMoles).Moles, CentipoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromDecimoles(mole.Decimoles).Moles, DecimolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromDecipoundMoles(mole.DecipoundMoles).Moles, DecipoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromKilomoles(mole.Kilomoles).Moles, KilomolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromKilopoundMoles(mole.KilopoundMoles).Moles, KilopoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromMegamoles(mole.Megamoles).Moles, MegamolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromMicromoles(mole.Micromoles).Moles, MicromolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromMicropoundMoles(mole.MicropoundMoles).Moles, MicropoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromMillimoles(mole.Millimoles).Moles, MillimolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromMillipoundMoles(mole.MillipoundMoles).Moles, MillipoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromMoles(mole.Moles).Moles, MolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromNanomoles(mole.Nanomoles).Moles, NanomolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromNanopoundMoles(mole.NanopoundMoles).Moles, NanopoundMolesTolerance);
            AssertEx.EqualTolerance(1, AmountOfSubstance.FromPoundMoles(mole.PoundMoles).Moles, PoundMolesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            AmountOfSubstance v = AmountOfSubstance.FromMoles(1);
            AssertEx.EqualTolerance(-1, -v.Moles, MolesTolerance);
            AssertEx.EqualTolerance(2, (AmountOfSubstance.FromMoles(3)-v).Moles, MolesTolerance);
            AssertEx.EqualTolerance(2, (v + v).Moles, MolesTolerance);
            AssertEx.EqualTolerance(10, (v*10).Moles, MolesTolerance);
            AssertEx.EqualTolerance(10, (10*v).Moles, MolesTolerance);
            AssertEx.EqualTolerance(2, (AmountOfSubstance.FromMoles(10)/5).Moles, MolesTolerance);
            AssertEx.EqualTolerance(2, AmountOfSubstance.FromMoles(10)/AmountOfSubstance.FromMoles(5), MolesTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            AmountOfSubstance oneMole = AmountOfSubstance.FromMoles(1);
            AmountOfSubstance twoMoles = AmountOfSubstance.FromMoles(2);

            Assert.True(oneMole < twoMoles);
            Assert.True(oneMole <= twoMoles);
            Assert.True(twoMoles > oneMole);
            Assert.True(twoMoles >= oneMole);

            Assert.False(oneMole > twoMoles);
            Assert.False(oneMole >= twoMoles);
            Assert.False(twoMoles < oneMole);
            Assert.False(twoMoles <= oneMole);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            Assert.Equal(0, mole.CompareTo(mole));
            Assert.True(mole.CompareTo(AmountOfSubstance.Zero) > 0);
            Assert.True(AmountOfSubstance.Zero.CompareTo(mole) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            Assert.Throws<ArgumentException>(() => mole.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            Assert.Throws<ArgumentNullException>(() => mole.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = AmountOfSubstance.FromMoles(1);
            var b = AmountOfSubstance.FromMoles(2);

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
            var a = AmountOfSubstance.FromMoles(1);
            var b = AmountOfSubstance.FromMoles(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals(null));
        }

        [Fact]
        public void EqualsRelativeToleranceIsImplemented()
        {
            var v = AmountOfSubstance.FromMoles(1);
            Assert.True(v.Equals(AmountOfSubstance.FromMoles(1), MolesTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(AmountOfSubstance.Zero, MolesTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            Assert.False(mole.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            AmountOfSubstance mole = AmountOfSubstance.FromMoles(1);
            Assert.False(mole.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(AmountOfSubstanceUnit.Undefined, AmountOfSubstance.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(AmountOfSubstanceUnit)).Cast<AmountOfSubstanceUnit>();
            foreach(var unit in units)
            {
                if(unit == AmountOfSubstanceUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(AmountOfSubstance.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Centimole).ToString());
                Assert.Equal("1 clbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.CentipoundMole).ToString());
                Assert.Equal("1 dmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Decimole).ToString());
                Assert.Equal("1 dlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.DecipoundMole).ToString());
                Assert.Equal("1 kmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Kilomole).ToString());
                Assert.Equal("1 klbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.KilopoundMole).ToString());
                Assert.Equal("1 Mmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Megamole).ToString());
                Assert.Equal("1 µmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Micromole).ToString());
                Assert.Equal("1 µlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.MicropoundMole).ToString());
                Assert.Equal("1 mmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Millimole).ToString());
                Assert.Equal("1 mlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.MillipoundMole).ToString());
                Assert.Equal("1 mol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Mole).ToString());
                Assert.Equal("1 nmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Nanomole).ToString());
                Assert.Equal("1 nlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.NanopoundMole).ToString());
                Assert.Equal("1 lbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.PoundMole).ToString());
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

            Assert.Equal("1 cmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Centimole).ToString(swedishCulture));
            Assert.Equal("1 clbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.CentipoundMole).ToString(swedishCulture));
            Assert.Equal("1 dmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Decimole).ToString(swedishCulture));
            Assert.Equal("1 dlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.DecipoundMole).ToString(swedishCulture));
            Assert.Equal("1 kmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Kilomole).ToString(swedishCulture));
            Assert.Equal("1 klbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.KilopoundMole).ToString(swedishCulture));
            Assert.Equal("1 Mmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Megamole).ToString(swedishCulture));
            Assert.Equal("1 µmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Micromole).ToString(swedishCulture));
            Assert.Equal("1 µlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.MicropoundMole).ToString(swedishCulture));
            Assert.Equal("1 mmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Millimole).ToString(swedishCulture));
            Assert.Equal("1 mlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.MillipoundMole).ToString(swedishCulture));
            Assert.Equal("1 mol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Mole).ToString(swedishCulture));
            Assert.Equal("1 nmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.Nanomole).ToString(swedishCulture));
            Assert.Equal("1 nlbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.NanopoundMole).ToString(swedishCulture));
            Assert.Equal("1 lbmol", new AmountOfSubstance(1, AmountOfSubstanceUnit.PoundMole).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s1"));
                Assert.Equal("0.12 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s2"));
                Assert.Equal("0.123 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s3"));
                Assert.Equal("0.1235 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s4"));
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
            Assert.Equal("0.1 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s1", culture));
            Assert.Equal("0.12 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s2", culture));
            Assert.Equal("0.123 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s3", culture));
            Assert.Equal("0.1235 mol", new AmountOfSubstance(0.123456, AmountOfSubstanceUnit.Mole).ToString("s4", culture));
        }

        #pragma warning disable 612, 618

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = AmountOfSubstance.FromMoles(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        #pragma warning restore 612, 618
    }
}
