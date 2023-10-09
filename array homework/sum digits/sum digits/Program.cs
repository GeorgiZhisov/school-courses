using System;

class Program
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        string numberString = number.ToString();

        for (int i = 0; i < numberString.Length; i++)
        {
            sum += int.Parse(numberString[i].ToString());
        }

        Console.WriteLine(sum);
    }
}

