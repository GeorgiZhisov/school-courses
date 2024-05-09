namespace rectangle_area
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());
            string color = Console.ReadLine();

            Rectangle firstRectangle = new Rectangle(width, heigth, color);
            Console.WriteLine($"React({firstRectangle.Width}, {firstRectangle.Height}, {firstRectangle.Color}) has area {firstRectangle.CalcArea()}.");
        }
    }
}

