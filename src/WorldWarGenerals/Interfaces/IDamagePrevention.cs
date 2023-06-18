using System;
using System.Collections.Generic;
using System.Text;

namespace WorldWarGeneralsGame.Interfaces
{
    public interface IDamagePrevention : IComponent
    {
        public int CalculateDamage(int amount);
    }
}
