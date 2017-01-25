using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class CardSpade: SuperCard
    {
        // Field _cardsuit that has type Suit for the Spade.
        private Suit _cardsuit = Suit.Spade;

        // Constructor CardSpade that takes in the enum Rank as cards_Rank.
        public CardSpade(Rank cards_Rank)
        {
            this.cardsRank = cards_Rank;
        }

        // Constructor that returns _cardsuit and overrides SuperCard's cardSuit in this class.
        public override Suit cardSuit
        {
            get
            {
                return this._cardsuit;
            }
        }

        // Display a Spade card while changing the colors for Spades.
        public override void Display()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("{0} of {1}s ♠", cardsRank, _cardsuit);
            Console.ResetColor();
        }
    }
}
