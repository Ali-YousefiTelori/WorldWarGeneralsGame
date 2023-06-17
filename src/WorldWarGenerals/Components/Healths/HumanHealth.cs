using WorldWarGeneralsGame.Interfaces;

namespace WorldWarGeneralsGame.Components.Healths
{
    public class HumanHealth : IHealth
    {
        public int Calculate()
        {
            return 1000;
        }
    }
}
