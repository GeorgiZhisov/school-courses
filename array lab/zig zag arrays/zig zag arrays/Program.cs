namespace zig_zag_arrays;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] firstarr = new int[n];
        int[] secondarr = new int[n];

        for(int i = 1; i <= n; i++)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            if (i % 2 == 0)
            {
                secondarr[i - 1] = arr[0];
                firstarr[i - 1] = arr[1];
                
            }
            else
            {
                secondarr[i - 1] = arr[1];
                firstarr[i - 1] = arr[0];
            }

           
        }
        Console.WriteLine(string.Join(" ", firstarr));
        Console.WriteLine(string.Join(" ", secondarr));
    }
}

