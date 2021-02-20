using System;
using System.Collections.Generic;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager(new PlayerValidationManager());
            //PlayerManager playerManager = new PlayerManager(new NationalityValidationManager());

            // Yukarıda iki farklı ValidationService birbiri arasında switch edilebilecektir.

            playerManager.Add(new Player
            {
                BirthDay = Convert.ToDateTime("30.01.1985"),
                FirstName = "ENGİN",
                LastName = "DEMİROĞ",
                Id = 1,
                TcNo = 12345678910
            });

            List<Player> playersList = playerManager.GetAllPlayers();

            foreach (var item in playersList)
            {
                Console.WriteLine(item.FirstName);
            }
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.CampaignAdd(new Game { GameName = "WarCaraft" });
            OrderManager order = new OrderManager(new PlayerValidationManager(), campaignManager);
            order.GameOrder(playersList.Find(p => p.FirstName == "ENGİN"), new Game { GameName = "WarCaraft" });

        }
    }
}
