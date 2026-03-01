using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _017_Kapsulleme
{
    // METOT KULLANARAK KAPSÜLLEME
    public class Bolum
    {
        private string BolumAdi; // Dışarıdan erişime kapalı değişkenimiz.
        public string getBolumAdi() { return BolumAdi; }
        public void setBolumAdi(string a)
        {
            if (a == "Programlama")
            {
                Console.WriteLine("Okulumuzda {0} bölümü bulunmamaktadır.",a);
            }
            else BolumAdi = a;
        }

    }

    // ÖZGEN (PROPERTY) KULLANARAK KAPSÜLLEME
    // Eğer veriyi atarken bir kontrol (validation) yapman gerekiyorsa (örneğin; girilen değer "Programlama" olmasın veya yaş 18'den küçük olmasın gibi), bu yöntemi kullanmalısın.
    class Fakulte
    {
        private string bolum;
        public string Bolum
        {
            get { return bolum; }
            set
            {
                if (value == "Programlama")
                {
                    Console.WriteLine("Okulumuzda {0} bölümü bulunmamaktadır.", value);
                }
                else bolum = value;
            }
        }
    }

    // YALNIZ OKUNUR (READY ONLY PROPERTY)
    // Eğer bir veri nesne oluşturulurken verilsin ve bir daha asla değişmesin istiyorsan bunu kullanmalısın.
    class Universite
    {
        private string bolum;
        public Universite(string str)
        {
            bolum = str;
        }
        public string Bolum
        {
            get { return bolum; }
        }
    }

    // YALNIZCA YAZILIR (WRITE ONLY PROPERTY)
    // Verinin dışarıdan okunmasının güvenlik riski oluşturduğu (şifre atama gibi) veya sadece bir işlemi tetiklemek için kullanılıp geri okunmasına gerek duyulmadığı (donanım ayarları gibi) durumlarda kullanılır.
    class YuksekOkul
    {
        private string bolum;
        public string Bolum
        {
            set
            {
                bolum = value;
                Console.WriteLine("Seçtiğiniz bölüm adı: " + value);
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bölüm adınızı giriniz: ");
            var bolumAdi = Console.ReadLine();
            Bolum bolum = new Bolum();
            bolum.setBolumAdi(bolumAdi);

            if (bolum.getBolumAdi() == null) { }
            else Console.WriteLine("Seçtiğiniz bölüm adı: " + bolum.getBolumAdi());

            //**********************************************************************************************************************

            Fakulte fakulte = new Fakulte();
            fakulte.Bolum = bolumAdi;
            if (fakulte.Bolum == null) { }
            else Console.WriteLine("Seçtiğiniz bölüm adı: " + fakulte.Bolum);

            //**********************************************************************************************************************

            Universite universite = new Universite(bolumAdi);
            Console.WriteLine("Seçtiğiniz bölüm adı: " + universite.Bolum);

            //**********************************************************************************************************************

            YuksekOkul yuksekOkul = new YuksekOkul();
            yuksekOkul.Bolum = bolumAdi;
        }
    }
}
