using System.Text;

namespace repeat_string_the_other_is_reverse;
class Program
{
    static void Main(string[] args)
    {
        string[] words = Console.ReadLine().Split();
        StringBuilder result = new StringBuilder();
        foreach(string word in words)
        {
            for(int i = 0; i<word.Length; i++)
            {
                result.Append(word);
            }
            Console.WriteLine(result.ToString());
        }
    }
}

