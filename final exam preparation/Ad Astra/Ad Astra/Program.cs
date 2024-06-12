    using System.Text.RegularExpressions;

    namespace ad_astra
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                string pattern = @"([|#])(?<item>[A-z\s]+)\1(?<date>\d{2}\/\d{2}\/\d{2})\1(?<calories>[0-9]{1,4}|10000)\1";

                string text = Console.ReadLine();
                int calories = 0;

                foreach (Match match in Regex.Matches(text, pattern))
                {
                    calories += int.Parse(match.Groups["calories"].Value);
                }
                int totalDays = calories / 2000;

                Console.WriteLine($"You have food to last you for: {totalDays} days!");
                foreach (Match match in Regex.Matches(text, pattern))
                {
                    Console.WriteLine($"Item: {match.Groups["item"].Value}, Best before: {match.Groups["date"].Value}, " +
                        $"Nutrition: {match.Groups["calories"].Value}");
                }
            }

        }
    }

