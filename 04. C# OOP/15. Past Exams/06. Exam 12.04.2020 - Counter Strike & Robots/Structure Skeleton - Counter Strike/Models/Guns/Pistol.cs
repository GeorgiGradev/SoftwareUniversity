
namespace CounterStrike.Models.Guns
{
    using CounterStrike.Models.Guns.Contracts;

    public class Pistol : Gun, IGun
    {
        public Pistol(string name, int bulletsCount)
            : base(name, bulletsCount)
        {
        }

        public override int Fire()
        {
            if (this.BulletsCount > 0)
            {
                this.BulletsCount -= 1;
                return 1;
            }
            return 0;
        }
    }
}
