using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RumahSakit
{
    class User
    {
        //atribut induk
        public string Nama;
        public int NomorID;
        private double NomorHP;
        protected string RiwayatPasien;
        internal string Bangsal;
        //properties
        public double Nomer
        {
            get { return this.NomorHP; }
            set { this.NomorHP = value; }
        }
        //abstraksi
        public double getNomer()
        {
            NomorHP = 0;
            return this.NomorHP;
        }
        public double setNomer(double NomorBaru)
        {
            this.NomorHP = NomorBaru;
            return this.NomorHP;
        }
    }
}
