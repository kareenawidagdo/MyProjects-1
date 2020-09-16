using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApps_XIRPL1_14
{
    class persegiPanjang : bangunDatar
    {
        //atribut Persegi Panjang
        public int p;
        public int l;

        //method Persegi Panjang
        public override double luas()
        {
            double luas = p * l;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Luas Persegi Panjang : " + luas);
            return luas;
        }
        public override double keliling()
        {
            double keliling = 2 * (p + l);
            Console.WriteLine("Keliling Persegi Panjang : " + keliling);
            return keliling;
        }
    }
}
