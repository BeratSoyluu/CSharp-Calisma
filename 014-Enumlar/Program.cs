using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014_Enumlar
{
    internal class Program
    {
        enum Aylar: byte // byte veri tipi ile sıralandı
        {
            Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
        }
        enum CalisilanGunler
        {
            Pazartesi, Salı, Çarşamba, Perşembe, Cuma
        }
        enum SiparisDurumu
        {
            Hazırlanıyor, Hazırlandı, KarhoBekliyor, Kargolandı
        }
        enum Meyveler : int // int veri tipi ile sıralandı
        {
            Elma = 3, Armut= 7, Çilek = 1
        }
        static void Main(string[] args)
        {
            // Enum lar nesneleri numaralandırmak için kullanılır.
            // Sayıları kelimelere dökerek kodun okunabilirliğini artırmak
            byte a = (byte)Meyveler.Armut;
            byte b = (byte)Meyveler.Elma;
            byte c = (byte)Meyveler.Çilek;
            Console.WriteLine("Armut = {0}, Armut = {1}, Çilek = {2}", a, b, c);
            Console.WriteLine("**********************************************************************************************************");

            Ornek();
            

        }
        static void Ornek()
        {
            int SiparisDurum = 1;
            if (SiparisDurum == 0) { Console.WriteLine("Siparis Durum: {0}", SiparisDurumu.Hazırlanıyor); }
            if (SiparisDurum == 1) { Console.WriteLine("Siparis Durum: {0}", SiparisDurumu.Hazırlandı); }
            if (SiparisDurum == 2) { Console.WriteLine("Siparis Durum: {0}", SiparisDurumu.KarhoBekliyor); }
            if (SiparisDurum == 3) { Console.WriteLine("Siparis Durum: {0}", SiparisDurumu.Kargolandı); }

        }
    }
}
