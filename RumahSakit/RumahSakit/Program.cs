using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t\t\t\tRumah Sakit ANANDA Purwokerto");
            //Biodata Dokter
            Dokter doctor = new Dokter();
            User ruangdok = new User();
            doctor.biodataDokter();
            ruangdok.Bangsal = "Poli Kebidanan dan Kandungan";
            Console.WriteLine("Ruangan Dokter : " + ruangdok.Bangsal);
            //Biodata Pasien
            Pasien patient = new Pasien();
            User ruangpas = new User();
            patient.biodataPasien();
            ruangpas.Bangsal = "Paviliun";
            Console.WriteLine("Bangsal Ruangan Pasien : " + ruangpas.Bangsal);
            Console.ReadLine();
        }
    }
}
