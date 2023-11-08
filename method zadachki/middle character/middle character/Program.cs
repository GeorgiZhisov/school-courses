namespace middle_character;
class Program
{
    static void Main(string[] args)
    {

        string word = Console.ReadLine();

        PrintMiddleLetter(word);

    }


    static void PrintMiddleLetter(string word)
    {
        int length = word.Length;
        int middle = length / 2;

        if (length % 2 == 0)
        {
            Console.WriteLine(word[middle - 1].ToString() + word[middle]);
           
        }
        else
        {
            Console.WriteLine(word[middle]);
        }
    }

}

