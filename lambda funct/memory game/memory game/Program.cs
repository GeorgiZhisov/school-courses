namespace memory_game;
class Program
{
    static void Main(string[] args)
    {


            int students = int.Parse(Console.ReadLine());
            int lectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double maxBonus = double.MinValue;
            int maxAttendances = 0;

            for (int i = 0; i < students; i++)
            {
                int attendances = int.Parse(Console.ReadLine());
                double currentBonus = (attendances / (double)lectures) * (5 + additionalBonus);

                if (currentBonus > maxBonus)
                {
                    maxBonus = currentBonus;
                    maxAttendances = attendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {maxAttendances} lectures.");

    }

}

