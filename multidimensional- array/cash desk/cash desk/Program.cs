namespace cash_desk;
class Program
{
    static void Main(string[] args)
    {
        int[] transactionCount = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int clientsCount = int.Parse(Console.ReadLine());
        int transactions = transactionCount[0] + transactionCount[1] + transactionCount[2];

        int time = 0;

        while (true)
        {
            clientsCount -= transactions;
            time++;

            if(time % 4 == 0)
            {
                time++;
            }

            if (clientsCount <= 0)
            {
                break;
            }

        }

        Console.WriteLine($"Time needed: {time}h.");
    }
}

