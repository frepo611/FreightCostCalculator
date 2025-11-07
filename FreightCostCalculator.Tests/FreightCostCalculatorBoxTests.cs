using FreightCostCalculator.App;

namespace FreightCostCalculator.Tests
{
    public class FreightCostCalculatorBoxTests
    {
        [Theory]
        [InlineData(-1, 1, 3, 10)]
        [InlineData(10, 1, 3, 30)]
        [InlineData(10, 1, 3, -30)]
        [InlineData(10, 0, 3, 0)]
        public void BoxConstructorShallThrowExceptionWhenParametersAreInvalid(int height, int width, int length, int weight)
        {
            Assert.ThrowsAny<Exception>(() =>
            new Box(new Centimeter(height),
            new Centimeter(width),
            new Centimeter(length),
            new Kilogram(weight)));

        }
    }
}