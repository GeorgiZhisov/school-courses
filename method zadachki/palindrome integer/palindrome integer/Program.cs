namespace Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(CheckPalindrome(input));
                input = Console.ReadLine();
            }
        }
        static string CheckPalindrome(string num)
        {
            for (int i = 0; i < num.Length / 2; i++)
            {
                if (num[i] == num[num.Length - i - 1])
                {
                    return "true";
                }
            }
            return "false";
        }
    }
}