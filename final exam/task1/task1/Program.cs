using System;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string input;

            while ((input = Console.ReadLine()) != "Read")
            {
                string[] splitted = input.Split("<->");
                string command = splitted[0];

                switch (command)
                {
                    case "Space":
                        int index = int.Parse(splitted[1]);
                        message = message.Insert(index, " ");
                        break;

                    case "Backward":
                        string substring = splitted[1];
                        int substringIndex = message.IndexOf(substring);

                        if (substringIndex != -1)
                        {
                            string textToMove = substring;
                            string reversedText = new string(textToMove.Reverse().ToArray());

                            message = message.Remove(substringIndex, textToMove.Length);
                            message += reversedText;
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "ReplaceAll":
                        string target = splitted[1];
                        string replacement = splitted[2];
                        message = message.Replace(target, replacement);
                        break;
                }

                Console.WriteLine(message);
            }

            Console.WriteLine($"You have a secret text message: {message}");
        }
    }
}
