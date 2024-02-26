namespace action_print;
class Program
{
    static void Main(string[] args)
    {

        string[] names = Console.ReadLine().Split().ToArray();
        Action<string[]> action = x => Console.WriteLine(string.Join($"\n", x));
        action(names);
    }
}

