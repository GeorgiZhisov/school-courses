namespace naming_sir;
class Program
{
    static void Main(string[] args)
    {
        string[] names = Console.ReadLine().Split();
        Action<string> sir = x => Console.WriteLine("sir "+ x);
        foreach (var name in names)
        {
            sir(name);
        }
    }
}

