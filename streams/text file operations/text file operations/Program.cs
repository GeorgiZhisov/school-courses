namespace text_file_operations;
class Program
{
    static void Main(string[] args)
    {
        string inputFilePath = @"..\..\..\intup.txt\input.txt";
        string outputFilePath = @"..\..\..\intup.txt\output.txt";
        ExtractOddLines(inputFilePath, outputFilePath);

    }

    static void ExtractOddLines(string inputFilePath, string outputFilePath)
    {

        var reader = new StreamReader("input.txt");

        using (reader)
        {

            int counter = 0;

            string line = reader.ReadLine();

            using (var writer = new StreamWriter("output.txt"))
            {

                while (line != null)

                    if (counter % 2 == 1)

                        writer.WriteLine(line);

                counter++;

                line = reader.ReadLine();

            }

        }
    }
}