using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    Console.WriteLine($"{alphabet[i]}{alphabet[j]}{alphabet[k]}");
                }
            }
        }
    }
}

