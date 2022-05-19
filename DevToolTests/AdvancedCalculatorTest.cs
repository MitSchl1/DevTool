using Xunit;
using DevTool;

namespace DevToolTests
{
    public class AdvancedCalculatorTest
    {
        AdvancedCalculator advancedCalculator = new();
        [Fact]
        public void Addition_Test()
        {
            //Act
            double actual = advancedCalculator.AddCalc(2, 2);

            //Arrange
            double expected = 4;

            //Assert

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Subtraction_Test()
        {
            //Act
            double actual = advancedCalculator.SubCalc(2, 5);

            //Arrange
            double expected = -3;

            //Assert

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Multiplication_Test()
        {
            //Act
            double actual = advancedCalculator.MultCalc(2, 3);

            //Arrange
            double expected = 6;

            //Assert

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Division_Test()
        {
            //Act
            double actual = advancedCalculator.DivCalc(2, 2);

            //Arrange
            double expected = 1;

            //Assert

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Sin_Test()
        {
            //Act
            double actual = advancedCalculator.SinCalc(1);

            //Arrange
            double expected = 0.8414709848078965;

            //Assert

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Cos_Test()
        {
            //Act
            double actual = advancedCalculator.CosCalc(0);

            //Arrange
            double expected = 1;

            //Assert

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Tan_Test()
        {
            //Act
            double actual = advancedCalculator.TanCalc(1);

            //Arrange
            double expected = 1.5574077246549023;

            //Assert

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Log2_Test()
        {
            //Act
            double actual = advancedCalculator.Log2Calc(25);

            //Arrange
            double expected = 4.643856189774724;

            //Assert

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Log10_Test()
        {
            //Act
            double actual = advancedCalculator.Log10Calc(25);

            //Arrange
            double expected = 1.3979400086720377;

            //Assert

            Assert.Equal(expected, actual);

        }
    }
}
