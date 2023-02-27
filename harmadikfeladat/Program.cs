using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harmadikfeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Orszagut orszagut = new Orszagut("forras.txt");
            foreach (string arg in orszagut)
            {
                Console.WriteLine(arg);
            }
        }
    }
}
