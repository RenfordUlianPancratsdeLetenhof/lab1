using lab5;
using System;
using Xunit;


namespace Lab5Tests
{
    public class ChxCalculatorTest
    {
        [Fact]
        public void ChxCycle_006_0999Returned()
        {
            var chxCalculator = new ChxCalculator(0.06);
            var expectedY = 0.999;
            var actualY = chxCalculator.ChxCycle(); // Без округлення
            Assert.Equal(expectedY, actualY, 15); // Очікується 3 десяткових знаки
        }

        [Fact]
        public void ChxRecursive_006_0999Returned()
        {
            var chxCalculator = new ChxCalculator(0.06);
            var expectedY = 0.999;
            double actualYRec = 0;
            chxCalculator.ChxRecursive(0.06, 1, 3, ref actualYRec);
            var roundedYRec = Math.Round(actualYRec, 3);
            Assert.Equal(expectedY, roundedYRec);
        }
    }
}