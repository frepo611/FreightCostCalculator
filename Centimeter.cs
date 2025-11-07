namespace FreightCostCalculator.App;

public readonly record struct Centimeter : IComparable<Centimeter?>, IComparable

{
    public readonly int Cms { get; }
    public Centimeter(int centimeters)
    {
       Cms = centimeters > 0 ? centimeters : throw new ArgumentOutOfRangeException($"{nameof(centimeters)}: The parameter must be larger than 0");
 
    }
        
    

    public int CompareTo(Centimeter? other)
    {
        if (other is null) return 1;
        return Cms.CompareTo(other.Value.Cms);
    }

    public int CompareTo(object? obj)
    {
        if (obj is null) return 1;
        if (obj is not Centimeter other) throw new ArgumentException("Object is not a Centimeter");
        return Cms.CompareTo(other.Cms); // Compare the underlying values
    }

   }

