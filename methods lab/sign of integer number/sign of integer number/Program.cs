namespace sign_of_integer_number;
class Program
{
    static void Main(string[] args)
    {

        int nums = 0;

        signOfIntegerNums(nums);

        

    }


    static void signOfIntegerNums(int nums)
    {
        nums = int.Parse(Console.ReadLine());

        if (nums > 0)
        {
            Console.WriteLine($"The number {nums} is positive.");
        }
        else if (nums == 0)
        {
            Console.WriteLine($"The number {nums} is zero.");
        }
        else
        {
            Console.WriteLine($"The number {nums} is negative.");
        }


    }
}

