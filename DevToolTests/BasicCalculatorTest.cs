using Xunit;
using DevTool;

namespace DevToolTests
{
    public class BasicCalculatorTest
    {
        BasicCalculator basicCalculator = new();
        
        [Theory]
        [InlineData(2,2,4)]
        [InlineData(3, 3, 6)]
        [InlineData(4, 4, 8)]

        public void Addition_Theory(double numberOne, double numberTwo, double numberThree)
        {
            //Arrange
            double expected = numberThree;

            //Act
            double actual = basicCalculator.AddCalc(numberOne, numberTwo);
   
            //Assert

            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(3, 3, 0)]
        [InlineData(4, 4, 0)]
        public void Subtraction_Theory(double numberOne, double numberTwo, double numberThree)
        {
            //Arrange
            double expected = numberThree;

            //Act
            double actual = basicCalculator.SubCalc(numberOne, numberTwo);


            //Assert

            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 9)]
        [InlineData(4, 4, 16)]
        public void Multiplication_Theory(double numberOne, double numberTwo, double numberThree)
        {
            //Arrange
            double expected = numberThree;

            //Act
            double actual = basicCalculator.MultCalc(numberOne, numberTwo);

            //Assert

            Assert.Equal(expected, actual);

        }
        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(3, 3, 1)]
        [InlineData(4, 4, 1)]
        public void Division_Theory(double numberOne, double numberTwo, double numberThree)
        {
            //Arrange
            double expected = numberThree;

            //Act
            double actual = basicCalculator.DivCalc(numberOne, numberTwo);

            //Assert

            Assert.Equal(expected, actual);

        }
    }
}
