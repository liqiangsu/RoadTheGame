using System;

namespace Road.Models
{
    public class Card
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public CardType Type { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public void Apply(Player player)
        {

        }
    }
}