namespace exam_preparation_number_1;
class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        int efficiency = int.Parse(input[0]);
        int efficiency2 = int.Parse(input[1]);
        int efficiency3 = int.Parse(input[2]);

        int transactions = int.Parse(Console.ReadLine());

        int totalEfficiency = efficiency + efficiency2 + efficiency3;

        int workTime = 0;
        while(transactions > 0)
        {
            workTime++;
        }
        if(workTime % 2 != 0)
        {
            transactions += totalEfficiency;
            if(totalEfficiency <= 0)
            {
                totalEfficiency = 0;
            }
        }

        Console.WriteLine($"Time needed: {workTime}");

    }
}

