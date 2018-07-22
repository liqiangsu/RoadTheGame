using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Road.Models
{
    public static class CardPool
    {
        private static List<Card> Cards = new List<Card>();

        private static void LoadCards()
        {
            //TODO load cards form database or file
            Cards = new List<Card>();
        }
        internal static Card DrawNew(int seed = 0)
        {
            var ran = new Random(seed);
            return Cards[ran.Next(Cards.Count)];
        }
    }
}
