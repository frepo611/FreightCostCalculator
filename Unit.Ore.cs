using System;
using System.Collections.Generic;
using System.Linq;
namespace FreightCostCalculator.App;

public record Ore(int value)
{
	public int Value { get; } = value > 0 ? value : throw new ArgumentOutOfRangeException(); 
}
