namespace define_a_class_person;
class Program
{
    static void Main(string[] args)
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());

        person person = new person(string name, int age); 
        Console.WriteLine(person);
    }
}

