class Program
{
    static void Main()
    {
        int[] initialFuel = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] consumptionIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int[] neededFuel = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int altitudesCount = initialFuel.Length;

        for (int altitude = 0; altitude < altitudesCount; altitude++)
        {
            int currentFuel = initialFuel[altitudesCount - 1];
            int consumptionIndex = consumptionIndexes[0];

            int remainingFuel = currentFuel - consumptionIndex;

            if (remainingFuel >= neededFuel[altitude])
            {
                Console.WriteLine($"John has reached: Altitude {altitude + 1}");
                initialFuel = initialFuel.Take(altitudesCount - 1).ToArray();
                consumptionIndexes = consumptionIndexes.Skip(1).ToArray();
            }
            else
            {
                Console.WriteLine($"John did not reach: Altitude {altitude + 1}");
                Console.WriteLine("John failed to reach the top.");
                Console.WriteLine($"Reached altitudes: {string.Join(", ", Enumerable.Range(1, altitude))}");
                return;
            }
        }

        Console.WriteLine("John has reached all the altitudes and managed to reach the top!");
    }
}