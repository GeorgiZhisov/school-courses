using System;


class Program
{
    static void Main()
    {
        string password = Console.ReadLine();

        CheckIfPasswordValid(password);
    }

    static void CheckIfPasswordValid(string password)
    {
        CheckLenght(password);
        CheckCharacter(password);

        CheckDigitCount(password);

    }

    static void CheckLenght(string password)
    {
        if (password.Length < 6 && password.Length > 10)
        {
            Console.WriteLine("Password must be between 6 and 10 characters");
        }
        else if (password.Length >= 6 && password.Length <= 10 ) 
        {
            Console.WriteLine("Password is valid");
            return;
        }
    }


    static void CheckCharacter(string password)
    {
        
        foreach(char c in password)
        {
            if (!char.IsLetterOrDigit(c))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                return;
            }
        }
    }


    static void CheckDigitCount(string password)
    {
        int digitCount = 0;
        foreach (char c in password)
        {
            if (char.IsDigit(c))
            {
                digitCount++;
            }
        }

        if (digitCount < 2)
        {
            Console.WriteLine("Password must have at least 2 digits");
        }

    }

}
