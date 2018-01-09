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
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ReactiveEnergy.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ReactiveEnergyTestsBase
    {
        protected abstract double KilovoltamperesReactiveHourInOneVoltampereReactiveHour { get; }
        protected abstract double MegavoltamperesReactiveHourInOneVoltampereReactiveHour { get; }
        protected abstract double VoltamperesReactiveHourInOneVoltampereReactiveHour { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double KilovoltamperesReactiveHourTolerance { get { return 1e-5; } }
        protected virtual double MegavoltamperesReactiveHourTolerance { get { return 1e-5; } }
        protected virtual double VoltamperesReactiveHourTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void VoltampereReactiveHourToReactiveEnergyUnits()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltamperesReactiveHour(1);
            AssertEx.EqualTolerance(KilovoltamperesReactiveHourInOneVoltampereReactiveHour, voltamperereactivehour.KilovoltamperesReactiveHour, KilovoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(MegavoltamperesReactiveHourInOneVoltampereReactiveHour, voltamperereactivehour.MegavoltamperesReactiveHour, MegavoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(VoltamperesReactiveHourInOneVoltampereReactiveHour, voltamperereactivehour.VoltamperesReactiveHour, VoltamperesReactiveHourTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ReactiveEnergy.From(1, ReactiveEnergyUnit.KilovoltampereReactiveHour).KilovoltamperesReactiveHour, KilovoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(1, ReactiveEnergy.From(1, ReactiveEnergyUnit.MegavoltampereReactiveHour).MegavoltamperesReactiveHour, MegavoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(1, ReactiveEnergy.From(1, ReactiveEnergyUnit.VoltampereReactiveHour).VoltamperesReactiveHour, VoltamperesReactiveHourTolerance);
        }

        [Fact]
        public void As()
        {
            var voltamperereactivehour = ReactiveEnergy.FromVoltamperesReactiveHour(1);
            AssertEx.EqualTolerance(KilovoltamperesReactiveHourInOneVoltampereReactiveHour, voltamperereactivehour.As(ReactiveEnergyUnit.KilovoltampereReactiveHour), KilovoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(MegavoltamperesReactiveHourInOneVoltampereReactiveHour, voltamperereactivehour.As(ReactiveEnergyUnit.MegavoltampereReactiveHour), MegavoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(VoltamperesReactiveHourInOneVoltampereReactiveHour, voltamperereactivehour.As(ReactiveEnergyUnit.VoltampereReactiveHour), VoltamperesReactiveHourTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltamperesReactiveHour(1);
            AssertEx.EqualTolerance(1, ReactiveEnergy.FromKilovoltamperesReactiveHour(voltamperereactivehour.KilovoltamperesReactiveHour).VoltamperesReactiveHour, KilovoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(1, ReactiveEnergy.FromMegavoltamperesReactiveHour(voltamperereactivehour.MegavoltamperesReactiveHour).VoltamperesReactiveHour, MegavoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(1, ReactiveEnergy.FromVoltamperesReactiveHour(voltamperereactivehour.VoltamperesReactiveHour).VoltamperesReactiveHour, VoltamperesReactiveHourTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ReactiveEnergy v = ReactiveEnergy.FromVoltamperesReactiveHour(1);
            AssertEx.EqualTolerance(-1, -v.VoltamperesReactiveHour, VoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(2, (ReactiveEnergy.FromVoltamperesReactiveHour(3)-v).VoltamperesReactiveHour, VoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(2, (v + v).VoltamperesReactiveHour, VoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(10, (v*10).VoltamperesReactiveHour, VoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(10, (10*v).VoltamperesReactiveHour, VoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(2, (ReactiveEnergy.FromVoltamperesReactiveHour(10)/5).VoltamperesReactiveHour, VoltamperesReactiveHourTolerance);
            AssertEx.EqualTolerance(2, ReactiveEnergy.FromVoltamperesReactiveHour(10)/ReactiveEnergy.FromVoltamperesReactiveHour(5), VoltamperesReactiveHourTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ReactiveEnergy oneVoltampereReactiveHour = ReactiveEnergy.FromVoltamperesReactiveHour(1);
            ReactiveEnergy twoVoltamperesReactiveHour = ReactiveEnergy.FromVoltamperesReactiveHour(2);

            Assert.True(oneVoltampereReactiveHour < twoVoltamperesReactiveHour);
            Assert.True(oneVoltampereReactiveHour <= twoVoltamperesReactiveHour);
            Assert.True(twoVoltamperesReactiveHour > oneVoltampereReactiveHour);
            Assert.True(twoVoltamperesReactiveHour >= oneVoltampereReactiveHour);

            Assert.False(oneVoltampereReactiveHour > twoVoltamperesReactiveHour);
            Assert.False(oneVoltampereReactiveHour >= twoVoltamperesReactiveHour);
            Assert.False(twoVoltamperesReactiveHour < oneVoltampereReactiveHour);
            Assert.False(twoVoltamperesReactiveHour <= oneVoltampereReactiveHour);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltamperesReactiveHour(1);
            Assert.Equal(0, voltamperereactivehour.CompareTo(voltamperereactivehour));
            Assert.True(voltamperereactivehour.CompareTo(ReactiveEnergy.Zero) > 0);
            Assert.True(ReactiveEnergy.Zero.CompareTo(voltamperereactivehour) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltamperesReactiveHour(1);
            Assert.Throws<ArgumentException>(() => voltamperereactivehour.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltamperesReactiveHour(1);
            Assert.Throws<ArgumentNullException>(() => voltamperereactivehour.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ReactiveEnergy a = ReactiveEnergy.FromVoltamperesReactiveHour(1);
            ReactiveEnergy b = ReactiveEnergy.FromVoltamperesReactiveHour(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ReactiveEnergy v = ReactiveEnergy.FromVoltamperesReactiveHour(1);
            Assert.True(v.Equals(ReactiveEnergy.FromVoltamperesReactiveHour(1), ReactiveEnergy.FromVoltamperesReactiveHour(VoltamperesReactiveHourTolerance)));
            Assert.False(v.Equals(ReactiveEnergy.Zero, ReactiveEnergy.FromVoltamperesReactiveHour(VoltamperesReactiveHourTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltamperesReactiveHour(1);
            Assert.False(voltamperereactivehour.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ReactiveEnergy voltamperereactivehour = ReactiveEnergy.FromVoltamperesReactiveHour(1);
            Assert.False(voltamperereactivehour.Equals(null));
        }
    }
}
