using System;

public class Program
{
    public static double Calculate(double num1, char op, double num2)
    {
        switch (op)
        {
            case '*':
                return num1 * num2;
            case '/':
                return num1 / num2;
            case '+':
                return num1 + num2;
            case '-':
                return num1 - num2;
            default:
                throw new ArgumentException("Invalid operator.");
        }
    }

    static void Main()
    {
        double num1 = Convert.ToDouble(Console.ReadLine());
        char op = Convert.ToChar(Console.ReadLine());
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = Calculate(num1, op, num2);

        Console.WriteLine($"{result:F2}");
    }
}
