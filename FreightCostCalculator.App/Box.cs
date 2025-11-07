using System.Linq.Expressions;

namespace FreightCostCalculator.App;
public class Box
{
    private readonly static Ore _minimumFreightCost = new Ore(10_000);
    private readonly static Ore _smallPackageLightWeightCost = new Ore(29_000);
    private readonly static Ore _smallPackageMediumWeightCost = new Ore(49_000);
    private readonly static Ore _smallPackageHeavyWeightCost = new Ore(79_000);

    public Centimeter Height { get; init; }
    public Centimeter Width { get; init; }
    public Centimeter Length { get; init; }
    public Kilogram Weight { get; init; }
    private readonly Centimeter _longestSide;

    private readonly Centimeter _shortestSide;

    public Box(Centimeter height, Centimeter width, Centimeter length, Kilogram weight)
    {
        Height = height;
        Width = width;
        Length = length;
        Weight = weight.Kgs <= 20 ? weight : throw new ArgumentOutOfRangeException("The weight of the parcel must not be larger than 20");
        _longestSide = new[] { height, width, length }.Max()!;
        _shortestSide = new[] { height, width, length }.Min()!;
    }

    public Ore GetFreightCost()
    {
        var weightForCostCalculation = Weight.Kgs > 2 ? Weight.Kgs : 2;
        
        if (_longestSide.Cms < 30)
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

        return new Ore(weightForCostCalculation * _shortestSide.Cms * _longestSide.Cms + _minimumFreightCost.Value);
    }
}