using System.Collections.Generic;
using WorldWarGeneralsGame.Interfaces;

namespace WorldWarGeneralsGame.Units
{
    public class WeaponUnit : Unit
    {
        public List<IWeapon> Weapons { get; set; } = new List<IWeapon>();
    }
}
