namespace FreightCostCalculator.App;

internal class Tube(Centimeter radius, Centimeter height, Kilogram weight)

{
    public Centimeter Radius { get; init; } = radius;
    public Centimeter Height { get; init; } = height;

    
    public Kilogram Weigth { get; init; } = weight.Value <= 20 ? weight : throw new ArgumentOutOfRangeException("The weight of the parcel must not be larger than 20");
}
