namespace _3rd;
class Program
{
    static void Main(string[] args)
    {
        decimal[] numbers = Console.ReadLine()
            .Split("", StringSplitOptions.RemoveEmptyEntries)
            .Select(decimal.Parse)
            .ToArray();

        for (int i = 0; i< numbers.Length; i++)
        {
            Console.WriteLine($"{numbers[i]} => {Math.Round(numbers[i])}");
        }


    }
}

