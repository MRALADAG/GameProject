using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{

    public class OrderManager : IOrderService
    {
        IPlayerValidationService _playerValidationService;
        List<Game> _campaignGames;

        public OrderManager(IPlayerValidationService playerValidationService, ICampaignService _IcampaignGames)
        {
            _playerValidationService = playerValidationService;
            _campaignGames = _IcampaignGames.GetAllCampaignGames();
        }


        public void GameOrder(Player player, Game game)
        {
            if (_playerValidationService.Validate(player) == true)
            {
                var item = _campaignGames.Exists(g => g.GameName == game.GameName);
                if (item)
                {
                    Console.WriteLine("{0} {1} isimli oyuncu {2} isimli oyunun kampanyalı siparişini verdi.", player.FirstName, player.LastName, game.GameName);
                }
                else
                {
                    Console.WriteLine("{0} {1} isimli oyuncu {2} isimli oyunun siparişini verdi.", player.FirstName, player.LastName, game.GameName);
                }
            }
            else
            {
                Console.WriteLine("Sistemde geçerli kayıtlı bir oyuncu bulunamadığı için satış yapılamamıştır.");
            }
        }
    }
}
