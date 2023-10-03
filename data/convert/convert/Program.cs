namespace convert;
class Program
{
    static void Main(string[] args)
    {
        decimal input = decimal.Parse(Console.ReadLine());
        decimal output = input / 1000;
        Console.WriteLine($"{output:F02}");
    }
}

