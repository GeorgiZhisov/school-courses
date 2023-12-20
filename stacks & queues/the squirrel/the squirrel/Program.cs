namespace the_squirrel;
class Program
{
    static void Main(string[] args)
    {

        int people = int.Parse(Console.ReadLine());

        int[] lifts = Console.ReadLine()
            .Split()
            .Select(int.Parse)

            .ToArray();

        for (int i = 0; i < lifts.Length; i++)
        {
            while (lifts[i] < 4 && people > 0)
            {
                lifts[i]++;
                people--;
            }
        } 

        if (people == 0)
        {
            int[] arr = lifts.Where(w => w < 4).ToArray();
            if (arr.Length > 0)
            {
                Console.WriteLine($"The lift has empty spots!");
                Console.WriteLine(string.Join(" ", lifts));


            }
            else 
            {
                Console.WriteLine(string.Join(" ", lifts));

            }




        }
   
        else if (people > 0)
        {
            Console.WriteLine($"There isn't enough space! {people} people in a queue!");
            Console.WriteLine(string.Join(" ", lifts));
        }
     
    }
}



