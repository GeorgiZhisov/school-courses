namespace sum_adjancent_equal_numbers__;
class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

        double lenght = numbers.Count;


       Console.WriteLine(CheckSymbol(lenght, numbers));
        
    }

    static string CheckSymbol(double lenght, List<double> numbers)
    {

        
        for (int i = 0; i < lenght; i++)
        {
            if (i == numbers.Count - 1)
            {
                break;
            }
            if (numbers[i] == numbers[i + 1])
            {

                numbers[i] += numbers[i + 1];
                numbers.RemoveAt(i + 1);
                i = -1;

            }

        }
        return string.Join(" ", numbers);


    }

}

