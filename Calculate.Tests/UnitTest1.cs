using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculate.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Plus_1_plus_1_equ_2()
        {
            CalculateTools.Calculate calc = new CalculateTools.Calculate();
            int expected= 2;

            int actual = calc.Plus(1, 1);

            Assert.AreEqual(expected, actual);
        }
    }
}
