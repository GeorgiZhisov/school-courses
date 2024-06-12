namespace enigma_code;
class Program
{
    static void Main(string[] args)
    {
        string message = Console.ReadLine();

        string input;
        while((input = Console.ReadLine()) != "Decode")
        {
            string[] splitted = input.Split("|");

            string command = splitted[0];
            switch (command)
            {
                case "Move":
                    int lettersNumber = int.Parse(splitted[1]);
                    string textToMove = message.Substring(0, lettersNumber);

                    message = message.Remove(0, lettersNumber);
                    message += textToMove;
                    break;
                case "Insert":
                    int index = int.Parse(splitted[1]);
                    string value = splitted[2];

                    message = message.Insert(index, value);
                    break;
                case "ChangeAll":
                    string substring = splitted[1];
                    string replacement = splitted[2];

                    message = message.Replace(substring, replacement);
                    break;
               
            }
        }

        Console.WriteLine($"The decrypted message is: {message}");
    }
}

