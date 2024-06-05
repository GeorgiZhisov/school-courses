namespace Line_numbers;
class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = @"..\..\..\Folder\input.txt";
        string outputFilePath = @"..\..\..\Folder\output.txt";

        RewriteFileWithLineNumbers(inputFilePath, outputFilePath);
    }
    static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
    {
        var reader = new StreamReader(inputFilePath);

        using (reader)
        {
            string Line = reader.ReadLine();
            int counter = 1;

            using (var writer = new StreamWriter(outputFilePath))
            {
                while (Line != null)
                {
                    writer.WriteLine($"{counter}.{Line}");
                    counter++;
                    Line = reader.ReadLine();
                    
                }
            }
        }

     


    }
}

