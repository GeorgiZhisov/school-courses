using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int tankCapacity = 255;
        int[] quantities = new int[n];

        for (int i = 0; i < n; i++)
        {
            quantities[i] = int.Parse(Console.ReadLine());
        }

        int totalLiters = 0;

        for (int i = 0; i < n; i++)
        {
            if (totalLiters + quantities[i] > tankCapacity)
            {
                Console.WriteLine("Insufficient capacity!");
            }
            else
            {
                totalLiters += quantities[i];
            }
        }

        Console.WriteLine(totalLiters);
    }
}


