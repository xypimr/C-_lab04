using task02;
namespace task03;

class Program
{
    static void Main(string[] args)
    {
        var first = new Car();
        first.Name = "VAS-2107";
        first.ProductionYear = 2012;
        first.MaxSpeed = 150;
        var second = new Car();
        second.Name = "Toyota Camry SV21";
        second.ProductionYear = 1987;
        second.MaxSpeed = 200;
        var third = new Car();
        third.Name = "Audi 80 b2";
        third.ProductionYear = 1981;
        third.MaxSpeed = 160;
        CarCatalog garage = new CarCatalog();
        garage.catalog = new[] { first, second, third };
        garage.mode = "yearsearch";
        garage.searchyear = 2000;
        foreach (var variable in garage)
        {
            Console.WriteLine(variable.Name);
        }
    }
}