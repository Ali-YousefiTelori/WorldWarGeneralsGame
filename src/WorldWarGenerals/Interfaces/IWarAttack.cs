using System.Threading.Tasks;
using WorldWarGeneralsGame.Units;

namespace WorldWarGeneralsGame.Interfaces
{
    public interface IWarAttack
    {
        Task Shoot(IWeapon weapon, Unit target);
    }
}
