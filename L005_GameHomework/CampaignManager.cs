using System;
using System.Collections.Generic;
using System.Text;

namespace L005_GameHomework
{
    class CampaignManager : ICampaignService
    {
        List<string> _campaign;
        public CampaignManager()
        {
            _campaign = new List<string>();
        }
        public void Add(Campaign campaign)
        {
            _campaign.Add(campaign.CampaignName);
        }

        public void Delete()
        {
            Console.WriteLine("Kampanya Silindi.");
        }

        public bool Validation(string campaignName)
        {
            if (campaignName == "25")
                return true;
            else
                return false;
        }

        public void Update()
        {
            Console.WriteLine("Kampanya Güncellendi.");
        }
    }
}
