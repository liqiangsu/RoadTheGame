using System;

namespace Road.Models
{
    public class RoadPoint
    {
        public Card Card { get; set; }
        public DateTime CreateTime { get; set; }
        public RoadPoint(Card card)
        {
            this.Card = card; 
            this.CreateTime = DateTime.UtcNow;
        }
    }
}