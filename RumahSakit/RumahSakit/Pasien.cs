using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit
{
    class Pasien : User
    {
        public string biodataPasien()
        {
            User namaPas = new User();
            User IDpas = new User();
            User NoPas = new User();
            namaPas.Nama = "Nn. Dini Andini";
            IDpas.NomorID = 0134;
            Console.WriteLine("\n======== BIODATA PASIEN ========\n");
            Console.WriteLine("Nama Pasien : " + namaPas.Nama);
            Console.WriteLine("No. ID Pasien : " + IDpas.NomorID);
            Console.WriteLine("No. HP Pasien : " + NoPas.setNomer(082233445566));
            Console.WriteLine("Riwayat Penyakit : " + RiwayatPasien);
            base.RiwayatPasien = "Usus Buntu";
            return RiwayatPasien;
        }
    }
}
