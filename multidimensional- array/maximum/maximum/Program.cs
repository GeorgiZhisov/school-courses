

namespace squaremaximumsum;
internal class Program
{
    static void Main(string[] args)
    {
        int[] size = Console.ReadLine()
          .Split(", ")
          .Select(int.Parse)
          .ToArray();

        int[,] matrix = new int[size[0], size[1]];
        int[,] secondMatrix = new int[2, 2];
        int biggestSum = int.MinValue;

        for (int row = 0; row < size[0]; row++)
        {
            int[] element = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            for (int col = 0; col < size[1]; col++)
                matrix[row, col] = element[col];
        }

        for (int row = 0; row < size[0] - 1; row++)
        {
            for (int col = 0; col < size[1] - 1; col++)
            {
                int sum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];

                if (sum > biggestSum)
                {
                    biggestSum = sum;
                    secondMatrix[0, 0] = matrix[row, col];
                    secondMatrix[0, 1] = matrix[row, col + 1];
                    secondMatrix[1, 0] = matrix[row + 1, col];
                    secondMatrix[1, 1] = matrix[row + 1, col + 1];
                }
            }
        }

        Console.WriteLine($"{secondMatrix[0, 0]} {secondMatrix[0, 1]}");
        Console.WriteLine($"{secondMatrix[1, 0]} {secondMatrix[1, 1]}");
        Console.WriteLine(biggestSum);
    }
}
}