namespace FreightCostCalculator.App;

public struct Ore(int ore)
{
    public int Value { get; } = ore >= 0 ? ore : throw new ArgumentOutOfRangeException("The value of Öre must be larger than 0");
   
}