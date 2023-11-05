namespace Grades;
class Program
{
    static void Main(string[] args)
    {
        double grade = double.Parse(Console.ReadLine());

        PrintInWords(grade);
    }
        
   static void PrintInWords(double grades)
    {
        string gradeInWords = string.Empty;

        if(grades >= 2 && grades <= 2.99)
        {
            gradeInWords = "Fail";

        }else if (grades >= 3 && grades<= 3.49)
        {
            gradeInWords = "Poor";

        }else if (grades >= 3.50 && grades <= 4.49)
        {
            gradeInWords = "Good";

        }else if (grades >= 4.50 && grades <= 5.49)
        {
            gradeInWords = "Very good";

        }else if(grades >= 5.50 && grades == 6)
        {
            gradeInWords = "Excellent";
        }

        Console.WriteLine(gradeInWords);

    }
}

