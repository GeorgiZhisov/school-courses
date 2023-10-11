namespace everything_in_common;
class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int sum = 0;
        bool ifequal = false;

        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i] != arr2[i])
            {
                Console.WriteLine("Arrays are not identical.");
                Console.WriteLine($"Found difference at {i} index ");
                break;
            }
            sum += arr1[i];
            if(i == arr1.Length - 1 && i == arr2.Length - 1)
            {
                Console.WriteLine("Arrays are identical.");
                Console.WriteLine($"Sum: {sum} ");
            }
        }    
    

    }

}

