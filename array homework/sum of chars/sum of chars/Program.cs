using System;


class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        char[] characters = new char[n];

        for (int i = 0; i < n; i++)
        {
            characters[i] = char.Parse(Console.ReadLine());
        }

        int totalSum = 0;

        for (int i = 0; i < n; i++)
        {
            totalSum += (int)characters[i];
        }

        Console.WriteLine($"The sum equals: {totalSum}");
    }
}
