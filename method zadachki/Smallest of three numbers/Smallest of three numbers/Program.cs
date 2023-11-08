namespace Smallest_of_three_numbers;
class Program
{
    static void Main(string[] args)
    {
        double num = double.Parse(Console.ReadLine());
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        SmallestNumber(num, num1, num2);

        

    }

    static void SmallestNumber(double num, double num1, double num2)
    {
        if (num < num1 && num < num2)
        {
            Console.WriteLine(num);


        } else if (num1 < num && num1 < num2)
        {
            Console.WriteLine(num1);

        } else if (num2 < num && num2 < num1)
        {
            Console.WriteLine(num2);

        }else if (num == num1 && num == num2)
        {
            Console.WriteLine(num);
        }

       
    }


}

