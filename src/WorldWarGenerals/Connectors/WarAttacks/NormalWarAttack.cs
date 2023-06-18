using System.Threading.Tasks;
using WorldWarGeneralsGame.Interfaces;
using WorldWarGeneralsGame.Units;

namespace WorldWarGeneralsGame.Connectors.WarAttacks
{
    public class NormalWarAttack : IWarAttack
    {
        public async Task Shoot(IWeapon weapon, Unit target)
        {
            var shootResult = await weapon.Shoot();
            await target.GetDamage(shootResult);
        }
    }
}
