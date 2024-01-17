using System.Linq;

namespace aaaa;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] plants = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int[] days = new int[plants.Length];
        Stack<int> proximityStack = new Stack<int>();
        proximityStack.Push(0);

        for (int i = 1; i < plants.Length; i++)
        {
            int MaxDays = 0;
            while (proximityStack.Count > 0 && plants[proximityStack.Peek()] >= plants[i])
            {
                MaxDays = Math.Max(MaxDays, days[proximityStack.Pop()]);
            }
            if (proximityStack.Count > 0)
            {
                days[i] = MaxDays + 1;
            }
            proximityStack.Push(i);

        }
        Console.WriteLine(days.Max());

    }
}


