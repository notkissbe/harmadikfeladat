using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikfeladat
{
    internal class AudiS8 : Jarmu
    {
        private bool lezerblokkolo;

        public AudiS8(int sebesseg, string rendszam, bool lezerblokkolo) : base(sebesseg, rendszam)
        {
            this.lezerblokkolo = lezerblokkolo;
        }

        public override bool GyorshajtottE(int sebessegkorlat)
        {
            if (this.sebesseg > sebessegkorlat)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Audi: {this.rendszam} - {this.sebesseg} km/h";
        }
    }
}
