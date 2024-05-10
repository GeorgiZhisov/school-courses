using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        List<Employees> students = new List<Employees >();

        for (int i = 0; i < n; i++)
        {
            string[] studentInfo = Console.ReadLine().Split();
            string firstName = studentInfo[0];
            string lastName = studentInfo[1];
            double grade = double.Parse(studentInfo[2]);

            Employees student = new Employees(firstName, lastName, grade);
            students.Add(student);
        }

        students.Sort((s1, s2) => s2.Salary.CompareTo(s1.Salary));

        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }
}


class Employees
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Salary { get; set; }

    public Employees(string firstName, string lastName, double salary)
    {
        FirstName = firstName;
        LastName = lastName;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}: {Salary:F2}";
    }
}


