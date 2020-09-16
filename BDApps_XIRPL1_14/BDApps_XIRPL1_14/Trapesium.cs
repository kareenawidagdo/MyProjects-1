using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApps_XIRPL1_14
{
    class Trapesium : bangunDatar
    {
        //atribut Trapesium Sama Kaki
        public int a;
        public int b;
        public int m;
        public int t;

        //method Trapesium Sama Kaki
        public override double luas()
        {
            double luas = (a + b) * t / 2;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Luas Trapesium Sama Kaki : " + luas);
            return luas;
        }
        public override double keliling()
        {
            double keliling = a + b + 2 * m;
            Console.WriteLine("Keliling Trapesium Sama Kaki : " + keliling);
            return keliling;
        }
    }
}
