using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface ICampaignService
    {
        void CampaignAdd(Game game);
        void CampaignDelete(Game game);
        void CampaignUpdate(Game game);
        List<Game> GetAllCampaignGames();
    }
}
