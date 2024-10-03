namespace CalculatorApp.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Add()
        {
            var result = CalculatorApp.Calculator.Add(2.0, 3.0);
            Assert.Equal(5.0, result);
        }

        [Theory]
        //          x, y, result
        [InlineData(41, 31, 72)]
        [InlineData(4, 3, 7)]
        [InlineData(20.3, 3.7, 24)]
        [InlineData(double.MaxValue, 5, double.MaxValue)]
        [InlineData(-309, -101, -410)]
        [InlineData(9, -9, 0)]
        public void ShouldAddTwoNumbers(double x, double y, double expected)
        {
            //Act
            double actual = Calculator.Add(x, y);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}