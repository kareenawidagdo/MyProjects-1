using System;

namespace beratIdeal_14_Kareen
{
    public class beratPriaWanita
    {
        public double beratIdealWanita(double tinggiBadan)
        {
            double hasilWanita = (tinggiBadan - 100) - ((tinggiBadan - 100) * 15/100);
            return hasilWanita;
        }
        public double beratIdealPria(double tinggiBadan)
        {
            double hasilPria = (tinggiBadan - 100) - ((tinggiBadan - 100) * 10 / 100);
            return hasilPria;
        }
    }
}
