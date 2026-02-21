using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _008_metotlar
{
    internal class geriye_deger_dondurmeyen_metotolar
    {
        // void dönüş değeri olmadığında tanımlıyoruz.
        // main kod bloğumuz static olduğu için static tanımlıyoruz.
        static void ToplamaYap()
        {
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("İşlem Sonucu: " + (sayi1 + sayi2));
        }
        /*static void Main(string[] args)
        {
            ToplamaYap();
        }*/
    }
}
