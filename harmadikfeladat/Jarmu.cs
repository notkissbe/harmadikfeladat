using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikfeladat
{
    abstract class Jarmu
    {
        protected int sebesseg;
        protected string rendszam;

        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public string Rendszam { get => rendszam; set => rendszam = value; }

        public Jarmu(int sebesseg,  string rendszam)
        {
            this.sebesseg = sebesseg;
            this.rendszam = rendszam;
        }

        public abstract bool GyorshajtottE(int sebessegkorlat);
            
 
        public override string ToString()
        {
            return $"{this.rendszam} - {this.sebesseg} km/h";
        }
    }
}
