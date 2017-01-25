using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class CardClub: SuperCard 
    {
        // Field _cardsuit that has type Suit for the Clubs.
        private Suit _cardsuit = Suit.Club;

        // Constructor CardClub that takes in the enum Rank as cards_Rank.
        public CardClub(Rank cards_Rank)
        {
            this.cardsRank = cards_Rank;
        }

        // Constructor that returns _cardsuit and overrides SuperCard's cardSuit.
        public override Suit cardSuit
        {
            get
            {
                return _cardsuit;
            }
        }

        // Display a club card, change the colors for club cards.
        public override void Display()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("{0} of {1}s ♣", cardsRank, _cardsuit);
            Console.ResetColor();
        }

        
    }
}
