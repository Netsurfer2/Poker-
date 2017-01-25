using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class CardDiamond : SuperCard
    {
        // Field _cardsuit that has type Suit for the Diamond.
        private Suit _cardsuit = Suit.Diamond;

        // Constructor CardDiamond that takes in the enum Rank as cards_Rank.
        public CardDiamond(Rank cards_rank)
        {
            this.cardsRank = cards_rank;
        }

        // Constructor that returns _cardsuit and overrides SuperCard's cardSuit.
        public override Suit cardSuit
        {
            get
            {
                return _cardsuit;
            }
        }
        // Display a Diamond card.
        public override void Display()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("{0} of {1}s ♦", cardsRank, _cardsuit);
            Console.ResetColor();
        }
    }
}
