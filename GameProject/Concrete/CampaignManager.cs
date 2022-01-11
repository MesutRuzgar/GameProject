using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " İsimli yeni kampanya eklendi.");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + " İsimli  kampanya silindi."); 
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "  Kampanyanız güncellendi."); 
        }
    }
}
