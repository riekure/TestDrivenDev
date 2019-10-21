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
            Money five = Money.CreateDollar(5);
            AreEqual(Money.CreateDollar(10), five.Times(2));
            AreEqual(Money.CreateDollar(15), five.Times(3));
        }

        [Test]
        public void TestEquality()
        {
            IsTrue(condition: Money.CreateDollar(5).Equals(Money.CreateDollar(5)));
            IsFalse(Money.CreateDollar(5).Equals(Money.CreateDollar(6)));
            IsTrue(Money.CreateFranc(5).Equals(Money.CreateFranc(5)));
            IsFalse(Money.CreateFranc(5).Equals(Money.CreateFranc(6)));
            IsFalse(Money.CreateFranc(5).Equals(Money.CreateDollar(5)));
        }
        
        [Test]
        public void TestFrancMultiplication()
        {
            Franc five = Money.CreateFranc(5);
            AreEqual(Money.CreateFranc(10), five.Times(2));
            AreEqual(Money.CreateFranc(15), five.Times(3));
        }

        [Test]
        public void TestCurrency()
        {
            AreEqual("USD", Money.CreateDollar(1).GetCurrency());
            AreEqual("CHF", Money.CreateFranc(1).GetCurrency());
        }
    }
}