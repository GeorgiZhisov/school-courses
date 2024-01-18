namespace problem_2;
class Program
{
    static void Main(string[] args)
    {

        int greenLight = int.Parse(Console.ReadLine());
        int window = int.Parse(Console.ReadLine());

        Queue<string> carsQueue = new Queue<string>();
        int passedCars = 0;
        bool accidents = false;

      

        while (true)
        {

            string Input = Console.ReadLine().ToUpper();

            if (Input == "STOP")
            {
                break;
            }

            if (Input == "LIGHT")
            {
                int remainingGreenLight = greenLight;

                while (remainingGreenLight > 0 && carsQueue.Count > 0)
                {
                    string Car = carsQueue.Dequeue();

                    if (remainingGreenLight - Car.Length >= 0)
                    {
                        remainingGreenLight -= Car.Length;
                        passedCars++;
                    }
                    else if (remainingGreenLight - Car.Length + window >= 0)
                    {
                        passedCars++;
                        break;
                    }
                    else
                    {
                        char Char = Car[remainingGreenLight + window];
                        Console.WriteLine($"Accident! {Car} was crushed at {Char}.");
                        accidents = true;
                        break;
                    }
                }
            }
            else
            {
                carsQueue.Enqueue(Input);
            }

            if (accidents)
            {
                break;
            }
        }


        if (!accidents)
        {
            Console.WriteLine("Success!");
            Console.WriteLine($"{passedCars} total cars are gone.");
        }
    }

}
      