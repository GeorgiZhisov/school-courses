namespace martoCat;
class Program
{
    static void Main(string[] args)
    {
        List<int> items = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();
        int startIndex = int.Parse(Console.ReadLine());
        string priceRating = Console.ReadLine();

        int leftSum = 0;
        int rightSum = 0;

        if (priceRating == "cheap")
        {
            leftSum = items
                .Take(startIndex)
                .Where(x => x < items[startIndex]).Sum();

            rightSum = items
                .Skip(startIndex + 1)
                .Take(startIndex)
                .Where(x => x < items[startIndex]).Sum();
        }
        else if (priceRating == "expensive")
        {
            leftSum = items
                .Take(startIndex)
                .Where(x => x > items[startIndex]).Sum();

            rightSum = items
                .Skip(startIndex + 1)
            .Take(startIndex)
            .Where(x => x > items[startIndex]).Sum();
        }
        if(rightSum <= leftSum)
        {
            Console.WriteLine($"Left - {leftSum}");
        }
        else
        {
            Console.WriteLine($"Right - {rightSum}"); 
        }
        
    }
}

