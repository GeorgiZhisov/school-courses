using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int[] people = new int[n];
        for (int i = 0; i < n; i++)
        {
            people[i] = int.Parse(Console.ReadLine());
        }

        int totalCourses = 0;
        int currentCount = 0;

        for (int i = 0; i < people.Length; i++)
        {
            currentCount += people[i];

            if (currentCount >= p)
            {
                totalCourses++;
                currentCount = 0;
            }
        }

        if (currentCount > 0)
        {
            totalCourses++;
        }

        Console.WriteLine(totalCourses);
    }
}


