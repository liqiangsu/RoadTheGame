using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Road.Models
{
    public class RoadMap
    {
        public int CurrenctPosition { get; set; }
        public List<RoadPoint> Map { get; set; } = new List<RoadPoint>() { new RoadPoint(new StartPoint()) };

        public RoadPoint CurrectRoadPoint => Map.ElementAt(CurrenctPosition);

        public void MoveNext(Card card)
        {
            CurrenctPosition++;
            Map.Add(new RoadPoint(card));
        }

        public void MoveBack(int numberOfStep)
        {
            if(numberOfStep > CurrenctPosition)
            {
                CurrenctPosition = 0;
            }
            CurrenctPosition -= numberOfStep;
        }
    }
}
