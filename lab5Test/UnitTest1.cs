using lab5;

namespace lab5Test
{
    [TestClass]
    public class ChxCalculatorTest
    {
        [TestMethod]
        public void ChxCycle_Zero_ReturnsZero()
        {
            var chxCalculator = new ChxCalculator(0);
            var expectedY = 0.0;
            var actualY = chxCalculator.ChxCycle();
            Assert.AreEqual(expectedY, actualY, 0.001);
        }

        [TestMethod]
        public void ChxCycle_PositiveX_ReturnsNonZero()
        {
            var chxCalculator = new ChxCalculator(0.5);
            var actualY = chxCalculator.ChxCycle();
            Assert.AreNotEqual(0.0, actualY);
        }

        [TestMethod]
        public void ChxRecursive_Zero_ReturnsZero()
        {
            var chxCalculator = new ChxCalculator(0);
            var expectedY = 0.0;
            double actualYRec = 0;
            chxCalculator.ChxRecursive(0, 1, 3, ref actualYRec);
            Assert.AreEqual(expectedY, actualYRec, 0.001);
        }

        [TestMethod]
        public void ChxRecursive_PositiveX_ReturnsNonZero()
        {
            var chxCalculator = new ChxCalculator(0.5);
            double actualYRec = 0;
            chxCalculator.ChxRecursive(0.5, 1, 3, ref actualYRec);
            Assert.AreNotEqual(0.0, actualYRec);
        }
    }
}