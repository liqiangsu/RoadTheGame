using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Road.Models
{
    public static class PlayerManager
    {
        static PlayerManager()
        {

        }
        public static Player GetPlayer(int id)
        {
            return ReadPlayer(id);
        }


        private static Player ReadPlayer(int id)
        {
            return new Player();
        }
    }
}
