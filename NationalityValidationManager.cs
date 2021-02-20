using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public class NationalityValidationManager : IPlayerValidationService
    {
        public bool Validate(Player player)
        {
            return true;
        }
    }
}
