namespace custom_coparator;
class Program
{
    static void Main(string[] args)
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Array.Sort(arr);

        List<int> sortedList = new List<int>();
        Func<int, bool> func = x => x % 2 == 0;

        foreach(int num in arr)
        {
            if(func(num))
            {
                sortedList.Add(num);
            }

        }

        foreach(int num in arr)
        {
            if (!func(num))
            {
                sortedList.Add(num);
            }
        }

        //Console.WriteLine(string.Join(" ", sortedList));
        Action<List<int>> print = x => Console.Write(string.Join(" ", x));
        print(sortedList);
    }
}

