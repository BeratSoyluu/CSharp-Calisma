using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_Struct_Yapilar
{
    struct Yapi // Stack de tutulur. İşi bittiğinde bellekten silinir.
    {
        // struct kullanımında class dan farklı olarak öğelere başlangıç değeri atanmaz.
        public int sayi;
        public string metin;
        public void Metot()
        {
            Console.WriteLine("Yapı içindeki metot  çalıştı.");
        }
    }

    class Program
    {
        struct Kimlik
        {
            public string ad;
            public string soyad;
            public int yas;
            public string dogumyeri;
            public DateTime DogumTarihi;
            public struct Adres // Bir struct içine struct tanımlayabiliriz.
            {
                public int Id { get; set; }
                public int KapiNo { get; set; }
                public string sehir { get; set; }
                public string Ilce { get; set; }
                public string AcikAdres { get; set; }
            }
        }

        static void Main(string[] args)
        {
            Kimlik kimlik = new Kimlik();
            kimlik.ad = "Eşref";
            kimlik.soyad = "Tek";
            kimlik.dogumyeri = "İstanbul";
            kimlik.yas = 25;


            // Önce Adres nesnesini oluşturuyoruz
            Kimlik.Adres benimAdresim = new Kimlik.Adres();

            // İçini dolduruyoruz
            benimAdresim.sehir = "İstanbul";
            benimAdresim.Ilce = "Kadıköy";
            benimAdresim.KapiNo = 14;
            benimAdresim.AcikAdres = "Moda Caddesi...";
        }
    }
}
