using System;
using System.Collections.Generic;
using System.Text;

namespace L005_GameHomework
{
    interface ICampaignService
    {
        public void Add(Campaign campaign);
        public void Update();
        public void Delete();
        public bool Validation(string campaignName);
    }
}
