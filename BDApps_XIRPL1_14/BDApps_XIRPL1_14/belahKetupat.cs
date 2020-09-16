using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApps_XIRPL1_14
{
    class belahKetupat : bangunDatar
    {
        //atribut Belah Ketupat
        public int sisi;
        public int d1;
        public int d2;

        //method Belah Ketupat
        public override double luas()
        {
            double luas = d1 * d2 / 2;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Luas Belah Ketupat : " + luas);
            return luas;
        }
        public override double keliling()
        {
            double keliling = 4 * sisi;
            Console.WriteLine("Keliling Belah Ketupat : " + keliling);
            return keliling;
        }
    }
}
