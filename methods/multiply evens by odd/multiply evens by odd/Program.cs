using System;

public class Program
{
    public static int GetSumOfEvenDigits(int number)
    {
        int sum = 0;
        number = Math.Abs(number); 

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                sum += digit;
            }
            number /= 10;
        }

        return sum;
    }

    public static int GetSumOfOddDigits(int number)
    {
        int sum = 0;
        number = Math.Abs(number); 

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 != 0)
            {
                sum += digit;
            }
            number /= 10;
        }

        return sum;
    }

    public static int GetMultipleOfEvenAndOdds(int number)
    {
        int sumOfEvenDigits = GetSumOfEvenDigits(number);
        int sumOfOddDigits = GetSumOfOddDigits(number);

        return sumOfEvenDigits * sumOfOddDigits;
    }

    static void Main()
    {
        int input = -12345;
        int result = GetMultipleOfEvenAndOdds(input);

        Console.WriteLine($"Result: {result}");
    }
}
