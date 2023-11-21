namespace train;
class Program
{
    static void Main(string[] args)
    {
        List<int> train = GetIntList();
        int capacity = int.Parse(Console.ReadLine());
        string[] command = GetStringArray();
        
        while (command[0]?.ToLower() != "end")
        {
            switch (command[0]?.ToLower())
            {
                case "add":
                    
                    train.Add(int.Parse(command[1]));
                    break;
                default:
                    AddNumberToThisList(train, capacity, command[0]);

                    break;
            }


            command = GetStringArray();
        }

        Console.WriteLine(string.Join(" ", train));
    }

    static List<int> GetIntList()
    {
        return Console.ReadLine()
            .Split(" ")
            .Select(int.Parse)
            .ToList();

    }


    static string[] GetStringArray()
    {
        return Console.ReadLine()
            .Split(" ")
            
            .ToArray();

    }

    static List<int> AddNumberToThisList(List<int> list, int capacity, string number)
    {
        int convertedNumber = int.Parse(number);

        for(int i = 0; i < list.Count; i++)
        {
            if (list[i] + convertedNumber <= capacity)
            {
                list[i] += convertedNumber;
                break;
            }

        }

        return list;
    }



}

