namespace FreightCostCalculator.App; 
// Testar primary constructor
    internal class Box(Centimeter height, Centimeter width, Centimeter length, Kilogram weight)
{
    public Centimeter Heigth { get; init; } = height;
    public Centimeter Width { get; init; } = width;
    public Centimeter Length { get; init; } = length;
    
    public Kilogram Weight { get; init; } = weight.Value <= 20 ? weight : throw new ArgumentOutOfRangeException("The weight of the parcel must not be larger than 20");
} 