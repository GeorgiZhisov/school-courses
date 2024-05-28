using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] elements = input.Split(' ');

        long sum = 0;

        foreach (string element in elements)
        {
            sum = ProcessElement(element, sum);
        }

        Console.WriteLine($"The total sum of all integers is: {sum}");
    }

    static long ProcessElement(string element, long currentSum)
    {
        try
        {
            int number = int.Parse(element);
            currentSum += number;
        }
        catch (FormatException)
        {
            Console.WriteLine($"The element '{element}' is in wrong format!");
        }
        catch (OverflowException)
        {
            Console.WriteLine($"The element '{element}' is out of range!");
        }

        Console.WriteLine($"Element '{element}' processed - current sum: {currentSum}");
        return currentSum;
    }
}
