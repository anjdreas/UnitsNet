﻿// Copyright © 2007 by Initial Force AS.  All rights reserved.
// https://github.com/InitialForce/UnitsNet
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
using NUnit.Framework;
using UnitsNet.Units;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Frequency.
    /// </summary>
    [TestFixture]
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class FrequencyTestsBase
    {
        protected abstract double BeatsPerHourInOneHertz { get; }
        protected abstract double BeatsPerMinuteInOneHertz { get; }
        protected abstract double GigahertzInOneHertz { get; }
        protected abstract double HertzInOneHertz { get; }
        protected abstract double KilohertzInOneHertz { get; }
        protected abstract double MegahertzInOneHertz { get; }
        protected abstract double TerahertzInOneHertz { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double BeatsPerHourTolerance { get { return 1e-5; } }
        protected virtual double BeatsPerMinuteTolerance { get { return 1e-5; } }
        protected virtual double GigahertzTolerance { get { return 1e-5; } }
        protected virtual double HertzTolerance { get { return 1e-5; } }
        protected virtual double KilohertzTolerance { get { return 1e-5; } }
        protected virtual double MegahertzTolerance { get { return 1e-5; } }
        protected virtual double TerahertzTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Test]
        public void HertzToFrequencyUnits()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.AreEqual(BeatsPerHourInOneHertz, hertz.BeatsPerHour, BeatsPerHourTolerance);
            Assert.AreEqual(BeatsPerMinuteInOneHertz, hertz.BeatsPerMinute, BeatsPerMinuteTolerance);
            Assert.AreEqual(GigahertzInOneHertz, hertz.Gigahertz, GigahertzTolerance);
            Assert.AreEqual(HertzInOneHertz, hertz.Hertz, HertzTolerance);
            Assert.AreEqual(KilohertzInOneHertz, hertz.Kilohertz, KilohertzTolerance);
            Assert.AreEqual(MegahertzInOneHertz, hertz.Megahertz, MegahertzTolerance);
            Assert.AreEqual(TerahertzInOneHertz, hertz.Terahertz, TerahertzTolerance);
        }

        [Test]
        public void FromValueAndUnit()
        {
            Assert.AreEqual(1, Frequency.From(1, FrequencyUnit.BeatPerHour).BeatsPerHour, BeatsPerHourTolerance);
            Assert.AreEqual(1, Frequency.From(1, FrequencyUnit.BeatPerMinute).BeatsPerMinute, BeatsPerMinuteTolerance);
            Assert.AreEqual(1, Frequency.From(1, FrequencyUnit.Gigahertz).Gigahertz, GigahertzTolerance);
            Assert.AreEqual(1, Frequency.From(1, FrequencyUnit.Hertz).Hertz, HertzTolerance);
            Assert.AreEqual(1, Frequency.From(1, FrequencyUnit.Kilohertz).Kilohertz, KilohertzTolerance);
            Assert.AreEqual(1, Frequency.From(1, FrequencyUnit.Megahertz).Megahertz, MegahertzTolerance);
            Assert.AreEqual(1, Frequency.From(1, FrequencyUnit.Terahertz).Terahertz, TerahertzTolerance);
        }

        [Test]
        public void As()
        {
            var hertz = Frequency.FromHertz(1);
            Assert.AreEqual(BeatsPerHourInOneHertz, hertz.As(FrequencyUnit.BeatPerHour), BeatsPerHourTolerance);
            Assert.AreEqual(BeatsPerMinuteInOneHertz, hertz.As(FrequencyUnit.BeatPerMinute), BeatsPerMinuteTolerance);
            Assert.AreEqual(GigahertzInOneHertz, hertz.As(FrequencyUnit.Gigahertz), GigahertzTolerance);
            Assert.AreEqual(HertzInOneHertz, hertz.As(FrequencyUnit.Hertz), HertzTolerance);
            Assert.AreEqual(KilohertzInOneHertz, hertz.As(FrequencyUnit.Kilohertz), KilohertzTolerance);
            Assert.AreEqual(MegahertzInOneHertz, hertz.As(FrequencyUnit.Megahertz), MegahertzTolerance);
            Assert.AreEqual(TerahertzInOneHertz, hertz.As(FrequencyUnit.Terahertz), TerahertzTolerance);
        }

        [Test]
        public void ConversionRoundTrip()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.AreEqual(1, Frequency.FromBeatsPerHour(hertz.BeatsPerHour).Hertz, BeatsPerHourTolerance);
            Assert.AreEqual(1, Frequency.FromBeatsPerMinute(hertz.BeatsPerMinute).Hertz, BeatsPerMinuteTolerance);
            Assert.AreEqual(1, Frequency.FromGigahertz(hertz.Gigahertz).Hertz, GigahertzTolerance);
            Assert.AreEqual(1, Frequency.FromHertz(hertz.Hertz).Hertz, HertzTolerance);
            Assert.AreEqual(1, Frequency.FromKilohertz(hertz.Kilohertz).Hertz, KilohertzTolerance);
            Assert.AreEqual(1, Frequency.FromMegahertz(hertz.Megahertz).Hertz, MegahertzTolerance);
            Assert.AreEqual(1, Frequency.FromTerahertz(hertz.Terahertz).Hertz, TerahertzTolerance);
        }

        [Test]
        public void ArithmeticOperators()
        {
            Frequency v = Frequency.FromHertz(1);
            Assert.AreEqual(-1, -v.Hertz, HertzTolerance);
            Assert.AreEqual(2, (Frequency.FromHertz(3)-v).Hertz, HertzTolerance);
            Assert.AreEqual(2, (v + v).Hertz, HertzTolerance);
            Assert.AreEqual(10, (v*10).Hertz, HertzTolerance);
            Assert.AreEqual(10, (10*v).Hertz, HertzTolerance);
            Assert.AreEqual(2, (Frequency.FromHertz(10)/5).Hertz, HertzTolerance);
            Assert.AreEqual(2, Frequency.FromHertz(10)/Frequency.FromHertz(5), HertzTolerance);
        }

        [Test]
        public void ComparisonOperators()
        {
            Frequency oneHertz = Frequency.FromHertz(1);
            Frequency twoHertz = Frequency.FromHertz(2);

            Assert.True(oneHertz < twoHertz);
            Assert.True(oneHertz <= twoHertz);
            Assert.True(twoHertz > oneHertz);
            Assert.True(twoHertz >= oneHertz);

            Assert.False(oneHertz > twoHertz);
            Assert.False(oneHertz >= twoHertz);
            Assert.False(twoHertz < oneHertz);
            Assert.False(twoHertz <= oneHertz);
        }

        [Test]
        public void CompareToIsImplemented()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.AreEqual(0, hertz.CompareTo(hertz));
            Assert.Greater(hertz.CompareTo(Frequency.Zero), 0);
            Assert.Less(Frequency.Zero.CompareTo(hertz), 0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentException))]
        public void CompareToThrowsOnTypeMismatch()
        {
            Frequency hertz = Frequency.FromHertz(1);
// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            hertz.CompareTo(new object());
        }

        [Test]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CompareToThrowsOnNull()
        { 
            Frequency hertz = Frequency.FromHertz(1);
// ReSharper disable once ReturnValueOfPureMethodIsNotUsed
            hertz.CompareTo(null);
        }


        [Test]
        public void EqualityOperators()
        {
            Frequency a = Frequency.FromHertz(1);
            Frequency b = Frequency.FromHertz(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a); 
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Test]
        public void EqualsIsImplemented()
        {
            Frequency v = Frequency.FromHertz(1);
            Assert.IsTrue(v.Equals(Frequency.FromHertz(1)));
            Assert.IsFalse(v.Equals(Frequency.Zero));
        }

        [Test]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.IsFalse(hertz.Equals(new object()));
        }

        [Test]
        public void EqualsReturnsFalseOnNull()
        {
            Frequency hertz = Frequency.FromHertz(1);
            Assert.IsFalse(hertz.Equals(null));
        }
    }
}
