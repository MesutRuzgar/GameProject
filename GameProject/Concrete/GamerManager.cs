using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;

        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.gamerCheckService(gamer))
            {
                Console.WriteLine(gamer.FirstName+ " İsimli oyuncu Eklendi!");
            }
            else
            {
                Console.WriteLine(gamer.FirstName + " Oyuncu eklemesi başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName +" İsteğiniz üzere oyuncu silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " Tebrikler! Oyuncu güncellendi.");
        }
    }
}
