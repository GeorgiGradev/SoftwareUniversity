using ViceCity.Models.Guns.Contracts;

namespace ViceCity.Models.Guns
{
    public class Pistol : Gun, IGun
    {
        private const int InitialBulletsPerBarrel = 10;
        private const int InitialTotalBullets = 100;
        private const int BulletsPerFire = 1;
        public Pistol(string name) 
            : base(name, InitialBulletsPerBarrel, InitialTotalBullets)
        {

        }

        public override int Fire()
        { 
            if (this.BulletsPerBarrel > 0)
            {
                this.BulletsPerBarrel -= BulletsPerFire;
            }
            else if (this.BulletsPerBarrel == 0)
            {
                if (this.TotalBullets > 0)
                {
                    this.BulletsPerBarrel = InitialBulletsPerBarrel;
                    this.TotalBullets -= BulletsPerBarrel;
                    this.BulletsPerBarrel -= BulletsPerFire;
                }
                else
                {
                    CanFire.Equals(false);
                    return 0;
                }
            }
            return BulletsPerFire;
        }
    }
}
