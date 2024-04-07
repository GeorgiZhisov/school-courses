using System.Text.RegularExpressions;
namespace regex;
class Program
{
    static void Main(string[] args)
    {
        string regexPattern = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";

        string input = Console.ReadLine();

        MatchCollection matches = Regex.Matches(input, regexPattern);

        foreach (Match match in matches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
    
