using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");
            string line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                //string[] cards = CardPicker.PickSomeCards(numberOfCards);
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    int index = card.
                    string[] cardPicked = new string[] { };
                    cardPicked = CardPicker.PickSomeCards(cardPicked[]);
                }

                //Console.WriteLine(numberOfCards);
            }
            else
            {
                Console.WriteLine("Wrong input! Put a number between 1 and 14!");   
            }
        }
    }
}
