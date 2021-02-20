using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class PlayerValidationManager : IPlayerValidationService
    {
        DateTime Tarih = Convert.ToDateTime("30.01.1985");
        public bool Validate(Player player)
        {
            if (player.BirthDay == Tarih && player.FirstName == "ENGİN" && player.LastName == "DEMİROĞ" && player.Id == 1 && player.TcNo == 12345678910)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
