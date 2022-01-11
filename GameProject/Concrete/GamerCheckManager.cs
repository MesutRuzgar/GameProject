using GameProject.Abstracts;
using GameProject.Entities;
using GameProject.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerCheckManager : IGamerCheckService
    {
        public bool gamerCheckService(Gamer gamer)
        {
            if (gamer.FirstName == "Mesut" && gamer.LastName == "RUZGAR" && gamer.DateOfBrith ==new DateTime(1995, 5, 8) && gamer.Nationality == "12345678910") 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
