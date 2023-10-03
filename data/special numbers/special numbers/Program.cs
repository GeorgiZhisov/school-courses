namespace special_numbers;
class Program
{
    static void Main(string[] args)
    {
        int input = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i<= input; i++)
        {
            int num = i;
            while (num > 0)
            {
                
                sum += num % 10;

                num /= 10;
            }

            if(sum == 5 || sum == 7 || sum == 11)
            {
                Console.WriteLine($"{i} -> True");
            }else
            {
                Console.WriteLine($"{i} -> False");
            }

            sum = 0;
        }
    }
}

