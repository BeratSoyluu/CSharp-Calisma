using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_classlar
{
    class Ev
    {
        // internal Sadece aynı proje içinden erişilebilir
        internal int KapiNo;
        internal string SokakAdi;
        internal string Ilce;
        internal string Sehir;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ev ilkEv = new Ev(); // Ev sınıfından ilkEv isimli bir nesne oluşturduk.
            ilkEv.Ilce = "Kadıköy";
            ilkEv.Sehir = "İstanbul";
            ilkEv.SokakAdi = "Mühürdar Sokak";
            ilkEv.KapiNo = 18;

            Console.WriteLine("İçe: " + ilkEv.Ilce);
            Console.WriteLine("Sehir: " + ilkEv.Sehir);
            Console.WriteLine("Sokak Adı: " + ilkEv.SokakAdi);
            Console.WriteLine("Kapı No: " + ilkEv.KapiNo);

            Console.WriteLine();
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine();

            Ev memlekettekiEv = new Ev()
            {
                Sehir = "Çankırı",
                Ilce = "Merkez",
                SokakAdi = "Papatya Sokak",
                KapiNo = 18
            };
            Console.WriteLine("İçe: " + memlekettekiEv.Ilce);
            Console.WriteLine("Sehir: " + memlekettekiEv.Sehir);
            Console.WriteLine("Sokak Adı: " + memlekettekiEv.SokakAdi);
            Console.WriteLine("Kapı No: " + memlekettekiEv.KapiNo);

            Console.WriteLine();
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine();

            Kullanici yenikullanici = new Kullanici();
            yenikullanici.Aktif = true;
            yenikullanici.KullaniciAdi = "admin";
            yenikullanici.Sifre = "123456";
            yenikullanici.Id = 1;

            Console.WriteLine($"Kullanıcı aktif mi? {yenikullanici.Aktif} \n" +
                $"Kullanıcı Adı: {yenikullanici.KullaniciAdi} \n" +
                $"Kullanıcı Şifre: {yenikullanici.Sifre}\n" +
                $"Kullanıcı ID: {yenikullanici.Id}");
            yenikullanici.EkranaYaziYaz("Merhaba");
            Console.WriteLine(yenikullanici.ToplamaYap(10,20) );
            Console.WriteLine(Kullanici.SinifDegiskeni); // Direkt Kullanici sınıfını yazarak erişebiliyoruz.
            
            Console.WriteLine();

            Console.Write("Mail adresi giriniz: ");
            var mailAdresi = Console.ReadLine();
            var islemsonucu = yenikullanici.MailGonder(mailAdresi);
            if (islemsonucu==true)
            {
                Console.WriteLine("Mail başarılı!");
            }
            else Console.WriteLine("Mail boş olamaz!");

            Console.WriteLine();
            Console.WriteLine("******************************************************************************************************");
            Console.WriteLine();
        }
    }
}
