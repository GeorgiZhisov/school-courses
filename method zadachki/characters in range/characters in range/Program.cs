namespace characters_in_range;
class Program
{
    static void Main(string[] args)
    {
        char input1 = char.Parse(Console.ReadLine());
        char input2 = char.Parse(Console.ReadLine());

        PrintCharBetweenTwoChars(input1, input2);


    }

    static void PrintCharBetweenTwoChars(char start , char end)
    {
        char  startChar;
        char  endChar;

        if (start < end)
        {
            startChar = start;
            endChar = end;
        }else
        {
            startChar = end;
            endChar = start;
        }

        for(char i = ++startChar; i <endChar; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }

    
}

