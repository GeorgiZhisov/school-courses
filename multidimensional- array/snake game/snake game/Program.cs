namespace snake_game;
class Program
{
    static void Main(string[] args)
    {
        int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
    string snake = Console.ReadLine();
    int snakePont = 0;

    char[][] Path = new char[input[0]][];

            for (int row = 0; row<input[0]; row++)
            {
                Path[row] = new char[input[1]];
                for (int col = 0; col<input[1]; col++)
                {
                   Path[row][col] = snake[snakePont];

                    if (snakePont == snake.Length - 1)
                        snakePont = 0;
                    else
                        snakePont++;
                }

                if (row % 2 != 0)
                    Path[row] = Path[row].Reverse().ToArray();
            }

            for (int i = 0; i < input[0]; i++)
{
    for (int j = 0; j < input[1]; j++)
    {
        Console.Write(Path[i][j]);
    }
    Console.WriteLine();
}
        }
    }
}