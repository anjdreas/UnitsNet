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
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
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
    /// Test of ElectricInductance.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricInductanceTestsBase
    {
        protected abstract double HenriesInOneHenry { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double HenriesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void HenryToElectricInductanceUnits()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            AssertEx.EqualTolerance(HenriesInOneHenry, henry.Henries, HenriesTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricInductance.From(1, ElectricInductanceUnit.Henry).Henries, HenriesTolerance);
        }

        [Fact]
        public void As()
        {
            var henry = ElectricInductance.FromHenries(1);
            AssertEx.EqualTolerance(HenriesInOneHenry, henry.As(ElectricInductanceUnit.Henry), HenriesTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            AssertEx.EqualTolerance(1, ElectricInductance.FromHenries(henry.Henries).Henries, HenriesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricInductance v = ElectricInductance.FromHenries(1);
            AssertEx.EqualTolerance(-1, -v.Henries, HenriesTolerance);
            AssertEx.EqualTolerance(2, (ElectricInductance.FromHenries(3)-v).Henries, HenriesTolerance);
            AssertEx.EqualTolerance(2, (v + v).Henries, HenriesTolerance);
            AssertEx.EqualTolerance(10, (v*10).Henries, HenriesTolerance);
            AssertEx.EqualTolerance(10, (10*v).Henries, HenriesTolerance);
            AssertEx.EqualTolerance(2, (ElectricInductance.FromHenries(10)/5).Henries, HenriesTolerance);
            AssertEx.EqualTolerance(2, ElectricInductance.FromHenries(10)/ElectricInductance.FromHenries(5), HenriesTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricInductance oneHenry = ElectricInductance.FromHenries(1);
            ElectricInductance twoHenries = ElectricInductance.FromHenries(2);

            Assert.True(oneHenry < twoHenries);
            Assert.True(oneHenry <= twoHenries);
            Assert.True(twoHenries > oneHenry);
            Assert.True(twoHenries >= oneHenry);

            Assert.False(oneHenry > twoHenries);
            Assert.False(oneHenry >= twoHenries);
            Assert.False(twoHenries < oneHenry);
            Assert.False(twoHenries <= oneHenry);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.Equal(0, henry.CompareTo(henry));
            Assert.True(henry.CompareTo(ElectricInductance.Zero) > 0);
            Assert.True(ElectricInductance.Zero.CompareTo(henry) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.Throws<ArgumentException>(() => henry.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.Throws<ArgumentNullException>(() => henry.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ElectricInductance a = ElectricInductance.FromHenries(1);
            ElectricInductance b = ElectricInductance.FromHenries(2);

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
            ElectricInductance v = ElectricInductance.FromHenries(1);
            Assert.True(v.Equals(ElectricInductance.FromHenries(1), ElectricInductance.FromHenries(HenriesTolerance)));
            Assert.False(v.Equals(ElectricInductance.Zero, ElectricInductance.FromHenries(HenriesTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.False(henry.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricInductance henry = ElectricInductance.FromHenries(1);
            Assert.False(henry.Equals(null));
        }
    }
}
