using WorldWarGeneralsGame.Interfaces;

namespace WorldWarGeneralsGame.Components.Healths
{
    public class HumanHealth : HealthBase
    {
        public override int Calculate()
        {
            return 1000;
        }
    }
}
