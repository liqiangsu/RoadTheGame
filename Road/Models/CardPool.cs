using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Road.Models
{
    public static class CardPool
    {
        private static List<Card> Cards = new List<Card>();
        static CardPool()
        {
            Cards.Add(new StartPoint());
            var propertiesNames = new List<string>() { "MEDITERRANEAN AVENUE",
"BALTIC AVENUE",
"READING RAILROAD",
"ORIENTAL AVENUE",
"VERMONT AVENUE",
"CONNECTICUT AVENUE",
"ST. CHARLES PLACE",
"ELECTRIC COMPANY",
"STATES AVENUE",
"VIRGINIA AVENUE",
"PENNSYLVANIA RAILROAD",
"ST. JAMES PLACE",
"TENNESSEE AVENUE",
"NEW YORK AVENUE",
"KENTUCKY AVENUE",
"INDIANA AVENUE",
"ILLINOIS AVENUE",
"B. & O. RAILROAD",
"ATLANTIC AVENUE",
"VENTNOR AVENUE",
"WATER WORKS",
"MARVIN GARDENS",
"PACIFIC AVENUE",
"NORTH CAROLINA AVENUE",
"PENNSYLVANIA AVENUE",
"SHORT LINE RAILROAD",
"PARK PLACE",
"BOARDWALK"};
            foreach(var name in propertiesNames)
            {
                Cards.Add(new PropertyCard() { Name = name });
            }
        }
        private static void LoadCards()
        {
            //TODO load cards form database or file
            Cards = new List<Card>();
        }
        static Random Ran = new Random();
        internal static Card DrawNew()
        {
            return Cards[Ran.Next(Cards.Count)];
        }
    }
}
