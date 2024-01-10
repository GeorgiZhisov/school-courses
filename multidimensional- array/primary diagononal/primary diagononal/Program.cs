namespace primary_diagonal;
internal class Program
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int diagonalS = 0;

        int[,] matrix = new int[num, num];

        for (int row = 0; row < num; row++)
        {
            int[] element = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int col = 0; col < num; col++)
            {

                matrix[row, col] = element[col];
            }
        }

        for (int position = 0; position < num; position++)
        {
            diagonalS += matrix[position, position];
        }

        Console.WriteLine(diagonalS);
    }
}
}