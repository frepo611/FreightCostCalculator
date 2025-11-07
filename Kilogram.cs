namespace FreightCostCalculator.App;

public readonly record struct Kilogram
{
    public int Kgs { get; }

    public Kilogram(int kilograms)
    {
   Kgs = kilograms > 0 ? kilograms : throw new ArgumentOutOfRangeException("Argument must be larger than 0");       
    }

}