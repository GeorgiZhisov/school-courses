namespace cards_game;


class Program
{
    static void Main()
    {
        List<int> firstPlayerDeck = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> secondPlayerDeck = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        while (firstPlayerDeck.Count > 0 && secondPlayerDeck.Count > 0)
        {
            int firstPlayerCard = firstPlayerDeck[0];
            int secondPlayerCard = secondPlayerDeck[0];

            if (firstPlayerCard > secondPlayerCard)
            {
                
                firstPlayerDeck.Add(firstPlayerCard);
                firstPlayerDeck.Add(secondPlayerCard);
            }
            else if (firstPlayerCard < secondPlayerCard)
            {
              
                secondPlayerDeck.Add(secondPlayerCard);
                secondPlayerDeck.Add(firstPlayerCard);
            }

            
            firstPlayerDeck.RemoveAt(0);
            secondPlayerDeck.RemoveAt(0);
        }

        PrintWinnerAndSum(firstPlayerDeck, secondPlayerDeck);
    }

    static void PrintWinnerAndSum(List<int> firstPlayerDeck, List<int> secondPlayerDeck)
    {
        if (firstPlayerDeck.Count > 0)
        {
            Console.WriteLine($"First player wins! Sum: {firstPlayerDeck.Sum()}");
        }
        else
        {
            Console.WriteLine($"Second player wins! Sum: {secondPlayerDeck.Sum()}");
        }
    }
}
