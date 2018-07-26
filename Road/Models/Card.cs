using System;

namespace Road.Models
{
    public class Card
    {
        static int currectId = 0;
        public int ID { get; set; } = currectId++;
        public string Name { get; set; }
        public CardType Type { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public void Apply(Player player)
        {

        }
    }
}