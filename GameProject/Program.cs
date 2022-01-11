using GameProject.Abstracts;
using GameProject.Entities;
using GameProject.Concrete;
using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Campaign> kampanyalar = new List<Campaign>() { new Campaign { CampaignName = "Öğrenci Kampanyası", Id = 1, Discount = 0.15 }, new Campaign { CampaignName = "Kış İndirimi", Id = 2, Discount = 0.25 } };

            Gamer gamer1 = new Gamer()
            {
                DateOfBrith = new DateTime(1995, 05, 08),
                FirstName = "Mesut",
                LastName = "RUZGAR",
                Nationality = "12345678910"
            };
            Gamer gamer2 = new Gamer()
            {
                DateOfBrith = new DateTime(2003,02,20),FirstName="Umut",LastName="RUZGAR",Nationality="01987654321"
            };

            
            Game game1 = new Game()
            { GameName="Counter Strike",Gamer=gamer1,Id=1,Price=30.99,Campaign=kampanyalar[0]
            };
            Game game2 = new Game() 
            {
                GameName="Far Cry 5",Gamer=gamer2,Id=2,Price=55.66,Campaign=kampanyalar[1]
            };

                       

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Delete(gamer2);
            gamerManager.Update(gamer1);

            GameManager gameManager=new GameManager();
            gameManager.Sale(game1);
            gameManager.Sale(game2);
            

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(kampanyalar[1]);
            campaignManager.Delete(kampanyalar[0]);
            campaignManager.Update(kampanyalar[0]);
        
        }

    }
}
