using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager : IGameService
    {
       
        public void Add(Game game)
        {
            Console.WriteLine(game.GameName +"İsimli yeni oyun eklendi.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine(game.GameName + "İsimli oyun isteğiniz üzere silindi.");

        }

        public void Sale(Game game)
        {
            Console.WriteLine(game.GameName+ " İsimli oyun "+ game.Gamer.FirstName+ "  Adlı oyuncu tarafından "+game.Campaign.CampaignName+ "  ile "+game.Campaign.Discount+ "  Oranlı indirimle "+ (game.Price-(game.Price*game.Campaign.Discount))+ " $ Fiyata satılmıştır." );
        }

        public void Update(Game game)
        {
            Console.WriteLine(game.GameName + "Tebrikler! Oyununuz Güncellendi.");

           
        }
       
    }
}
