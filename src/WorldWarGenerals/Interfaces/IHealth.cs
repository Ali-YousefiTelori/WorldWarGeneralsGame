using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WorldWarGeneralsGame.Interfaces
{
    public interface IHealth : IComponent
    {
        bool IsDead { get; set; }
        int Amount { get; set; }
        Task<int> Decrease(int amount);
    }
}
