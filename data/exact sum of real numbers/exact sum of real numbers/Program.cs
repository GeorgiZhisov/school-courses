using System;

namespace exact_sum_of_real_numbers;
class Program
{
    static void Main(string[] args)
    {
        decimal n = decimal.Parse(Console.ReadLine());
        decimal sum = 0;
        
        for (int i = 0; i< n; i++)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            sum += number;
            
            

            
        }

        Console.WriteLine(sum);

    }
}

