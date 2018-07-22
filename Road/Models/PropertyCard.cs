using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Road.Models
{
    public class PropertyCard : Card
    {
        public int PurchasePrice { get; set; }
        public int BuildingCost { get; set; }
        public int DevelopmentLevel { get; set; }
        public int MaxDevelopmentLevel { get; }
        public Dictionary<int, int> RentByDevelopmentLevel { get; set; } = new Dictionary<int, int>();

        public bool LevelUp()
        {
            if (DevelopmentLevel == MaxDevelopmentLevel) return false;
            DevelopmentLevel++;
            return true;
        }

        public int GetRent()
        {
            return RentByDevelopmentLevel[DevelopmentLevel];
        }
    }
}
