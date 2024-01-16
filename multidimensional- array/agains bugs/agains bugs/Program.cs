namespace agains_bugs;
class Program
{
    static async void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        int[] positions = new int[n];
        int[] sprays = new int[n];

        string[] input = Console.ReadLine().Split();
        for(int i = 0; i< n; i++)
        {
            positions[i] = int.Parse(input[i]);
        }

        int days = 2;
        while (true)
        {
            bool plantDied = false;
            for(int i =1; i<n; i++)
            {
                if (sprays[i] > sprays[i - 1])
                {
                    sprays[i] = sprays[i - 1];
                    plantDied = true;
                }
            }

            if (!plantDied)
            {
                break;
            }

            days++;

        }


        Console.WriteLine(days);


    }
}

