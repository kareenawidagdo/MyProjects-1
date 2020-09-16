using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDApps_XIRPL1_14
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== MENGHITUNG LUAS dan KELILING BANGUN DATAR ===");
            Console.WriteLine("1) Persegi\n2) Persegi Panjang\n3) Segitiga Siku-Siku\n4) Jajar Genjang\n5) Trapesium\n6) Layang-Layang\n7) Belah Ketupat");
            Console.Write("Pilih Menu : ");
            int angka = int.Parse(Console.ReadLine());

            switch (angka)
            {
                case 1:
                    Persegi square1 = new Persegi();
                    Console.WriteLine("\n<<< Menghitung Luas dan Keliling Persegi >>>\n");
                    Console.Write("Sisi : ");
                    square1.sisi = int.Parse(Console.ReadLine());
                    square1.luas();
                    square1.keliling();
                    Console.Write("\nContinue? Y/N : ");
                    string a = Console.ReadLine();
                    if ((a == "y") | (a == "Y"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Press C key to exit");
                    }
                    break;

                case 2:
                    persegiPanjang rect1 = new persegiPanjang();
                    Console.WriteLine("\n<<< Menghitung Luas dan Keliling Persegi Panjang >>>\n");
                    Console.Write("Panjang : ");
                    rect1.p = int.Parse(Console.ReadLine());
                    Console.Write("Lebar : ");
                    rect1.l = int.Parse(Console.ReadLine());
                    rect1.luas();
                    rect1.keliling();
                    Console.Write("\nContinue? Y/N : ");
                    string b = Console.ReadLine();
                    if ((b == "y") | (b == "Y"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Press C key to exit");
                    }
                    break;

                case 3:
                    Segitiga tri1 = new Segitiga();
                    Console.WriteLine("\n<<< Menghitung Luas dan Keliling Segitiga Siku-Siku >>>\n");
                    Console.Write("Sisi Alas : ");
                    tri1.a = int.Parse(Console.ReadLine());
                    Console.Write("Sisi Miring : ");
                    tri1.m = int.Parse(Console.ReadLine());
                    Console.Write("Tinggi : ");
                    tri1.t = int.Parse(Console.ReadLine());
                    tri1.luas();
                    tri1.keliling();
                    Console.Write("\nContinue? Y/N : ");
                    string c = Console.ReadLine();
                    if ((c == "y") | (c == "Y"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Press C key to exit");
                    }
                    break;

                case 4:
                    jajarGenjang jage1 = new jajarGenjang();
                    Console.WriteLine("\n<<< Menghitung Luas dan Keliling Jajar Genjang >>>\n");
                    Console.Write("Sisi Alas : ");
                    jage1.a = int.Parse(Console.ReadLine());
                    Console.Write("Sisi Miring : ");
                    jage1.m = int.Parse(Console.ReadLine());
                    Console.Write("Tinggi : ");
                    jage1.t = int.Parse(Console.ReadLine());
                    jage1.luas();
                    jage1.keliling();
                    Console.Write("\nContinue? Y/N : ");
                    string d = Console.ReadLine();
                    if ((d == "y") | (d == "Y"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Press C key to exit");
                    }
                    break;

                case 5:
                    Trapesium trap1 = new Trapesium();
                    Console.WriteLine("\n<<< Menghitung Luas dan Keliling Trapesium Sama Kaki >>>\n");
                    Console.Write("Sisi a : ");
                    trap1.a = int.Parse(Console.ReadLine());
                    Console.Write("Sisi b : ");
                    trap1.b = int.Parse(Console.ReadLine());
                    Console.Write("Sisi Miring : ");
                    trap1.m = int.Parse(Console.ReadLine());
                    Console.Write("Tinggi : ");
                    trap1.t = int.Parse(Console.ReadLine());
                    trap1.luas();
                    trap1.keliling();
                    Console.Write("\nContinue? Y/N : ");
                    string e = Console.ReadLine();
                    if ((e == "y") | (e == "Y"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Press C key to exit");
                    }
                    break;

                case 6:
                    layangLayang lay1 = new layangLayang();
                    Console.WriteLine("\n<<< Menghitung Luas dan Keliling Layang-Layang >>>\n");
                    Console.Write("Sisi a // b : ");
                    lay1.ab = int.Parse(Console.ReadLine());
                    Console.Write("Sisi c // d : ");
                    lay1.cd = int.Parse(Console.ReadLine());
                    Console.Write("Diagonal 1 : ");
                    lay1.d1 = int.Parse(Console.ReadLine());
                    Console.Write("Diagonal 2 : ");
                    lay1.d2 = int.Parse(Console.ReadLine());
                    lay1.luas();
                    lay1.keliling();
                    Console.Write("\nContinue? Y/N : ");
                    string f = Console.ReadLine();
                    if ((f == "y") | (f == "Y"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Press C key to exit");
                    }
                    break;

                case 7:
                    belahKetupat bel1 = new belahKetupat();
                    Console.WriteLine("\n<<< Menghitung Luas dan Keliling Belah Ketupat >>>\n");
                    Console.Write("Sisi : ");
                    bel1.sisi = int.Parse(Console.ReadLine());
                    Console.Write("Diagonal 1 : ");
                    bel1.d1 = int.Parse(Console.ReadLine());
                    Console.Write("Diagonal 2 : ");
                    bel1.d2 = int.Parse(Console.ReadLine());
                    bel1.luas();
                    bel1.keliling();
                    Console.Write("\nContinue? Y/N : ");
                    string g = Console.ReadLine();
                    if ((g == "y") | (g == "Y"))
                    {
                        System.Console.Clear();
                        Main();
                    }
                    else
                    {
                        Console.WriteLine("Press C key to exit");
                    }
                    break;
            }

            Console.ReadLine();
        }
    }
}
