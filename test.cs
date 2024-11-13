using Xunit;

namespace CalculatorTests
{
    public class CalculatorHelperTests
    {
        [Fact]
        public void Add_Int_ReturnsCorrectSum()
        {
            // Arrange
            int num1 = 5;
            int num2 = 10;

            // Act
            object result = CalculatorHelper.Add(num1, num2);

            // Assert
            Assert.Equal(15, (int)result);
        }

        // Add more test methods for other operations (Subtract, Multiply, Divide)
        // and different data types.
    }
}