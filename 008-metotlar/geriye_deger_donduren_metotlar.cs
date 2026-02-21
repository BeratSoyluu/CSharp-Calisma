using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_metotlar
{
    internal class geriye_deger_donduren_metotlar
    {
        static int KucukHarfSay(String s)
        {
            int kucukharfsayisi = 0;
            foreach(char harf in s)
            {
                if (char.IsLetter(harf)) kucukharfsayisi++;
            }
            return kucukharfsayisi;
        }
        /*static void Main(string[] args)
        {
            Console.Write("Vir cümle yazınız: ");
            string s = Console.ReadLine();
            Console.WriteLine("Harf Sayısı: " + KucukHarfSay(s));
            
        }*/
    }
}
