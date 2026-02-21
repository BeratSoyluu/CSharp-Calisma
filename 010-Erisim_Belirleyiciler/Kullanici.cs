using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Erisim_Belirleyiciler
{
    public class Kullanici
    {
        public string Adi; // Program class ında bu değişkene ulaşmak için string in önüne public ekledik, yoksa orada erişemiyorduk
        internal string Soyadi; // string in önüne internal yazmak, böylece aynı projede olduğu için bu değişkene ulaşılabilir hale geliyor.
        private string Telefon; // private yaptığımız için program class ında gelmez ama bu class da kullanabiliriz.
        protected string Email; // program cs den erişemeyiz protected yaptığımız için, bu sınıfta veya buradan miras alan bir sınıfta kullanabiliriz.
        string sifre;
    }
    internal class Adres
    {
        private class Siparis
        {

        }
    }
    // Ana sınıflar sadece public ve internal alabilir.
    // Ana sınıf içerisinde private ve protected erişim belirteci alabilir sınflar.
    // protected ı kullanamayız.
    // private ı kullanamayız.
    // Enumlar erişim belirteci almazlar çünkü her zaman public ler.
}
