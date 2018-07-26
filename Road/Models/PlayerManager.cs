using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Road.Models
{
    public static class PlayerManager
    {
        static Player dummyPlayer;
        static PlayerManager()
        {
            dummyPlayer = new Player()
            {
                Id = 1
            };
        }
        public static Player GetPlayer(int id)
        {
            return ReadPlayer(id);
        }


        private static Player ReadPlayer(int id)
        {
            return dummyPlayer;
        }

        internal static void SavePlayer(Player player)
        {
            dummyPlayer = player;
        }
    }
}
