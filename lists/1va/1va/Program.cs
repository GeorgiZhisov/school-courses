namespace _1va;
class Program
{
    static void Main(string[] args)
    {
        List<int> number = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();


        int lenght = number.Count;


        for(int i = 0; i < lenght; i++)
        {

        }

    }
}

