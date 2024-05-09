namespace car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VM";
            car.Model = "MK£";
            car.Year = 1992;

            Console.WriteLine($"Make: {car.Make} \nModel: {car.Model} \nYear: {car.Year}");
        }
    }
}

