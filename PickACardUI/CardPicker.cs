using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickACardUI
{
    class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)    
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // get a random number from 1 to 4
            int value = random.Next(1, 5);
            // if it's 1 reutrn the string Spades
            if (value == 1) return "Spades";
            // if it's 2 return string Hearts
            if (value == 2) return "Hearts";
            // if it's 3 return the string Clubs
            if (value == 3) return "Clubs";
            // if we haven't returned yet, return the string Diamonds
            return "Diamonds";
        }

        private static string RandomValue()
        {
            // get a random number from 1 to 13
            int value = random.Next(1, 14);
            // if it's 1 return the Ace
            if (value == 1) return "Ace";
            // if 11 return the Jack
            if (value == 11) return "Jack";
            // if 12 return the Queen
            if (value == 12) return "Queen";
            // if 13 return the King
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
