namespace the_pianist;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<string>> pieces = new Dictionary<string, List<string>>();

        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split("|");
            string piece = input[0];
            string composer = input[1];
            string key = input[2];

            if (!pieces.ContainsKey(piece))
            {
                pieces[piece] = new List<string>();
                pieces[piece].Add(composer);
                pieces[piece].Add(key);
            }
        }

        string commandInput;
        while((commandInput = Console.ReadLine()) != "Stop")
        {
            string[] commandTokens = commandInput.Split("|");

            string command = commandTokens[0];
            string piece = commandTokens[1];

            switch (command)
            {
                case "Add":
                    if (pieces.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        string composer = commandTokens[2];
                        string key = commandTokens[3];

                        pieces[piece] = new List<string>();
                        pieces[piece].Add(composer);
                        pieces[piece].Add(key);

                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    break;

                case "Remove":
                    if (pieces.ContainsKey(piece))
                    {
                        pieces.Remove(piece);
                        Console.WriteLine($"Succesfully removed {piece}");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection");
                    }
                    break;

                case "ChangeKey":
                    string newKey = commandTokens[2];
                    if (pieces.ContainsKey(piece))
                    {
                        pieces[piece][2] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operatio! {piece} does not exist in the collection");
                    }
                    break;
            }

         
        }
        foreach (var piece in pieces.OrderBy(x => x.Key).ThenBy(x => x.Value[0]))
        {
            Console.WriteLine($"{piece.Key} -> Composer:{piece.Value[0]}, Key: {piece.Value[1]}");
        }
    }
}

