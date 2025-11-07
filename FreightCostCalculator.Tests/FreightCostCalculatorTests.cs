using FreightCostCalculator.App;
using System.Collections;

namespace FreightCostCalculator.Tests;
public class FreightCostCalculatorTests : FreightCostCalculatorBoxTests
{
       [Theory]
       [ClassData(typeof(BoxFreightCostData))]
    public void GetFreightCost_ReturnsExpected(int height, int width, int length, int weight, int expected)
    {
            Box sut = new(new Centimeter(height), new Centimeter(width), new Centimeter(length), new Kilogram(weight));
            Ore expectedCost = new(expected);

            var actualCost = sut.GetFreightCost();

            Assert.Equal(expectedCost, actualCost);
    }
}

public class BoxFreightCostData : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
       yield return new object[] { 10, 5, 3, 1, 29_000}; //  _smallPackageLightWeightCost
       yield return new object[] { 10, 10, 10, 11, 79_000}; //  _smallPackageHeavyWeightCost

       yield return new object[] { 12, 7, 8, 5, 49_000 }; // _smallPackageMediumWeightCost
       yield return new object[] { 12, 70, 80, 10, 12 * 80 * 10 + 10_000 };
       yield return new object[] { 100, 100, 100, 20, 100 * 100 * 20 + 10_000 };
            }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}