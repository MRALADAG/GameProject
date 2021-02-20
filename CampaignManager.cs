using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameProject
{
    public class CampaignManager : ICampaignService
    {
        List<Game> _games;
        List<Game> _campaignGames;

        public CampaignManager()
        {
            _games = new List<Game> { new Game {GameName = "WarCaraft"}, new Game {GameName = "NEEDforSPEED"},
                                      new Game {GameName = "MortalCombat"}, new Game {GameName = "FIFA"},
                                      new Game {GameName = "CALLofDUTY"}, new Game {GameName = "WinningEleven2020"}};
            _campaignGames = new List<Game> { };
        }

        public void CampaignAdd(Game game)
        {
            _campaignGames.Add(game);
            foreach (var item in _campaignGames)
            {
                Console.WriteLine("{0} isimli oyun kampanyalıdır.", item.GameName);
            }
        }

        public void CampaignDelete(Game game)
        {
            Game gameToDelete = _campaignGames.SingleOrDefault(g => g.GameName == game.GameName);
            _campaignGames.Remove(gameToDelete);
            Console.WriteLine("{0} isimli oyun kampanyalardan silindi.");
        }

        public void CampaignUpdate(Game game)
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
        public List<Game> GetAllCampaignGames()
        {
            return _campaignGames;
        }
    }
}
