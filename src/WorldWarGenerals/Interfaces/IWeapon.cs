using System;
using System.Threading.Tasks;

namespace WorldWarGeneralsGame.Interfaces
{
    public interface IWeapon
    {
        /// <summary>
        /// null is unlimit
        /// for Knife
        /// when hit count comeplete you have to reload
        /// </summary>
        int? HitCount { get; set; }
        int Bullets { get; set; }
        int DamagePerHit { get; set; }
        int DecreasePerShoot { get; set; }
        TimeSpan ReloadTime { get; set; }
        bool IsNeedsReload();
        Task Reload();
        Task<int> Shoot();
    }
}
