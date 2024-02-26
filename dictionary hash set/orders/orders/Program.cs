namespace orders;
class Program
{
    static void Main(string[] args)
    {
        var products = new Dictionary<string, List<double>>();
        string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
        while(input[0] != "buy")
        {
            string product = input[0];
            double price = double.Parse(input[1]);
            int qty = int.Parse(input[2]);

            if (products.ContainsKey(product))
            {
                products[product][0] = price;
                products[product][1] += qty;
            }
            else
            {
                products.Add(product, new List<double>());
                products[product].Add(price);
                products[product].Add(qty);
            }
        }

        foreach(var kvp in products)
        {
            double totalPrice = kvp.Value[0] * kvp.Value[1];
            Console.WriteLine($"{kvp.Key} -> {totalPrice:F2}");
        }
    }
}

