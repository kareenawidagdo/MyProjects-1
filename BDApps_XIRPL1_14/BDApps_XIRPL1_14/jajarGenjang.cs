using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApps_XIRPL1_14
{
    class jajarGenjang : bangunDatar
    {
        //atribut Jajar Genjang
        public int a;
        public int m;
        public int t;

        //methid Jajar Genjang
        public override double luas()
        {
            double luas = a * t;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Luas Jajar Genjang : " + luas);
            return luas;
        }
        public override double keliling()
        {
            double keliling = 2 * (a + m);
            Console.WriteLine("Keliling Jajar Genjang : " + keliling);
            return keliling;
        }
    }
}
