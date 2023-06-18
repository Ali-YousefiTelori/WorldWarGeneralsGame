using WorldWarGeneralsGame.Components.Damages.HumanWeapons;
using WorldWarGeneralsGame.Components.Healths;

namespace WorldWarGeneralsGame.Units.Persons
{
    public class Soldier : WeaponUnit
    {
        public Soldier()
        {
            Weapons.Add(new KalashnikovGun());
            Components.Add(new HumanHealth());
        }
    }
}
