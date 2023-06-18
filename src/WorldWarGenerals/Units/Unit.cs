using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorldWarGeneralsGame.Interfaces;

namespace WorldWarGeneralsGame.Units
{
    public class Unit
    {
        public List<IComponent> Components { get; set; } = new List<IComponent>();
        public bool IsDead { get; set; }
        public async Task GetDamage(int amount)
        {
            foreach (IDamagePrevention damage in Components.Where(x => x is IDamagePrevention).ToArray())
            {
                amount = damage.CalculateDamage(amount);
            }
            if (amount > 0)
            {
                var allHealthes = Components.Where(x => x is IHealth).Cast<IHealth>().ToArray();
                foreach (IHealth health in allHealthes)
                {
                    amount = await health.Decrease(amount);
                    if (amount <= 0)
                        break;
                }
                bool isDead = allHealthes.All(x => x.IsDead);
                if (isDead)
                    await Dead();
            }
        }

        public Task Dead()
        {
            IsDead = true;
            return Task.CompletedTask;
        }
    }
}
