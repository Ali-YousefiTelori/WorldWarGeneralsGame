using System;
using System.Threading;
using System.Threading.Tasks;
using WorldWarGeneralsGame.Interfaces;

namespace WorldWarGeneralsGame.Components.Damages
{
    public abstract class DamageBaseGun : IWeapon
    {
        public DamageBaseGun(int bullets, int damagePerHit, TimeSpan reloadTime, int? hitCount, int decreasePerShoot = 1)
        {
            Bullets = bullets;
            DamagePerHit = damagePerHit;
            ReloadTime = reloadTime;
            HitCount = hitCount;
            DecreasePerShoot = decreasePerShoot;
        }

        public int? HitCount { get; set; }
        public int Bullets { get; set; }
        public int DamagePerHit { get; set; }
        public int DecreasePerShoot { get; set; }
        public TimeSpan ReloadTime { get; set; }
        SemaphoreSlim SemaphoreSlim { get; set; } = new SemaphoreSlim(1);

        public bool IsNeedsReload()
        {
            return Bullets <= 0;
        }

        public virtual async Task Reload()
        {
            if (!HitCount.HasValue)
                return;
            await Task.Delay(ReloadTime);
            try
            {
                await SemaphoreSlim.WaitAsync();
                Bullets = HitCount.Value;
            }
            finally
            {
                SemaphoreSlim.Release();
            }
        }

        public async Task<int> Shoot()
        {
            try
            {
                await SemaphoreSlim.WaitAsync();
                Bullets -= DecreasePerShoot;
                if (Bullets < 0)
                    return (DecreasePerShoot + Bullets) * DamagePerHit;
                else
                    return DecreasePerShoot * DamagePerHit;
            }
            finally
            {
                SemaphoreSlim.Release();
            }
        }
    }
}
