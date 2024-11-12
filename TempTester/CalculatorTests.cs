using Calculator;
using FluentAssertions;

namespace TempTester
{
    public class CalculatorTests
    {
        private Maths _sut;
        public CalculatorTests() => _sut = new Maths();

        [Fact]
        public void Add_2_Positive_Numbers_Returns_Positive_Ans()
        {
            // Arrange
            int num1 = 1, num2 = 2, expected = 3;
            // Act
            var result = _sut.Sum(num1, num2);
            // Assert
            result.Should().Be(expected);
            result.Should<int>();
        }

        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(2, 3, 6)]
        public void Mulitply_2_Positive_Numbers_Returns_Positive_Ans(int num1, int num2, int expected)
        {
            // Arrange
            // Act
            var result = _sut.Multiply(num1, num2);
            // Assert
            result.Should().Be(expected);
            result.Should<int>();
        }
    }
}