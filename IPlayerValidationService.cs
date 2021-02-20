using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    public interface IPlayerValidationService
    {
        bool Validate(Player player);
    }
}
