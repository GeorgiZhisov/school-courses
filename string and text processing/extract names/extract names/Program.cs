using System.Text;
namespace extract_names;
class Program
{
    static void Main(string[] args)
    {
        string[] file = Console.ReadLine().Split('\\');
        string[] lines = file[file.Length - 1].Split('.');

        string fileName = lines[0];
        string extention = lines[1];
        Console.WriteLine($"File name: {fileName}");
        Console.WriteLine($"File extention: {extention}");
    }
}

