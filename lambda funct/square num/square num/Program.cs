
namespace square_num;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        Stack<string> textStates = new Stack<string>();
        string text = string.Empty;

        for (int i = 0; i < n; i++)
        {
            string[] operation = Console.ReadLine().Split();
            string command = operation[0];

            switch (command)
            {
                case "1":
                    textStates.Push(text);
                    string someString = operation[1];
                    text += someString;
                    break;
                case "2":
                    textStates.Push(text);
                    int count = int.Parse(operation[1]);
                    text = text.Substring(0, Math.Max(0, text.Length - count));
                    break;
                case "3":
                    int index = int.Parse(operation[1]) - 1;
                    Console.WriteLine(text[index]);
                    break;
                case "4":
                    if (textStates.Count > 0)
                    {
                        text = textStates.Pop();
                    }
                    break;
            }
        }
    }
}