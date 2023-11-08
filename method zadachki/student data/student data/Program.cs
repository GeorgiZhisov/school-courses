namespace student_data;
class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int grade = int.Parse(Console.ReadLine());

        GetStudentData(name , grade);
    }

    void GetStudentData(string name, int grade) =>
        Console.WriteLine($"{name} is studying in {grade} grade");
}

