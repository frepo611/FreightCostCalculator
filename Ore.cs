namespace FreightCostCalculator.App;

public record Ore(int value)
{
    public int Value { get; } = value >= 0 ? value : throw new ArgumentOutOfRangeException("The value of Öre must be larger than 0");
   
}