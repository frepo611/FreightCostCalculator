namespace FreightCostCalculator.App;


internal class Program
{
    static void Main(string[] args)
    {
          var box1 = new Box(height: new Centimeter(10), width: new Centimeter(10), length: new Centimeter(10), weight: new Kilogram(19));
          var box2 = new Box(height: new Centimeter(10), width: new Centimeter(3), length: new Centimeter(10), weight: new Kilogram(9));
          var box3 = new Box(height: new Centimeter(10), width: new Centimeter(10), length: new Centimeter(89), weight: new Kilogram(19));
          var tube1 = new Tube(height: new Centimeter(10), radius: new Centimeter(10), weight: new Kilogram(19));
          var tube2 = new Tube(height: new Centimeter(12), radius: new Centimeter(15), weight: new Kilogram(4));
    }
}
