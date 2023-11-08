namespace Repeat_String;
class Program
{
    static void Main(string[] args)
    {
        string txt = Console.ReadLine();
        double n = double.Parse(Console.ReadLine());
        
        Console.WriteLine(NewText(txt, n));

    }
        
       static string NewText (string text, double n)
    {
        string result = "";

        for (int i = 0; i < n; i++)
        {
            result += text;


         }
        return result;

    }
}

