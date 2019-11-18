using NUnit.Framework;

namespace TestDrivenDevTest
{
    [TestFixture]
    public class CalcTest
    {
        [Test]
        public void TestSum()
        {
            Assert.AreEqual(4, Plus(3, 1));
            Assert.AreEqual(7, Plus(3, 4));
        }

        private int Plus(int augend, int addend)
        {
            return augend + addend;
        }

        [Test]
        public void TestSumArray()
        {
            Assert.AreEqual(5, Sum(new int[] {5}));
            Assert.AreEqual(12, Sum(new int[]{5, 7}));
        }

        private int Sum(int[] values)
        {
            var sum = 0;
            foreach (var v in values)
            {
                sum = sum + v;
            }
            return sum;
        }
    }
}