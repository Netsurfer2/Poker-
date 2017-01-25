using System;
using CardLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{

    public class CardSet
    {
        // Instantiate an object called rnd at random.
        Random rnd = new Random();
        SuperCard[] cardArray;

        // Indexer with get. Get's the cardArray.
        public SuperCard this[int index]
        {
            get
            {
                return cardArray[index]; // Get's each index randomly out of the 52 indexes for each card.
            }
        }

        /* Loop through all 52 cards and add to the cardArray for each suit. */
        public CardSet()
        {
            cardArray = new SuperCard[52];
            int index1 = 0;

            while(index1 < 52)
            {             
                   for(int index2 = 2; index2 <= 14; index2++) // Iterates through each card.
                        cardArray[index1++] = new CardClub((Rank)(index2)); // Adds into the index of the array.
                   for (int index2 = 2; index2 <= 14; index2++)
                        cardArray[index1++] = new CardDiamond((Rank)(index2));
                   for (int index2 = 2; index2 <= 14; index2++)
                        cardArray[index1++] = new CardHeart((Rank)(index2));
                   for (int index2 = 2; index2 <= 14; index2++)
                        cardArray[index1++] = new CardSpade((Rank)(index2));                
            }
        }

        /* Loop through up to five times while taking out a random card,
           move into the variable temp. Check to see if the temp is not
           in play, then count it as in play, add the card to Cards array
           and then set the temp array as true (cards being used).  
           Finally return the Cards. Note: number corresponds to five (Cards). */
        public SuperCard[] GetCards(int number)
        {
            SuperCard[] Cards = new SuperCard[number];

            for (int i = 0; i < number; i++) {
                Cards[i] = GetOneCard();
            }
            return Cards; // Return all five cards in the Card array.
        }

        /*Loop through to get a random card that is not inplay. 
          Then take the lowest number card out and replace it with a random card.*/
          // Just returns one random card. 
        public SuperCard GetOneCard() 
        {
            // Loop through 0 - 52 and check if the card is in play. If not, then return the card. 
            int temp;
            do
            {
                temp = rnd.Next(0, 52); // Get a random number from 0 to 52.

            } while (this[temp].inplay); // Check to see if the random number is in play.

            /* This checks to see if the cards are in play. Set the card inplay equal to true
               (doesn't use it again). Same typeof, return one card.*/
            this[temp].inplay = true; // 
            SuperCard oneCard = this[temp]; 
            return oneCard; // Returns the one card. 
        }

        // Resets the cards to all false on inplay inside the card array (Each Round).
        public void ResetUsage()
        {
            for(int i = 0; i< 52; i++)
            {
                cardArray[i].inplay = false;
            }

        }
    }
}
