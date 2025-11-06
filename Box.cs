using System.Linq.Expressions;

namespace FreightCostCalculator.App;
public class Box(Centimeter height, Centimeter width, Centimeter length, Kilogram weight)
{
    private readonly static Ore _minimumFreightCost = new Ore(10_000);
    private readonly static Ore _smallPackageLightWeightCost = new Ore(29_000);
    private readonly static Ore _smallPackageMediumWeightCost = new Ore(49_000);
    private readonly static Ore _smallPackageHeavyWeightCost = new Ore(79_000);

    public Centimeter Height { get; init; } = height;
    public Centimeter Width { get; init; } = width;
    public Centimeter Length { get; init; } = length;
    public Kilogram Weight { get; init; } = weight.Value <= 20 ? weight : throw new ArgumentOutOfRangeException("The weight of the parcel must not be larger than 20");
    private readonly Centimeter _longestSide = new[] { height, width, length }.Max()!;

    private readonly Centimeter _shortestSide = new[] { height, width, length }.Min()!;

    public Ore GetFreightCost()
    {
        var weightForCostCalculation = Weight.Value > 2 ? Weight.Value : 2;
        
        if (_longestSide.Value < 30)
        {
            switch (weightForCostCalculation)
            {
                case 2:
                    return _smallPackageLightWeightCost;
                case > 2 and <= 10:
                    return _smallPackageMediumWeightCost;
                case > 10:
                    return _smallPackageHeavyWeightCost;
            }
        }

        return new Ore(weightForCostCalculation * _shortestSide.Value * _longestSide.Value + _minimumFreightCost.Value);
    }
}