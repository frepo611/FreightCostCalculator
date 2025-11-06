using System.ComponentModel.DataAnnotations;

namespace FreightCostCalculator.App;

public record Kilogram(int value)
{
    public int Value { get; } = value > 0 ? value : throw new ArgumentOutOfRangeException("Kilogram value must be larger than 0");
}