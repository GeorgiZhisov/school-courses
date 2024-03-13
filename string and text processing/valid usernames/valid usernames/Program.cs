using System.Text;
namespace valid_usernames;
class Program
{
    static void Main(string[] args)
    {
        string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
        StringBuilder result = new StringBuilder();
        foreach(string username in usernames)
        {
            if(username.Length >= 3 && username.Length <= 16 && CheckForNumsLetter(username))
            {
                result.AppendLine(username);
            }
          
        }
    }

    static bool CheckForNumsLetter(string str)
    {
        foreach(char c in str)
        {
            if(char.IsLetter(c) && !char.IsDigit(c) && c == '-' && c =='_')
            {
                return false;
            }
        }

        return true;
    }
}

