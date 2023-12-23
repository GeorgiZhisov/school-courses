namespace flower_wreaths;
class Program
{
    static void Main(string[] args)
    {
        List<int> lilies = Console.ReadLine().Split(", ").Select(int.Parse).ToList();
        List<int> roses = Console.ReadLine().Split(", ").Select(int.Parse).ToList();

        int wreathsCount = 0;
        int neededWreaths = 5;

        while (lilies.Count > 0 && roses.Count > 0 && wreathsCount < neededWreaths)
        {
            int sum = lilies.Last() + roses.First();

            if (sum == 15)
            {
                lilies.RemoveAt(lilies.Count - 1);
                roses.RemoveAt(0);
                wreathsCount++;
            }
            else if (sum > 15)
            {
                lilies[lilies.Count - 1] -= 2;
                roses.RemoveAt(0);
            }
            else
            {
                lilies.RemoveAt(lilies.Count - 1);
                roses.RemoveAt(0);
            }
        }

        int remainingFlowers = lilies.Sum() + roses.Sum();

        if (wreathsCount > neededWreaths)
        {
            Console.WriteLine($"You made it, you are going to the competition with {wreathsCount} wreaths!");
        }
        else
        {
            int moreWreathsNeeded = neededWreaths - wreathsCount;
            Console.WriteLine($"You didn't make it, you need {moreWreathsNeeded} wreaths more!");
        }


    }
}