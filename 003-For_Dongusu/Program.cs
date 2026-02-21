using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_For_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Metin içindeki süslü parantezler ve içindeki rakamlar, "Buraya bir veri gelecek" mesajını verir. Rakamlar ise virgülden sonraki değişkenlerin sırasını (indeksini) temsil eder:
            //{ 0}: Virgülden sonraki 1.değişkeni(yani i) buraya koy.
            //{1}: Virgülden sonraki 2.değişkeni(yani toplam) buraya koy.
            int toplam = 0;
            for(int i =0; i < 10; i++)
            {
                toplam += i;
                Console.WriteLine("i değişkeninin değeri {0} toplamın değeri {1}", i, toplam);
            }
            Console.WriteLine("Toplam: " + toplam);
        }
    }
}
