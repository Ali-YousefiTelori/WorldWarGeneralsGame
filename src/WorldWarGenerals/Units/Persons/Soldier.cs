using WorldWarGeneralsGame.Components.Damages.HumanWeapons;
using WorldWarGeneralsGame.Components.Healths;

namespace WorldWarGeneralsGame.Units.Persons
{
    public class Soldier : WeaponUnit
    {
        public Soldier()
        {
            Weapons.Add(new ClashGun());
            Components.Add(new HumanHealth());
        }
    }
}
