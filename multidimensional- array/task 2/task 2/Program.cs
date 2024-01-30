namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> Steel = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            Stack<int> Carbon = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToList());
            int swords = 0;
            int extraCarbon = 0;
            int CarbonSum = 0;
            while (Steel.Count > 0)
            {
                switch (Carbon.Peek() + Steel.Peek() + extraCarbon)
                {
                    case 70:
                        Console.WriteLine($"Gladius");
                        Steel.Dequeue();
                        Carbon.Pop();
                        swords++;
                        break;
                    case 80:
                        Console.WriteLine($"Shamshir");
                        Steel.Dequeue();
                        Carbon.Pop();
                        swords++;
                        break;
                    case 90:
                        Console.WriteLine($"Katana");
                        Steel.Dequeue();
                        Carbon.Pop();
                        swords++;
                        break;
                    case 110:
                        Console.WriteLine($"Sabre");
                        Steel.Dequeue();
                        Carbon.Pop();
                        swords++;
                        break;
                    case 150:
                        Console.WriteLine($"Broadsword");
                        Steel.Dequeue();
                        Carbon.Pop();
                        swords++;
                        break;
                    default:
                        Steel.Dequeue();
                        CarbonSum += 5;
                        extraCarbon += 5;
                        continue;
                }
                extraCarbon = 0;
            }
            if (swords == 0)
            {
                Console.WriteLine("You did not have enough resources to forge a sword.");
            }
            else
            {
                Console.WriteLine($"You have forged {swords} swords.");
            }
            Console.WriteLine($"Steel left: {Steel.Sum()}");
            Console.WriteLine($"Carbon left: {Carbon.Sum() + CarbonSum}");
        }


    }
}
