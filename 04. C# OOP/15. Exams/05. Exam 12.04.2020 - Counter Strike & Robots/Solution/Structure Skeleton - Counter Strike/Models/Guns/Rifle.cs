namespace CounterStrike.Models.Guns
{
    using CounterStrike.Models.Guns.Contracts;

    public class Rifle : Gun, IGun
    {
        public Rifle(string name, int bulletsCount) 
            : base(name, bulletsCount)
        {
        }

        public override int Fire()
        {
            if (this.BulletsCount >= 10)
            {
                this.BulletsCount -= 10;
                return 10;
            }
            return 0;
        }
    }
}
 