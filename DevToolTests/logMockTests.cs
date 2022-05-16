using Xunit;
using DevTool;
using Moq;


namespace DevToolTests
{
    public class LogMockTests
    {
        [Fact]
        public void LogToAnyBaseMock_Test()
        {
            //Arrange
            double numberOne = 2;
            double numberTwo = 3;   
            var mock = new Mock<IAdvancedCalculation>();
            mock.Setup(x => x.CalcWithTwoPassedValues(numberOne, numberTwo)).Returns(LogToAnyBase(numberOne, numberTwo));
            var mockObject = mock.Object;

            //Act
            var actual = mockObject.CalcWithTwoPassedValues(numberOne, numberTwo);
            var expected = LogToAnyBase(numberOne, numberTwo);

            //Assert
            Assert.True(actual != 0);
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void LogToBaseEMock_Test()
        {
            //Arrange
            double number = 12;
            var mock = new Mock<IAdvancedCalculation>();
            mock.Setup(x => x.CalcWithOnePassedValue(number)).Returns(logToBaseE(number));
            var mockObject = mock.Object;

            //Act
            var actual = mockObject.CalcWithOnePassedValue(number);
            var expected = logToBaseE(number);

            //Assert
            Assert.True(actual != 0);
            Assert.Equal(expected, actual);

        }

        private double logToBaseE(double number)
        {
            double result = Math.Log(number);
            return result;

        }

        private double LogToAnyBase(double numberOne, double numberTwo)
        {
            double result = Math.Log(numberOne, numberTwo);
            return result;
        }

    }


}


