namespace calculateRectangleArea;
class Program
{
    static void Main(string[] args)
    {
        int sideA = int.Parse(Console.ReadLine());
        int sideB = int.Parse(Console.ReadLine());

       Console.WriteLine(rectangleshort(sideA, sideB));



       // Console.WriteLine(recatngle(sideA, sideB));
       
    }



  //  static int recatngle (int a , int b)
    //  {
    //    Console.WriteLine($"Long method result:");
      //  int result = a + b;
        //  return result;


    //  }

    static int rectangleshort(int a, int b) => a * b;
}

