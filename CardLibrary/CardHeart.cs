using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public class CardHeart: SuperCard
    {
        // Field _cardsuit that has type Suit for the Heart.
        private Suit _cardsuit = Suit.Heart;


        // Constructor CardHeart that takes in the enum Rank as cards_Rank.
        public CardHeart(Rank cards_Rank)
        {
            this.cardsRank = cards_Rank;
        }

        // Constructor that returns _cardsuit and overrides SuperCard's cardSuit.
        public override Suit cardSuit
        {
            get {
                   return _cardsuit;
                }
        }

        // Display a Heart card.
        public override void Display()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} of {1}s ♥", cardsRank, _cardsuit);
            Console.ResetColor();
        }
    }
}
