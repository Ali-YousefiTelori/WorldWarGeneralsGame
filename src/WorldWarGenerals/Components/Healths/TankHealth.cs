using System;
using System.Collections.Generic;
using System.Text;
using WorldWarGeneralsGame.Interfaces;

namespace WorldWarGeneralsGame.Components.Healths
{
    public class TankHealth : IHealth
    {
        public int Calculate()
        {
            return 15000;
        }
    }
}
