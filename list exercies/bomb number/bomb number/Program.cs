namespace bomb_numbers
{

    class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombInfo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bombInfo[0];
            int power = bombInfo[1];

            DetonateBomb(numbers, bombNumber, power);

            Console.WriteLine(numbers.Sum());
        }

        static void DetonateBomb(List<int> numbers, int bombNumber, int power)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int leftBound = Math.Max(0, i - power);
                    int rightBound = Math.Min(numbers.Count - 1, i + power);

                    int range = rightBound - leftBound + 1;
                    numbers.RemoveRange(leftBound, range);
                    i = -1;
                }
            }
        }
    }
}


