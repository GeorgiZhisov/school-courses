namespace chars_to_string;
class Program
{
    static void Main(string[] args)
    {
        string output = string.Empty;
        for(int i = 0; i < 3; i++)
        {
            char input = char.Parse(Console.ReadLine());
            output += input;
        }
        Console.WriteLine(output);
    }
}

