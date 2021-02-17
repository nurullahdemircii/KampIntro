using System;
using System.Collections.Generic;
using System.Text;

namespace L005_GameHomework
{
    class OrderManager : IOrderService
    {
        ICampaignService _campaignService;
        public OrderManager(ICampaignService campaignService)
        {
            _campaignService = campaignService;
        }
        public void SaleGame(Games games, Gamer gamer)
        {
            if (_campaignService.Validation("25") == true)
                Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + games.GameName + " Oyununu 25% İndirimli Sattı.");
            else
                Console.WriteLine(games.GameName + " Oyunu için Kampanya Geçerli Değil.");
        }
    }
}
