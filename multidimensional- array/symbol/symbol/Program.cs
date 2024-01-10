namespace SymbolInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool symbolExists = false;

            char[,] matrix = new char[num, num];

            for (int row = 0; row < num; row++)
            {
                string element = Console.ReadLine();

                for (int col = 0; col < num; col++)
                    matrix[row, col] = element[col];
            }

            char symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < num; row++)
            {
                for (int col = 0; col < num; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        symbolExists = true;
                        Console.WriteLine($"({row}, {col})");
                    }
                }
            }

            if (symbolExists == false)
                Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}