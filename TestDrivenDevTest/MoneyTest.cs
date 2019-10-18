using System;
using NUnit.Framework;
using TestDrivenDev;
using static NUnit.Framework.Assert;

namespace TestDrivenDevTest
{
    [TestFixture]
    public class MoneyTest
    {
        [Test]
        public void TestMultiplication()
        {
            Dollar five = new Dollar(5);
            AreEqual(new Dollar(10), five.Times(2));
            AreEqual(new Dollar(15), five.Times(3));
        }

        [Test]
        public void TestEquality()
        {
            IsTrue(new Dollar(5).Equals(new Dollar(5)));
            IsFalse(new Dollar(5).Equals(new Dollar(6)));
            IsTrue(new Frunc(5).Equals(new Frunc(5)));
            IsFalse(new Frunc(5).Equals(new Frunc(6)));
            IsFalse(new Dollar(5).Equals(new Frunc(5)));
        }
        
        [Test]
        public void TestFruncMultiplication()
        {
            Frunc five = new Frunc(5);
            AreEqual(new Frunc(10), five.Times(2));
            AreEqual(new Frunc(15), five.Times(3));
        }
    }
}