namespace task02;

class Program
{
    static void Main(string[] args)
    {
        void Print(Car[] a)
        {
            foreach (var variable in a)
            {
                Console.WriteLine(variable.Name);
            }
            Console.WriteLine("\n");
        }
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
        Car[] garage = { first, second, third };
        Array.Sort(garage, new CarComparer()); 
        Print(garage);
        CarComparer.mode = "speed";
        Array.Sort(garage,  new CarComparer());
        Print(garage);
        CarComparer.mode = "year";
        Array.Sort(garage,  new CarComparer());
        Print(garage);
    }
}