using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApps_XIRPL1_14
{
    class Persegi : bangunDatar
    {
        //atribut Persegi
        public int sisi;

        //method Persegi
        public override double luas()
        {
            double luas = sisi * sisi;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Luas Persegi : " + luas);
            return luas;
        }
        public override double keliling()
        {
            double keliling = 4 * sisi;
            Console.WriteLine("Keliling Persegi : " + keliling);
            return keliling;
        }
    }
}
