using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_Foreach_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ogrenciler2 = { 100, 200, 300, 400, 500 };
            String[] isimler2 = { "Mustafa", "Tamer", "Mehmet" };
            foreach (var item in isimler2)
            {
                Console.WriteLine("Öğrenci Adı: " + item);
                /*
                Öğrenci Adı: Mustafa
                Öğrenci Adı: Tamer
                Öğrenci Adı: Mehmet
                */
            }
        }
    }
}
