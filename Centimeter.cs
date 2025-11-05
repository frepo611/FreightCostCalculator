namespace FreightCostCalculator.App;

public record Centimeter(int value)

{
    public int Value { get; } = value > 0 ? value : throw new ArgumentOutOfRangeException("Centimeter value must be larger than 0");
}
