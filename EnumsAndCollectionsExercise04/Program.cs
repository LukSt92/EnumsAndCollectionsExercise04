using EnumsAndCollectionsExercise01;
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
        }

        public static Card RandomCard()
        {
            return new Card((Values)random.Next(1,14), (Suits)random.Next(4));
        }
        public static void PrintCards(List<Card> cards)
        {
            foreach(Card card in cards)
                Console.WriteLine(card.Name);
        }
    }
}
