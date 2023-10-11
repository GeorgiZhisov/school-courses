namespace something_in_common;
class Program
{
    static void Main(string[] args)
    {
        string[] arr = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

        foreach(string commonword in arr)
        {
            foreach(string commonword2 in array)
            {
                if (commonword == commonword2)
                {
                    Console.Write(($"{commonword} "));
                }
            }
        }
    }
}

