using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikfeladat
{
    internal class Robogo : Jarmu, KisGepjarmu
    {
        private int maxsebesseg;
        public Robogo(int sebesseg, string rendszam, int maxsebesseg):base(sebesseg, rendszam)
        {
           this.sebesseg = sebesseg;
        }

        public override bool GyorshajtottE(int sebessegkorlat)
        {
            if (sebesseg > sebessegkorlat)
            {
                return true;
            }
            return false;
        }

        public bool Haladhatitt(int kapottparameter)
        {
            if (maxsebesseg > kapottparameter)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Robogo:rendszam - {this.sebesseg} km/h";
        }
    }
}
