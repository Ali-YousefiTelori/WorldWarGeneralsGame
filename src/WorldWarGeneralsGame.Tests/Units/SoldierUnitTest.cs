using WorldWarGeneralsGame.Components.Damages.HumanWeapons;
using WorldWarGeneralsGame.Units.Persons;

namespace WorldWarGeneralsGame.Tests.Units
{
    public class SoldierUnitTest
    {
        [Fact]
        public async Task ShootKalashnikovGunTest()
        {
            Soldier soldier = new Soldier();
            int realodCount = 0;
            foreach (KalashnikovGun item in soldier.Weapons.Where(x => x is KalashnikovGun))
            {
                int shootCount = 0;
                for (int i = 0; i < 100; i++)
                {
                    var shootResult = await item.Shoot();
                    shootCount += item.DecreasePerShoot;
                    if (item.IsNeedsReload())
                    {
                        shootResult = await item.Shoot();
                        Assert.Equal(0, shootResult);
                        Assert.Equal(item.HitCount, shootCount);
                        await item.Reload();
                        shootCount = 0;
                        realodCount++;
                    }
                }
            }
            Assert.Equal(3, realodCount);
        }
    }
}
