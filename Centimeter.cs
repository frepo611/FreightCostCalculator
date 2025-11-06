namespace FreightCostCalculator.App;

public record Centimeter(int value) : IComparable

{
    public int Value { get; } = value > 0 ? value : throw new ArgumentOutOfRangeException("Centimeter value must be larger than 0");

    public int CompareTo(Centimeter? other)
    {
        if (other is null) return 1;
        return Value.CompareTo(other.Value);
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) return 1; // Null is considered less than any instance
        if (obj is not Centimeter other) throw new ArgumentException("Object is not a Centimeter");
        return value.CompareTo(other.value); // Compare the underlying values
    }
}
