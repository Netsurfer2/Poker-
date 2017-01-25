using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    // IComparable (Compares cards) and IEquatable (compares objects to one another) interfaces. 
    public abstract class SuperCard : IComparable<SuperCard>, IEquatable<SuperCard>
    {
        // Get/Set the cardsRank, but let the Children override.
        public Rank cardsRank { get; set; }
        public abstract Suit cardSuit { get; }
        public bool inplay { get; set; } 
        public string Name { get; set; }


        // Check to see if the cards are equal to one another.
        public  bool Equals(SuperCard otherCard)
        {
            if (this.Name == otherCard.Name)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Added Method to display from each card class.
        public abstract void Display();

        // Compare the cards. If other is not a valid object reference, this instance is greater.
        public int CompareTo(SuperCard other)
        {
             
            if (other == null) return 1; // Put all the valid objects at the top of the array.

            if (other.cardSuit < this.cardSuit)
            {
                return 1; // "I'm bigger that the one you passed in.
            }
            else if (other.cardSuit == this.cardSuit)
            {
                if (other.cardsRank > this.cardsRank)
                {
                    return -1;
                }
                return 0;  // Both have the same Suit.
            }
            return -1;  // the one passed it is bigger than I am.
        }
    }
}
