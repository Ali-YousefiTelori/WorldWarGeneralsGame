using System;

namespace WorldWarGeneralsGame.Components.Damages.HumanWeapons
{
    public class ClashGun : DamageBaseGun
    {
        public ClashGun() : base(30, 50, TimeSpan.FromSeconds(3), 30)
        {

        }
    }
}
