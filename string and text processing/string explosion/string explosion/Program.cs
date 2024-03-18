namespace string_explosion;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        for(int i = 0; i < input.Length; i++)
        {
            if (input[i] == '>')
            {
                for(int j = 0; j< input[i + 1]; j++)
                {
                    int strenght = input[i + 1]; 
                    if (input[j] == '>')
                    {
                        strenght += input[j + 1];
                    }
                    else
                    {
                        input.Remove(j, strenght);
                    }
                    
                }
            }
        }
    }
}

