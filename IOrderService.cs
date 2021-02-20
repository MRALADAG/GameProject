using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IOrderService
    {
        void GameOrder(Player player, Game game);
    }
}
