namespace array_rotation;
class Program
{
    static void Main(string[] args)
    {

        int[] arr = Console.ReadLine().
            Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = arr.Length - 1; j >= 0; i--)
            {
                int tmep = arr[arr.Length - 1];
                arr[arr.Length - 1] = arr[j];
                arr[j] = tmep;
            }  

        }
        Console.WriteLine(string.Join(" ", arr));
    }
}

