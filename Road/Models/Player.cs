using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Road.Models
{
    public class Player
    {
        public int Money { get; set; } = 10000;
        public int MovesAviable { get; set; } = 2;
        public RoadMap RoadMap { get; set; } = new RoadMap();
        
        public List<Card> DrawCards(int numberOfCard = 2)
        {
            var cards = new List<Card>();
            for(var i = 0; i < numberOfCard; i++)
            {
                var card = CardPool.DrawNew();
                cards.Add(card);
            }
            return cards;
        }

        public void MoveNext(Card card)
        {
            RoadMap.MoveNext(card);
            card.Apply(this);
            MovesAviable--;
        }

        public void MoveBack(int steps)
        {
            RoadMap.MoveBack(steps);
        }
    }
}
