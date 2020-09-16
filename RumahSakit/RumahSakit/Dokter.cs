using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit
{
    class Dokter : User
    {
        public string biodataDokter()
        {
            User namaDok = new User();
            User IDdok = new User();
            User NoDok = new User();
            namaDok.Nama = "dr. Setya Dian Kartika, SpOG";
            IDdok.NomorID = 1754;
            NoDok.Nomer = 081234567890;
            Console.WriteLine("\n======== BIODATA DOKTER ========\n");
            Console.WriteLine("Nama Dokter : " + namaDok.Nama);
            Console.WriteLine("No. ID Dokter : " + IDdok.NomorID);
            Console.WriteLine("No. HP Dokter : " + NoDok.Nomer);
            Console.WriteLine("Riwayat Penyakit : " + RiwayatPasien);
            base.RiwayatPasien = "sehat";
            return RiwayatPasien;
        }
    }
}
