namespace FreightCostCalculator.App;

internal class Tube(Centimeter radius, Centimeter height, Kilogram weight)

{
    public Centimeter Radius { get; init; } = radius;
    public Centimeter Height { get; init; } = height;

    
    public Kilogram Weigth { get; init; } = weight.Kgs <= 20 ? weight : throw new ArgumentOutOfRangeException($"The weight of the package must not be higher than 20.");
}
