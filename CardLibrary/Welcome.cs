using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardLibrary
{
    public static class Welcome
    {
        
        // Give's the welcome message with choice of how many cards.
        public static void WelcomeMessage()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            for (int i = 0, m = 1; i < 30; i++)
            
                for (int l = 0; l < new[] { 5, 6, 7, 6, 8, 10, 3, 10, 4, 13, 1, 13, 1, 87, 1, 27, 4, 23, 7, 20, 11, 16, 16, 11, 20, 7, 24, 3, 27, 1 }[i]; l++, m++)
                
            Console.Write((i % 2 > 0 ? "♥♣♦♠"[m % 4] : ' ') + (m % 29 > 0 ? "" : "\n"));
            Console.ResetColor();
           
            // 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("\n\nWelcome to the Poker Game!\nYou have $10.00 to start (*Each round places a bet at $1.00).\n");
            Console.WriteLine("\n       Rules: "+
                                        "\n       *Who ever gets a flush without being a tie Wins!"+
                                        "\n       *Dealer always wins in a tie, even if both get a flush!"+
                                        "\n       *Highest card count always wins (when there is no flush)!");

            //Allow the player to chose how many cards they want dealt.
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nPlease put in the amount of cards you want dealt each time: ");
            Console.ResetColor();
        }
    }
}
