namespace problem_1;
class Program
{
    static void Main(string[] args)
    {
        double[] priceInput = Console.ReadLine().Split().Select(double.Parse).ToArray();
        double peopleCount = double.Parse(Console.ReadLine());

        double Mats = (priceInput[2] * peopleCount) * 1.2; 

        double Balls = priceInput[0] * peopleCount;


        int freeBalls = (int)(peopleCount / 5);
        Balls -= priceInput[1] * freeBalls;

        double Blocks = priceInput[1] * (2 * peopleCount); 
        double sum = Mats + Balls + Blocks;

        Console.WriteLine($"{sum:F2}$ needed for equipment.");
    }
}

