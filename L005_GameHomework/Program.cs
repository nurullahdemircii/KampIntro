using System;

namespace L005_GameHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                FirstName = "Nurullah",
                LastName = "Demirci",
                BirthYear = 1990,
                IdentityNumber = 12345
            }
            );

            GamesManager gamesManager = new GamesManager();
            gamesManager.Add(new Games { GameName = "MortalCombat" });
            gamesManager.Add(new Games { GameName = "StreetFighter" });
            gamesManager.Add(new Games { GameName = "Fifa 2021" });
            gamesManager.Add(new Games { GameName = "Pes 2021" });

            OrderManager orderManager = new OrderManager(new CampaignManager());
            orderManager.SaleGame(
            new Games
            {
                Id = 1,
                GameName = "Fifa 2021"
            },
            new Gamer
            {
                Id = 1,
                FirstName = "Nurullah",
                LastName = "Demirci",
                BirthYear = 1990,
                IdentityNumber = 12345
            });
        }
    }
}
