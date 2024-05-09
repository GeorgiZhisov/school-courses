namespace student;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        string[] name = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        Student student = new Student();
        Console.WriteLine(student.ToString());
    }
}

class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
    class student
    {

    }

    public override string ToString()
    {
        return $"{FirstName} {LastName} {Grade}";
    }
}

