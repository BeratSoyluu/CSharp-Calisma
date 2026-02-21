using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_classlar
{
    internal class Kullanici
    {
        string KurucuMetot; // Sadece new anahtar kelimesiyle nesne oluşturulduğu anda bir kez çalışır.
        public Kullanici() // ctor yaz tab a bas. 
        {
            KurucuMetot = "Sınıflarda constructor (kurucu metot) özelliği vardır ve bu metotlar sınıftan bir nesne oluşturduğunda otomatik olarak çalışır ve içerisindeki kodları çalıştırır. Kurucu metotlar değişkenler gibi veri tipi almazlar ve void ifadesi de bulunmaz, sınıfın adıyla aynı ad kullanılarak oluşturulur."; // yukarıda tanımladığımız kurucuMetot değişkenine sınıfımızın kurucu metodunda değer ataması yaptık.
            Console.WriteLine(KurucuMetot);

        }
        public int Id;
        public string KullaniciAdi;
        public string Sifre;
        public bool Aktif;
        public void EkranaYaziYaz(string ekranaYazilacakYazi) // public olduğu için dışarıdan erişime açık.
        {
            Console.WriteLine(ekranaYazilacakYazi);
        }

        public int ToplamaYap(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static string SinifDegiskeni = "Sınıflarda metot ve değişken de kullanılabilir."; // Direkt Kullanici sınıfını yazarak erişebiliyoruz.
        public bool MailGonder(string mail)
        {
            if (!string.IsNullOrWhiteSpace(mail)) // mail boş değilse yani doluysa
            {
                return true;
            }
            else return false;
        }
    }
}
