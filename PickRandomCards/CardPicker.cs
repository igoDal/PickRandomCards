using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    class CardPicker
    {
        private static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickCards[i] = RandomValue() + " of " + RandomSuit();
            }

            return pickCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);
            //get a random number from 1 to 4 (5 is not included)
            if (value == 1)
                return "Spades";
            if (value == 2)
                return "Hearts";
            if (value == 3)
                return "Clubs";
            return "Diamonds"; //it's like else statement
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) //if it's 1 - return string Ace
                return "Ace";
            if (value == 11) // if the value is 11 - return string Jack
                return "Jack";
            if (value == 12) //if the value is 12 - return string Queen
                return "Queen";
            if (value == 13) //if the value is 13 - return string King
                return "King";
            return value.ToString(); //this will return an int value (2-10) AS STRING -> "2" instead 2
        }
    }
}
