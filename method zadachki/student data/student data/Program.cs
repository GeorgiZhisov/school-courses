namespace student_data;
class Program
{
    
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            bool changesMade = false;

            while (true)
            {
                string[] command = Console.ReadLine().Split();

                if (command[0] == "end") break;

                switch (command[0])
                {
                    case "Contains":
                        Console.WriteLine(numbers.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                        break;

                    case "PrintEven":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 == 0)));
                        break;

                    case "PrintOdd":
                        Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
                        break;

                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;

                    case "Filter":
                        string condition = command[1];
                        int filterNumber = int.Parse(command[2]);
                        numbers = numbers.Where(n => (condition, n) switch
                        {
                            ("<", var x) => x < filterNumber,
                            (">", var x) => x > filterNumber,
                            ("<=", var x) => x <= filterNumber,
                            (">=", var x) => x >= filterNumber,
                            (_, _) => throw new ArgumentException("Invalid condition")
                        }).ToList();
                        changesMade = true;
                        break;

                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }

            if (changesMade) Console.WriteLine(string.Join(" ", numbers));
        }

}


