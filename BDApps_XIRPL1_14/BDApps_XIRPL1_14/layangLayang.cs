using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApps_XIRPL1_14
{
    class layangLayang : bangunDatar
    {
        //atribut Layang-Layang
        public int ab;
        public int cd;
        public int d1;
        public int d2;

        //method Layang-Layang
        public override double luas()
        {
            double luas = d1 * d2 / 2;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Luas Layang-Layang : " + luas);
            return luas;
        }
        public override double keliling()
        {
            double keliling = 2 * (ab + cd);
            Console.WriteLine("Keliling Layang-Layang : " + keliling);
            return keliling;
        }
    }
}
