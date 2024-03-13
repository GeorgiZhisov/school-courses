using System.Text;
namespace text_filter;
class Program
{
    static void Main(string[] args)
    {
        string[] banlist = Console.ReadLine().Split(", ");
        StringBuilder text = new StringBuilder(Console.ReadLine());

       
            foreach (string ban in banlist)
            {
                while (text.ToString().Contains(ban))
                {
                    text.Replace(ban, new string('*', ban.Length));

                }

            }
            Console.WriteLine(text.ToString());

         
    }
}

