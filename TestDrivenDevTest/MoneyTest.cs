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
            Money five = Money._Dollar(5);
            AreEqual(Money._Dollar(10), five.Times(2));
            AreEqual(Money._Dollar(15), five.Times(3));
        }

        [Test]
        public void TestEquality()
        {
            IsTrue(Money._Dollar(5).Equals(Money._Dollar(5)));
            IsFalse(Money._Dollar(5).Equals(Money._Dollar(6)));
            IsTrue(Money._Frunc(5).Equals(new Franc(5)));
            IsFalse(Money._Frunc(5).Equals(new Franc(6)));
            IsFalse(Money._Frunc(5).Equals(Money._Dollar(5)));
        }
        
        [Test]
        public void TestFrancMultiplication()
        {
            Franc five = Money._Frunc(5);
            AreEqual(Money._Frunc(10), five.Times(2));
            AreEqual(Money._Frunc(15), five.Times(3));
        }
    }
}