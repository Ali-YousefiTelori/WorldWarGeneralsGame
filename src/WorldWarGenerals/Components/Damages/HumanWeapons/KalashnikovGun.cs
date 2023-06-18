using System;

namespace WorldWarGeneralsGame.Components.Damages.HumanWeapons
{
    public class KalashnikovGun : DamageBaseGun
    {
        public KalashnikovGun() : base(30, 50, TimeSpan.FromSeconds(3), 30)
        {

        }
    }
}
