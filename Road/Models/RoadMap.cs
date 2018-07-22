using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Road.Models
{
    public class RoadMap
    {
        public int CurrenctPosition { get; set; }
        public LinkedList<RoadPoint> Map { get; set; } = new LinkedList<RoadPoint>();

        public RoadPoint CurrectRoadPoint => Map.ElementAt(CurrenctPosition);

        public void MoveNext(Card card)
        {
            CurrenctPosition++;
            Map.AddLast(new RoadPoint(card));
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
