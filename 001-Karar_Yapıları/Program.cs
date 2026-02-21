using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_Karar_Yapıları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int sayi = -10;
            if (sayi > 0) // Eğer sayi değişkenin değeri 0'dan büyükse
            {
                Console.WriteLine("Sayi pozitif");
            }
            else if (sayi == 0)
            {
                Console.WriteLine("Sayi sifir");
            }
            else
            {
                Console.WriteLine("Sayi negatif");
            }*/

            //----------------------------------------------------------------------------------------------------------------------------------------------------

            /*Console.Write("Kullanıcı Adınızı Giriniz: ");
            String kullaniciadi = Console.ReadLine();  // Console.ReadLine() metodu ekrandan girilen değeri yaklar ve kullaniciadi değişkenine atar.
            Console.Write("Şifre Giriniz: ");
            String sifre = Console.ReadLine(); // // Console.ReadLine() metodu ekrandan girilen değeri yaklar ve sifre değişkenine atar.

            String vtkullaniciadi = "admin";
            String vtsifre = "123456";
            if((kullaniciadi==vtkullaniciadi) && (sifre == vtsifre))
            {
                Console.WriteLine("Uygulamaya hoşgeldiniz...");
            }
            else
            {
                Console.WriteLine("Yanlış kullanıcı adı veya şifre!!!");
            }*/

            //----------------------------------------------------------------------------------------------------------------------------------------------------

            Console.Write("Yaşınızı giriniz: ");
            int yas = Convert.ToInt32(Console.ReadLine()); // Console.ReadLine() metodu ekrandan aldığı veriyi string veri tipinde bize döndürür, convert metoduyla sayısal veriyi string'e dönüştürürüz.
            String ogrenim = "lise";
            if(yas >= 18)
            {
                if(ogrenim == "lise" || ogrenim == "üniversite")
                {
                    Console.WriteLine("Ehliyet alabilirsiniz.");
                }
                else
                {
                    Console.WriteLine("Ehliyet alamazsınız.");
                }
            }
            else
            {
                Console.WriteLine("Ehliyet alamazsınız.");
            }
        }
    }
}
