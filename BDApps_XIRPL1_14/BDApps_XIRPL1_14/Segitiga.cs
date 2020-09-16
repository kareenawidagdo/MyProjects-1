using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApps_XIRPL1_14
{
    class Segitiga : bangunDatar
    {
        //atribut Segitiga Siku-Siku
        public int a;
        public int m;
        public int t;

        //method Segitiga Siku-Siku
        public override double luas()
        {
            double luas = a * t / 2;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Luas Segitiga Siku-Siku : " + luas);
            return luas;
        }
        public override double keliling()
        {
            double keliling = a + m + t;
            Console.WriteLine("Keliling Segitiga Siku-Siku : " + keliling);
            return keliling;
        }
    }
}
