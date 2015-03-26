using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using Newtonsoft.Json;
using GlmSharp;

// ReSharper disable InconsistentNaming

namespace GlmSharpTest.Generated.Vec4
{
    [TestFixture]
    public class DoubleVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new dvec4(-7.5d);
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var v = new dvec4(1.5d, -8, -3.5d, 0.0);
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var v = new dvec4(new dvec2(-3.5d, 1.5d));
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var v = new dvec4(new dvec3(-2, 8.5d, 0.5d));
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var v = new dvec4(new dvec4(-4.5d, -2, 4.5d, -1));
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(-1, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new dvec4(8.5d, 4.5d, 3, 1.0);
            Assert.AreEqual(8.5d, v[0]);
            Assert.AreEqual(4.5d, v[1]);
            Assert.AreEqual(3, v[2]);
            Assert.AreEqual(1.0, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0.0; } );
            
            v[1] = 0.0;
            Assert.AreEqual(0.0, v[1]);
            v[3] = 1.0;
            Assert.AreEqual(1.0, v[3]);
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[2] = 3;
            Assert.AreEqual(3, v[2]);
            v[3] = 4;
            Assert.AreEqual(4, v[3]);
            v[2] = 5;
            Assert.AreEqual(5, v[2]);
            v[2] = 6;
            Assert.AreEqual(6, v[2]);
            v[2] = 7;
            Assert.AreEqual(7, v[2]);
            v[2] = 8;
            Assert.AreEqual(8, v[2]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[1] = -2;
            Assert.AreEqual(-2, v[1]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[3] = -4;
            Assert.AreEqual(-4, v[3]);
            v[2] = -5;
            Assert.AreEqual(-5, v[2]);
            v[3] = -6;
            Assert.AreEqual(-6, v[3]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[0] = -8;
            Assert.AreEqual(-8, v[0]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
            v[0] = -9.5d;
            Assert.AreEqual(-9.5d, v[0]);
            v[2] = -8.5d;
            Assert.AreEqual(-8.5d, v[2]);
            v[1] = -7.5d;
            Assert.AreEqual(-7.5d, v[1]);
            v[1] = -6.5d;
            Assert.AreEqual(-6.5d, v[1]);
            v[0] = -5.5d;
            Assert.AreEqual(-5.5d, v[0]);
            v[1] = -4.5d;
            Assert.AreEqual(-4.5d, v[1]);
            v[1] = -3.5d;
            Assert.AreEqual(-3.5d, v[1]);
            v[3] = -2.5d;
            Assert.AreEqual(-2.5d, v[3]);
            v[0] = -1.5d;
            Assert.AreEqual(-1.5d, v[0]);
            v[2] = -0.5d;
            Assert.AreEqual(-0.5d, v[2]);
            v[0] = 0.5d;
            Assert.AreEqual(0.5d, v[0]);
            v[0] = 1.5d;
            Assert.AreEqual(1.5d, v[0]);
            v[1] = 2.5d;
            Assert.AreEqual(2.5d, v[1]);
            v[2] = 3.5d;
            Assert.AreEqual(3.5d, v[2]);
            v[1] = 4.5d;
            Assert.AreEqual(4.5d, v[1]);
            v[3] = 5.5d;
            Assert.AreEqual(5.5d, v[3]);
            v[1] = 6.5d;
            Assert.AreEqual(6.5d, v[1]);
            v[3] = 7.5d;
            Assert.AreEqual(7.5d, v[3]);
            v[0] = 8.5d;
            Assert.AreEqual(8.5d, v[0]);
            v[3] = 9.5d;
            Assert.AreEqual(9.5d, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new dvec4(6.5d, 8, 1.0, 6);
            var vals = v.Values;
            Assert.AreEqual(6.5d, vals[0]);
            Assert.AreEqual(8, vals[1]);
            Assert.AreEqual(1.0, vals[2]);
            Assert.AreEqual(6, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0.0, dvec4.Zero.x);
            Assert.AreEqual(0.0, dvec4.Zero.y);
            Assert.AreEqual(0.0, dvec4.Zero.z);
            Assert.AreEqual(0.0, dvec4.Zero.w);
            
            Assert.AreEqual(1.0, dvec4.Ones.x);
            Assert.AreEqual(1.0, dvec4.Ones.y);
            Assert.AreEqual(1.0, dvec4.Ones.z);
            Assert.AreEqual(1.0, dvec4.Ones.w);
            
            Assert.AreEqual(1.0, dvec4.UnitX.x);
            Assert.AreEqual(0.0, dvec4.UnitX.y);
            Assert.AreEqual(0.0, dvec4.UnitX.z);
            Assert.AreEqual(0.0, dvec4.UnitX.w);
            
            Assert.AreEqual(0.0, dvec4.UnitY.x);
            Assert.AreEqual(1.0, dvec4.UnitY.y);
            Assert.AreEqual(0.0, dvec4.UnitY.z);
            Assert.AreEqual(0.0, dvec4.UnitY.w);
            
            Assert.AreEqual(0.0, dvec4.UnitZ.x);
            Assert.AreEqual(0.0, dvec4.UnitZ.y);
            Assert.AreEqual(1.0, dvec4.UnitZ.z);
            Assert.AreEqual(0.0, dvec4.UnitZ.w);
            
            Assert.AreEqual(0.0, dvec4.UnitW.x);
            Assert.AreEqual(0.0, dvec4.UnitW.y);
            Assert.AreEqual(0.0, dvec4.UnitW.z);
            Assert.AreEqual(1.0, dvec4.UnitW.w);
            
            Assert.AreEqual(double.MaxValue, dvec4.MaxValue.x);
            Assert.AreEqual(double.MaxValue, dvec4.MaxValue.y);
            Assert.AreEqual(double.MaxValue, dvec4.MaxValue.z);
            Assert.AreEqual(double.MaxValue, dvec4.MaxValue.w);
            
            Assert.AreEqual(double.MinValue, dvec4.MinValue.x);
            Assert.AreEqual(double.MinValue, dvec4.MinValue.y);
            Assert.AreEqual(double.MinValue, dvec4.MinValue.z);
            Assert.AreEqual(double.MinValue, dvec4.MinValue.w);
            
            Assert.AreEqual(double.Epsilon, dvec4.Epsilon.x);
            Assert.AreEqual(double.Epsilon, dvec4.Epsilon.y);
            Assert.AreEqual(double.Epsilon, dvec4.Epsilon.z);
            Assert.AreEqual(double.Epsilon, dvec4.Epsilon.w);
            
            Assert.AreEqual(double.NaN, dvec4.NaN.x);
            Assert.AreEqual(double.NaN, dvec4.NaN.y);
            Assert.AreEqual(double.NaN, dvec4.NaN.z);
            Assert.AreEqual(double.NaN, dvec4.NaN.w);
            
            Assert.AreEqual(double.NegativeInfinity, dvec4.NegativeInfinity.x);
            Assert.AreEqual(double.NegativeInfinity, dvec4.NegativeInfinity.y);
            Assert.AreEqual(double.NegativeInfinity, dvec4.NegativeInfinity.z);
            Assert.AreEqual(double.NegativeInfinity, dvec4.NegativeInfinity.w);
            
            Assert.AreEqual(double.PositiveInfinity, dvec4.PositiveInfinity.x);
            Assert.AreEqual(double.PositiveInfinity, dvec4.PositiveInfinity.y);
            Assert.AreEqual(double.PositiveInfinity, dvec4.PositiveInfinity.z);
            Assert.AreEqual(double.PositiveInfinity, dvec4.PositiveInfinity.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new dvec4(4, 3.5d, 5.5d, -6);
            var v2 = new dvec4(4, 3.5d, 5.5d, -6);
            var v3 = new dvec4(-6, 5.5d, 3.5d, 4);
            Assert.That(v1 == new dvec4(v1));
            Assert.That(v2 == new dvec4(v2));
            Assert.That(v3 == new dvec4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new dvec4(0.0, 3, -6.5d, 1.5d);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = dvec4.Parse(s0);
            var v1 = dvec4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = dvec4.TryParse(s0, out v0);
            var b1 = dvec4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = dvec4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = dvec4.TryParse("", out v0);
            Assert.False(b0);
            b0 = dvec4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { dvec4.Parse(null); });
            Assert.Throws<FormatException>(() => { dvec4.Parse(""); });
            Assert.Throws<FormatException>(() => { dvec4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = dvec4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = dvec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = dvec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new dvec4(6.5d, 2, -6.5d, 2);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<dvec4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

    }
}
