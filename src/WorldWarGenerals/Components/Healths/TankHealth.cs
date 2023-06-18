using System;
using System.Collections.Generic;
using System.Text;
using WorldWarGeneralsGame.Interfaces;

namespace WorldWarGeneralsGame.Components.Healths
{
    public class TankHealth : HealthBase
    {
        public override int Calculate()
        {
            return 15000;
        }
    }
}
