using System;
namespace Game_of_war
{
	public class Card
	{
		public CardFace Face { get; set; }
		public CardSuit Suit { get; set; }

       
        public override string ToString()
        {
            return base.ToString();
            int face = (int)Enum.Parse(typeof(CardFace), this.Face.ToString());
            char suit = (char)this.Suit;
            if(face > 10)
            {
                char charFace = this.Face.ToString()[0];

                return $"{charFace}{suit}";
            }

            return $"{face}{suit}";

        }
    }
}

