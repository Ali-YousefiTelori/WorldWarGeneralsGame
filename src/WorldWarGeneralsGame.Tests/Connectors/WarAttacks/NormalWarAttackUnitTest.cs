using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldWarGeneralsGame.Components.Damages.HumanWeapons;
using WorldWarGeneralsGame.Connectors.WarAttacks;
using WorldWarGeneralsGame.Interfaces;
using WorldWarGeneralsGame.Units.Persons;

namespace WorldWarGeneralsGame.Tests.Connectors.WarAttacks
{
    public class NormalWarAttackUnitTest
    {
        [Fact]
        public async Task ShootSolidersByKalashnikovGunTest()
        {
            Soldier soldier1 = new Soldier();
            Soldier soldier2 = new Soldier();
            NormalWarAttack warAttack = new NormalWarAttack();
            var soldierHealth = soldier1.Components.Where(x => x is IHealth).Cast<IHealth>().Sum(x => x.Amount);
            foreach (KalashnikovGun item in soldier1.Weapons.Where(x => x is KalashnikovGun))
            {
                for (int i = 0; i < soldierHealth; i++)
                {
                    await warAttack.Shoot(item, soldier2);
                    if (item.IsNeedsReload())
                        await item.Reload();
                    if (soldier2.IsDead)
                        break;
                }
            }
            Assert.True(soldier2.IsDead);
        }
    }
}
