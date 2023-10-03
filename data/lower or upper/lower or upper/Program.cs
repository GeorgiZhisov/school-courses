using System;
namespace uperlower;

class Program
{
    static void Main()
    {
        
        char input = Console.ReadLine()[0]; 
        if (char.IsUpper(input))
        {
            Console.WriteLine($"upper-case");
        }
        else if (char.IsLower(input))
        {
            Console.WriteLine($"lower-case");
        }

    }
}
