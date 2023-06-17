using System;
using System.Collections.Generic;
using System.Text;
using WorldWarGeneralsGame.Interfaces;

namespace WorldWarGeneralsGame.Units
{
    public class Unit
    {
        public List<IComponent> Components { get; set; } = new List<IComponent>();
    }
}
