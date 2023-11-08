namespace Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{FactDiv(num1, num2):f2}");

        }
        static decimal FactDiv(int fNum, int sNum)
        {
            decimal f1 = CalculateFactorial(fNum);
            decimal f2 = CalculateFactorial(sNum);
            return f1 / f2;
        }
        static decimal CalculateFactorial(decimal n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
    }
}
