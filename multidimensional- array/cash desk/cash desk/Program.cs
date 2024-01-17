namespace ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] transactionCount = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int clientsCount = int.Parse(Console.ReadLine());

            int time = transactionCount[0] + transactionCount[1] + transactionCount[2];

            int transactions = 0;

            while (true)
            {
                if (clientsCount <= 0)
                {
                    break;
                }

                clientsCount -= time;
                transactions++;

                if (transactions % 4 == 0)
                {
                    transactions++;
                }


            }

            Console.WriteLine($"Time needed: {transactions}h.");

        }
    }
}
