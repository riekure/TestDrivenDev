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
    }
}