using Xunit;
using DevTool;

namespace DevToolTests
{
    public class BasicCalculatorTest
    {
        BasicCalculator basicCalculator = new();
        
        [Fact]
        public void Addition_Test()
        {
            //Act
            double actual = basicCalculator.addCalc(2, 2);

            //Arrange
            double expected = 4;    

            //Assert

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Subtraction_Test()
        {
            //Act
            double actual = basicCalculator.subCalc(2, 5);

            //Arrange
            double expected = -3;

            //Assert

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Multiplication_Test()
        {
            //Act
            double actual = basicCalculator.multCalc(2, 3);

            //Arrange
            double expected = 6;

            //Assert

            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Division_Test()
        {
            //Act
            double actual = basicCalculator.divCalc(2, 2);

            //Arrange
            double expected = 1;

            //Assert

            Assert.Equal(expected, actual);

        }
    }
}
