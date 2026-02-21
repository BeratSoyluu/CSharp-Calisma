using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Public: Kod tüm sınıflar tarafından erişilebilir durumdadır.
Private: Kod yalnızca aynı sınıf içinde erişilebilir.
Protected: Kod, aynı sınıf içinde veya o sınıftan miras alan bir sınıfta erişilebilir durumdadır.
İnternal: Kod yalnızca kendi derlemesi içinde erişilebilir, başka bir derlemeden erişilemez.
*/
namespace _010_Erisim_Belirleyiciler
{
    internal class Program
    {
        public class deneme
        {
            public string UrunAdi = "Public öğeye herkes erişebilir";
            private string urunAdi;
            public void Toplam()
            {

            }

            protected bool MailGonder()
            {
                return true;
            }
        }

        protected class test // Ait olduğu sınıftan veya o sınıftan türetilen sınıflardan erişilebilir. (Burada Program class ının içindekiler erişebilir veya Program claasından türetilen sınıflar erişebilir.)
        {
            private string UrunAdi;
        }

        internal class urun // internal erişim belirteci etkin projeye ait sınıflardan erişilebilir, onların dışında erişilemez.   (Etkin proje: Çalıştırdığımız proje)
        {
            private string gizli = "Private sadece bulunduğu sınıftan erişilebilir, dıştaki sınıflardan erişilemez. (gizli değişkenimiz sadece urun class'ından erişilebilir.)";
        }
        static void Main(string[] args)
        {
            Kullanici kullanici = new Kullanici();
            kullanici.Adi = "Ali";
            kullanici.Soyadi = "Cambaz";

            Console.WriteLine("Kullanıcı Adı: " + kullanici.Adi);
            Console.WriteLine("Kullanıcı Soyadı: " + kullanici.Soyadi);

        }
    }
}
