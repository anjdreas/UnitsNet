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
    /// Test of MagneticField.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MagneticFieldTestsBase
    {
        protected abstract double TeslasInOneTesla { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double TeslasTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void TeslaToMagneticFieldUnits()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            AssertEx.EqualTolerance(TeslasInOneTesla, tesla.Teslas, TeslasTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, MagneticField.From(1, MagneticFieldUnit.Tesla).Teslas, TeslasTolerance);
        }

        [Fact]
        public void As()
        {
            var tesla = MagneticField.FromTeslas(1);
            AssertEx.EqualTolerance(TeslasInOneTesla, tesla.As(MagneticFieldUnit.Tesla), TeslasTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            AssertEx.EqualTolerance(1, MagneticField.FromTeslas(tesla.Teslas).Teslas, TeslasTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            MagneticField v = MagneticField.FromTeslas(1);
            AssertEx.EqualTolerance(-1, -v.Teslas, TeslasTolerance);
            AssertEx.EqualTolerance(2, (MagneticField.FromTeslas(3)-v).Teslas, TeslasTolerance);
            AssertEx.EqualTolerance(2, (v + v).Teslas, TeslasTolerance);
            AssertEx.EqualTolerance(10, (v*10).Teslas, TeslasTolerance);
            AssertEx.EqualTolerance(10, (10*v).Teslas, TeslasTolerance);
            AssertEx.EqualTolerance(2, (MagneticField.FromTeslas(10)/5).Teslas, TeslasTolerance);
            AssertEx.EqualTolerance(2, MagneticField.FromTeslas(10)/MagneticField.FromTeslas(5), TeslasTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            MagneticField oneTesla = MagneticField.FromTeslas(1);
            MagneticField twoTeslas = MagneticField.FromTeslas(2);

            Assert.True(oneTesla < twoTeslas);
            Assert.True(oneTesla <= twoTeslas);
            Assert.True(twoTeslas > oneTesla);
            Assert.True(twoTeslas >= oneTesla);

            Assert.False(oneTesla > twoTeslas);
            Assert.False(oneTesla >= twoTeslas);
            Assert.False(twoTeslas < oneTesla);
            Assert.False(twoTeslas <= oneTesla);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            Assert.Equal(0, tesla.CompareTo(tesla));
            Assert.True(tesla.CompareTo(MagneticField.Zero) > 0);
            Assert.True(MagneticField.Zero.CompareTo(tesla) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            Assert.Throws<ArgumentException>(() => tesla.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            Assert.Throws<ArgumentNullException>(() => tesla.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            MagneticField a = MagneticField.FromTeslas(1);
            MagneticField b = MagneticField.FromTeslas(2);

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
            MagneticField v = MagneticField.FromTeslas(1);
            Assert.True(v.Equals(MagneticField.FromTeslas(1), MagneticField.FromTeslas(TeslasTolerance)));
            Assert.False(v.Equals(MagneticField.Zero, MagneticField.FromTeslas(TeslasTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            Assert.False(tesla.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            MagneticField tesla = MagneticField.FromTeslas(1);
            Assert.False(tesla.Equals(null));
        }
    }
}
