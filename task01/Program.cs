namespace task01;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите пределы: (min max)");
        var per = Console.ReadLine().Split(' ');
        Matrix.Min = int.Parse(per[0]);
        Matrix.Max = int.Parse(per[1]);
        Matrix m1 = new Matrix(3, 3);
        m1.Print();
    }
}