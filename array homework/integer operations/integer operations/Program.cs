

class Program
{
    static void Main()
    {
        
        int[] numbers = new int[4];

        
        for (int i = 0; i < 4; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

       
        int result = (numbers[0] + numbers[1]) / numbers[2] * numbers[3];

        
        Console.WriteLine(result);
    }
}
