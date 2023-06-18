using System;
using System.Threading;
using System.Threading.Tasks;
using WorldWarGeneralsGame.Interfaces;

namespace WorldWarGeneralsGame.Components.Healths
{
    public abstract class HealthBase : IHealth
    {
        public HealthBase()
        {
            Amount = Calculate();
        }

        public int Amount { get; set; }
        public bool IsDead { get; set; }
        public abstract int Calculate();

        SemaphoreSlim SemaphoreSlim { get; } = new SemaphoreSlim(1);
        public async Task<int> Decrease(int amount)
        {
            if (Amount <= 0 || amount <= 0)
                return 0;
            try
            {
                await SemaphoreSlim.WaitAsync();
                Amount -= amount;
                if (Amount <= 0)
                {
                    IsDead = true;
                    return Math.Abs(Amount);
                }
                return 0;
            }
            finally
            {
                SemaphoreSlim.Release();
            }
        }
    }
}
