using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        string[] models = new string[n];
        double[] volumes = new double[n];

        for (int i = 0; i < n; i++)
        {
            string model = Console.ReadLine();
            double radius = double.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double volume = Math.PI * Math.Pow(radius, 2) * height;

            models[i] = model;
            volumes[i] = volume;
        }

        int maxVolumeIndex = Array.IndexOf(volumes, volumes.Max());

        Console.WriteLine(models[maxVolumeIndex]);
    }
}
