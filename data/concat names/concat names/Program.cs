namespace concat_names;
class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        string surname = Console.ReadLine();
        string delimer = Console.ReadLine();


        Console.WriteLine($"{name}{delimer}{surname}");

    }
}

