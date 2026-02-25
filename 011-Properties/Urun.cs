using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Properties
{
    class Urun
    {
        public string urunAdi;
        private double urunFiyat;

        public double UrunFiyat
        {
            get { return urunFiyat; }
            set
            {
                if(value <= 0)
                {
                    urunFiyat = 1;
                }
                else
                {
                    urunFiyat = value;
                }
            }
        }
    }
}
