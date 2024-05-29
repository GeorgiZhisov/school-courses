class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(", ");

        List<string> cards = new List<string>();

        foreach (var cardDef in input)
        {
            try
            {
                string[] parts = cardDef.Split(' ');
                if (parts.Length != 2)
                {
                    throw new ArgumentException("Invalid card!");
                }

                string face = parts[0];
                string suit = parts[1];

                Card card = CreateCard(face, suit);
                cards.Add(card.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Invalid card!");
            }
        }

        Console.WriteLine(string.Join(" ", cards));
    }
    class Card
    {
        public string Face { get; private set; }
        public string Suit { get; private set; }

        private static readonly string[] validFaces =
        {
        "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"
    };


        private static readonly string[] validSuits = { "S", "H", "D", "C" };
        private static readonly string[] suitSymbols = { "♠", "♥", "♦", "♣" };

        public Card(string face, string suit)
        {
            if (!IsValidFace(face) || !IsValidSuit(suit))
            {
                throw new ArgumentException("Invalid card!");
            }

            Face = face;
            Suit = GetSuitSymbol(suit);
        }

        private bool IsValidFace(string face)
        {
            foreach (var validFace in validFaces)
            {
                if (validFace == face)
                {
                    return true;
                }
            }
            return false;
        }

        private bool IsValidSuit(string suit)
        {
            foreach (var validSuit in validSuits)
            {
                if (validSuit == suit)
                {
                    return true;
                }
            }
            return false;
        }

        private string GetSuitSymbol(string suit)
        {
            for (int i = 0; i < validSuits.Length; i++)
            {
                if (validSuits[i] == suit)
                {
                    return suitSymbols[i];
                }
            }
            throw new ArgumentException("Invalid card!");
        }

        public override string ToString()
        {
            return $"[{Face}{Suit}]";
        }
    }

    static Card CreateCard(string face, string suit)
    {
        return new Card(face, suit);
    }
}