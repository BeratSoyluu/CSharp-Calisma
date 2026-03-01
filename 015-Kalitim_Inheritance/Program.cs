using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015_Kalitim_Inheritance
{
    class AtaSinif
    {
        public AtaSinif()
        {
            Console.WriteLine("AtaSinif kurucu metodu çalıştı");
        }
        public void Yaz()
        {
            Console.WriteLine("AtaSinif içindeki Yaz metodu çalıştı");
        }
    }

    class OgulSinif : AtaSinif // Miras böyle alınır.
    {
        public OgulSinif()
        {
            Console.WriteLine("OgulSinif kurucu metodu çalıştı");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            OgulSinif ogul = new OgulSinif();
            ogul.Yaz();
            // Çıktısı:
            //  AtaSinif kurucu metodu çalıştı
            //  OgulSinif kurucu metodu çalıştı
            //  AtaSinif içindeki Yaz metodu çalıştı

            Console.WriteLine("**********************************************************************************************************");
            ApartmanKati apartmanKati = new ApartmanKati();
            apartmanKati.EvSahibiYaz("Müfit Bey");
            apartmanKati.sahip = "Müfit Bey";
            apartmanKati.EvSahibiYaz(apartmanKati.sahip);
        }
    }
    class Ev
    {
        public string sahip;
        public void EvSahibiYaz(string sahip)
        {
            Console.WriteLine("Ev Sahibi: " + sahip);
        }
    }
    class ApartmanKati : Ev
    {
        internal string apartmanYoneticisi;
        public void ApartmanYoneticisiniYaz(string apartmanYoneticisi)
        {
            Console.WriteLine("Apartman Yönetici: " + apartmanYoneticisi);
        }
    }

    
}
