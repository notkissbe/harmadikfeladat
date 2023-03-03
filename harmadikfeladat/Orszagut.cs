using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.SymbolStore;

namespace harmadikfeladat
{
    internal class Orszagut
    {
        private List<Jarmu> lista = new List<Jarmu>();
        public Orszagut(string fajl)
        {
            this.lista = lista;
            Beolvas("forras.txt");
            KiketMertunkBe();
        }
        public void Beolvas(string fajlnev)
        {
            StreamReader sr=new StreamReader(fajlnev);
            while(!sr.EndOfStream)
            { 
                string[] line = sr.ReadLine().Split(';');
                if (line[0]=="robogo")
                {
                    lista.Add(new Robogo(Convert.ToInt32(line[2]), line[1], Convert.ToInt32(line[3])));
                }
                else
                {
                    lista.Add(new AudiS8(Convert.ToInt32(line[2]), line[1], Convert.ToBoolean(line[3])));
                }
            }
            foreach(var item in lista) 
            {
                Console.WriteLine(item);
            }
            sr.Close();
        }


        public void KiketMertunkBe()
        {
            StreamWriter sw = new StreamWriter("buntetes.txt");
            foreach (var item in lista)
            {
                if (item is Robogo && (item as Robogo).Haladhatitt(90) == false)
                {
                    sw.WriteLine($"{item} ---- {(item as Robogo)} Haladhat");
                }
                else if(item is AudiS8 && (item as AudiS8).GyorshajtottE(90) == false)
                {
                    sw.WriteLine($"{item} ---- {(item as AudiS8).GyorshajtottE(90)}");
                }
            
            }
            sw.Close(); 
        }
    }
}
