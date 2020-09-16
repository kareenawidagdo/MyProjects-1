using System;
using beratIdeal_14_Kareen;

namespace hitungBerat_14_Kareen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======== MENGHITUNG BERAT BADAN IDEAL ========\n");
            beratPriaWanita beratIdeal = new beratPriaWanita();
            Console.Write("Jenis Kelamin : ");
            string jenis = Console.ReadLine();

            if (jenis=="wanita")
            {
                Console.Write("Nama Anda : ");
                string nama = Console.ReadLine();
                Console.Write("Tinggi badan Anda : ");
                double berat = beratIdeal.beratIdealWanita(double.Parse(Console.ReadLine()));
                Console.WriteLine("\nHai, " + nama + "!");
                Console.WriteLine("Berat badan ideal Anda adalah " + berat + " kg.");
            }
            else if (jenis=="pria")
            {
                Console.Write("Nama Anda : ");
                string nama = Console.ReadLine();
                Console.Write("Tinggi badan Anda : ");
                double berat = beratIdeal.beratIdealPria(double.Parse(Console.ReadLine()));
                Console.WriteLine("\nHai, " + nama + "!");
                Console.WriteLine("Berat badan ideal Anda adalah " + berat + " kg.");
            }
            else
            {
                Console.WriteLine("undefined input");
            }

            Console.ReadLine();
        }
    }
}
