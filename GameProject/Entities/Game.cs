using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Entities
{
   public class Game
    {
        public int Id { get; set; }
        public string GameName { get; set; }
        public double Price { get; set; }
        public Gamer Gamer { get; set; }
        public Campaign Campaign { get; set; }
    }
}
