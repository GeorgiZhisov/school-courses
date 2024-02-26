namespace custom_min_function;
class Program
{
    static void Main(string[] args)
    {
        List<int> n = Console.ReadLine().Split().Select(int.Parse).ToList();
        Func<List<int>, int> func = x => x.Min();
        Console.WriteLine(func(n));
    }
}

