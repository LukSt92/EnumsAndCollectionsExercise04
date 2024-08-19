using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumsAndCollectionsExercise04
{
    internal class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            IComparer<Card> valueComparer = new CardComparerByValue();
            Console.Write("Enter number of cards: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfCards))
                for (int i = 1; i < numberOfCards; i++)
                    cards.Add(RandomCard());
                PrintCards(cards);
                Console.WriteLine("\n... Sorting the cards ....\n");
                cards.Sort(valueComparer);
                PrintCards(cards);
        }

        static Card RandomCard()
        {
            return new Card((Values)random.Next(1,14), (Suits)random.Next(4));
        }
        static void PrintCards(List<Card> cards)
        {
            foreach(Card card in cards)
                Console.WriteLine(card.Name);
        }
    }
}
